using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public partial class author_master : Master_Entry_framwork.Form1
    {
        Database db;
        Author a;
        public author_master()
        {
            InitializeComponent();
        }

        private void author_master_Load(object sender, EventArgs e)
        {
            db = new Database();
            a = new Author();
        }

        protected override void Onadd()
        {
            erp1.Dispose();
            lbl_result.Text="";
            btn_save.Enabled=true;
            txt_an.Text = a.getnextNo().ToString();
            cmb_aname.DropDownStyle = ComboBoxStyle.Simple;
            configcomboBox();
        }

        protected override void Onedit()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            txt_an.Clear();
            cmb_aname.DropDownStyle = ComboBoxStyle.DropDown;
            configcomboBox();
        }

        protected override void Ondelete()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            txt_an.Clear();
            cmb_aname.DropDownStyle = ComboBoxStyle.DropDown;
            configcomboBox();
        }

        protected override void Onview()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = false;
            txt_an.Clear();
            cmb_aname.DropDownStyle = ComboBoxStyle.Simple;
            configcomboBox();
        }

        public void configcomboBox()
        {
            db.loadComboBox(cmb_aname, a.selectAuthor("selectAuthor"), "Author Name", "Author ID");
            cmb_aname.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_aname.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_aname.SelectedIndex = -1;
        }

        public void giveError()
        {
            erp1.SetError(cmb_aname, "Author can not be empty.");
            erp1.SetIconPadding(cmb_aname, 7);
            erp1.BlinkRate = 200;
            cmb_aname.Focus();
        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1://add
                    erp1.Dispose();
                    if (cmb_aname.Text!="")
                    {
                        try
                        {
                            int r = a.insertAuthor(cmb_aname.Text.ToString().Trim(), int.Parse(txt_an.Text.Trim()));
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                cmb_aname.Text = "";
                                txt_an.Text = a.getnextNo().ToString();
                            }
                        }
                        catch(Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        giveError();
                    }
                    break;
                case 2://edit
                    erp1.Dispose();
                    if (cmb_aname.Text != "" && txt_an.Text!="")
                    {
                        try
                        {
                            int r = a.editAuthor(cmb_aname.Text.ToString().Trim(), int.Parse(txt_an.Text.Trim()));
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                cmb_aname.Text = "";
                                txt_an.Clear();
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        if (cmb_aname.Text== "")
                        { giveError(); }
                    }
                    break;
                case 3://delete
                    erp1.Dispose();
                    if (cmb_aname.Text!="" && txt_an.Text!="")
                    {
                        try
                        {
                            int r = a.deleteAuthor(int.Parse(txt_an.Text));
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                cmb_aname.Text = "";
                                txt_an.Clear();
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        if (cmb_aname.Text=="")
                        { giveError(); }
                    }

                    break;
                case 4://view

                    break;
                default:
                    MessageBox.Show("Select a mode..");
                    break;
            }
            configcomboBox();
        }

        private void cmb_aname_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_aname.Text != "")
            {
                if (i != 2 && i != 1)
                { txt_an.Clear(); }
                lbl_result.Text = "";
                if (i != 1)
                {
                    if (a.isexistAutorName(cmb_aname.Text.ToString().Trim()))
                    {
                        txt_an.Text = a.getAuthorNo(cmb_aname.Text.ToString().Trim()).ToString();
                    }
                    else
                    {
                        if (i != 2)
                            lbl_result.Text = "Author doesn't exist.";
                    }
                }
            }
        }


    }
}
