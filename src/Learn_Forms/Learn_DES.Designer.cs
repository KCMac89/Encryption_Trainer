
namespace Encryption_Trainer
{
    partial class Learn_DES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Learn_DES));
            this.Close_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Hide_diagram_btn = new System.Windows.Forms.Button();
            this.Diagram_btn = new System.Windows.Forms.Button();
            this.diagram_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.diagram_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Black;
            this.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(12, 32);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(59, 40);
            this.Close_btn.TabIndex = 94;
            this.Close_btn.Text = "X";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(191, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 98;
            this.label2.Text = "Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(204, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 42);
            this.label3.TabIndex = 97;
            this.label3.Text = "DES";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(16, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(557, 418);
            this.richTextBox1.TabIndex = 99;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Hide_diagram_btn
            // 
            this.Hide_diagram_btn.BackColor = System.Drawing.Color.Black;
            this.Hide_diagram_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Hide_diagram_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide_diagram_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hide_diagram_btn.ForeColor = System.Drawing.Color.White;
            this.Hide_diagram_btn.Location = new System.Drawing.Point(452, 38);
            this.Hide_diagram_btn.Name = "Hide_diagram_btn";
            this.Hide_diagram_btn.Size = new System.Drawing.Size(90, 44);
            this.Hide_diagram_btn.TabIndex = 101;
            this.Hide_diagram_btn.Text = "HIDE DIAGRAM";
            this.Hide_diagram_btn.UseVisualStyleBackColor = false;
            this.Hide_diagram_btn.Click += new System.EventHandler(this.Hide_diagram_btn_Click);
            // 
            // Diagram_btn
            // 
            this.Diagram_btn.BackColor = System.Drawing.Color.Black;
            this.Diagram_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Diagram_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diagram_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Diagram_btn.ForeColor = System.Drawing.Color.White;
            this.Diagram_btn.Location = new System.Drawing.Point(350, 38);
            this.Diagram_btn.Name = "Diagram_btn";
            this.Diagram_btn.Size = new System.Drawing.Size(90, 44);
            this.Diagram_btn.TabIndex = 100;
            this.Diagram_btn.Text = "SHOW DIAGRAM";
            this.Diagram_btn.UseVisualStyleBackColor = false;
            this.Diagram_btn.Click += new System.EventHandler(this.Diagram_btn_Click);
            // 
            // diagram_pic
            // 
            this.diagram_pic.Image = global::Encryption_Trainer.src.Properties.Resources.des_structure1;
            this.diagram_pic.Location = new System.Drawing.Point(12, 88);
            this.diagram_pic.Name = "diagram_pic";
            this.diagram_pic.Size = new System.Drawing.Size(577, 440);
            this.diagram_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diagram_pic.TabIndex = 102;
            this.diagram_pic.TabStop = false;
            this.diagram_pic.Visible = false;
            // 
            // Learn_DES
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(590, 561);
            this.Controls.Add(this.diagram_pic);
            this.Controls.Add(this.Hide_diagram_btn);
            this.Controls.Add(this.Diagram_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Close_btn);
            this.MinimumSize = new System.Drawing.Size(606, 600);
            this.Name = "Learn_DES";
            this.Text = "Learn_DES";
            ((System.ComponentModel.ISupportInitialize)(this.diagram_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Hide_diagram_btn;
        private System.Windows.Forms.Button Diagram_btn;
        private System.Windows.Forms.PictureBox diagram_pic;
    }
}