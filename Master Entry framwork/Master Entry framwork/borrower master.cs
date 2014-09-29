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
    public partial class borrower_master : Master_Entry_framwork.Form1
    {
        Borrower bor;
        Database db;
        public borrower_master()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            erp1.Dispose();
            erp2.Dispose();
            switch (i)
            {
                case 1:
                    if(cmb_name.Text!=""&&txt_nic.Text!="")
                    {
                        bor.setNic(txt_nic.Text);
                        bor.setName(cmb_name.Text);
                        bor.setPhone(txt_phone.Text);
                        bor.setEmail(txt_email.Text);
                        bor.setHouseNo(txt_houseNo.Text);
                        bor.setStreetNo(txt_streetNo.Text);
                        bor.setCity(txt_city.Text);
                        bor.setEstate(txt_estate.Text);
                        int r= bor.insertBorrower();
                        if (r!= 0)
                        {
                            lbl_result.Text = r.ToString() + " Rows affected";
                            clearItems();
                        }
                    }
                    else
                    {
                        if (cmb_name.Text == "")
                            givNameError();
                        if (txt_nic.Text == "")
                            givNicError();
                    }

                    break;
                case 2:
                    if (cmb_name.Text != "" && txt_nic.Text != "")
                    {
                        bor.setNic(txt_nic.Text);
                        bor.setName(cmb_name.Text);
                        bor.setPhone(txt_phone.Text);
                        bor.setEmail(txt_email.Text);
                        bor.setHouseNo(txt_houseNo.Text);
                        bor.setStreetNo(txt_streetNo.Text);
                        bor.setCity(txt_city.Text);
                        bor.setEstate(txt_estate.Text);
                        int r = 0;
                        try
                        {
                            r = bor.editBorrower();
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        if (r != 0)
                        {
                            lbl_result.Text = r.ToString() + " Rows affected";
                            clearItems();
                        }
                    }
                    else
                    {
                        if (cmb_name.Text == "")
                            givNameError();
                        if (txt_nic.Text == "")
                            givNicError();
                    }
                    break;
                case 3:
                    if (txt_nic.Text != ""&&cmb_name.Text!="")
                    {
                        if (bor.isNameExist(cmb_name.Text))
                        {
                            int r=bor.deleteBorrower(txt_nic.Text);
                            if(r!=0)
                            {
                                lbl_result.Text=r.ToString()+" rows affected";
                                clearItems();
                            }
                        }
                        else
                        { lbl_result.Text = "Name doesn't exist."; }
                    }
                    else
                    {
                        if (txt_nic.Text =="")
                            givNicError();
                        if (cmb_name.Text == "")
                            givNameError();
                    }
                    break;
                case 4:

                    break;
                default:
                    MessageBox.Show("Select a mode..");
                    break;
            }
            configComboBox();
        }

        public void givNameError()
        {
            erp1.SetError(cmb_name, "Name can not be empty.");
            erp1.SetIconPadding(cmb_name, 6);
            erp1.BlinkRate = 200;
            cmb_name.Focus();
        }

        public void givNicError()
        {
            erp2.SetError(txt_nic, "NIC can not be empty.");
            erp2.SetIconPadding(txt_nic, 6);
            erp2.BlinkRate = 200;
            txt_nic.Focus();
        }

        public void clearItems()
        {
            txt_houseNo.Clear();
            txt_streetNo.Clear();
            txt_city.Clear();
            txt_estate.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            cmb_name.Text = "";
            txt_nic.Enabled = true;
            txt_nic.Clear();
        }

        public void retrieveBorrower(string nam)
        {
            bor.viewBorrower(nam);
            cmb_name.Text = bor.getName();
            txt_nic.Text = bor.getNic();
            txt_phone.Text = bor.getPhone();
            txt_email.Text = bor.getEmail();
            txt_houseNo.Text = bor.getHouseNo();
            txt_streetNo.Text = bor.getStreetNo();
            txt_city.Text = bor.getCity();
            txt_estate.Text = bor.getEstate();
        }

        public void retrieveBorrowerByNic(string nc)
        {
            bor.viewBorrwrByNic(nc);
            cmb_name.Text = bor.getName();
            txt_nic.Text = bor.getNic();
            txt_phone.Text = bor.getPhone();
            txt_email.Text = bor.getEmail();
            txt_houseNo.Text = bor.getHouseNo();
            txt_streetNo.Text = bor.getStreetNo();
            txt_city.Text = bor.getCity();
            txt_estate.Text = bor.getEstate();
        }



        protected override void Onadd()
        {
            erp1.Dispose();
            erp2.Dispose();
            clearItems();
            configComboBox();
            txt_nic.ReadOnly = false;
            txt_phone.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_houseNo.ReadOnly = false;
            txt_streetNo.ReadOnly = false;
            txt_city.ReadOnly = false;
            txt_estate.ReadOnly = false;
            btn_save.Enabled = true;
        }
        protected override void Onedit()
        {
            erp1.Dispose();
            erp2.Dispose();
            clearItems();
            configComboBox();
            txt_nic.ReadOnly = false;
            txt_phone.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_houseNo.ReadOnly = false;
            txt_streetNo.ReadOnly = false;
            txt_city.ReadOnly = false;
            txt_estate.ReadOnly = false;
            btn_save.Enabled = true;
        }
        protected override void Ondelete()
        {
            erp1.Dispose();
            erp2.Dispose();
            clearItems();
            configComboBox();
            txt_nic.ReadOnly = true;
            txt_phone.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_houseNo.ReadOnly = true;
            txt_streetNo.ReadOnly = true;
            txt_city.ReadOnly = true;
            txt_estate.ReadOnly = true;
            btn_save.Enabled = true;
        }
        protected override void Onview()
        {
            erp1.Dispose();
            erp2.Dispose();
            clearItems();
            configComboBox();
            txt_nic.ReadOnly = true;
            txt_phone.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_houseNo.ReadOnly = true;
            txt_streetNo.ReadOnly = true;
            txt_city.ReadOnly = true;
            txt_estate.ReadOnly = true;
            btn_save.Enabled = false;
        }

        private void borrower_master_Load(object sender, EventArgs e)
        {
            bor = new Borrower();
            db = new Database();
        }

        public void configComboBox()
        {
            cmb_name.SelectedIndexChanged -= cmb_name_SelectedIndexChanged;
            db.loadComboWithAutoCmplt(cmb_name, db.executeReader("selectBorwerNam", CommandType.StoredProcedure, null), "name", "name");
            cmb_name.SelectedIndexChanged += cmb_name_SelectedIndexChanged;
        }

        private void cmb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i == 3 || i == 4)
            {
                if (cmb_name.Text != "")
                {
                    if (bor.isNameExist(cmb_name.Text.Trim()))
                    {
                        retrieveBorrower(cmb_name.Text);
                    }
                    else
                    { lbl_result.Text = "Name doesn't exist"; }
                }
            }
        }

        private void txt_nic_Validating(object sender, CancelEventArgs e)
        {
            lbl_result.Text = "";            
            if (txt_nic.Text!="")
            {
                if (i == 1)
                {
                    bor.setNic(txt_nic.Text);
                    bool isNicExist = bor.isNicExist();
                    if (isNicExist)
                    {
                        lbl_result.Text = "NIC is already Exist..";
                        txt_nic.Focus();
                    }
                    else
                        txt_nic.Enabled = false;
                }
                if (i == 2)
                {
                    bor.setNic(txt_nic.Text);
                    bool isNicExist = bor.isNicExist();
                    if (isNicExist)
                    {
                        retrieveBorrowerByNic(txt_nic.Text);
                        txt_nic.Enabled = false;
                    }
                    else
                    {
                        lbl_result.Text = "NIC doesn't Exist..";
                        txt_nic.Focus();
                    }
                }
            }
        }

        private void cmb_name_Validating(object sender, CancelEventArgs e)
        {
            lbl_result.Text = "";
            if (cmb_name.Text != "")
            {
                if (i == 1)
                {
                    bool isNameExist = bor.isNameExist(cmb_name.Text);
                    if (isNameExist)
                    {
                        lbl_result.Text = "Name is already Exist..";
                        cmb_name.Focus();
                    }
                }
                if (i == 2 && txt_nic.Text=="")
                {
                    bool isNameExist = bor.isNameExist(cmb_name.Text);
                    if (isNameExist)
                    {
                        retrieveBorrower(cmb_name.Text);
                        txt_nic.Enabled = false;
                    }
                    else
                    {
                        lbl_result.Text = "Name doesn't Exist..";
                        cmb_name.Focus();
                    }
                }
            }
        }
    }
}
