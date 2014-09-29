using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public partial class return_transaction : Form
    {
        Barrow brw;
        DataTable BKCONDITION;

        public return_transaction()
        {
            InitializeComponent();
        }

        private void return_transaction_Load(object sender, EventArgs e)
        {
            brw = new Barrow();
            GeneralCode gc = new GeneralCode();
            BKCONDITION = gc.selectGencode("BKCONDTION");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_reffer.Text !="")
            {

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_reffer_Validating(object sender, CancelEventArgs e)
        {
            if (txt_reffer.Text !="")
            {
                try
                {
                    brw.Refferno = int.Parse(txt_reffer.Text);
                }
                catch (FormatException fex)
                {
                    brw.Refferno = 0;
                    MessageBox.Show(fex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_reffer.Clear();
                }
                if (brw.isExistRefferNo())
                {
                    if (brw.getRtnStatusOfReffNo("ref") == false)              //newly added 18/01/2014
                    {
                        clear();
                        brw.viewPendingBook();
                        txt_nic.Text = brw.Nic;
                        txt_borrowDate.Text = brw.BorrowDate.ToShortDateString();
                        txt_expireDate.Text = brw.ExpireDate.ToShortDateString();
                        txt_fine.Text = brw.getFineRate().ToString("F");
                        txt_remarks.Text = brw.Remarks;
                        txt_totalFine.Text = brw.TotBkFine.ToString("F");
                        int i = 0;

                        foreach (DataRow dr in brw.PendingBooks.Rows)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1[0, i].Value = dr[1].ToString();
                            dataGridView1[1, i].Value = dr[0].ToString();
                            dataGridView1[3, i].Value = dr[2].ToString();   //return date
                            dataGridView1[2, i].Value = dr[3].ToString();       //book condition
                            i++;
                        }
                    }
                    else
                    {
                        clear();
                        MessageBox.Show("Refference "+brw.Refferno.ToString()+" is Closed\n\n All Books has been returned", "Library CORE", MessageBoxButtons.OK);
                        txt_reffer.Clear();
                        txt_reffer.Focus();
                    }
                }
                else
                {
                    clear();
                    lbl_result.Text = "Refferece No " + txt_reffer.Text + " doesn't exist.";
                    txt_reffer.Focus();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DataGridViewComboBoxCell cmbCell;
                cmbCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                cmbCell.DisplayMember = "General Code";
                cmbCell.ValueMember = "General Code";
                cmbCell.DataSource = BKCONDITION;
            }
            if (e.ColumnIndex == 3)
            {
                if (dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Empty)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString().Trim() == "")
                    {
                        MessageBox.Show("Please Select the book condition.", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Are you sure you want to confirm returned date as today?\n\n" + "Today   " + DateTime.Today.ToShortDateString().ToString(), "Library CORE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            if (int.Parse((DateTime.Today - Convert.ToDateTime(txt_expireDate.Text)).TotalDays.ToString()) > 0)
                            {
                                dataGridView1.Rows[e.RowIndex].Cells[4].Value = (Convert.ToDecimal(txt_fine.Text.ToString()) * int.Parse((DateTime.Today - Convert.ToDateTime(txt_expireDate.Text)).TotalDays.ToString())).ToString();
                                txt_totalFine.Text = (decimal.Parse(txt_totalFine.Text) + decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString())).ToString("F");
                            }
                            else
                                dataGridView1.Rows[e.RowIndex].Cells[4].Value = 0.00;
                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(51, 255, 102);
                        }
                    }
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you want to reset the return details of the book ?", "Library CORE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {               
                        txt_totalFine.Text = (decimal.Parse(txt_totalFine.Text) - decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString())).ToString("F");
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = 0.00;
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
                    }
                }
                
            }
        }

        public void clear()
        {
            txt_nic.Clear();
            txt_borrowDate.Clear();
            txt_expireDate.Clear();
            txt_fine.Clear();
            txt_totalFine.Clear();
            txt_remarks.Clear();
            dataGridView1.Rows.Clear();
            lbl_result.Text = "";
        }
        public void clear1()
        {
            txt_reffer.Clear();
            txt_borrowDate.Clear();
            txt_expireDate.Clear();
            txt_fine.Clear();
            txt_totalFine.Clear();
            txt_remarks.Clear();
            dataGridView1.Rows.Clear();
            lbl_result.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                DataTable borrowedBooks = new DataTable();
                borrowedBooks.Columns.Add("Isbn", typeof(string));
                borrowedBooks.Columns.Add("bkCondition", typeof(string));
                borrowedBooks.Columns.Add("returnDate", typeof(DateTime));
                borrowedBooks.Columns.Add("bkFineAmt", typeof(decimal));
                foreach (DataGridViewRow dgvr in dataGridView1.Rows)
                {
                    if (dgvr.DefaultCellStyle.BackColor == Color.FromArgb(51, 255, 102))
                    {
                        DataRow dr = borrowedBooks.NewRow();
                        dr[0] = dgvr.Cells[1].Value.ToString();
                        dr[1] = dgvr.Cells[2].Value.ToString();
                        dr[2] = DateTime.Today;
                        dr[3] = Convert.ToDecimal(dgvr.Cells[4].Value);
                        borrowedBooks.Rows.Add(dr);
                    }
                }
                if (borrowedBooks.Rows.Count != 0)
                {
                    brw.FineRate = Convert.ToDecimal(txt_fine.Text);
                    brw.TotBkFine = Convert.ToDecimal(txt_totalFine.Text);
                    brw.Remarks = txt_remarks.Text;
                    brw.Refferno = int.Parse(txt_reffer.Text);
                    brw.BorrowedBooks = borrowedBooks;
                    int result = brw.updateBookReturn();
                    if (result != 0)
                    {
                        lbl_result.Text = result+ " Rows affected.";
                        MessageBox.Show("Book(s) return saved successfully.", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_reffer.Clear();
                        txt_nic.Clear();
                        txt_borrowDate.Clear();
                        txt_expireDate.Clear();
                        txt_fine.Clear();
                        txt_totalFine.Clear();
                        txt_remarks.Clear();
                        lbl_result.Text = "";
                        dataGridView1.Rows.Clear();
                    }

                }
            }
        }

        private void txt_nic_Validating(object sender, CancelEventArgs e)
        {
            if (txt_nic.Text != "")
            {
                Borrower brwer = new Borrower();
                brwer.setNic("");
                brw.Nic = "";
                brw.Refferno = 0;
                brwer.setNic(txt_nic.Text.Trim());
                if (brwer.isNicExist())
                {
                    //brw.Nic = txt_nic.Text.Trim();
                    if (brw.isPersonBorrowedByNic(txt_nic.Text.Trim()))
                    {
                        brw.Nic = txt_nic.Text.Trim();
                        if (brw.getRtnStatusOfReffNo("nic") == false)
                        {
                            brw.Refferno = brw.getReffByNic(txt_nic.Text.Trim());
                            clear();              
                            brw.viewPendingBook();
                            txt_reffer.Text = brw.Refferno.ToString();
                            txt_nic.Text = brw.Nic;
                            txt_borrowDate.Text = brw.BorrowDate.ToShortDateString();
                            txt_expireDate.Text = brw.ExpireDate.ToShortDateString();
                            txt_fine.Text = brw.getFineRate().ToString("F");
                            txt_remarks.Text = brw.Remarks;
                            txt_totalFine.Text = brw.TotBkFine.ToString("F");
                            int i = 0;

                            foreach (DataRow dr in brw.PendingBooks.Rows)
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1[0, i].Value = dr[1].ToString();
                                dataGridView1[1, i].Value = dr[0].ToString();
                                dataGridView1[3, i].Value = dr[2].ToString();   //return date
                                dataGridView1[2, i].Value = dr[3].ToString();       //book condition
                                i++;
                            }
                        }
                        else
                        {
                            txt_borrowDate.Clear();
                            txt_expireDate.Clear();
                            txt_fine.Clear();
                            txt_totalFine.Clear();
                            txt_remarks.Clear();
                            txt_reffer.Text = brw.Refferno.ToString();
                            MessageBox.Show("Refference " + brw.Refferno.ToString() + " is Closed\n\n All Books has been returned", "Library CORE", MessageBoxButtons.OK);
                            clear1();
                            txt_nic.Clear();
                        }
                    }
                    else
                    {
                        clear1();
                        MessageBox.Show("Borrower " + txt_nic.Text.ToString() + " has not barrowed any book yet.", "Library CORE", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txt_nic.Clear();
                    }
                }
                else
                {
                    clear1();
                    MessageBox.Show("Such a borrower does not exist..", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_nic.Clear();
                }
            }
        }




    }
}
