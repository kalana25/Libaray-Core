using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public partial class rack_master : Master_Entry_framwork.Form1
    {
        Database db;
        Rack rack;
        Dictionary<int, string> sections;
        public rack_master()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    erp1.Dispose();
                    if (cmb_rackname.Text != "")
                    {
                        try
                        {
                            rack.RackID = int.Parse(txt_rackid.Text.ToString().Trim());
                            rack.RackName = cmb_rackname.Text.Trim();
                            rack.Sections = sections;
                            int r = rack.insertRack();
                            if (r != -9)
                            {
                                lbl_result.Text = r.ToString() + " Row(s) affected";
                                cmb_rackname.Text = "";
                                dataGridView1.Rows.Clear();
                                txt_rackid.Text = rack.getnextNo().ToString();
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
                    erp1.Dispose();
                    if (cmb_rackname.Text != "")
                    {
                        try
                        {
                            rack.RackID = int.Parse(txt_rackid.Text);
                            rack.RackName = cmb_rackname.Text.Trim();
                            rack.Sections = sections;
                            int r = rack.editRack();
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Row(s) affected";
                                cmb_rackname.Text = "";
                                dataGridView1.Rows.Clear();
                                txt_rackid.Clear();
                            }
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        giveError();
                    }
                    break;
                case 3:
                    erp1.Dispose();
                    if (cmb_rackname.Text != "")
                    {
                        try
                        {
                            int r = rack.deleteRack();
                            if (r != 0)
                            {
                                lbl_result.Text = r.ToString() + " Row(s) affected";
                                cmb_rackname.Text = "";
                                dataGridView1.Rows.Clear();
                                txt_rackid.Clear();
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
                case 4:

                    break;
                default:
                    MessageBox.Show("Select a mode..");
                    break;
            }
            configcomboBox();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        protected override void Onadd()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;    
            txt_rackid.Text = rack.getnextNo().ToString();
            cmb_rackname.DropDownStyle = ComboBoxStyle.Simple;
            dataGridView1.Rows.Clear();
            configcomboBox();
            dataGridView1.ReadOnly = false;

            sections.Clear();
        }

        protected override void Onedit()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            txt_rackid.Clear();
            cmb_rackname.DropDownStyle = ComboBoxStyle.DropDown;
            dataGridView1.Rows.Clear();
            configcomboBox();
            dataGridView1.ReadOnly = false;

            sections.Clear();
        }

        protected override void Ondelete()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            txt_rackid.Clear();
            cmb_rackname.DropDownStyle = ComboBoxStyle.DropDown;
            dataGridView1.Rows.Clear();
            configcomboBox();
            dataGridView1.ReadOnly = true;

            sections.Clear();
        }

        protected override void Onview()
        {
            erp1.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = false;
            txt_rackid.Clear();
            cmb_rackname.DropDownStyle = ComboBoxStyle.Simple;
            dataGridView1.Rows.Clear();
            configcomboBox();
            dataGridView1.ReadOnly = true;

            sections.Clear();
        }

        public void giveError()
        {
            erp1.SetError(cmb_rackname, "Rack Name can not be empty.");
            erp1.SetIconPadding(cmb_rackname, 7);
            erp1.BlinkRate = 200;
            cmb_rackname.Focus();
        }

        private void rack_master_Load(object sender, EventArgs e)
        {
            db = new Database();
            rack = new Rack();
            sections = new Dictionary<int, string>();
            //Button del = (Button)dataGridView1.Columns[2].
        }

        public void configcomboBox()
        {
            db.loadComboBox(cmb_rackname, rack.selectRackName("selectRackNames"), "rName", "");
            cmb_rackname.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_rackname.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_rackname.SelectedIndex = -1;
        }

        private void dataGridView1_Validated(object sender, EventArgs e)
        {
            if (i == 1 || i==2)
            {
                erp1.Dispose();
                if (cmb_rackname.Text.Trim() != "")
                {
                    sections.Clear();
                    for (int count = 0; count < int.Parse(dataGridView1.Rows.Count.ToString()) - 1; count++)
                    {
                        sections.Add(int.Parse(dataGridView1.Rows[count].Cells[0].Value.ToString()), dataGridView1.Rows[count].Cells[1].Value.ToString());
                    }
                }
                else
                {
                    giveError();
                    dataGridView1.Rows.Clear();
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (i == 1 || i==2)
            {
                if (cmb_rackname.Text.Trim() != "")
                {
                    int currentRowIndex = -9;
                    try
                    {
                        currentRowIndex = dataGridView1.CurrentRow.Index;
                    }
                    catch
                    {
                        currentRowIndex = 0;
                    }
                    if (currentRowIndex == 0)
                    {
                        try
                        {
                            dataGridView1.CurrentRow.Cells[0].Value = rack.getNextSecNo(int.Parse(txt_rackid.Text));
                        }
                        catch
                        {
                            if (txt_rackid.Text != "")
                            {
                                dataGridView1.Rows[0].Cells[0].Value = rack.getNextSecNo(int.Parse(txt_rackid.Text));
                            }
                        }
                    }
                    else
                    {
                            dataGridView1.CurrentRow.Cells[0].Value = int.Parse(dataGridView1.Rows[currentRowIndex - 1].Cells[0].Value.ToString()) + 1;
                    }
                }
            }
        }

        private void cmb_rackname_Validating(object sender, CancelEventArgs e)
        {
            lbl_result.Text = "";
            txt_rackid.Clear();
            dataGridView1.Rows.Clear();
            if (i == 3||i==2||i==4)
            {
                rack.RackName = cmb_rackname.Text.Trim();
                if (rack.isRackNameExist())
                {
                    rack.viewRackInfor();
                    txt_rackid.Text = rack.RackID.ToString();

                    int index = 0;
                    dataGridView1.RowsAdded -= dataGridView1_RowsAdded;

                    foreach (KeyValuePair<int, string> entry in rack.Sections)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = entry.Key;
                        dataGridView1.Rows[index].Cells[1].Value = entry.Value;
                        index++;        
                    }
                    dataGridView1.RowsAdded +=dataGridView1_RowsAdded;
                }
                else
                {
                    //code for if Rack Name doesn't exist.
                    lbl_result.Text = "Rack Name doesn't exist.";
                    cmb_rackname.Focus();
                }
            }
            else if (i == 1)
            {
                rack.RackName = cmb_rackname.Text.Trim();
                if (rack.isRackNameExist())
                {
                    lbl_result.Text = "Rack Name already exist.";
                    cmb_rackname.Focus();
                }
                else
                { txt_rackid.Text = rack.getnextNo().ToString(); }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "X")
                {
                    if (i == 1 || i == 2)
                    {
                        if (e.ColumnIndex == 2)
                        {
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                            sections.Remove(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        }
                    }
                }
            }
            catch (NullReferenceException)
            { }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }





    }
}
