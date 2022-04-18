
namespace Encryption_Trainer
{
    partial class V_Cipher_Demo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.right_rtb = new System.Windows.Forms.RichTextBox();
            this.left_rtb = new System.Windows.Forms.RichTextBox();
            this.GenMsg_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.V_decrypt_btn = new System.Windows.Forms.Button();
            this.V_encrypt_btn = new System.Windows.Forms.Button();
            this.Key_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RandKey_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Black;
            this.Exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(12, 32);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(59, 40);
            this.Exit_btn.TabIndex = 81;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(255, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 31);
            this.label5.TabIndex = 89;
            this.label5.Text = "Demo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(150, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 42);
            this.label1.TabIndex = 88;
            this.label1.Text = "Vigenere Cipher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 18);
            this.label2.TabIndex = 90;
            this.label2.Text = "Type your message in the text box";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(317, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 18);
            this.label3.TabIndex = 91;
            this.label3.Text = "Encrypted message appears here";
            // 
            // right_rtb
            // 
            this.right_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.right_rtb.Location = new System.Drawing.Point(307, 135);
            this.right_rtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.right_rtb.Name = "right_rtb";
            this.right_rtb.ReadOnly = true;
            this.right_rtb.Size = new System.Drawing.Size(285, 233);
            this.right_rtb.TabIndex = 93;
            this.right_rtb.Text = "";
            // 
            // left_rtb
            // 
            this.left_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.left_rtb.Location = new System.Drawing.Point(13, 135);
            this.left_rtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.left_rtb.Name = "left_rtb";
            this.left_rtb.Size = new System.Drawing.Size(286, 233);
            this.left_rtb.TabIndex = 92;
            this.left_rtb.Text = "";
            // 
            // GenMsg_btn
            // 
            this.GenMsg_btn.BackColor = System.Drawing.Color.Black;
            this.GenMsg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.GenMsg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenMsg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenMsg_btn.ForeColor = System.Drawing.Color.White;
            this.GenMsg_btn.Location = new System.Drawing.Point(21, 473);
            this.GenMsg_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GenMsg_btn.Name = "GenMsg_btn";
            this.GenMsg_btn.Size = new System.Drawing.Size(104, 43);
            this.GenMsg_btn.TabIndex = 97;
            this.GenMsg_btn.Text = "GENERATE MSG";
            this.GenMsg_btn.UseVisualStyleBackColor = false;
            this.GenMsg_btn.Click += new System.EventHandler(this.GenMsg_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.Black;
            this.Clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear_btn.ForeColor = System.Drawing.Color.White;
            this.Clear_btn.Location = new System.Drawing.Point(402, 474);
            this.Clear_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(104, 43);
            this.Clear_btn.TabIndex = 96;
            this.Clear_btn.Text = "CLEAR";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // V_decrypt_btn
            // 
            this.V_decrypt_btn.BackColor = System.Drawing.Color.Black;
            this.V_decrypt_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.V_decrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.V_decrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.V_decrypt_btn.ForeColor = System.Drawing.Color.White;
            this.V_decrypt_btn.Location = new System.Drawing.Point(275, 474);
            this.V_decrypt_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.V_decrypt_btn.Name = "V_decrypt_btn";
            this.V_decrypt_btn.Size = new System.Drawing.Size(104, 43);
            this.V_decrypt_btn.TabIndex = 95;
            this.V_decrypt_btn.Text = "DECRYPT";
            this.V_decrypt_btn.UseVisualStyleBackColor = false;
            this.V_decrypt_btn.Click += new System.EventHandler(this.V_decrypt_btn_Click);
            // 
            // V_encrypt_btn
            // 
            this.V_encrypt_btn.BackColor = System.Drawing.Color.Black;
            this.V_encrypt_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.V_encrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.V_encrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.V_encrypt_btn.ForeColor = System.Drawing.Color.White;
            this.V_encrypt_btn.Location = new System.Drawing.Point(148, 474);
            this.V_encrypt_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.V_encrypt_btn.Name = "V_encrypt_btn";
            this.V_encrypt_btn.Size = new System.Drawing.Size(104, 43);
            this.V_encrypt_btn.TabIndex = 94;
            this.V_encrypt_btn.Text = "ENCRYPT";
            this.V_encrypt_btn.UseVisualStyleBackColor = false;
            this.V_encrypt_btn.Click += new System.EventHandler(this.V_encrypt_btn_Click);
            // 
            // Key_tb
            // 
            this.Key_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Key_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key_tb.Location = new System.Drawing.Point(114, 406);
            this.Key_tb.MaxLength = 20;
            this.Key_tb.Name = "Key_tb";
            this.Key_tb.Size = new System.Drawing.Size(227, 29);
            this.Key_tb.TabIndex = 98;
            this.Key_tb.Text = "KEY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(21, 413);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 99;
            this.label4.Text = "Enter a key ";
            // 
            // RandKey_btn
            // 
            this.RandKey_btn.BackColor = System.Drawing.Color.Black;
            this.RandKey_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.RandKey_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandKey_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RandKey_btn.ForeColor = System.Drawing.Color.White;
            this.RandKey_btn.Location = new System.Drawing.Point(357, 405);
            this.RandKey_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RandKey_btn.Name = "RandKey_btn";
            this.RandKey_btn.Size = new System.Drawing.Size(116, 34);
            this.RandKey_btn.TabIndex = 100;
            this.RandKey_btn.Text = "RANDOM KEY";
            this.RandKey_btn.UseVisualStyleBackColor = false;
            this.RandKey_btn.Click += new System.EventHandler(this.RandKey_btn_Click);
            // 
            // V_Cipher_Demo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(605, 561);
            this.Controls.Add(this.RandKey_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Key_tb);
            this.Controls.Add(this.GenMsg_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.V_decrypt_btn);
            this.Controls.Add(this.V_encrypt_btn);
            this.Controls.Add(this.right_rtb);
            this.Controls.Add(this.left_rtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_btn);
            this.MinimumSize = new System.Drawing.Size(621, 600);
            this.Name = "V_Cipher_Demo";
            this.Text = "V_Cipher_Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox right_rtb;
        private System.Windows.Forms.RichTextBox left_rtb;
        private System.Windows.Forms.Button GenMsg_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button V_decrypt_btn;
        private System.Windows.Forms.Button V_encrypt_btn;
        private System.Windows.Forms.TextBox Key_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RandKey_btn;
    }
}