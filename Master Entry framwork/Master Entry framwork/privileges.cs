using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Master_Entry_framwork
{
    public partial class privileges : Form
    {
        private User usrobj;
        public privileges()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void privileges_Load(object sender, EventArgs e)
        {
            usrobj = new User();
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            lbl_result.Text = "";
            if (txt_username.Text != "" && usrobj.isExistUsername(txt_username.Text.Trim()))
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to pop up all the unassigned program?", "Library CORE", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    dataGridView1.Rows.Clear();
                    DataTable dtbl=usrobj.viewUAProgram(txt_username.Text.Trim());
                    int i=0;
                    foreach (DataRow dr in dtbl.Rows)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1["program_id", i].Value = dr["pId"].ToString();
                        dataGridView1["program_name", i].Value = dr["pName"].ToString();
                        i++;
                    }
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    DataTable dtbl = usrobj.viewAProgram(txt_username.Text.Trim());
                    int n = 0;
                    foreach (DataRow dr in dtbl.Rows)
                    {
                        dataGridView1.Rows.Add();                    
                        dataGridView1["program_id", n].Value = dr["pId"].ToString();
                        dataGridView1["program_name", n].Value = dr["pName"].ToString();
                        dataGridView1["entry", n].Value = dr["window"].ToString();
                        dataGridView1["add", n].Value = dr["new"].ToString();
                        dataGridView1["edit", n].Value = dr["edit"].ToString();
                        dataGridView1["delete", n].Value = dr["remove"].ToString();
                        dataGridView1["view", n].Value = dr["show"].ToString();
                        n++;
                    }
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int r = 0;
                //ArrayList checkedRowIndex = new ArrayList();
                //int gridRowCount = 0;
                //while (gridRowCount < dataGridView1.Rows.Count)
                //{
                //    string entry = (dataGridView1.Rows[gridRowCount].Cells[2].Value == null) ? "false" : dataGridView1.Rows[gridRowCount].Cells[2].Value.ToString();
                //    string add = (dataGridView1.Rows[gridRowCount].Cells[3].Value == null) ? "false" : dataGridView1.Rows[gridRowCount].Cells[3].Value.ToString();
                //    string edit = (dataGridView1.Rows[gridRowCount].Cells[4].Value == null) ? "false" : dataGridView1.Rows[gridRowCount].Cells[4].Value.ToString();
                //    string delete = (dataGridView1.Rows[gridRowCount].Cells[5].Value == null) ? "false" : dataGridView1.Rows[gridRowCount].Cells[5].Value.ToString();
                //    string view = (dataGridView1.Rows[gridRowCount].Cells[6].Value == null) ? "false" : dataGridView1.Rows[gridRowCount].Cells[6].Value.ToString();
                //    if (bool.Parse(entry) || bool.Parse(add) || bool.Parse(edit) || bool.Parse(delete) || bool.Parse(view))
                //    {
                //        checkedRowIndex.Add(gridRowCount);
                //    }
                //    gridRowCount++;
                //}
                DataGridViewRow[] dgwr = new DataGridViewRow[dataGridView1.Rows.Count];
                int i = 0;
                //for (int n = 0; n < indexArry.Length;n++ )
                //{
                //    dgwr[i] = dataGridView1.Rows[indexArry[n]];
                //    i++;
                //}
                foreach (DataGridViewRow raw in dataGridView1.Rows)
                {
                    dgwr[i] = raw;
                    i++;
                }
                try
                {
                    r = usrobj.updatePrivileges(dgwr, txt_username.Text);
                    if (r != 0)
                    {
                        lbl_result.Text = r.ToString() + " rows affected";
                    }
                    dataGridView1.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}
