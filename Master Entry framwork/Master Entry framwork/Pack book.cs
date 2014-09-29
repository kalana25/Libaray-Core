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
    public partial class Pack_book : Form
    {
        private string username;
        Database db;
        DataTable dtblBook;
        RackAlloc obj;
        public Pack_book(string un)
        {
            InitializeComponent();
            this.username = un.Trim();

            this.username = "Kalana";

            db = new Database();
            dtblBook = db.executeReader("select Isbn,bName from Books  where packed='false' and avalable='true'", CommandType.Text, null);
        }

        private void Pack_book_Load(object sender, EventArgs e)
        {
            cmb_rack.SelectedIndexChanged -= cmb_rack_SelectedIndexChanged;
            db.loadComboWithAutoCmplt(cmb_rack, db.executeReader("select rName from mstRackName", CommandType.Text, null), "rName", "");
            cmb_rack.SelectedIndexChanged += cmb_rack_SelectedIndexChanged;

            cmb_book.SelectedIndexChanged -= cmb_book_SelectedIndexChanged;
            db.loadComboWithAutoCmplt(cmb_book,dtblBook, "bName", "Isbn");
            cmb_book.SelectedIndexChanged += cmb_book_SelectedIndexChanged;

            cmb_book_search.SelectedIndexChanged -= cmb_book_search_SelectedIndexChanged;
            db.loadComboWithAutoCmplt(cmb_book_search, db.executeReader("select Isbn,bName from Books where packed='true' and avalable='true'", CommandType.Text, null), "bName", "Isbn");
            cmb_book_search.SelectedIndexChanged += cmb_book_search_SelectedIndexChanged;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_addbooktorack_Click(object sender, EventArgs e)
        {
            erp_book.Dispose();
            erp_rack.Dispose();
            erp_section.Dispose();
            try
            {

                if (btn_save.Enabled == false)
                { btn_save.Enabled = true; }
                if (dataGridView1.Columns[5].Visible == true)
                { dataGridView1.Columns[5].Visible = false; }
                if (dataGridView1.Columns[4].Visible == false)
                { dataGridView1.Columns[4].Visible = true; }
                if (cmb_book.Text != "" && cmb_rack.Text != "" && cmb_section.Text != "")
                {
                    dataGridView1.Rows.Add();
                    if (dataGridView1.Rows.Count != 0)
                    {

                        int current = int.Parse(dataGridView1.Rows.Count.ToString()) - 1;
                        dataGridView1.Rows[current].Cells[0].Value = cmb_rack.Text.Trim();
                        dataGridView1.Rows[current].Cells[1].Value = cmb_section.Text.Trim();
                        dataGridView1.Rows[current].Cells[2].Value = cmb_book.Text.Trim();
                        dataGridView1.Rows[current].Cells[3].Value = cmb_book.SelectedValue;
                        dtblBook.Rows.RemoveAt(cmb_book.SelectedIndex);
                        cmb_book.Refresh();
                    }
                }
                else
                {
                    if (cmb_section.Text.Trim() == "") givesectionError();
                    if (cmb_rack.Text.Trim() == "") giverackError();
                    if (cmb_book.Text.Trim() == "") giveBookError();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "X")
                    {
                        DataRow obj = dtblBook.NewRow();
                        obj["bName"] = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        obj["Isbn"] = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        dtblBook.Rows.Add(obj);
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete Shelf infor")
                    {
                        if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove permanantly book shelf information from database ?", "Library CORE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            obj = new RackAlloc();
                            lbl_result.Text = "";
                            lbl_result.Text = obj.deleteRackAllocation(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim()) + " row(s) affected.";
                            dataGridView1.Rows.RemoveAt(e.RowIndex);

                            cmb_book_search.SelectedIndexChanged -= cmb_book_search_SelectedIndexChanged;
                            db.loadComboWithAutoCmplt(cmb_book_search, db.executeReader("select Isbn,bName from Books where packed='true' and avalable='true'", CommandType.Text, null), "bName", "Isbn");
                            cmb_book_search.SelectedIndexChanged += cmb_book_search_SelectedIndexChanged;

                            dtblBook = db.executeReader("select Isbn,bName from Books  where packed='false' and avalable='true'", CommandType.Text, null);
                            cmb_book.SelectedIndexChanged -= cmb_book_SelectedIndexChanged;
                            db.loadComboWithAutoCmplt(cmb_book, dtblBook, "bName", "Isbn");
                            cmb_book.SelectedIndexChanged += cmb_book_SelectedIndexChanged;
                        }
                    }

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void cmb_rack_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlParameter[]paralist={db.addParameter("@rName",cmb_rack.Text.Trim())};
            db.loadComboWithAutoCmplt(cmb_section, db.executeReader("selectSectionNames", CommandType.StoredProcedure, paralist), "secName", "secId");
        }

        private void cmb_book_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {dataGridView1.Rows.Clear();}
                if (dataGridView1.Columns[5].Visible == false)
                { dataGridView1.Columns[5].Visible = true; }
                if (dataGridView1.Columns[4].Visible == true)
                { dataGridView1.Columns[4].Visible = false; }
                if (btn_save.Enabled == true)
                { btn_save.Enabled = false; }
                obj = new RackAlloc();
                DataTable viwtbl = obj.viewRackAllocation(cmb_book_search.SelectedValue.ToString());
                if (viwtbl.Rows.Count == 1)
                {
                    DataRow dr = viwtbl.Rows[0];
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = dr[0].ToString();
                    dataGridView1.Rows[0].Cells[1].Value = dr[1].ToString();
                    dataGridView1.Rows[0].Cells[2].Value = dr[2].ToString();
                    dataGridView1.Rows[0].Cells[3].Value = dr[3].ToString();
                }
                else
                {
                    MessageBox.Show("There are two records for the same book.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}
            
        }

        public void giveBookError()
        {
            erp_book.SetError(cmb_book, "Book can not be empty.");
            erp_book.SetIconPadding(cmb_book, 5);
            erp_book.BlinkRate = 200;
            cmb_book.Focus();
        }

        public void giverackError()
        {
            erp_rack.SetError(cmb_rack, "Rack can not be empty.");
            erp_rack.SetIconPadding(cmb_rack, 5);
            erp_rack.BlinkRate = 200;
            cmb_rack.Focus();
        }

        public void givesectionError()
        {
            erp_section.SetError(cmb_section, "Section can not be empty.");
            erp_section.SetIconPadding(cmb_section, 5);
            erp_section.BlinkRate = 200;
            cmb_section.Focus();
        }

        private void cmb_book_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("Rack", typeof(string)));
                dt.Columns.Add(new DataColumn("Section", typeof(string)));
                dt.Columns.Add(new DataColumn("BookName", typeof(string)));
                dt.Columns.Add(new DataColumn("Isbn", typeof(string)));
                dt.Columns.Add(new DataColumn("UserName", typeof(string)));
                foreach(DataGridViewRow dgvrw in dataGridView1.Rows)
                {
                    DataRow newrow=dt.NewRow();
                    newrow["Rack"]=dgvrw.Cells[0].Value.ToString().Trim();
                    newrow["Section"]=dgvrw.Cells[1].Value.ToString().Trim();
                    newrow["BookName"]=dgvrw.Cells[2].Value.ToString().Trim();
                    newrow["Isbn"]=dgvrw.Cells[3].Value.ToString().Trim();
                    dt.Rows.Add(newrow);
                }
                obj = new RackAlloc();
                try
                {
                    lbl_result.Text = obj.insertRackAllocation(dt,username).ToString() + " row(s) affected.";
                    dataGridView1.Rows.Clear();
                    cmb_rack.SelectedIndex = 0;
                    cmb_section.SelectedIndex = 0;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }

    }
}
