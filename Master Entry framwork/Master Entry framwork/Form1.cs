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
    public partial class Form1 : Form
    {
        protected byte i = 0;
        protected byte r = 0;

        public void pushMode(PictureBox p)
        {
            foreach (PictureBox pbx in pnl_header.Controls.OfType<PictureBox>())
            {
                if (pbx.BackColor != Color.Gainsboro)
                    pbx.BackColor = Color.Gainsboro;
            }
            foreach (PictureBox pbx in pnl_header.Controls.OfType<PictureBox>())
            {
                if (pbx.Name == p.Name)
                {
                    p.BackColor = Color.DarkGray;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            disposeitem();
            this.Dispose();      
        }

        protected virtual void disposeitem() { }

        private void pbx_add_Click(object sender, EventArgs e)
        {
            pushMode(pbx_add);
            i = 1;
            Onadd();
        }

        protected virtual void Onadd() { MessageBox.Show("Base Onadd"); }

        private void pbx_edit_Click(object sender, EventArgs e)
        {
            pushMode(pbx_edit);
            i = 2;
            Onedit();
        }

        protected virtual void Onedit() { MessageBox.Show("Base Onedit"); }

        private void pbx_delete_Click(object sender, EventArgs e)
        {
            pushMode(pbx_delete);
            i = 3;
            Ondelete();
        }

        protected virtual void Ondelete() { MessageBox.Show("Base Ondelete"); }

        private void pbx_view_Click(object sender, EventArgs e)
        {
            pushMode(pbx_view);
            i = 4;
            Onview();
        }

        protected virtual void Onview() { MessageBox.Show("Base Onview"); }

    }
}
