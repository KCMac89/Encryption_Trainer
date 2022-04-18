using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace Encryption_Trainer
{
    public partial class AES_Demo : Form
    {


        public AES_Demo()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            //// Check arguments.
            //if (plainText == null || plainText.Length <= 0)
            //    throw new ArgumentNullException("plainText");
            //if (Key == null || Key.Length <= 0)
            //    throw new ArgumentNullException("Key");
            //if (IV == null || IV.Length <= 0)
            //    throw new ArgumentNullException("IV");

            try
            {
                // initializing encrypted array bytes
                byte[] encrypted;


                // Create an Aes object
                // with the specified key and IV.
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;

                    // Create an encryptor to perform the stream transform.
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    // Create the streams used for encryption.
                    using MemoryStream msEncrypt = new MemoryStream();
                    using CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        //Write all data to the stream.
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                }

                // Return the encrypted bytes from the memory stream.
                return encrypted;
            }

            catch (CryptographicException e)
            {
                MessageBox.Show("A cryptographic error has occurred: " + e.Message);
                return null;
            }
            
        }

        // Used in Encrypt button to convert enc bytes to string
        public static string ReturnEncString(byte[] enc_bytes) 
        {
            string enc_str = Convert.ToBase64String(enc_bytes);
            return enc_str;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            //// Check arguments.
            //if (cipherText == null || cipherText.Length <= 0)
            //    throw new ArgumentNullException("cipherText");
            //if (Key == null || Key.Length <= 0)
            //    throw new ArgumentNullException("Key");
            //if (IV == null || IV.Length <= 0)
            //    throw new ArgumentNullException("IV");

            try
            {
                // Declare the string used to hold
                // the decrypted text.
                string plaintext = null;

                // Create an Aes object
                // with the specified key and IV.
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;

                    // Create a decryptor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    // Create the streams used for decryption.
                    using MemoryStream msDecrypt = new MemoryStream(cipherText);
                    using CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
                    using StreamReader srDecrypt = new StreamReader(csDecrypt);

                    // Read the decrypted bytes from the decrypting stream
                    // and place them in a string.
                    plaintext = srDecrypt.ReadToEnd();
                }

                return plaintext;
            }

            catch (CryptographicException e)
            {
                MessageBox.Show("A cryptographic error has ocurred: " + e.Message);
                return null;           
            }
        }

        // Encrypts the message in the left textbox and outputs it to the right textbox
        private void AES_encrypt_btn_Click(object sender, EventArgs e)
        {
            if (left_rtb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Enter a message into the left text box first", title);
            }

            else
            {
                string original = left_rtb.Text;

                // Create a new instance of the Aes
                // class.  This generates a new key and initialization
                // vector (IV).
                using Aes myAes = Aes.Create();

                // Encrypt the string to an array of bytes.
                byte[] encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);
                string enc_string = ReturnEncString(encrypted);

                // Display Encrypted String
                right_rtb.Text = enc_string;
            }
        }

        // Decrypts the encrypted mesage in the right textbox
        private void AES_decrypt_btn_Click(object sender, EventArgs e)
        {
            if (left_rtb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Enter a message into the left text box first", title);
            }

            else
            {
                // Original message equals the left textBox
                string original = left_rtb.Text;

                // Create a new instance of the Aes
                // class.  This generates a new key and initialization
                // vector (IV).
                using Aes myAes = Aes.Create();

                // Decrypting text after getting encrypted bytes
                byte[] encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);
                string decrypted = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

                // settting the right textbox as the decrypted plain text
                right_rtb.Text = decrypted;
            }

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            left_rtb.Text = "";
            right_rtb.Text = "";
        }

        private void GenMsg_btn_Click(object sender, EventArgs e)
        {
            String RandMsg = MsgGenerator.RandomString(100);
            left_rtb.Text = RandMsg;
        }

    }
}
