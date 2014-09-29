using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public partial class Publisher_master : Master_Entry_framwork.Form1
    {
        private Publisher p;
        private Database db;
        public Publisher_master()
        {
            InitializeComponent();
        }

        private void Publisher_master_Load(object sender, EventArgs e)
        {
            db = new Database();
            p = new Publisher();
        }

        protected override void Onadd()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            txt_pubNo.Text = p.getnextNo().ToString();
            cmb_pubName.DropDownStyle = ComboBoxStyle.Simple;
            configCombobox();
        }

        protected override void Onedit()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            txt_pubNo.Clear();
            btn_save.Enabled = true;
            cmb_pubName.DropDownStyle = ComboBoxStyle.DropDown;
            configCombobox();
        }

        protected override void Ondelete()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            txt_pubNo.Clear();
            btn_save.Enabled = true;
            cmb_pubName.DropDownStyle = ComboBoxStyle.DropDown;
            configCombobox();
        }

        protected override void Onview()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            txt_pubNo.Clear();
            btn_save.Enabled = false;
            cmb_pubName.DropDownStyle = ComboBoxStyle.Simple;
            configCombobox();
        }

        public void configCombobox()
        {
            db.loadComboBox(cmb_pubName, p.selectPublisher("selectPublisher"), "Publisher Name", "Publisher ID");
            cmb_pubName.AutoCompleteSource= AutoCompleteSource.ListItems;
            cmb_pubName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_pubName.SelectedIndex = -1;
        }

        public void giveError()
        {
            erp1.SetError(cmb_pubName, "Publisher can not be empty.");
            erp1.SetIconPadding(cmb_pubName, 7);
            erp1.BlinkRate = 200;
            cmb_pubName.Focus();
        }

        private void cmb_pubName_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_pubName.Text != "")
            {
                if (i != 2 && i != 1)
                { txt_pubNo.Clear(); }
                lbl_result.Text = "";
                if (i != 1)
                {
                    if (p.isexistPubName(cmb_pubName.Text.ToString().Trim()))
                    {
                        txt_pubNo.Text = p.getPubNo(cmb_pubName.Text.ToString().Trim()).ToString();
                    }
                    else
                    {
                        if (i != 2)
                            lbl_result.Text = "Publisher doesn't exist.";
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            erp1.Dispose();
            switch (i)
            {
                case 1:
                    if (cmb_pubName.Text!="")
                    {
                        try
                        {
                            int r = p.insertPublisher(cmb_pubName.Text.ToString().Trim(), int.Parse(txt_pubNo.Text.Trim()));
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                cmb_pubName.Text = "";
                                txt_pubNo.Text = p.getnextNo().ToString();
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
                case 2:
                    if (cmb_pubName.Text != "" && txt_pubNo.Text != "")
                    {
                        try
                        {
                            int r = p.editPublisher(cmb_pubName.Text.ToString().Trim(), int.Parse(txt_pubNo.Text.Trim()));
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                cmb_pubName.Text = "";
                                txt_pubNo.Clear();
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        if (cmb_pubName.Text == "")
                        { giveError(); }
                    }

                    break;
                case 3:
                    if (cmb_pubName.Text != "" && txt_pubNo.Text != "")
                    {
                        try
                        {
                            int r = p.deletePublisher(int.Parse(txt_pubNo.Text));
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                cmb_pubName.Text = "";
                                txt_pubNo.Clear();
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        if (cmb_pubName.Text == "")
                        { giveError(); }
                    }
                    break;
                case 4:

                    break;

                default:
                    MessageBox.Show("Select a mode..");
                    break;
            }
            configCombobox();
        }



    }
}
