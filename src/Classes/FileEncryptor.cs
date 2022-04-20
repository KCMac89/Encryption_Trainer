using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Encryption_Trainer
{
    class FileEncryptor
    {

        // FILE ENCRYPTION RSA, AES
        //* ONLY WORKS FOR .txt FILES

        // Declare CspParmeters and RsaCryptoServiceProvider
        // objects with global scope of your Form class.
        readonly CspParameters _cspp = new CspParameters();
        RSACryptoServiceProvider _rsa;

        // Path variables for source, encryption, and
        // decryption folders. Must end with a backslash.
        const string EncrFolder = @"c:\Encrypt\";
        const string DecrFolder = @"c:\Decrypt\";
        //  const string SrcFolder = @"c:\docs\";

        // Public key file
        const string PubKeyFile = @"c:\encrypt\rsaPublicKey.txt";

        // Key container name for
        // private/public key value pair.
        const string KeyName = "Key01";


        public void CreateKeys()
        {
            // This task creates an asymmetric key that encrypts and decrypts the Aes key.
            // This key was used to encrypt the content and it displays the key container name on the label control.


            // Stores a key pair in the key container.
            _cspp.KeyContainerName = KeyName;
            _rsa = new RSACryptoServiceProvider(_cspp)
            {
                PersistKeyInCsp = true
            };

            // removed key_lbl from this version

            //key_lbl.Text = _rsa.PublicOnly
            //     ? $"Key: {_cspp.KeyContainerName} - Public Only"
            //     : $"Key: {_cspp.KeyContainerName} - Full Key Pair";
        }

        public void ExportPublicKey()
        {
            // This task simulates the scenario of user A giving user B her public key so that he can encrypt files for her.
            // All who have that public key will not be able to decrypt them because they do not have the full key pair with private parameters.

            // Save the public key created by the RSA
            // to a file. Caution, persisting the
            // key to a file is a security risk.
            Directory.CreateDirectory(EncrFolder);
            using var sw = new StreamWriter(PubKeyFile, false);
            sw.Write(_rsa.ToXmlString(false));
        }

        public void EncryptFile(FileInfo file)
        {
            // The EncryptFile method does the following:

            /* 1. Creates an Aes symmetric algorithm to encrypt the content.
                2. Creates an RSACryptoServiceProvider object to encrypt the Aes key.
                3. Uses a CryptoStream object to read and encrypt the FileStream of the source file, in blocks of bytes, into a destination FileStream object for the encrypted file.
                4. Determines the lengths of the encrypted key and IV, and creates byte arrays of their length values.
                5. Writes the Key, IV, and their length values to the encrypted package. */

            //The encryption package uses the following format:

            /* Key length, bytes 0 - 3
                IV length, bytes 4 - 7
                Encrypted key
                IV
                Cipher text */

            // You can use the lengths of the key and IV to determine the starting points and lengths of all parts of the encryption package, which can then be used to decrypt the file.

            // Create instance of Aes for
            // symmetric encryption of the data.
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            // Use RSACryptoServiceProvider to
            // encrypt the AES key.
            // rsa is previously instantiated:
            // rsa = new RSACryptoServiceProvider(cspp);
            byte[] keyEncrypted = _rsa.Encrypt(aes.Key, false);

            // Create byte arrays to contain
            // the length values of the key and IV.
            int lKey = keyEncrypted.Length;
            byte[] LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            byte[] LenIV = BitConverter.GetBytes(lIV);

            // Write the following to the FileStream
            // for the encrypted file (outFs):
            // - length of the key
            // - length of the IV
            // - ecrypted key
            // - the IV
            // - the encrypted cipher content

            // Change the file's extension to ".enc"
            string outFile =
                Path.Combine(EncrFolder, Path.ChangeExtension(file.Name, ".enc"));

            using var outFs = new FileStream(outFile, FileMode.Create);
            outFs.Write(LenK, 0, 4);
            outFs.Write(LenIV, 0, 4);
            outFs.Write(keyEncrypted, 0, lKey);
            outFs.Write(aes.IV, 0, lIV);

            // Now write the cipher text using
            // a CryptoStream for encrypting.
            using var outStreamEncrypted =
                new CryptoStream(outFs, transform, CryptoStreamMode.Write);
            // By encrypting a chunk at
            // a time, you can save memory
            // and accommodate large files.
            int count = 0;
            int offset = 0;

            // blockSizeBytes can be any arbitrary size.
            int blockSizeBytes = aes.BlockSize / 8;
            byte[] data = new byte[blockSizeBytes];
            int bytesRead = 0;

            using (var inFs = new FileStream(file.FullName, FileMode.Open))
            {

                if (file is null)
                {
                    MessageBox.Show("The file cannot be found");
                }


                do
                {
                    count = inFs.Read(data, 0, blockSizeBytes);
                    offset += count;
                    outStreamEncrypted.Write(data, 0, count);
                    bytesRead += blockSizeBytes;
                } while (count > 0);
            }
            outStreamEncrypted.FlushFinalBlock();
        }

        public void DecryptFile(FileInfo file)
        {
            // The Decrypt method does the following:

            /* 1. Creates an Aes symmetric algorithm to decrypt the content.
               2. Reads the first eight bytes of the FileStream of the encrypted package into byte arrays to obtain the lengths of the encrypted key and the IV.
               3. Extracts the key and IV from the encryption package into byte arrays.
               4. Creates an RSACryptoServiceProvider object to decrypt the Aes key.
               5. Uses a CryptoStream object to read and decrypt the cipher text section of the FileStream encryption package, in blocks of bytes,
                  into the FileStream object for the decrypted file. When this is finished, the decryption is completed. */

            // Create instance of Aes for
            // symmetric decryption of the data.
            Aes aes = Aes.Create();

            // Create byte arrays to get the length of
            // the encrypted key and IV.
            // These values were stored as 4 bytes each
            // at the beginning of the encrypted package.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            // Construct the file name for the decrypted file.
            string outFile =
                Path.ChangeExtension(file.FullName.Replace("Encrypt", "Decrypt"), ".txt");

            // Use FileStream objects to read the encrypted
            // file (inFs) and save the decrypted file (outFs).
            using var inFs = new FileStream(file.FullName, FileMode.Open);
            inFs.Seek(0, SeekOrigin.Begin);
            inFs.Read(LenK, 0, 3);
            inFs.Seek(4, SeekOrigin.Begin);
            inFs.Read(LenIV, 0, 3);

            // Convert the lengths to integer values.
            int lenK = BitConverter.ToInt32(LenK, 0);
            int lenIV = BitConverter.ToInt32(LenIV, 0);

            // Determine the start postition of
            // the ciphter text (startC)
            // and its length(lenC).
            int startC = lenK + lenIV + 8;
            int lenC = (int)inFs.Length - startC;

            // Create the byte arrays for
            // the encrypted Aes key,
            // the IV, and the cipher text.
            byte[] KeyEncrypted = new byte[lenK];
            byte[] IV = new byte[lenIV];

            // Extract the key and IV
            // starting from index 8
            // after the length values.
            inFs.Seek(8, SeekOrigin.Begin);
            inFs.Read(KeyEncrypted, 0, lenK);
            inFs.Seek(8 + lenK, SeekOrigin.Begin);
            inFs.Read(IV, 0, lenIV);

            Directory.CreateDirectory(DecrFolder);
            // Use RSACryptoServiceProvider
            // to decrypt the AES key.
            byte[] KeyDecrypted = _rsa.Decrypt(KeyEncrypted, false); // length of data is not valid for the size of this key, when trying to decrypt the wrong type of file

            // Decrypt the key.
            ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

            // Decrypt the cipher text from
            // from the FileSteam of the encrypted
            // file (inFs) into the FileStream
            // for the decrypted file (outFs).
            using var outFs = new FileStream(outFile, FileMode.Create);
            int count = 0;
            int offset = 0;

            // blockSizeBytes can be any arbitrary size.
            int blockSizeBytes = aes.BlockSize / 8;
            byte[] data = new byte[blockSizeBytes];

            // By decrypting a chunk a time,
            // you can save memory and
            // accommodate large files.

            // Start at the beginning
            // of the cipher text.
            inFs.Seek(startC, SeekOrigin.Begin);
            using var outStreamDecrypted =
                new CryptoStream(outFs, transform, CryptoStreamMode.Write);
            do
            {
                count = inFs.Read(data, 0, blockSizeBytes);
                offset += count;
                outStreamDecrypted.Write(data, 0, count);
            } while (count > 0);

            outStreamDecrypted.FlushFinalBlock();
        }
    }
}
