using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public partial class MainNew : Form
    {
        private string username;
        public MainNew()
        {
            InitializeComponent();
            this.username = "Kalana Sachith";
        }

        private void mnuItm_general_code_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GENCODE")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                gencode_master obj = new gencode_master();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_user_priviladges_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "USER PRIVILEGES")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                privileges obj = new privileges();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_user_master_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "USER MASTER")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                user_master obj = new user_master();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_book_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BOOK")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                book_master obj = new book_master();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_category_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "CATEGORY")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                Category_master obj = new Category_master();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_author_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AUTHORS")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                author_master obj = new author_master();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_publisher_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "PUBLISHER")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                Publisher_master obj = new Publisher_master();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_language_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "LANGUAGE")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                language_master obj = new language_master();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_borrowing_book_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BORROW BOOKS")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                barrow_transaction obj = new barrow_transaction();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_returning_book_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "RETURN BOOKS")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                return_transaction obj = new return_transaction();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_borrower_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BORROWER")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                borrower_master obj = new borrower_master();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_rack_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "RACK")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                rack_master obj = new rack_master();
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void mnuItm_pack_book_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Pack Book")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                Pack_book obj = new Pack_book(this.username);
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void tv_report_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = tv_report.SelectedNode;
            if (node.Text == "All Books")
            {
                Reports.Report_form obj = new Reports.Report_form(new Reports.all_book());
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
            else if (node.Text == "All Books with Image")
            {
                Reports.Report_form obj = new Reports.Report_form(new Reports.books_with_images());
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
            else if (node.Text == "Book Category Wise")
            {
                Reports.Report_form obj = new Reports.Report_form(new Reports.cat_wise_book());
                obj.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                obj.Location = new Point((panel1.Width / 2) - (obj.Width / 2), (panel1.Height / 2) - (obj.Height / 2));
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }
    }
}
