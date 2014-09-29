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
    public partial class Main : Form
    {
        private string username;

        public Main()
        {
            InitializeComponent();
            username = "Kalana Sachith";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void userPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void userMasterToolStripMenuItem_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void borrowerToolStripMenuItem1_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void borrowingBookToolStripMenuItem_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void returningBooksToolStripMenuItem_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void rackToolStripMenuItem1_Click(object sender, EventArgs e)
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
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void putBooksToolStripMenuItem_Click(object sender, EventArgs e)
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
                Pack_book obj = new Pack_book(username);
                IsMdiContainer = true;
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

    }
}
