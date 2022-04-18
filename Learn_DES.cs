using System;
using System.Windows.Forms;

namespace Encryption_Trainer
{
    public partial class Learn_DES : Form
    {
        public Learn_DES()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Diagram_btn_Click(object sender, EventArgs e)
        {
            diagram_pic.Visible = true;
        }

        private void Hide_diagram_btn_Click(object sender, EventArgs e)
        {
            diagram_pic.Visible = false;
        }
    }
}
