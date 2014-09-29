using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public partial class Login : Form
    {
        User u;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        { this.Dispose();}

        private void btn_exit_Click(object sender, EventArgs e)
        { this.Dispose();}

        private void Login_Load(object sender, EventArgs e)
        {
            u = new User();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            disposeErp();
            if (txt_uname.Text != "" && txt_pw.Text != "")
            {
                int result = -9;
                try
                {
                    result = u.authenticate(txt_uname.Text.Trim(), txt_pw.Text.Trim());
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (result == 1)
                {
                    lbl_feedback.Text="User doesn't exist...!";
                }
                else if (result == -1)
                {
                    lbl_feedback.Text="Password incorrect...!";
                }
                else
                {
                    this.Hide();
                    Main m = new Main();
                    m.Show();
                }
            }
            else
            {
                if (txt_uname.Text == "")
                {
                    erp1.SetError(txt_uname, "User name can not be empty.");
                    erp1.SetIconPadding(txt_uname, 7);
                    erp1.BlinkRate = 200;
                    txt_uname.Focus();
                }
                if (txt_pw.Text == "")
                {
                    erp2.SetError(txt_pw, "Password can not be empty.");
                    erp2.SetIconPadding(txt_pw, 7);
                    erp2.BlinkRate = 200;
                    txt_pw.Focus();
                }
                if (txt_pw.Text == "" & txt_uname.Text == "")
                {
                    erp1.SetError(txt_uname, "User name can not be empty.");
                    erp1.SetIconPadding(txt_uname, 7);
                    erp1.BlinkRate = 200;
                    erp2.SetError(txt_pw, "Password can not be empty.");
                    erp2.SetIconPadding(txt_pw, 7);
                    erp2.BlinkRate = 200;
                    txt_uname.Focus();
                }
            }
        }

        public void disposeErp()
        {
            erp1.Dispose();
            erp2.Dispose();
        }
    }
}
