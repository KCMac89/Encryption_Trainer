
namespace Encryption_Trainer
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Demos_btn = new System.Windows.Forms.Button();
            this.Logo_pnl = new System.Windows.Forms.Panel();
            this.SubCipher_btn = new System.Windows.Forms.Button();
            this.OTP_btn = new System.Windows.Forms.Button();
            this.DES_btn = new System.Windows.Forms.Button();
            this.AES_btn = new System.Windows.Forms.Button();
            this.Learn_btn = new System.Windows.Forms.Button();
            this.demos_pnl = new System.Windows.Forms.Panel();
            this.XOR_btn = new System.Windows.Forms.Button();
            this.VCipher_btn = new System.Windows.Forms.Button();
            this.Transpos_btn = new System.Windows.Forms.Button();
            this.Learn_Subs_btn = new System.Windows.Forms.Button();
            this.Learn_OTP_btn = new System.Windows.Forms.Button();
            this.Learn_DES_btn = new System.Windows.Forms.Button();
            this.Learn_AES_btn = new System.Windows.Forms.Button();
            this.learn_pnl = new System.Windows.Forms.Panel();
            this.Learn_XOR_btn = new System.Windows.Forms.Button();
            this.Learn_VCipher_btn = new System.Windows.Forms.Button();
            this.Learn_TCipher_btn = new System.Windows.Forms.Button();
            this.Help_btn = new System.Windows.Forms.Button();
            this.childForm_pnl = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.DecryptFile_btn = new System.Windows.Forms.Button();
            this.EncryptFile_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sideMenu_pnl = new System.Windows.Forms.Panel();
            this.Help_pnl = new System.Windows.Forms.Panel();
            this.Help_XOR_btn = new System.Windows.Forms.Button();
            this.Help_VCipher_btn = new System.Windows.Forms.Button();
            this.Help_TCipher_btn = new System.Windows.Forms.Button();
            this.Help_Subs_btn = new System.Windows.Forms.Button();
            this.Help_OTP_btn = new System.Windows.Forms.Button();
            this.Help_DES_btn = new System.Windows.Forms.Button();
            this.Help_AES_btn = new System.Windows.Forms.Button();
            this.Help_File_btn = new System.Windows.Forms.Button();
            this._encryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._decryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.demos_pnl.SuspendLayout();
            this.learn_pnl.SuspendLayout();
            this.childForm_pnl.SuspendLayout();
            this.sideMenu_pnl.SuspendLayout();
            this.Help_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Demos_btn
            // 
            this.Demos_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Demos_btn.FlatAppearance.BorderSize = 0;
            this.Demos_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Demos_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Demos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Demos_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Demos_btn.ForeColor = System.Drawing.Color.White;
            this.Demos_btn.Location = new System.Drawing.Point(0, 107);
            this.Demos_btn.Name = "Demos_btn";
            this.Demos_btn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Demos_btn.Size = new System.Drawing.Size(269, 49);
            this.Demos_btn.TabIndex = 1;
            this.Demos_btn.Text = "Encryption Demos";
            this.Demos_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Demos_btn.UseVisualStyleBackColor = true;
            this.Demos_btn.Click += new System.EventHandler(this.Demos_btn_Click);
            // 
            // Logo_pnl
            // 
            this.Logo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_pnl.Location = new System.Drawing.Point(0, 0);
            this.Logo_pnl.Name = "Logo_pnl";
            this.Logo_pnl.Size = new System.Drawing.Size(269, 107);
            this.Logo_pnl.TabIndex = 0;
            // 
            // SubCipher_btn
            // 
            this.SubCipher_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubCipher_btn.FlatAppearance.BorderSize = 0;
            this.SubCipher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SubCipher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.SubCipher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubCipher_btn.ForeColor = System.Drawing.Color.White;
            this.SubCipher_btn.Location = new System.Drawing.Point(0, 129);
            this.SubCipher_btn.Name = "SubCipher_btn";
            this.SubCipher_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SubCipher_btn.Size = new System.Drawing.Size(269, 43);
            this.SubCipher_btn.TabIndex = 3;
            this.SubCipher_btn.Text = "Substitution Cipher";
            this.SubCipher_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubCipher_btn.UseVisualStyleBackColor = true;
            this.SubCipher_btn.Click += new System.EventHandler(this.Subs_btn_Click);
            // 
            // OTP_btn
            // 
            this.OTP_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OTP_btn.FlatAppearance.BorderSize = 0;
            this.OTP_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OTP_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.OTP_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OTP_btn.ForeColor = System.Drawing.Color.White;
            this.OTP_btn.Location = new System.Drawing.Point(0, 86);
            this.OTP_btn.Name = "OTP_btn";
            this.OTP_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.OTP_btn.Size = new System.Drawing.Size(269, 43);
            this.OTP_btn.TabIndex = 2;
            this.OTP_btn.Text = "One-Time Pad Cipher ";
            this.OTP_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OTP_btn.UseVisualStyleBackColor = true;
            this.OTP_btn.Click += new System.EventHandler(this.OTP_btn_Click);
            // 
            // DES_btn
            // 
            this.DES_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DES_btn.FlatAppearance.BorderSize = 0;
            this.DES_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DES_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.DES_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DES_btn.ForeColor = System.Drawing.Color.White;
            this.DES_btn.Location = new System.Drawing.Point(0, 43);
            this.DES_btn.Name = "DES_btn";
            this.DES_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.DES_btn.Size = new System.Drawing.Size(269, 43);
            this.DES_btn.TabIndex = 1;
            this.DES_btn.Text = "DES";
            this.DES_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DES_btn.UseVisualStyleBackColor = true;
            this.DES_btn.Click += new System.EventHandler(this.DES_btn_Click);
            // 
            // AES_btn
            // 
            this.AES_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AES_btn.FlatAppearance.BorderSize = 0;
            this.AES_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AES_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.AES_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AES_btn.ForeColor = System.Drawing.Color.White;
            this.AES_btn.Location = new System.Drawing.Point(0, 0);
            this.AES_btn.Name = "AES_btn";
            this.AES_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.AES_btn.Size = new System.Drawing.Size(269, 43);
            this.AES_btn.TabIndex = 0;
            this.AES_btn.Text = "AES";
            this.AES_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AES_btn.UseVisualStyleBackColor = true;
            this.AES_btn.Click += new System.EventHandler(this.AES_btn_Click);
            // 
            // Learn_btn
            // 
            this.Learn_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Learn_btn.FlatAppearance.BorderSize = 0;
            this.Learn_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Learn_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Learn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Learn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Learn_btn.ForeColor = System.Drawing.Color.White;
            this.Learn_btn.Location = new System.Drawing.Point(0, 468);
            this.Learn_btn.Name = "Learn_btn";
            this.Learn_btn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Learn_btn.Size = new System.Drawing.Size(269, 49);
            this.Learn_btn.TabIndex = 3;
            this.Learn_btn.Text = "Learn More";
            this.Learn_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Learn_btn.UseVisualStyleBackColor = true;
            this.Learn_btn.Click += new System.EventHandler(this.Learn_btn_Click);
            // 
            // demos_pnl
            // 
            this.demos_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.demos_pnl.Controls.Add(this.XOR_btn);
            this.demos_pnl.Controls.Add(this.VCipher_btn);
            this.demos_pnl.Controls.Add(this.Transpos_btn);
            this.demos_pnl.Controls.Add(this.SubCipher_btn);
            this.demos_pnl.Controls.Add(this.OTP_btn);
            this.demos_pnl.Controls.Add(this.DES_btn);
            this.demos_pnl.Controls.Add(this.AES_btn);
            this.demos_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.demos_pnl.Location = new System.Drawing.Point(0, 156);
            this.demos_pnl.Name = "demos_pnl";
            this.demos_pnl.Size = new System.Drawing.Size(269, 312);
            this.demos_pnl.TabIndex = 2;
            // 
            // XOR_btn
            // 
            this.XOR_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.XOR_btn.FlatAppearance.BorderSize = 0;
            this.XOR_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.XOR_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.XOR_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XOR_btn.ForeColor = System.Drawing.Color.White;
            this.XOR_btn.Location = new System.Drawing.Point(0, 258);
            this.XOR_btn.Name = "XOR_btn";
            this.XOR_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.XOR_btn.Size = new System.Drawing.Size(269, 43);
            this.XOR_btn.TabIndex = 6;
            this.XOR_btn.Text = "XOR Cipher";
            this.XOR_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XOR_btn.UseVisualStyleBackColor = true;
            this.XOR_btn.Click += new System.EventHandler(this.XOR_btn_Click);
            // 
            // VCipher_btn
            // 
            this.VCipher_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.VCipher_btn.FlatAppearance.BorderSize = 0;
            this.VCipher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VCipher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.VCipher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VCipher_btn.ForeColor = System.Drawing.Color.White;
            this.VCipher_btn.Location = new System.Drawing.Point(0, 215);
            this.VCipher_btn.Name = "VCipher_btn";
            this.VCipher_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.VCipher_btn.Size = new System.Drawing.Size(269, 43);
            this.VCipher_btn.TabIndex = 5;
            this.VCipher_btn.Text = "Vigenere Cipher";
            this.VCipher_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VCipher_btn.UseVisualStyleBackColor = true;
            this.VCipher_btn.Click += new System.EventHandler(this.V_Cipher_btn_Click);
            // 
            // Transpos_btn
            // 
            this.Transpos_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Transpos_btn.FlatAppearance.BorderSize = 0;
            this.Transpos_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Transpos_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Transpos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transpos_btn.ForeColor = System.Drawing.Color.White;
            this.Transpos_btn.Location = new System.Drawing.Point(0, 172);
            this.Transpos_btn.Name = "Transpos_btn";
            this.Transpos_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Transpos_btn.Size = new System.Drawing.Size(269, 43);
            this.Transpos_btn.TabIndex = 4;
            this.Transpos_btn.Text = "Transposition Cipher";
            this.Transpos_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transpos_btn.UseVisualStyleBackColor = true;
            this.Transpos_btn.Click += new System.EventHandler(this.Transpos_btn_Click);
            // 
            // Learn_Subs_btn
            // 
            this.Learn_Subs_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Learn_Subs_btn.FlatAppearance.BorderSize = 0;
            this.Learn_Subs_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Learn_Subs_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Learn_Subs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Learn_Subs_btn.ForeColor = System.Drawing.Color.White;
            this.Learn_Subs_btn.Location = new System.Drawing.Point(0, 132);
            this.Learn_Subs_btn.Name = "Learn_Subs_btn";
            this.Learn_Subs_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Learn_Subs_btn.Size = new System.Drawing.Size(269, 43);
            this.Learn_Subs_btn.TabIndex = 3;
            this.Learn_Subs_btn.Text = "Substitution Cipher";
            this.Learn_Subs_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Learn_Subs_btn.UseVisualStyleBackColor = true;
            this.Learn_Subs_btn.Click += new System.EventHandler(this.Learn_Subs_btn_Click);
            // 
            // Learn_OTP_btn
            // 
            this.Learn_OTP_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Learn_OTP_btn.FlatAppearance.BorderSize = 0;
            this.Learn_OTP_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Learn_OTP_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Learn_OTP_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Learn_OTP_btn.ForeColor = System.Drawing.Color.White;
            this.Learn_OTP_btn.Location = new System.Drawing.Point(0, 89);
            this.Learn_OTP_btn.Name = "Learn_OTP_btn";
            this.Learn_OTP_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Learn_OTP_btn.Size = new System.Drawing.Size(269, 43);
            this.Learn_OTP_btn.TabIndex = 2;
            this.Learn_OTP_btn.Text = "One-Time Pad Cipher";
            this.Learn_OTP_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Learn_OTP_btn.UseVisualStyleBackColor = true;
            this.Learn_OTP_btn.Click += new System.EventHandler(this.Learn_OTP_btn_Click);
            // 
            // Learn_DES_btn
            // 
            this.Learn_DES_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Learn_DES_btn.FlatAppearance.BorderSize = 0;
            this.Learn_DES_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Learn_DES_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Learn_DES_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Learn_DES_btn.ForeColor = System.Drawing.Color.White;
            this.Learn_DES_btn.Location = new System.Drawing.Point(0, 46);
            this.Learn_DES_btn.Name = "Learn_DES_btn";
            this.Learn_DES_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Learn_DES_btn.Size = new System.Drawing.Size(269, 43);
            this.Learn_DES_btn.TabIndex = 1;
            this.Learn_DES_btn.Text = "DES";
            this.Learn_DES_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Learn_DES_btn.UseVisualStyleBackColor = true;
            this.Learn_DES_btn.Click += new System.EventHandler(this.Learn_DES_btn_Click);
            // 
            // Learn_AES_btn
            // 
            this.Learn_AES_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Learn_AES_btn.FlatAppearance.BorderSize = 0;
            this.Learn_AES_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Learn_AES_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Learn_AES_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Learn_AES_btn.ForeColor = System.Drawing.Color.White;
            this.Learn_AES_btn.Location = new System.Drawing.Point(0, 0);
            this.Learn_AES_btn.Name = "Learn_AES_btn";
            this.Learn_AES_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Learn_AES_btn.Size = new System.Drawing.Size(269, 46);
            this.Learn_AES_btn.TabIndex = 0;
            this.Learn_AES_btn.Text = "AES";
            this.Learn_AES_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Learn_AES_btn.UseVisualStyleBackColor = true;
            this.Learn_AES_btn.Click += new System.EventHandler(this.Learn_AES_btn_Click);
            // 
            // learn_pnl
            // 
            this.learn_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.learn_pnl.Controls.Add(this.Learn_XOR_btn);
            this.learn_pnl.Controls.Add(this.Learn_VCipher_btn);
            this.learn_pnl.Controls.Add(this.Learn_TCipher_btn);
            this.learn_pnl.Controls.Add(this.Learn_Subs_btn);
            this.learn_pnl.Controls.Add(this.Learn_OTP_btn);
            this.learn_pnl.Controls.Add(this.Learn_DES_btn);
            this.learn_pnl.Controls.Add(this.Learn_AES_btn);
            this.learn_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.learn_pnl.Location = new System.Drawing.Point(0, 517);
            this.learn_pnl.Name = "learn_pnl";
            this.learn_pnl.Size = new System.Drawing.Size(269, 312);
            this.learn_pnl.TabIndex = 4;
            // 
            // Learn_XOR_btn
            // 
            this.Learn_XOR_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Learn_XOR_btn.FlatAppearance.BorderSize = 0;
            this.Learn_XOR_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Learn_XOR_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Learn_XOR_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Learn_XOR_btn.ForeColor = System.Drawing.Color.White;
            this.Learn_XOR_btn.Location = new System.Drawing.Point(0, 261);
            this.Learn_XOR_btn.Name = "Learn_XOR_btn";
            this.Learn_XOR_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Learn_XOR_btn.Size = new System.Drawing.Size(269, 43);
            this.Learn_XOR_btn.TabIndex = 6;
            this.Learn_XOR_btn.Text = "XOR Cipher";
            this.Learn_XOR_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Learn_XOR_btn.UseVisualStyleBackColor = true;
            this.Learn_XOR_btn.Click += new System.EventHandler(this.Learn_XOR_btn_Click);
            // 
            // Learn_VCipher_btn
            // 
            this.Learn_VCipher_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Learn_VCipher_btn.FlatAppearance.BorderSize = 0;
            this.Learn_VCipher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Learn_VCipher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Learn_VCipher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Learn_VCipher_btn.ForeColor = System.Drawing.Color.White;
            this.Learn_VCipher_btn.Location = new System.Drawing.Point(0, 218);
            this.Learn_VCipher_btn.Name = "Learn_VCipher_btn";
            this.Learn_VCipher_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Learn_VCipher_btn.Size = new System.Drawing.Size(269, 43);
            this.Learn_VCipher_btn.TabIndex = 5;
            this.Learn_VCipher_btn.Text = "Vigenere Cipher";
            this.Learn_VCipher_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Learn_VCipher_btn.UseVisualStyleBackColor = true;
            this.Learn_VCipher_btn.Click += new System.EventHandler(this.Learn_VCipher_btn_Click);
            // 
            // Learn_TCipher_btn
            // 
            this.Learn_TCipher_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Learn_TCipher_btn.FlatAppearance.BorderSize = 0;
            this.Learn_TCipher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Learn_TCipher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Learn_TCipher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Learn_TCipher_btn.ForeColor = System.Drawing.Color.White;
            this.Learn_TCipher_btn.Location = new System.Drawing.Point(0, 175);
            this.Learn_TCipher_btn.Name = "Learn_TCipher_btn";
            this.Learn_TCipher_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Learn_TCipher_btn.Size = new System.Drawing.Size(269, 43);
            this.Learn_TCipher_btn.TabIndex = 4;
            this.Learn_TCipher_btn.Text = "Transposition Cipher";
            this.Learn_TCipher_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Learn_TCipher_btn.UseVisualStyleBackColor = true;
            this.Learn_TCipher_btn.Click += new System.EventHandler(this.Learn_TCipher_btn_Click);
            // 
            // Help_btn
            // 
            this.Help_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_btn.FlatAppearance.BorderSize = 0;
            this.Help_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Help_btn.ForeColor = System.Drawing.Color.White;
            this.Help_btn.Location = new System.Drawing.Point(0, 829);
            this.Help_btn.Name = "Help_btn";
            this.Help_btn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Help_btn.Size = new System.Drawing.Size(269, 49);
            this.Help_btn.TabIndex = 8;
            this.Help_btn.Text = "Help";
            this.Help_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_btn.UseVisualStyleBackColor = true;
            this.Help_btn.Click += new System.EventHandler(this.Help_btn_Click);
            // 
            // childForm_pnl
            // 
            this.childForm_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.childForm_pnl.Controls.Add(this.label5);
            this.childForm_pnl.Controls.Add(this.label3);
            this.childForm_pnl.Controls.Add(this.label2);
            this.childForm_pnl.Controls.Add(this.label4);
            this.childForm_pnl.Controls.Add(this.Exit_btn);
            this.childForm_pnl.Controls.Add(this.DecryptFile_btn);
            this.childForm_pnl.Controls.Add(this.EncryptFile_btn);
            this.childForm_pnl.Controls.Add(this.label1);
            this.childForm_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childForm_pnl.Location = new System.Drawing.Point(286, 0);
            this.childForm_pnl.Name = "childForm_pnl";
            this.childForm_pnl.Size = new System.Drawing.Size(606, 561);
            this.childForm_pnl.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "You can also use the options on the left to demo and learn\r\n about different type" +
    "s of encryption.\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 60);
            this.label3.TabIndex = 11;
            this.label3.Text = "You can use the buttons below to quickly encrypt or decrypt a text file.\r\n\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome to the Encryption Suite!\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(209, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 55);
            this.label4.TabIndex = 9;
            this.label4.Text = "Suite";
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Black;
            this.Exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(493, 39);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(67, 46);
            this.Exit_btn.TabIndex = 8;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // DecryptFile_btn
            // 
            this.DecryptFile_btn.BackColor = System.Drawing.Color.Black;
            this.DecryptFile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.DecryptFile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptFile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecryptFile_btn.ForeColor = System.Drawing.Color.White;
            this.DecryptFile_btn.Location = new System.Drawing.Point(330, 401);
            this.DecryptFile_btn.Name = "DecryptFile_btn";
            this.DecryptFile_btn.Size = new System.Drawing.Size(119, 46);
            this.DecryptFile_btn.TabIndex = 5;
            this.DecryptFile_btn.Text = "DECRYPT FILE";
            this.DecryptFile_btn.UseVisualStyleBackColor = false;
            this.DecryptFile_btn.Click += new System.EventHandler(this.DecryptFile_btn_Click);
            // 
            // EncryptFile_btn
            // 
            this.EncryptFile_btn.BackColor = System.Drawing.Color.Black;
            this.EncryptFile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.EncryptFile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptFile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EncryptFile_btn.ForeColor = System.Drawing.Color.White;
            this.EncryptFile_btn.Location = new System.Drawing.Point(96, 401);
            this.EncryptFile_btn.Name = "EncryptFile_btn";
            this.EncryptFile_btn.Size = new System.Drawing.Size(119, 46);
            this.EncryptFile_btn.TabIndex = 3;
            this.EncryptFile_btn.Text = "ENCRYPT FILE";
            this.EncryptFile_btn.UseVisualStyleBackColor = false;
            this.EncryptFile_btn.Click += new System.EventHandler(this.EncryptFile_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encryption ";
            // 
            // sideMenu_pnl
            // 
            this.sideMenu_pnl.AutoScroll = true;
            this.sideMenu_pnl.BackColor = System.Drawing.Color.Black;
            this.sideMenu_pnl.Controls.Add(this.Help_pnl);
            this.sideMenu_pnl.Controls.Add(this.Help_btn);
            this.sideMenu_pnl.Controls.Add(this.learn_pnl);
            this.sideMenu_pnl.Controls.Add(this.Learn_btn);
            this.sideMenu_pnl.Controls.Add(this.demos_pnl);
            this.sideMenu_pnl.Controls.Add(this.Demos_btn);
            this.sideMenu_pnl.Controls.Add(this.Logo_pnl);
            this.sideMenu_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu_pnl.Location = new System.Drawing.Point(0, 0);
            this.sideMenu_pnl.Name = "sideMenu_pnl";
            this.sideMenu_pnl.Size = new System.Drawing.Size(286, 561);
            this.sideMenu_pnl.TabIndex = 3;
            // 
            // Help_pnl
            // 
            this.Help_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Help_pnl.Controls.Add(this.Help_XOR_btn);
            this.Help_pnl.Controls.Add(this.Help_VCipher_btn);
            this.Help_pnl.Controls.Add(this.Help_TCipher_btn);
            this.Help_pnl.Controls.Add(this.Help_Subs_btn);
            this.Help_pnl.Controls.Add(this.Help_OTP_btn);
            this.Help_pnl.Controls.Add(this.Help_DES_btn);
            this.Help_pnl.Controls.Add(this.Help_AES_btn);
            this.Help_pnl.Controls.Add(this.Help_File_btn);
            this.Help_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_pnl.Location = new System.Drawing.Point(0, 878);
            this.Help_pnl.Name = "Help_pnl";
            this.Help_pnl.Size = new System.Drawing.Size(269, 353);
            this.Help_pnl.TabIndex = 9;
            // 
            // Help_XOR_btn
            // 
            this.Help_XOR_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_XOR_btn.FlatAppearance.BorderSize = 0;
            this.Help_XOR_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help_XOR_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Help_XOR_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_XOR_btn.ForeColor = System.Drawing.Color.White;
            this.Help_XOR_btn.Location = new System.Drawing.Point(0, 304);
            this.Help_XOR_btn.Name = "Help_XOR_btn";
            this.Help_XOR_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Help_XOR_btn.Size = new System.Drawing.Size(269, 43);
            this.Help_XOR_btn.TabIndex = 7;
            this.Help_XOR_btn.Text = "XOR Cipher Demo";
            this.Help_XOR_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_XOR_btn.UseVisualStyleBackColor = true;
            this.Help_XOR_btn.Click += new System.EventHandler(this.Help_XOR_btn_Click);
            // 
            // Help_VCipher_btn
            // 
            this.Help_VCipher_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_VCipher_btn.FlatAppearance.BorderSize = 0;
            this.Help_VCipher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help_VCipher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Help_VCipher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_VCipher_btn.ForeColor = System.Drawing.Color.White;
            this.Help_VCipher_btn.Location = new System.Drawing.Point(0, 261);
            this.Help_VCipher_btn.Name = "Help_VCipher_btn";
            this.Help_VCipher_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Help_VCipher_btn.Size = new System.Drawing.Size(269, 43);
            this.Help_VCipher_btn.TabIndex = 6;
            this.Help_VCipher_btn.Text = "Vigenere Cipher Demo";
            this.Help_VCipher_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_VCipher_btn.UseVisualStyleBackColor = true;
            this.Help_VCipher_btn.Click += new System.EventHandler(this.Help_VCipher_btn_Click);
            // 
            // Help_TCipher_btn
            // 
            this.Help_TCipher_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_TCipher_btn.FlatAppearance.BorderSize = 0;
            this.Help_TCipher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help_TCipher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Help_TCipher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_TCipher_btn.ForeColor = System.Drawing.Color.White;
            this.Help_TCipher_btn.Location = new System.Drawing.Point(0, 218);
            this.Help_TCipher_btn.Name = "Help_TCipher_btn";
            this.Help_TCipher_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Help_TCipher_btn.Size = new System.Drawing.Size(269, 43);
            this.Help_TCipher_btn.TabIndex = 5;
            this.Help_TCipher_btn.Text = "Transposition Cipher Demo";
            this.Help_TCipher_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_TCipher_btn.UseVisualStyleBackColor = true;
            this.Help_TCipher_btn.Click += new System.EventHandler(this.Help_TCipher_btn_Click);
            // 
            // Help_Subs_btn
            // 
            this.Help_Subs_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_Subs_btn.FlatAppearance.BorderSize = 0;
            this.Help_Subs_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help_Subs_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Help_Subs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_Subs_btn.ForeColor = System.Drawing.Color.White;
            this.Help_Subs_btn.Location = new System.Drawing.Point(0, 175);
            this.Help_Subs_btn.Name = "Help_Subs_btn";
            this.Help_Subs_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Help_Subs_btn.Size = new System.Drawing.Size(269, 43);
            this.Help_Subs_btn.TabIndex = 4;
            this.Help_Subs_btn.Text = "Substitution Cipher Demo";
            this.Help_Subs_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_Subs_btn.UseVisualStyleBackColor = true;
            this.Help_Subs_btn.Click += new System.EventHandler(this.Help_Subs_btn_Click);
            // 
            // Help_OTP_btn
            // 
            this.Help_OTP_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_OTP_btn.FlatAppearance.BorderSize = 0;
            this.Help_OTP_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help_OTP_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Help_OTP_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_OTP_btn.ForeColor = System.Drawing.Color.White;
            this.Help_OTP_btn.Location = new System.Drawing.Point(0, 132);
            this.Help_OTP_btn.Name = "Help_OTP_btn";
            this.Help_OTP_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Help_OTP_btn.Size = new System.Drawing.Size(269, 43);
            this.Help_OTP_btn.TabIndex = 3;
            this.Help_OTP_btn.Text = "OTP Cipher Demo";
            this.Help_OTP_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_OTP_btn.UseVisualStyleBackColor = true;
            this.Help_OTP_btn.Click += new System.EventHandler(this.Help_OTP_btn_Click);
            // 
            // Help_DES_btn
            // 
            this.Help_DES_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_DES_btn.FlatAppearance.BorderSize = 0;
            this.Help_DES_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help_DES_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Help_DES_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_DES_btn.ForeColor = System.Drawing.Color.White;
            this.Help_DES_btn.Location = new System.Drawing.Point(0, 89);
            this.Help_DES_btn.Name = "Help_DES_btn";
            this.Help_DES_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Help_DES_btn.Size = new System.Drawing.Size(269, 43);
            this.Help_DES_btn.TabIndex = 2;
            this.Help_DES_btn.Text = "DES Demo";
            this.Help_DES_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_DES_btn.UseVisualStyleBackColor = true;
            this.Help_DES_btn.Click += new System.EventHandler(this.Help_DES_btn_Click);
            // 
            // Help_AES_btn
            // 
            this.Help_AES_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_AES_btn.FlatAppearance.BorderSize = 0;
            this.Help_AES_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help_AES_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Help_AES_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_AES_btn.ForeColor = System.Drawing.Color.White;
            this.Help_AES_btn.Location = new System.Drawing.Point(0, 46);
            this.Help_AES_btn.Name = "Help_AES_btn";
            this.Help_AES_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Help_AES_btn.Size = new System.Drawing.Size(269, 43);
            this.Help_AES_btn.TabIndex = 1;
            this.Help_AES_btn.Text = "AES Demo";
            this.Help_AES_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_AES_btn.UseVisualStyleBackColor = true;
            this.Help_AES_btn.Click += new System.EventHandler(this.Help_AES_btn_Click);
            // 
            // Help_File_btn
            // 
            this.Help_File_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_File_btn.FlatAppearance.BorderSize = 0;
            this.Help_File_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help_File_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Help_File_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_File_btn.ForeColor = System.Drawing.Color.White;
            this.Help_File_btn.Location = new System.Drawing.Point(0, 0);
            this.Help_File_btn.Name = "Help_File_btn";
            this.Help_File_btn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Help_File_btn.Size = new System.Drawing.Size(269, 46);
            this.Help_File_btn.TabIndex = 0;
            this.Help_File_btn.Text = "File Encryption";
            this.Help_File_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_File_btn.UseVisualStyleBackColor = true;
            this.Help_File_btn.Click += new System.EventHandler(this.Help_File_btn_Click);
            // 
            // _encryptOpenFileDialog
            // 
            this._encryptOpenFileDialog.FileName = "_encryptOpenFileDialog";
            // 
            // _decryptOpenFileDialog
            // 
            this._decryptOpenFileDialog.FileName = "_decryptOpenFileDialog";
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(892, 561);
            this.Controls.Add(this.childForm_pnl);
            this.Controls.Add(this.sideMenu_pnl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(908, 600);
            this.MinimumSize = new System.Drawing.Size(908, 600);
            this.Name = "MainMenu";
            this.Text = "Encryption Suite";
            this.demos_pnl.ResumeLayout(false);
            this.learn_pnl.ResumeLayout(false);
            this.childForm_pnl.ResumeLayout(false);
            this.childForm_pnl.PerformLayout();
            this.sideMenu_pnl.ResumeLayout(false);
            this.Help_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Demos_btn;
        private System.Windows.Forms.Panel Logo_pnl;
        private System.Windows.Forms.Button SubCipher_btn;
        private System.Windows.Forms.Button OTP_btn;
        private System.Windows.Forms.Button DES_btn;
        private System.Windows.Forms.Button AES_btn;
        private System.Windows.Forms.Button Learn_btn;
        private System.Windows.Forms.Panel demos_pnl;
        private System.Windows.Forms.Button Learn_Subs_btn;
        private System.Windows.Forms.Button Learn_OTP_btn;
        private System.Windows.Forms.Button Learn_DES_btn;
        private System.Windows.Forms.Button Learn_AES_btn;
        private System.Windows.Forms.Panel learn_pnl;
        private System.Windows.Forms.Button Help_btn;
        private System.Windows.Forms.Panel childForm_pnl;
        private System.Windows.Forms.Panel sideMenu_pnl;
        private System.Windows.Forms.Button XOR_btn;
        private System.Windows.Forms.Button VCipher_btn;
        private System.Windows.Forms.Button Transpos_btn;
        private System.Windows.Forms.Button Learn_XOR_btn;
        private System.Windows.Forms.Button Learn_VCipher_btn;
        private System.Windows.Forms.Button Learn_TCipher_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DecryptFile_btn;
        private System.Windows.Forms.Button EncryptFile_btn;
        private System.Windows.Forms.OpenFileDialog _encryptOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog _decryptOpenFileDialog;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Help_pnl;
        private System.Windows.Forms.Button Help_XOR_btn;
        private System.Windows.Forms.Button Help_VCipher_btn;
        private System.Windows.Forms.Button Help_TCipher_btn;
        private System.Windows.Forms.Button Help_Subs_btn;
        private System.Windows.Forms.Button Help_OTP_btn;
        private System.Windows.Forms.Button Help_DES_btn;
        private System.Windows.Forms.Button Help_AES_btn;
        private System.Windows.Forms.Button Help_File_btn;
    }
}

