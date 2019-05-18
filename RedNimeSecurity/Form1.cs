using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedNimeSecurity
{
    public partial class SecurityForm : Form
    {
        public SecurityForm()
        {
            InitializeComponent();
        }

        private void DisableMd5()
        {
            R_Md5.Checked = false;
            R_Md5.Enabled = false;
        }

        private void EnableMd5()
        {
            R_Md5.Enabled = true;
        }

        private void DisableBase64()
        {
            R_Base64.Checked = false;
            R_Base64.Enabled = false;
        }

        private void EnableBase64()
        {
            R_Base64.Enabled = true;
        }

        private void ProcessNow()
        {
            if(R_Encrypt.Checked == true && R_Decrypt.Checked == false)
            {
                if (R_Md5.Checked)
                {
                    RTB_Output.Text = SecureKey.Md5(RTB_Input.Text);
                }

                if (R_Base64.Checked)
                {
                    RTB_Output.Text = SecureKey.Base64Encode(RTB_Input.Text);
                }

                if(!R_Md5.Checked && !R_Base64.Checked)
                {
                    MessageBox.Show("Silahkan pilih action !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(R_Encrypt.Checked == false && R_Decrypt.Checked == true)
            {
                if (R_Base64.Checked)
                {
                    RTB_Output.Text = SecureKey.Base64Decode(RTB_Input.Text);
                }
                else
                {
                    MessageBox.Show("Silahkan pilih action !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih action !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SecurityForm_Load(object sender, EventArgs e)
        {
            DisableMd5();
            DisableBase64();
        }

        private void B_Convert_Click(object sender, EventArgs e)
        {
            if (!R_Encrypt.Checked && !R_Decrypt.Checked)
            {
                MessageBox.Show("Silahkan pilih action !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ProcessNow();
            }
            
        }

        private void R_Encrypt_Click(object sender, EventArgs e)
        {
            EnableMd5();
            EnableBase64();
        }

        private void R_Decrypt_Click(object sender, EventArgs e)
        {
            EnableBase64();
            DisableMd5();
        }
    }
}
