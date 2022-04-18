using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Encryption_Trainer
{
    public partial class Feistel_Demo : Form

	/* Reference: https://dotnetcademy.net/Learn/7/Pages/2 */

	/* This program will do the following things:
		   Define block size and split plain text into blocks
		   Represent each block as positive integer number
		   Define Feistel network parameters (Rounds count, Key length)
		   Design Round function
		   Encrypt each block with Feistel network
		   Decrypt cipher text
	*/

	// Need to modify Encrypt function
	// Need to add Decrypt Function

	{
	public const int BLOCK_SIZE = 4;
    public const ushort SECRET = 65535;
    public const int ROUNDS = 5;

    public Feistel_Demo()
	{
		var blocks = new uint[] { 1074632793, 2393460436, 1820682509, 53228064, 3452521679, 3660823688, 1296079281, 1025549298, 19687968, 721445875, 3202418118, 3721585831, 78447188, 1211095104, 422738656, 271553040, 3111137266, 152305785, 239110881, 3170940915, 2657138408, 1661319489, 1817774531, 195557908, 1778915809, 1447756419, 2856347641, 3380626671, 1875413487, 411273861, 420747897, 897633263, 4210034662, 2869831457, 3532921957, 67406433, 329509508, 420747897, 897633263, 3068331398, 606405456, 1035516916, 3600889486 };

		var key = "1234";

		var result = Feistel(blocks, key);

		var cipherText = Encoding.ASCII.GetString(result.SelectMany(r => BitConverter.GetBytes(r).Reverse()).ToArray());

		InitializeComponent();
    }

		public static uint[] Feistel(uint[] plainText, string password)
		{
			var cipherBlocks = new uint[plainText.Count()];

			for (int i = 0; i < plainText.Count(); i++)
			{
				cipherBlocks[i] = F(plainText[i], password);
			}

			return cipherBlocks;
		}

		public static uint F(uint originalBlock, string key)
		{
			var bytes = GetBytes(originalBlock);

			ushort leftPart = ToUshort(bytes.Take(2).ToArray());
			ushort rightPart = ToUshort(bytes.Skip(2).Take(2).ToArray());

			var keyBytes = Encoding.ASCII.GetBytes(key);

			var key1 = ToUshort(keyBytes.Take(2).ToArray().ToArray());
			var key2 = ToUshort(keyBytes.Skip(2).Take(2).ToArray().ToArray());

			for (int i = 0; i < ROUNDS; i++)
			{
				var f = RoundF(leftPart, i % 2 == 0 ? key1 : key2);

				UInt16 result = (UInt16)(f ^ rightPart);

				if (i < ROUNDS - 1)
				{
					rightPart = leftPart;
					leftPart = result;
				}
				else
				{
					rightPart = result;
				}
			}

			var cipherBytes = new byte[BLOCK_SIZE]
							{
				BitConverter.GetBytes(leftPart)[1], BitConverter.GetBytes(leftPart)[0],
				BitConverter.GetBytes(rightPart)[1],BitConverter.GetBytes(rightPart)[0]
							 };

			return ToUInt32(cipherBytes);
		}

		public static ushort RoundF(ushort originalBlock, ushort key)
		{
			ushort result = (ushort)(originalBlock ^ key);

			result = (ushort)(result << 5);
			return result;
		}


		// convert to 16 bit integers
		public static ushort ToUshort(byte[] bytes)
		{
			ushort result = 0;

			result += (ushort)(bytes[0] * 256 + bytes[1]);

			return result;
		}

		// convert to 32 bit integers
		public static uint ToUInt32(byte[] bytes)
		{
			uint result = 0;

			for (int i = 0; i < 4; i++)
			{
				result += (uint)Math.Pow(256, 3 - i) * bytes[i];
			}

			return result;
		}

		public static uint[] GetBlocks(string text)
		{
			var bytes = Encoding.ASCII.GetBytes(text);

			var blocksCount = (int)Math.Ceiling(bytes.Count() / (double)BLOCK_SIZE);

			var result = new uint[blocksCount];

			for (int i = 0; i < blocksCount; i++)
			{
				result[i] = ToUInt32(bytes.Skip(i * BLOCK_SIZE).Take(BLOCK_SIZE).ToArray());
			}

			return result;
		}

		public static byte[] GetBytes(uint originalBlock)
		{
			return BitConverter.GetBytes(originalBlock).Reverse().ToArray();
		}

        private void Feistel_encrypt_btn_Click(object sender, EventArgs e)
        {
			//string plainText = "Symmetric-key algorithms[1] are a class of algorithms for cryptography that use the same cryptographic keys for both encryption of plaintext and decryption of ciphertext.!!";
			//left_rtb.Text = plainText;
			//var blocks = GetBlocks(plainText);

			var blocks = new uint[] { 1074632793, 2393460436, 1820682509, 53228064, 3452521679, 3660823688, 1296079281, 1025549298, 19687968, 721445875, 3202418118, 3721585831, 78447188, 1211095104, 422738656, 271553040, 3111137266, 152305785, 239110881, 3170940915, 2657138408, 1661319489, 1817774531, 195557908, 1778915809, 1447756419, 2856347641, 3380626671, 1875413487, 411273861, 420747897, 897633263, 4210034662, 2869831457, 3532921957, 67406433, 329509508, 420747897, 897633263, 3068331398, 606405456, 1035516916, 3600889486 };
			var key = "1234";
			var result = Feistel(blocks, key);
			var cipherText = Encoding.ASCII.GetString(result.SelectMany(r => BitConverter.GetBytes(r).Reverse()).ToArray());
			right_rtb.Text = cipherText;
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
    }
}
