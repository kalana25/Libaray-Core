using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Master_Entry_framwork
{
    public partial class gencode_master : Master_Entry_framwork.Form1
    {
        private Database db;
        private GeneralCode g;
        private int id;
        public gencode_master()
        {
            InitializeComponent();
        }

        private void gencode_master_Load(object sender, EventArgs e)
        {
            db = new Database();
            g = new GeneralCode();        
        }

        protected override void Onadd()
        {
            erp1.Dispose();
            erp2.Dispose();
            erp3.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            cmb_genType.Enabled = true;
            txt_desc.Text = "";
            cmb_genType.Text = "";
            cmb_genType.DropDownStyle = ComboBoxStyle.Simple;
            cmb_genCode.DropDownStyle = ComboBoxStyle.Simple;
            configGentype();
        }


        protected override void Onedit()
        {
            erp1.Dispose();
            erp2.Dispose();
            erp3.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            txt_desc.Text = "";
            cmb_genType.Text = "";
            cmb_genType.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_genCode.DropDownStyle = ComboBoxStyle.DropDown;
            configGentype();
        }

        protected override void Ondelete()
        {
            erp1.Dispose();
            erp2.Dispose();
            erp3.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            cmb_genType.Enabled = true;
            txt_desc.Text = "";
            cmb_genType.Text = "";
            cmb_genType.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_genCode.DropDownStyle = ComboBoxStyle.DropDown;
            configGentype();
        }

        protected override void Onview()
        {
            erp1.Dispose();
            erp2.Dispose();
            erp3.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = false;
            cmb_genType.Enabled = true;
            txt_desc.Text = "";
            cmb_genType.Text = "";
            cmb_genType.DropDownStyle = ComboBoxStyle.Simple;
            configGentype();
        }

        public void configGentype()
        {
            cmb_genType.SelectedIndexChanged -= cmb_genType_SelectedIndexChanged;
            db.loadComboBox(cmb_genType, g.selectGentype("selectGenType"), "General Code Type", "Description"); 
            cmb_genType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_genType.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_genType.SelectedIndex = -1;
            cmb_genType.SelectedIndexChanged += cmb_genType_SelectedIndexChanged;
        }

        public void configGencode(string type)
        {
            db.loadComboBox(cmb_genCode, g.selectGencode(type), "General Code", "");
            cmb_genCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_genCode.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_genCode.SelectedIndex = -1;
        }

        public void giveGenCError()
        {
            erp3.SetError(cmb_genCode, "General Code can not be empty.");
            erp3.SetIconPadding(cmb_genCode, 7);
            erp3.BlinkRate = 200;
            cmb_genCode.Focus();
        }

        public void giveDescError()
        {
            erp2.SetError(txt_desc, "Description can not be empty.");
            erp2.SetIconPadding(txt_desc, 7);
            erp2.BlinkRate = 200;
            txt_desc.Focus();
        }

        public void giveGenTError()
        {
            erp1.SetError(cmb_genType, "General Code Type can not be empty.");
            erp1.SetIconPadding(cmb_genType, 7);
            erp1.BlinkRate = 200;
            cmb_genType.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            erp1.Dispose();
            erp2.Dispose();
            erp3.Dispose();
            switch (i)
            {
                case 1:
                    if (cmb_genType.Text != "" && txt_desc.Text != "" && cmb_genCode.Text!="")
                    {
                        try
                        {
                            int r = g.insertGencode(cmb_genType.Text.Trim(), txt_desc.Text.Trim(), cmb_genCode.Text.Trim());
                            if (r!=0)
                            { lbl_result.Text = r.ToString() + " Rows affected"; }
                            txt_desc.Text = "";
                            cmb_genType.Text = "";
                            cmb_genCode.Text = "";
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        if (cmb_genType.Text == "")
                        { giveGenTError(); }
                        if (txt_desc.Text == "")
                        { giveDescError(); }
                        if (cmb_genCode.Text == "")
                        { giveGenCError(); }
                    }
                    break;
                case 2:
                    if (cmb_genType.Text != "" && txt_desc.Text != "" && cmb_genCode.Text!="")
                    {               
                        try
                        {
                            int r = g.editGencode(id, cmb_genType.Text, txt_desc.Text, cmb_genCode.Text);
                            if (r != 0)
                            { lbl_result.Text = r.ToString() + " Rows affected"; }
                            txt_desc.Text = "";
                            cmb_genType.Text = "";
                            cmb_genCode.Text = "";
                            cmb_genType.Enabled = true;
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        if (cmb_genType.Text == "")
                        { giveGenTError(); }
                        if (txt_desc.Text == "")
                        { giveDescError(); }
                        if (cmb_genCode.Text == "")
                        { giveGenCError(); }
                    }
                    break;
                case 3:
                    if (cmb_genType.Text != "" && txt_desc.Text != "")
                    {
                        try
                        {
                            int r = g.deleteGencode(cmb_genType.Text.Trim(), txt_desc.Text.Trim(), cmb_genCode.Text.Trim());
                            if (r != 0)
                            { lbl_result.Text = r.ToString() + " Rows affected"; }

                        }
                        catch(SqlException ex)
                        { 
                            if((int)ex.Number==547)
                            lbl_result.Text = "Gencodes exist for " + cmb_genType.Text + " type.";
                        }
                        txt_desc.Text = "";
                        cmb_genType.Text = "";
                        cmb_genCode.Text = "";
                        
                    }
                    else
                    {
                        if (cmb_genType.Text == "")
                        { giveGenTError(); }
                        if (txt_desc.Text == "")
                        { giveDescError(); }
                    }
                    break;
                case 4:

                    break;
                default:
                    MessageBox.Show("Select a mode..");
                    break;
            }
            configGentype();
        }

        private void cmb_genType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_result.Text = "";

            if (cmb_genType.SelectedIndex != -1)
            {
                txt_desc.Text = cmb_genType.SelectedValue.ToString();
                configGencode(cmb_genType.Text.Trim());
            }
            if (i == 2)
            {
                cmb_genType.Enabled = false;
            }
        }

        private void cmb_genCode_Leave(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            if ((i == 3 || i == 4)&& cmb_genCode.Text!="")
            {
                if (!g.isExistGenCode(cmb_genType.Text, cmb_genCode.Text))
                    lbl_result.Text = "Gencode doesn't exist";
            }
            else if (i == 1 && cmb_genCode.Text!="")
            {
                if (g.isExistGenCode(cmb_genType.Text, cmb_genCode.Text))
                    lbl_result.Text = "Gencode exist";
            }

            if (i == 2 && cmb_genType.Text != "")
            {
                try
                {
                    id = g.getId(cmb_genType.Text, cmb_genCode.Text);
                }
                catch
                { }
            }
        }

        private void cmb_genType_Leave(object sender, EventArgs e)
        {
            if (cmb_genType.Text != "")
            {
                if (i == 2 || i == 3 || i == 4)
                {
                    if (!g.isExistGenType(cmb_genType.Text))
                        lbl_result.Text = "Gencode Type doesn't exist";
                }
            }
        }

        private void cmb_genCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i == 2 && cmb_genType.Text != "")
            {
                try
                {
                    id = g.getId(cmb_genType.Text, cmb_genCode.Text);
                }
                catch
                { }
            }
        }
    }
}
