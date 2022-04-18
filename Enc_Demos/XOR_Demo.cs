using System;
using System.Windows.Forms;

namespace Encryption_Trainer
{
    public partial class XOR_Demo : Form
    {
        public XOR_Demo()
        {
            InitializeComponent();
        }

        // Uses alphabetic character to xor and encipher msg
        private void XOR_Encrypt(char xorChar)
        {
            String plainText = left_rtb.Text.ToLower(); // all uppercase will appear as lowercase in the decrypted text
            Char letter;
            String encrypted = "";

            foreach (Char c in plainText)
            {
                letter = c;
                letter = (char)(letter ^ xorChar); // ^ means XOR with the character in binary
                encrypted += letter;
            }
            right_rtb.Text = encrypted; // encrypted msg shows up in right text box

        }

        // Uses alphabetic character to xor and decipher msg
        private void XOR_Decrypt(char xorChar)
        {
            String encrypted = right_rtb.Text;
            Char letter;
            String message = "";

            foreach (Char c in encrypted)
            {
                letter = c;
                letter = (char)(letter ^ xorChar);
                message += letter;
            }
            right_rtb.Text = message;

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            left_rtb.Text = "";
            right_rtb.Text = "";
        }

        // Encrypts the message in the left textbox and outputs it to the right textbox
        private void Bin_encrypt_btn_Click(object sender, EventArgs e)
        {

            if (left_rtb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Type a message into the left text box first", title);
            }

            if (XOR_tb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Enter a character in the XOR textbox first", title);
            }

            else
            {
                string xor = XOR_tb.Text;
                char xorChar = xor[0];
                XOR_Encrypt(xorChar);
            }
        }

        // Decrypts the encrypted mesage in the right textbox
        private void Bin_decrypt_btn_Click(object sender, EventArgs e)
        {
            if (left_rtb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Type a message into the left text box first", title);
            }

            if (XOR_tb.Text == "")
            {
                String title = "Warning";
                MessageBox.Show("Enter a character in the XOR textbox first", title);
            }

            else
            {
                string xor = XOR_tb.Text;
                char xorChar = xor[0];
                XOR_Decrypt(xorChar);
            }

        }

        private void GenMsg_btn_Click(object sender, EventArgs e)
        {
            String RandMsg = MsgGenerator.RandomString(100);
            left_rtb.Text = RandMsg;
        }

        private void XOR_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }

            else
            {
                String title = "Warning";
                MessageBox.Show("Enter only alphabetic characters in the text box (A-Z) ", title);
            }

            e.Handled = true;
        }
    }
}
