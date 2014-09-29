using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Master_Entry_framwork
{
    public partial class user_master : Form
    {
        User userobj;
        private DataTable userType;
        public user_master()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void user_master_Load(object sender, EventArgs e)
        {
            userobj = new User();
            userType = userobj.viewUserType();
            if (userType.Rows.Count != 0)
            {
                cmb_userType.DataSource = userType;
                cmb_userType.DisplayMember = "gencode";

                DataTable dtbl = userobj.viewUsers();
                foreach (DataRow dtrw in dtbl.Rows)
                {

                    ListViewItem lvi = new ListViewItem(dtrw["uType"].ToString());
                    lvi.SubItems.Add(dtrw["uName"].ToString());
                    if ((dtrw["pWord"].ToString().Length) != 0)
                        lvi.SubItems.Add("*****************");
                    else
                        lvi.SubItems.Add("Empty");
                    listView1.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Please create Usertype first", "GENARAL CODE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            erp1.Dispose();
            erp2.Dispose();
            if (txt_username.Text != "" && txt_password.Text != "")
            {
                int r = userobj.insertUser(txt_username.Text, txt_password.Text, cmb_userType.Text);
                if (r != 0)
                {
                    lbl_result.Text = r.ToString() + " Rows affected";
                    addAlist(txt_username.Text, txt_password.Text, cmb_userType.Text);
                    clear();
                }
            }
            else
            {
                if (txt_username.Text == "")
                {
                    erp1.SetError(txt_username, "Username can not be empty.");
                    erp1.SetIconPadding(txt_username, 6);
                    erp1.BlinkRate = 200;
                    txt_username.Focus();
                }
                if (txt_password.Text == "")
                {
                    erp2.SetError(txt_password, "Password can not be empty.");
                    erp2.SetIconPadding(txt_password, 6);
                    erp2.BlinkRate = 200;
                    txt_password.Focus();
                }
            }
        }

        public void clear()
        {
            txt_password.Clear();
            txt_username.Clear();
            cmb_userType.SelectedIndex = 0;
        }
        public void addAlist(string un, string pw, string ut)
        {
            ListViewItem lvi = new ListViewItem(ut);
            lvi.SubItems.Add(un);
            lvi.SubItems.Add("*****************");
            listView1.Items.Add(lvi);
        }

        //** to BE DEVELOPED  **

        //We have to develop and check. when we going to delete a user that already assigns permisions... what messages give.
        //we have to check behaviours when form load without UUSER TYPE GENCODE.
        //WE HAVE TO GIVE USER CLUES WHETHER THE USERS ARE ASSIGNS TO PERMISSIONS OR NOT

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                int r = 0;
                try
                {
                    r = userobj.deleteUser(listView1.SelectedItems[0].SubItems[1].Text);
                    listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("That user already assigned ", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                
                lbl_result.Text = r.ToString() + " rows affected.";
            }
        }

    }
}
