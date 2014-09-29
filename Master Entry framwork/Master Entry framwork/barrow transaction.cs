using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.CodeDom;
using System.Collections;

namespace Master_Entry_framwork
{
    public partial class barrow_transaction : Master_Entry_framwork.Form1
    {
        Database db;
        Book b;
        Barrow brw;
        ArrayList isbnList;
        DataTable wholeBookList;
        public barrow_transaction()
        {
            InitializeComponent();
        }

        private void barrow_transaction_Load(object sender, EventArgs e)
        {
            isbnList = new ArrayList();
            db = new Database();
            b = new Book();
            brw = new Barrow();
            configureComboBoxes();
        }

        public void configureComboBoxes()
        {
            db.loadComboWithAutoCmplt(cmb_nic, db.executeReader("selectNic", CommandType.StoredProcedure, null), "nic", "nic");
            wholeBookList = db.executeReader("selectAvalbleIsbn", CommandType.StoredProcedure, null);
            cmb_isbn.DataSource = wholeBookList;
            cmb_isbn.ValueMember = "bName";
            cmb_isbn.DisplayMember = "Isbn";
            cmb_isbn.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_isbn.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        public void setIsbnList()
        {
            if (listView1.Items.Count != 0)
            {
                foreach (ListViewItem liv in listView1.Items)
                {
                    isbnList.Add(liv.Text.Trim());
                }
            }
        }

        public void sendBackToIsbnComboBox()// This method is to use only within the onAdd, onEdit, onDelete, onView methods.
        {
            if (listView1.Items.Count != 0)
            {
                brw.Refferno = int.Parse(cmb_refer.Text.Trim());
                if (brw.isExistRefferNo())
                {
                    foreach (ListViewItem liv in listView1.Items)
                    {
                        if (!brw.isIsbnExistForReffrNo(int.Parse(cmb_refer.Text.Trim()), liv.Text.Trim()))
                        {
                            DataRow obj = wholeBookList.NewRow();
                            obj["Isbn"] = liv.Text;
                            obj["bName"] = liv.SubItems[1].Text;
                            wholeBookList.Rows.Add(obj);
                            liv.Remove();
                        }
                        else
                        {
                            liv.Remove();
                        }
                    }
                }
                else
                {
                    foreach (ListViewItem liv in listView1.Items)
                    {
                        DataRow obj = wholeBookList.NewRow();
                        obj["Isbn"] = liv.Text;
                        obj["bName"] = liv.SubItems[1].Text;
                        wholeBookList.Rows.Add(obj);
                        liv.Remove();
                    }
                }
            }
        }

        protected override void Onadd()
        {
            btn_add.Enabled = true;
            btn_save.Enabled = true; 
            cmb_isbn.Enabled = true;
            cmb_nic.Enabled = true;
            dtpkr_borrowDate.Enabled = true;
            dtpkr_borrowDate.Value = DateTime.Today;//new
            dtpkr_expireDate.Enabled = true;
            cmb_refer.Enabled = false;
            cmb_refer.BackColor = Color.LightSteelBlue;
            lbl_result.Text = "";

            cmb_nic.Text = "";
            sendBackToIsbnComboBox();
            cmb_refer.Text = brw.getNextRefferNo().ToString();
        }

        protected override void Onedit()
        {
            btn_add.Enabled = true;
            btn_save.Enabled = true;
            cmb_isbn.Enabled = true;
            cmb_refer.Enabled = true;
            cmb_nic.Enabled = true;
            dtpkr_borrowDate.Enabled = true;
            dtpkr_borrowDate.Value = DateTime.Today;//new
            dtpkr_expireDate.Enabled = true;
            cmb_refer.BackColor = Color.White;
            lbl_result.Text = "";

            sendBackToIsbnComboBox();            
            cmb_refer.Text = "";
            cmb_nic.Text = "";
        }

        protected override void Ondelete()
        {
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            cmb_isbn.Enabled = false;
            cmb_refer.BackColor = Color.White;
            cmb_refer.Enabled = true;
            cmb_nic.Enabled = true;
            dtpkr_borrowDate.Enabled = true;
            dtpkr_borrowDate.Value = DateTime.Today;//new
            dtpkr_expireDate.Enabled = true;
            lbl_result.Text = "";

            sendBackToIsbnComboBox();
            cmb_refer.Text = "";
            cmb_nic.Text = "";
        }

        protected override void Onview()
        {
            btn_add.Enabled = false;
            btn_save.Enabled = false;
            cmb_isbn.Enabled = false;
            cmb_refer.BackColor = Color.White;
            cmb_refer.Enabled = true;
            cmb_nic.Enabled = true;
            dtpkr_borrowDate.Enabled = true;
            dtpkr_borrowDate.Value = DateTime.Today;//new
            dtpkr_expireDate.Enabled = true;
            lbl_result.Text = "";

            sendBackToIsbnComboBox();
            cmb_refer.Text = "";
            cmb_nic.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmb_isbn.Text != "" && (i==1 || i==2) )
            {
                try
                {
                    if (b.isBookAvailable(cmb_isbn.Text.Trim()))
                    {
                        //add the item to the list View.
                        ListViewItem liv = new ListViewItem(cmb_isbn.Text);
                        liv.SubItems.Add(cmb_isbn.SelectedValue.ToString());
                        listView1.Items.Add(liv);
                        //Remove it from ComboBox.
                        wholeBookList.Rows.RemoveAt(int.Parse(cmb_isbn.SelectedIndex.ToString()));
                        db.loadComboWithAutoCmplt(cmb_isbn, wholeBookList, "Isbn", "bName");
                    }
                    else
                    { 
                        MessageBox.Show("This book already borrowed....\nThis book does not availble until it return", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wholeBookList.Rows.RemoveAt(int.Parse(cmb_isbn.SelectedIndex.ToString()));
                    }
                }
                catch (NullReferenceException)
                {
                    if (b.isExistBook(cmb_isbn.Text.Trim()))
                        MessageBox.Show("This book might already borrowed.", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Such a book does not exist in the system.\nPlease Enter the Book details to system first..", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void clear()
        {
            cmb_nic.Text = "";
            cmb_isbn.Text = "";
            cmb_refer.Text = "";
            dtpkr_borrowDate.Value = DateTime.Today;
            listView1.Items.Clear();    //guess this code doesn't need but have to test.
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (i == 1 || i == 2)
            {
                if (e.Item.Checked == true)
                {
                    //add item to comboBox list.
                    DataRow obj = wholeBookList.NewRow();
                    obj["Isbn"] = e.Item.Text;
                    obj["bName"] = e.Item.SubItems[1].Text;
                    wholeBookList.Rows.Add(obj);
                    //remove it from listview
                    e.Item.Remove();
                }
            }
        }

        public void givBookError()
        {
            erp2.SetError(listView1, "Books list can not be empty..");
            erp2.SetIconPadding(listView1, 4);
            erp2.BlinkRate = 200;
            listView1.Focus();
        }

        public void givNicError()
        {
            erp1.SetError(cmb_nic, "NIC can not be empty.");
            erp1.SetIconPadding(cmb_nic, 4);
            erp1.BlinkRate = 200;
            cmb_nic.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            erp1.Dispose();
            erp2.Dispose();
            switch (i)
            {
                case 1:
                    if (cmb_nic.Text != "" && listView1.Items.Count != 0)
                    {
                        setIsbnList();
                        try
                        {
                            int r = brw.borrowBook(int.Parse(cmb_refer.Text.Trim()), cmb_nic.Text, dtpkr_borrowDate.Value, dtpkr_expireDate.Value, isbnList);
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                clear();
                                cmb_refer.Text = brw.getNextRefferNo().ToString();
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else
                    {
                        if (listView1.Items.Count == 0)
                            givBookError();
                        if (cmb_nic.Text == "")
                            givNicError();
                    }
                    break;
                case 2:
                    if (cmb_nic.Text != "" && listView1.Items.Count != 0)
                    {
                        setIsbnList();
                        try
                        {
                            int r = brw.editBorrowBook(int.Parse(cmb_refer.Text.Trim()),isbnList);
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                clear();
                                cmb_refer.Enabled = true;
                                cmb_nic.Enabled = true;
                                dtpkr_borrowDate.Enabled = true;
                                dtpkr_expireDate.Enabled = true;
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                    }
                    else
                    {
                        if (listView1.Items.Count == 0)
                            givBookError();
                        if (cmb_nic.Text == "")
                            givNicError();
                    }
                    break;
                case 3:
                    if (cmb_nic.Text != "" && listView1.Items.Count != 0)
                    {
                        try
                        {
                            int r = brw.deleteBorrow(int.Parse(cmb_refer.Text.Trim()));
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Rows affected";
                                clear();
                                cmb_refer.Enabled = true;
                                cmb_nic.Enabled = true;
                                dtpkr_borrowDate.Enabled = true;
                                dtpkr_expireDate.Enabled = true;
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else
                    {
                        if (listView1.Items.Count == 0)
                            givBookError();
                        if (cmb_nic.Text == "")
                            givNicError();
                    }
                    break;
                case 4:

                    break;
                default:
                    MessageBox.Show("Select a mode..");
                    break;
            }
            configureComboBoxes();
            isbnList.Clear();
        }

        private void cmb_refer_Validating(object sender, CancelEventArgs e)
        {
            lbl_result.Text = "";
            if (i != 1 && i!=0 && cmb_refer.Text!="")
            {
                brw.Refferno = int.Parse(cmb_refer.Text);
                if (brw.isExistRefferNo())
                {
                    brw.viewBorrowHdr();
                    cmb_nic.Text = brw.Nic;
                    dtpkr_borrowDate.Value = brw.BorrowDate;
                    dtpkr_expireDate.Value = brw.ExpireDate;
                    if (i == 2 || i == 3)//new module.
                    {
                        cmb_refer.Enabled = false;
                        cmb_nic.Enabled = false;
                        dtpkr_borrowDate.Enabled = false;
                        dtpkr_expireDate.Enabled = false;
                    }
                    foreach (DataRow dr in brw.BorrowedBooks.Rows)
                    {
                        ListViewItem lvi=new ListViewItem(dr["Isbn"].ToString());
                        lvi.SubItems.Add(dr["bName"].ToString());
                        listView1.Items.Add(lvi);
                    }
                }
                else
                {
                    lbl_result.Text = "Refference No doesn't exist.";
                    cmb_refer.Focus();
                }
            }
            
        }

        private void dtpkr_borrowDate_ValueChanged(object sender, EventArgs e)
        {
            dtpkr_expireDate.Value = dtpkr_borrowDate.Value.AddDays(brw.getAllowDays());
        }

    }
}
