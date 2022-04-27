
namespace Encryption_Trainer
{
    partial class Learn_AES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Learn_AES));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Diagram_btn = new System.Windows.Forms.Button();
            this.diagram_pic = new System.Windows.Forms.PictureBox();
            this.Hide_diagram_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diagram_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(192, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 70;
            this.label4.Text = "Encryption";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(204, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 42);
            this.label1.TabIndex = 69;
            this.label1.Text = "AES ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(16, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(557, 418);
            this.richTextBox1.TabIndex = 73;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
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
            this.Exit_btn.TabIndex = 75;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Diagram_btn
            // 
            this.Diagram_btn.BackColor = System.Drawing.Color.Black;
            this.Diagram_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Diagram_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diagram_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Diagram_btn.ForeColor = System.Drawing.Color.White;
            this.Diagram_btn.Location = new System.Drawing.Point(349, 39);
            this.Diagram_btn.Name = "Diagram_btn";
            this.Diagram_btn.Size = new System.Drawing.Size(90, 44);
            this.Diagram_btn.TabIndex = 77;
            this.Diagram_btn.Text = "SHOW DIAGRAM";
            this.Diagram_btn.UseVisualStyleBackColor = false;
            this.Diagram_btn.Click += new System.EventHandler(this.Diagram_btn_Click);
            // 
            // diagram_pic
            // 
            this.diagram_pic.Image = global::Encryption_Trainer.src.Properties.Resources.security_aes_design;
            this.diagram_pic.Location = new System.Drawing.Point(12, 98);
            this.diagram_pic.Name = "diagram_pic";
            this.diagram_pic.Size = new System.Drawing.Size(569, 439);
            this.diagram_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diagram_pic.TabIndex = 78;
            this.diagram_pic.TabStop = false;
            this.diagram_pic.Visible = false;
            // 
            // Hide_diagram_btn
            // 
            this.Hide_diagram_btn.BackColor = System.Drawing.Color.Black;
            this.Hide_diagram_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Hide_diagram_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide_diagram_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hide_diagram_btn.ForeColor = System.Drawing.Color.White;
            this.Hide_diagram_btn.Location = new System.Drawing.Point(451, 39);
            this.Hide_diagram_btn.Name = "Hide_diagram_btn";
            this.Hide_diagram_btn.Size = new System.Drawing.Size(90, 44);
            this.Hide_diagram_btn.TabIndex = 79;
            this.Hide_diagram_btn.Text = "HIDE DIAGRAM";
            this.Hide_diagram_btn.UseVisualStyleBackColor = false;
            this.Hide_diagram_btn.Click += new System.EventHandler(this.Hide_diagram_btn_Click);
            // 
            // Learn_AES
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(590, 561);
            this.Controls.Add(this.Hide_diagram_btn);
            this.Controls.Add(this.diagram_pic);
            this.Controls.Add(this.Diagram_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(606, 600);
            this.Name = "Learn_AES";
            this.Text = "Learn_AES";
            this.Load += new System.EventHandler(this.Learn_AES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagram_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Diagram_btn;
        private System.Windows.Forms.PictureBox diagram_pic;
        private System.Windows.Forms.Button Hide_diagram_btn;
    }
}