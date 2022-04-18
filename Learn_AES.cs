using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Encryption_Trainer
{
    public partial class Learn_AES : Form
    {
        public Learn_AES()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
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

        private void Learn_AES_Load(object sender, EventArgs e)
        {
      
        }

        //private void tech_target_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    try
        //    {
        //        VisitLink();
        //    }

        //    catch (Exception)
        //    {
        //        MessageBox.Show("Unable to open link.");
        //    }
        //}

        //private void VisitLink()
        //{
        //    tech_target_link.LinkVisited = true;
        //    Process.Start("https://www.techtarget.com/searchsecurity/definition/Advanced-Encryption-Standard");
          
        //}
    }
}
