using System;
using System.Windows.Forms;
using System.IO;



namespace Encryption_Trainer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            CustomizeDesign();  
        }

        // FILE ENCRYPTION RSA, AES
        // *ONLY WORKS FOR .txt FILES*

        // Path variables for source, encr folders. Must end with a backslash.
        const string EncrFolder = @"c:\Encrypt\";
        const string SrcFolder = @"c:\docs\";

        private void EncryptFile_btn_Click(object sender, EventArgs e)
        {
            // displays a dialog box for selecting a file and passes the file name to the second method, which performs the encryption.

            //Creates instance of FileEncryptor class
            var FE = new FileEncryptor();

            // Display a dialog box to select a file to encrypt.
            _encryptOpenFileDialog.InitialDirectory = SrcFolder;
            if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = _encryptOpenFileDialog.FileName;

                string ext = Path.GetExtension(fName);// checking for  .txt extensions only

                if (fName != null && ext == ".txt")
                {
                    // Create asymmetric keys
                    FE.CreateKeys();

                    // Export Public Key
                    FE.ExportPublicKey();

                    // Pass the file name without the path.
                    
                    FE.EncryptFile(new FileInfo(fName));
                }

                else
                {
                    String title = "Error";
                    MessageBox.Show("Please choose a file with the extension '.txt'", title, MessageBoxButtons.OK);
                }
            }
        }

        private void DecryptFile_btn_Click(object sender, EventArgs e)
        {
            // Displays a dialog box for selecting a file and passes its file name to the second method, which performs the decryption.

            //Creates instance of FileEncryptor Class
            var FE = new FileEncryptor();

            // Creates Asm Keys
            FE.CreateKeys();

            // Display a dialog box to select the encrypted file.
            _decryptOpenFileDialog.InitialDirectory = EncrFolder;
            if (_decryptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = _decryptOpenFileDialog.FileName;

                string ext = Path.GetExtension(fName);// checking extension


                if (fName != null && ext == ".enc")
                {
                    FE.DecryptFile(new FileInfo(fName));
                }

                else
                {
                    String title = "Error";
                    MessageBox.Show("Please choose a file with the extension '.enc'", title, MessageBoxButtons.OK);
                }
            }
        }

        private void CustomizeDesign()
        {
            demos_pnl.Visible = false;
            learn_pnl.Visible = false;
            Help_pnl.Visible = false;
           
        }

        private void HideSubMenu()
        {

            if (learn_pnl.Visible == true)
            {
                learn_pnl.Visible = false;
            }

            if (demos_pnl.Visible == true)
            {
                demos_pnl.Visible = false;
            }

            if (Help_pnl.Visible == true)
            {
                Help_pnl.Visible = false;
            }

            // Alternate method
            //study_pnl.Visible = !study_pnl.Visible;
            //demos_pnl.Visible = !demos_pnl.Visible;
          
        }

        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;

            }
            else
            {
                submenu.Visible = false;
            }

            //Alternate method
            //submenu.Visible = !submenu.Visible;
        }


        private Form activeForm = null; // set active form to null first
        private void OpenChildForm(Form childForm)
        {
            // method for opening a single form
            // can modify to open multiple forms
            // change size of child forms to the same size as the childForm panel without borders
            // this will prevent the form from flickering

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm_pnl.Controls.Add(childForm);
            childForm_pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Transpos_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TCipher());
            HideSubMenu();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Subs_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubCipher());
            HideSubMenu();
        }

        private void XOR_learn_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Learn_XOR());
            HideSubMenu();
        }

        private void XOR_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XOR_Demo());
            HideSubMenu();
        }

        private void Subs_learn_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Learn_Subs());
            HideSubMenu();
        }

        private void Demos_btn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(demos_pnl);
        }

        private void Learn_btn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(learn_pnl);
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(Help_pnl);
        }

        private void AES_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AES_Demo());
            HideSubMenu();
        }

        private void Transpos_learn_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Learn_TCipher());
            HideSubMenu();
        }

        private void DES_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DES_Demo());
            HideSubMenu();
        }

        private void OTP_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OTP_Demo());
            HideSubMenu();
        }

        private void Feistal_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Feistel_Demo());
            HideSubMenu();
        }

        private void V_Cipher_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new V_Cipher_Demo());
            HideSubMenu();
        }

        private void Learn_AES_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Learn_AES());
            HideSubMenu();
        }

        private void Learn_DES_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Learn_DES());
            HideSubMenu();
        }

        private void Learn_OTP_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Learn_OTP());
            HideSubMenu();
        }

        private void Learn_Subs_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Learn_Subs());
            HideSubMenu();
        }

        private void Learn_TCipher_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Learn_TCipher());
            HideSubMenu();
        }

        private void Learn_VCipher_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Learn_VCipher());
            HideSubMenu();
        }

        private void Learn_XOR_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Learn_XOR());
            HideSubMenu();
        }

        private void Help_AES_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Help_AES());
            HideSubMenu();
        }

        private void Help_DES_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Help_DES());
            HideSubMenu();
        }

        private void Help_TCipher_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Help_TCipher());
            HideSubMenu();
        }

        private void Help_OTP_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Help_OTP());
            HideSubMenu();
        }

        private void Help_Subs_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Help_Subs());
            HideSubMenu();
        }

        private void Help_XOR_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Help_XOR());
            HideSubMenu();
        }

        private void Help_VCipher_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Help_VCipher());
            HideSubMenu();
        }

        private void Help_File_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Help_FileEnc());
            HideSubMenu();
        }
    }
}
