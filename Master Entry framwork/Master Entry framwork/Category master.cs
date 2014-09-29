using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public partial class Category_master : Master_Entry_framwork.Form1
    {
        Category c;
        Database db;
        public Category_master()
        {
            InitializeComponent();
        }

        public void clear()
        {
            cmb_catname.Text = "";
            txt_catno.Clear();
        }

        private void Category_master_Load(object sender, EventArgs e)
        {
            c = new Category();
            db = new Database();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    erp1.Dispose();
                    if (cmb_catname.Text != "")
                    {
                        try
                        {
                            int r = c.insertCategory(cmb_catname.Text.ToString(), int.Parse(txt_catno.Text.ToString()));
                            if(r!=0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                cmb_catname.Text = "";
                                txt_catno.Text = c.getNextNo().ToString();
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        erp1.SetError(cmb_catname, "Category name can not be empty.");
                        erp1.SetIconPadding(cmb_catname, 7);
                        erp1.BlinkRate = 200;
                        cmb_catname.Focus();
                    }
                    
                    break;
                case 2:
                    erp1.Dispose();
                    if (cmb_catname.Text != "")
                    {
                        try
                        {
                            if(txt_catno.Text!="")
                            {
                                int r = c.editCategory(cmb_catname.Text.ToString().Trim(), int.Parse(txt_catno.Text));
                                if (r != 0)
                                {
                                    lbl_result.Text = r.ToString() + " Rows affected";
                                    cmb_catname.Text = "";
                                    txt_catno.Clear();
                                }
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        erp1.SetError(cmb_catname, "Category name can not be empty.");
                        erp1.SetIconPadding(cmb_catname, 7);
                        erp1.BlinkRate = 200;
                        cmb_catname.Focus();
                    }

                    break;

                case 3:
                    erp1.Dispose();
                    if (cmb_catname.Text != "")
                    {
                        try
                        {
                            if (txt_catno.Text != "")
                            {
                                int r = c.deleteCategory(int.Parse(txt_catno.Text));
                                if (r != 0)
                                {
                                    lbl_result.Text = r.ToString() + " Rows affected";
                                    cmb_catname.Text = "";
                                    txt_catno.Clear();
                                }
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        erp1.SetError(cmb_catname, "Category name can not be empty.");
                        erp1.SetIconPadding(cmb_catname, 7);
                        erp1.BlinkRate = 200;
                        cmb_catname.Focus();
                    }
                    break;  
         
                case 4:

                    break;

                default:
                    MessageBox.Show("Select a mode..");
                    break;
            }
        }

        public void configComboBox()
        {
            db.loadComboBox(cmb_catname, c.selectCategory("selectCategory"), "Category Name", "Category ID");
            cmb_catname.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_catname.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_catname.SelectedIndex = -1;
        }

        protected override void disposeitem()
        {
            cmb_catname.Text = "";
        }


        //This function run when new mode buttons are clicked.
        protected override void Onadd()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            txt_catno.ReadOnly = true;
            txt_catno.Text = c.getNextNo().ToString();
            cmb_catname.DropDownStyle = ComboBoxStyle.Simple;
            configComboBox();
            btn_save.Enabled = true;
        }

        //This function run when mode buttons are clicked.
        protected override void Onedit()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            txt_catno.Clear();
            txt_catno.ReadOnly = true;
            cmb_catname.DropDownStyle = ComboBoxStyle.Simple;
            configComboBox();
            btn_save.Enabled = true;
        }

        //This function run when mode buttons are clicked.
        protected override void Ondelete()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            txt_catno.Clear();
            txt_catno.ReadOnly = true;
            cmb_catname.DropDownStyle = ComboBoxStyle.Simple;
            configComboBox();
            btn_save.Enabled = true;
        }

        //This function run when view mode buttons are clicked.
        protected override void Onview()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            txt_catno.Clear();
            txt_catno.ReadOnly = true;
            cmb_catname.DropDownStyle = ComboBoxStyle.Simple;
            configComboBox();
            btn_save.Enabled = false;
        }

        private void cmb_catname_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_catname.Text != "")
            {
                if (i != 2 && i != 1)
                { txt_catno.Clear(); }
                lbl_result.Text = "";
                if (i != 1)
                {
                    if (c.isexistCatName(cmb_catname.Text.ToString().Trim()))
                    {
                        txt_catno.Text = c.getcatNo(cmb_catname.Text.ToString().Trim()).ToString();
                    }
                    else
                    {
                        if (i != 2)
                            lbl_result.Text = "Category name doesn't exist.";
                    }
                }
            }
        }
    }
}
