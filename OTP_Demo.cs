using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Encryption_Trainer
{
    public partial class OTP_Demo : Form
    {
        public OTP_Demo()
        {
            InitializeComponent();
        }


        // The one-time pad.
        private string PadString;

        // The number of offsets used to encrypt and decrypt.
        private int NumUsedToEncrypt, NumUsedToDecrypt;

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            left_rtb.Clear();
            right_rtb.Clear();

            // clearing the pad text, resetting the highlighting
            NumUsedToEncrypt = 0;
            NumUsedToDecrypt = 0;
            DisplayPad();
        }

        private void OTP_Demo_Load(object sender, EventArgs e)
        {
            // Initialize the pad.
            PadString = MsgGenerator.RandomStringAlpha(200);
            
            NumUsedToEncrypt = 0;
            NumUsedToDecrypt = 0;

            // Display the pad.
            DisplayPad();
        }

        private void DisplayPad()
        {
            Pad_rtb.Text = PadString; 
            Pad_rtb.Select(0, PadString.Length); 
            Pad_rtb.SelectionColor = Pad_rtb.ForeColor; 
            Pad_rtb.SelectionBackColor = Pad_rtb.BackColor;

            // text changes to green on encrypt
            Pad_rtb.Select(0, NumUsedToEncrypt);
            Pad_rtb.SelectionColor = Color.Green;

            // text is highlighted orange on decrypt
            Pad_rtb.Select(0, NumUsedToDecrypt);
            Pad_rtb.SelectionBackColor = Color.Orange;
        }

        // Break the text into 5-character chunks.
        private string To5Chars(string message)
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

    
        private string Encrypt(string pad, int startIndex, string plaintext)
        {
            return EncryptDecrypt(pad, startIndex, plaintext, false);
        }

        private string Decrypt(string pad, int startIndex, string ciphertext)
        {
            return EncryptDecrypt(pad, startIndex, ciphertext, true);
        }

        // Use the one-time pad to encrypt or decrypt the text.
        private string EncryptDecrypt(string pad, int startIndex, string text, bool decrypt)
        {
            text = text.ToUpper().Replace(" ", "");

            // Start at the right entry in the pad.
            int i = startIndex;

            // Make sure we have enough pad left for this message.
            if (i + text.Length > pad.Length)
            {
                MessageBox.Show("The pad doesn't contain enough unnused characters for this operation.");
                return "**********";
            }

            string result = "";
            foreach (char ch in text)
            {
                int chNum = ch - 'A';
                int padNum = pad[i] - 'A';

                int newCh;
                if (decrypt)
                    newCh = 'A' + (chNum - padNum + 26) % 26;
                else
                    newCh = 'A' + (chNum + padNum) % 26;
                result += (char)newCh;
                i++;
            }

            // Return the ciphertext.
            return result;
        }

        // Encrypts the message in the left textbox and outputs it to the right textbox
        private void OTP_encrypt_btn_Click(object sender, EventArgs e)
        {

            if (left_rtb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Type a message into the left text box first", title);
            }

            else
            {
                string message = left_rtb.Text.ToUpper().Replace(" ", "");
                string cipherText = Encrypt(PadString, NumUsedToEncrypt, message);
                right_rtb.Text = To5Chars(cipherText);

                NumUsedToEncrypt += cipherText.Length;
                DisplayPad();
            }
        }

        // Decrypts the encrypted mesage in the right textbox
        private void OTP_decrypt_btn_Click(object sender, EventArgs e)
        {
            if (left_rtb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Type a message into the left text box first", title);
            }

            else
            {
                string cipherText = right_rtb.Text;
                string plainText = Decrypt(PadString, NumUsedToDecrypt, cipherText);
                right_rtb.Text = To5Chars(plainText);

                NumUsedToDecrypt += plainText.Length;
                DisplayPad();
            }



        }

        private void GenMsg_btn_Click(object sender, EventArgs e)
        {
            String RandMsg = MsgGenerator.RandomStringAlpha(100);
            left_rtb.Text = RandMsg;
        }
    }
}
