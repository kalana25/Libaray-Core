using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public partial class language_master : Master_Entry_framwork.Form1
    {
        Language l;
        Database db;
        public language_master()
        {
            InitializeComponent();
        }

        private void language_master_Load(object sender, EventArgs e)
        {
            l = new Language();
            db = new Database();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1://add
                    erp1.Dispose();
                    if (cmb_lanName.Text != "")
                    {
                        try
                        {
                            int r = l.insertLanguage(cmb_lanName.Text.ToString().Trim(), int.Parse(txt_lanNo.Text.Trim()));
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                cmb_lanName.Text = "";
                                txt_lanNo.Text = l.getnextNo().ToString();
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
                    if (cmb_lanName.Text != "" && txt_lanNo.Text!="")
                    {
                        try
                        {
                            int r = l.editLanguage(cmb_lanName.Text.ToString().Trim(), int.Parse(txt_lanNo.Text.Trim()));
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                cmb_lanName.Text = "";
                                txt_lanNo.Clear();
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        if (cmb_lanName.Text == "")
                        { giveError(); }
                    }

                    break;

                case 3://delete
                    erp1.Dispose();
                    if (cmb_lanName.Text != "" && txt_lanNo.Text!="")
                    {
                        try
                        {
                            int r = l.deleteLanguage(int.Parse(txt_lanNo.Text));
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                cmb_lanName.Text = "";
                                txt_lanNo.Clear();
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        if (cmb_lanName.Text == "")
                        { giveError(); }
                    }

                    break;

                case 4://view

                    break;

                default:
                    MessageBox.Show("Select a mode..");
                    break;
            }
            configComboBox();
        }


        protected override void Onadd()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            txt_lanNo.Text = l.getnextNo().ToString();
            cmb_lanName.DropDownStyle = ComboBoxStyle.Simple;
            configComboBox();
        }

        protected override void Onedit()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            txt_lanNo.Clear();
            btn_save.Enabled = true;
            cmb_lanName.DropDownStyle = ComboBoxStyle.DropDown;
            configComboBox();
        }

        protected override void Ondelete()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            txt_lanNo.Clear();
            btn_save.Enabled = true;
            cmb_lanName.DropDownStyle = ComboBoxStyle.DropDown;
            configComboBox();
        }

        protected override void Onview()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            txt_lanNo.Clear();
            btn_save.Enabled = false;
            cmb_lanName.DropDownStyle = ComboBoxStyle.Simple;
            configComboBox();
        }

        public void configComboBox()
        {
            db.loadComboBox(cmb_lanName, l.selectLanguage("selectLanguage"), "Language", "Language ID");
            cmb_lanName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_lanName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_lanName.SelectedIndex = -1;
        }

        public void giveError()
        {
            erp1.SetError(cmb_lanName, "Language can not be empty.");
            erp1.SetIconPadding(cmb_lanName, 7);
            erp1.BlinkRate = 200;
            cmb_lanName.Focus();
        }

        private void cmb_lanName_Validating(object sender, CancelEventArgs e)
        {
            if(cmb_lanName.Text!="")
            {
                if (i != 2 && i != 1)
                { txt_lanNo.Clear(); }
                lbl_result.Text = "";
                if (i != 1)
                {
                    if(l.isexistLanName(cmb_lanName.Text.ToString().Trim()))
                    {
                        txt_lanNo.Text = l.getLanNo(cmb_lanName.Text.ToString().Trim()).ToString();
                    }
                    else
                    {
                        if (i != 2)
                        lbl_result.Text = "Language doesn't exist.";
                    }
                }
            }
        }


    }
}