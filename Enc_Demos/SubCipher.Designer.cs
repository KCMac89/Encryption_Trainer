
namespace Encryption_Trainer
{
    partial class SubCipher
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
            this.Clear_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.right_rtb = new System.Windows.Forms.RichTextBox();
            this.left_rtb = new System.Windows.Forms.RichTextBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SC_decrypt_btn = new System.Windows.Forms.Button();
            this.SC_encrypt_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shift_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Plus_btn = new System.Windows.Forms.Button();
            this.Minus_btn = new System.Windows.Forms.Button();
            this.GenMsg_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.Black;
            this.Clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear_btn.ForeColor = System.Drawing.Color.White;
            this.Clear_btn.Location = new System.Drawing.Point(402, 498);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(104, 43);
            this.Clear_btn.TabIndex = 85;
            this.Clear_btn.Text = "CLEAR";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(317, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 18);
            this.label3.TabIndex = 84;
            this.label3.Text = "Encrypted message appears here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 18);
            this.label2.TabIndex = 83;
            this.label2.Text = "Type your message in the text box\r\n";
            // 
            // right_rtb
            // 
            this.right_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.right_rtb.Location = new System.Drawing.Point(307, 135);
            this.right_rtb.Name = "right_rtb";
            this.right_rtb.ReadOnly = true;
            this.right_rtb.Size = new System.Drawing.Size(285, 290);
            this.right_rtb.TabIndex = 82;
            this.right_rtb.Text = "";
            // 
            // left_rtb
            // 
            this.left_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.left_rtb.Location = new System.Drawing.Point(13, 135);
            this.left_rtb.Name = "left_rtb";
            this.left_rtb.Size = new System.Drawing.Size(285, 290);
            this.left_rtb.TabIndex = 81;
            this.left_rtb.Text = "";
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
            this.Exit_btn.TabIndex = 80;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 42);
            this.label1.TabIndex = 79;
            this.label1.Text = "Substitution Cipher";
            // 
            // SC_decrypt_btn
            // 
            this.SC_decrypt_btn.BackColor = System.Drawing.Color.Black;
            this.SC_decrypt_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.SC_decrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SC_decrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SC_decrypt_btn.ForeColor = System.Drawing.Color.White;
            this.SC_decrypt_btn.Location = new System.Drawing.Point(275, 498);
            this.SC_decrypt_btn.Name = "SC_decrypt_btn";
            this.SC_decrypt_btn.Size = new System.Drawing.Size(104, 43);
            this.SC_decrypt_btn.TabIndex = 78;
            this.SC_decrypt_btn.Text = "DECRYPT";
            this.SC_decrypt_btn.UseVisualStyleBackColor = false;
            this.SC_decrypt_btn.Click += new System.EventHandler(this.SC_decrypt_btn_Click);
            // 
            // SC_encrypt_btn
            // 
            this.SC_encrypt_btn.BackColor = System.Drawing.Color.Black;
            this.SC_encrypt_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.SC_encrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SC_encrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SC_encrypt_btn.ForeColor = System.Drawing.Color.White;
            this.SC_encrypt_btn.Location = new System.Drawing.Point(148, 497);
            this.SC_encrypt_btn.Name = "SC_encrypt_btn";
            this.SC_encrypt_btn.Size = new System.Drawing.Size(104, 43);
            this.SC_encrypt_btn.TabIndex = 77;
            this.SC_encrypt_btn.Text = "ENCRYPT";
            this.SC_encrypt_btn.UseVisualStyleBackColor = false;
            this.SC_encrypt_btn.Click += new System.EventHandler(this.SC_encrypt_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(64, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 86;
            this.label4.Text = "(1-25)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(255, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 31);
            this.label5.TabIndex = 87;
            this.label5.Text = "Demo";
            // 
            // shift_tb
            // 
            this.shift_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shift_tb.Location = new System.Drawing.Point(184, 445);
            this.shift_tb.MaxLength = 2;
            this.shift_tb.Name = "shift_tb";
            this.shift_tb.Size = new System.Drawing.Size(44, 31);
            this.shift_tb.TabIndex = 88;
            this.shift_tb.Text = "1";
            this.shift_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(22, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 89;
            this.label6.Text = "Enter amount to shift";
            // 
            // Plus_btn
            // 
            this.Plus_btn.BackColor = System.Drawing.Color.Black;
            this.Plus_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Plus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Plus_btn.ForeColor = System.Drawing.Color.White;
            this.Plus_btn.Location = new System.Drawing.Point(250, 443);
            this.Plus_btn.Name = "Plus_btn";
            this.Plus_btn.Size = new System.Drawing.Size(44, 34);
            this.Plus_btn.TabIndex = 90;
            this.Plus_btn.Text = "+";
            this.Plus_btn.UseVisualStyleBackColor = false;
            this.Plus_btn.Click += new System.EventHandler(this.Plus_btn_Click);
            // 
            // Minus_btn
            // 
            this.Minus_btn.BackColor = System.Drawing.Color.Black;
            this.Minus_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Minus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Minus_btn.ForeColor = System.Drawing.Color.White;
            this.Minus_btn.Location = new System.Drawing.Point(300, 442);
            this.Minus_btn.Name = "Minus_btn";
            this.Minus_btn.Size = new System.Drawing.Size(44, 34);
            this.Minus_btn.TabIndex = 91;
            this.Minus_btn.Text = "-";
            this.Minus_btn.UseVisualStyleBackColor = false;
            this.Minus_btn.Click += new System.EventHandler(this.Minus_btn_Click);
            // 
            // GenMsg_btn
            // 
            this.GenMsg_btn.BackColor = System.Drawing.Color.Black;
            this.GenMsg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.GenMsg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenMsg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenMsg_btn.ForeColor = System.Drawing.Color.White;
            this.GenMsg_btn.Location = new System.Drawing.Point(21, 497);
            this.GenMsg_btn.Name = "GenMsg_btn";
            this.GenMsg_btn.Size = new System.Drawing.Size(104, 43);
            this.GenMsg_btn.TabIndex = 92;
            this.GenMsg_btn.Text = "GENERATE MSG";
            this.GenMsg_btn.UseVisualStyleBackColor = false;
            this.GenMsg_btn.Click += new System.EventHandler(this.GenMsg_btn_Click);
            // 
            // SubCipher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(605, 561);
            this.Controls.Add(this.GenMsg_btn);
            this.Controls.Add(this.Minus_btn);
            this.Controls.Add(this.Plus_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shift_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.right_rtb);
            this.Controls.Add(this.left_rtb);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SC_decrypt_btn);
            this.Controls.Add(this.SC_encrypt_btn);
            this.MinimumSize = new System.Drawing.Size(621, 600);
            this.Name = "SubCipher";
            this.Text = "SubCipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox right_rtb;
        private System.Windows.Forms.RichTextBox left_rtb;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SC_decrypt_btn;
        private System.Windows.Forms.Button SC_encrypt_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shift_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Plus_btn;
        private System.Windows.Forms.Button Minus_btn;
        private System.Windows.Forms.Button GenMsg_btn;
    }
}