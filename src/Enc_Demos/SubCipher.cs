using System;
using System.Windows.Forms;


namespace Encryption_Trainer
{
    public partial class SubCipher : Form
    {
        public SubCipher()
        {
            InitializeComponent();     
        }

        private string SubCipherEncrypt(string original_msg, int shiftNum) // works for alphabet chars (A-Z)
        {
            char[] buffer = original_msg.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                // each letter will be separated then changed
                char letter = buffer[i];
                // shift the letters according to the shiftNo variable
                letter = (char)(letter + shiftNum);
                if (letter > 'z')
                {
                    letter = (char)(letter - 26); //subtracting 26 on the overflow
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26); // adding 26 on the underflow
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        private string SubCipherDecrypt(string enc_msg, int shiftNum)
        {

            char[] buffer = enc_msg.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                // each letter will be separated then changed
                char letter = buffer[i];

                // shift the letters according to the shiftNo variable
                letter = (char)(letter - shiftNum);

                // makes it so z loops back around to a
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }

                buffer[i] = letter;

            }
            return new string(buffer);
        }

        // Encrypts the message in the left textbox and outputs it to the right textbox
        private void SC_encrypt_btn_Click(object sender, EventArgs e)
        {
            String title = "Warning";

            if (left_rtb.Text == "")
            {
                
                MessageBox.Show("Type a message into the left text box first", title);
              
            }

            else
            {
                string plainText = left_rtb.Text; 
                bool validInput = int.TryParse(shift_tb.Text, out int shiftNum) && shiftNum > 0 && shiftNum < 26;

                if (validInput)
                {
                    right_rtb.Text = SubCipherEncrypt(plainText.ToLower(), shiftNum); // convert toLower for uppercase letters
                }

                else
                {
                    MessageBox.Show("Please enter a number in the valid range: 1-25", title);
                }
            }

        }


        // Decrypts the encrypted mesage in the right textbox
        private void SC_decrypt_btn_Click(object sender, EventArgs e)
        {
            String title = "Warning";

            if (left_rtb.Text == "")
            {
               
                MessageBox.Show("Type a message into the left text box first", title);
            }

            else
            {
                string enc_msg = right_rtb.Text;
                bool validInput = int.TryParse(shift_tb.Text, out int shiftNum) && shiftNum > 0 && shiftNum < 26;

                if (validInput)
                {
                    right_rtb.Text = SubCipherDecrypt(enc_msg, shiftNum);
                }
                
                else
                {
                    MessageBox.Show("Please enter a number in the valid range: 1-25", title);
                }
               
            }
     
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            left_rtb.Clear();
            right_rtb.Clear();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Plus_btn_Click(object sender, EventArgs e)
        {
            // throws exceptions for letters in shiftbox or if out of range
            bool validInput = int.TryParse(shift_tb.Text, out int shiftNum) && shiftNum > 0 && shiftNum < 25;

            if (validInput)
            {
                shiftNum++;
                shift_tb.Text = shiftNum.ToString();
            }
        }

        private void Minus_btn_Click(object sender, EventArgs e)
        {
            // throws exceptions for letters in shiftbox or if out of range
            bool validInput = int.TryParse(shift_tb.Text, out int shiftNum) && shiftNum > 1 && shiftNum < 26; // note 26 for minus button upper bound

            if (validInput)
            {
                shiftNum--;
                shift_tb.Text = shiftNum.ToString();
            }
        }

        private void GenMsg_btn_Click(object sender, EventArgs e)
        {
            String RandMsg = MsgGenerator.RandomStringAlpha(100);
            left_rtb.Text = RandMsg;
        }
    }
}

