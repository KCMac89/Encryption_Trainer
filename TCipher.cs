using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Encryption_Trainer
{
    public partial class TCipher : Form
    {
        public TCipher()
        {
            InitializeComponent();
        }

		private static int[] GetShiftIndexes(string key)
		{
			// takes the key as input and returns the new indexes after shifing them

			int keyLength = key.Length;
			int[] indexes = new int[keyLength];
			List<KeyValuePair<int, char>> sortedKey = new List<KeyValuePair<int, char>>();
			int i;

			for (i = 0; i < keyLength; ++i)
				sortedKey.Add(new KeyValuePair<int, char>(i, key[i]));

			sortedKey.Sort(
				delegate (KeyValuePair<int, char> pair1, KeyValuePair<int, char> pair2) {
					return pair1.Value.CompareTo(pair2.Value);
				}
			);

			for (i = 0; i < keyLength; ++i)
				indexes[sortedKey[i].Key] = i;

			return indexes;
		}

		// Takes input message, key, and pad character and uses to encipher 
		public static string Encipher(string input, string key, char padChar)
		{
			input = (input.Length % key.Length == 0) ? input : input.PadRight(input.Length - (input.Length % key.Length) + key.Length, padChar);
			StringBuilder output = new StringBuilder();
			int totalChars = input.Length;
			int totalColumns = key.Length;
			int totalRows = (int)Math.Ceiling((double)totalChars / totalColumns);
			char[,] rowChars = new char[totalRows, totalColumns];
			char[,] colChars = new char[totalColumns, totalRows];
			char[,] sortedColChars = new char[totalColumns, totalRows];
			int currentRow, currentColumn, i, j;
			int[] shiftIndexes = GetShiftIndexes(key);

			for (i = 0; i < totalChars; ++i)
			{
				currentRow = i / totalColumns;
				currentColumn = i % totalColumns;
				rowChars[currentRow, currentColumn] = input[i];
			}

			for (i = 0; i < totalRows; ++i)
				for (j = 0; j < totalColumns; ++j)
					colChars[j, i] = rowChars[i, j];

			for (i = 0; i < totalColumns; ++i)
				for (j = 0; j < totalRows; ++j)
					sortedColChars[shiftIndexes[i], j] = colChars[i, j];

			for (i = 0; i < totalChars; ++i)
			{
				currentRow = i / totalRows;
				currentColumn = i % totalRows;
				output.Append(sortedColChars[currentRow, currentColumn]);
			}

			return output.ToString();
		}

		// Takes the encrypted message, key and uses to decipher
		public static string Decipher(string input, string key)
		{
			StringBuilder output = new StringBuilder();
			int totalChars = input.Length;
			int totalColumns = (int)Math.Ceiling((double)totalChars / key.Length);
			int totalRows = key.Length;
			char[,] rowChars = new char[totalRows, totalColumns];
			char[,] colChars = new char[totalColumns, totalRows];
			char[,] unsortedColChars = new char[totalColumns, totalRows];
			int currentRow, currentColumn, i, j;
			int[] shiftIndexes = GetShiftIndexes(key);

			for (i = 0; i < totalChars; ++i)
			{
				currentRow = i / totalColumns;
				currentColumn = i % totalColumns;
				rowChars[currentRow, currentColumn] = input[i];
			}

			for (i = 0; i < totalRows; ++i)
				for (j = 0; j < totalColumns; ++j)
					colChars[j, i] = rowChars[i, j];

			for (i = 0; i < totalColumns; ++i)
				for (j = 0; j < totalRows; ++j)
					unsortedColChars[i, j] = colChars[i, shiftIndexes[j]];

			for (i = 0; i < totalChars; ++i)
			{
				currentRow = i / totalRows;
				currentColumn = i % totalRows;
				output.Append(unsortedColChars[currentRow, currentColumn]);
			}

			return output.ToString();
		}

		// Encrypts the message in the left textbox and outputs it to the right textbox
        private void TC_encrypt_btn_Click(object sender, EventArgs e)
        {
			if (left_rtb.Text == "")
			{
				String title = "Warning";
				MessageBox.Show("Type a message into the left text box first", title);
			}

            else
            {
				String cipherText = Encipher(left_rtb.Text, "key", '-');
				right_rtb.Text = cipherText;
			}

		}

		// Decrypts the encrypted mesage in the right textbox
        private void TC_decrypt_btn_Click(object sender, EventArgs e)
        {
			if (left_rtb.Text == "")
			{
				String title = "Warning";
				MessageBox.Show("Type a message into the left text box first", title);
			}

            else
            {
				String cipherText = right_rtb.Text;
				String decrypted = Decipher(cipherText, "key");
				right_rtb.Text = decrypted;
				left_rtb.Enabled = true;
			}	
		}

        private void Exit_btn_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
			left_rtb.Clear();
			right_rtb.Clear();		
        }

		// Generates a random alphanumeric string of 100 characters
        private void GenMsg_btn_Click(object sender, EventArgs e)
        {
			String RandMsg = MsgGenerator.RandomString(100);
			left_rtb.Text = RandMsg;
		}
    }
}
