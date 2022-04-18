using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Encryption_Trainer
{
    public partial class DES_Demo : Form
    {
        public DES_Demo()
        {
            InitializeComponent();
        }


        static byte[] EncryptStringToBytes_DES(string plainText, byte[] Key, byte[] IV)
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

                // Create an Des object
                // with the specified key and IV.
                using (DES desAlg = DES.Create())
                {
                    desAlg.Key = Key;
                    desAlg.IV = IV;

                    // Create an encryptor to perform the stream transform.
                    ICryptoTransform encryptor = desAlg.CreateEncryptor(desAlg.Key, desAlg.IV);

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

        public static string ReturnEncString(byte[] enc_bytes) // used in Encrypt button to convert enc bytes to string
        {
            string enc_str = Convert.ToBase64String(enc_bytes);
            return enc_str;
        }

        static string DecryptStringFromBytes_DES(byte[] cipherText, byte[] Key, byte[] IV)
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

                // Create an Des object
                // with the specified key and IV.
                using (DES desAlg = DES.Create())
                {
                    desAlg.Key = Key;
                    desAlg.IV = IV;

                    // Create a decryptor to perform the stream transform.
                    ICryptoTransform decryptor = desAlg.CreateDecryptor(desAlg.Key, desAlg.IV);

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
                MessageBox.Show("A cryptographic error has occurred: " + e.Message);
                return null;
            }     
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenMsg_btn_Click(object sender, EventArgs e)
        {
            // Generates a random alphanumeric string of 100 characters
            String RandMsg = MsgGenerator.RandomString(100);
            left_rtb.Text = RandMsg;
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            left_rtb.Text = "";
            right_rtb.Text = "";
        }

        // Encrypts the message in the left textbox and outputs it to the right textbox
        private void DES_encrypt_btn_Click(object sender, EventArgs e)
        {
            if (left_rtb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Enter a message into the left text box first", title);
            }

            else
            {
                string original = left_rtb.Text;

                // Create a new instance of the Des
                // class.  This generates a new key and initialization
                // vector (IV).
                using DES myDes = DES.Create();

                // Encrypt the string to an array of bytes.
                byte[] encrypted = EncryptStringToBytes_DES(original, myDes.Key, myDes.IV);
                string enc_string = ReturnEncString(encrypted);

                // Display Encrypted String
                right_rtb.Text = enc_string;
            }
        }

        // Decrypts the encrypted mesage in the right textbox
        private void DES_decrypt_btn_Click(object sender, EventArgs e)
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
                using DES myDes = DES.Create();

                // Decrypting text after getting encrypted bytes
                byte[] encrypted = EncryptStringToBytes_DES(original, myDes.Key, myDes.IV);
                string decrypted = DecryptStringFromBytes_DES(encrypted, myDes.Key, myDes.IV);

                // settting the right textbox as the decrypted plain text
                right_rtb.Text = decrypted;
            }
        }
    }
}
