using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Encryption_Trainer
{
    public partial class V_Cipher_Demo : Form
    {
        public V_Cipher_Demo()
        {
            InitializeComponent();
        }

        // Encrypts the message in the left textbox and outputs it to the right textbox
        private void V_encrypt_btn_Click(object sender, EventArgs e)
        {
            if (left_rtb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Enter a message in the left text box first", title);
            }

            else
            {
                string plainText = left_rtb.Text.ToUpper().Replace(" ", "");
                string key = Key_tb.Text;

                if (key == "")
                {
                    String title = "Warning";
                    MessageBox.Show("Enter a key first", title);
                }
                else
                {
                    Key_tb.Enabled = false;
                    string cipherText = Encrypt(plainText, key);
                    right_rtb.Text = ToChunks(cipherText);
                }
            }
        }

        // Decrypts the encrypted mesage in the right textbox
        private void V_decrypt_btn_Click(object sender, EventArgs e)
        {
            if (left_rtb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Enter a message in the left text box first", title);
            }

            else
            {

                string cipherText = right_rtb.Text.ToUpper().Replace(" ", "");
                string key = Key_tb.Text;


                if (key == "")
                {
                    String title = "Warning";
                    MessageBox.Show("Enter a key first", title);
                }
                else
                {
                    string plainText = Decrypt(cipherText, key);
                    right_rtb.Text = ToChunks(plainText);
                    Key_tb.Enabled = true;
                }
            }
        }

        // Use a Vigenere cihper to encrypt the message.
        private string Encrypt(string plaintext, string key)
        {
            return EncryptDecrypt(plaintext, key, false);
        }

        // Use a Vigenere cihper to decrypt the message.
        private string Decrypt(string ciphertext, string key)
        {
            return EncryptDecrypt(ciphertext, key, true);
        }

        // Use a Vigenere cihper to encrypt or decrypt the message.
        private string EncryptDecrypt(string plaintext, string key, bool decrypt)
        {
            // Convert the key into an array of offsets.
            int[] offset = new int[key.Length];
            if (decrypt)
            {
                for (int i = 0; i < key.Length; i++) offset[i] = 26 - (key[i] - 'A');
            }
            else
            {
                for (int i = 0; i < key.Length; i++) offset[i] = key[i] - 'A';
            }

            // Process the message.
            string result = "";
            for (int i = 0; i < plaintext.Length; i++)
            {
                int j = (i % key.Length);
                int chNum = plaintext[i] - 'A';
                chNum = (chNum + offset[j]) % 26;
                result += (char)(chNum + 'A');
            }

            return result;
        }

        // Break the text into 5-character chunks.
        private string ToChunks(string message)
        {
            // Pad the message in case its length isn't a multiple of 5.
            message += "     ";

            // Create the 5-character chunks.
            string result = "";
            for (int i = 0; i < message.Length - 5; i += 5)
                result += message.Substring(i, 5) + " ";

            // Remove trailing spaces.
            return result.TrimEnd();
        }


        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // removes text from all textboxes and enables the key
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            left_rtb.Clear();
            right_rtb.Clear();
            Key_tb.Clear();
            Key_tb.Enabled = true;
        }

        private void GenMsg_btn_Click(object sender, EventArgs e)
        {
            left_rtb.Text = MsgGenerator.RandomStringAlpha(100);
        }

        private void RandKey_btn_Click(object sender, EventArgs e)
        {
            Key_tb.Text = MsgGenerator.RandomString(15);
        }
    }
}
