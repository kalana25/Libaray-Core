namespace Master_Entry_framwork
{
    partial class Category_master
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_catno = new System.Windows.Forms.TextBox();
            this.cmb_catname = new System.Windows.Forms.ComboBox();
            this.erp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(168, 5);
            this.label1.Size = new System.Drawing.Size(238, 43);
            this.label1.Text = "Category Master";
            // 
            // pnl_footer
            // 
            this.pnl_footer.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category No";
            // 
            // txt_catno
            // 
            this.txt_catno.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_catno.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_catno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_catno.Location = new System.Drawing.Point(223, 162);
            this.txt_catno.Name = "txt_catno";
            this.txt_catno.Size = new System.Drawing.Size(256, 24);
            this.txt_catno.TabIndex = 0;
            this.txt_catno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_catname
            // 
            this.cmb_catname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_catname.FormattingEnabled = true;
            this.cmb_catname.Location = new System.Drawing.Point(223, 206);
            this.cmb_catname.Name = "cmb_catname";
            this.cmb_catname.Size = new System.Drawing.Size(256, 26);
            this.cmb_catname.TabIndex = 1;
            this.cmb_catname.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_catname_Validating);
            // 
            // erp1
            // 
            this.erp1.ContainerControl = this;
            // 
            // Category_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(575, 393);
            this.Controls.Add(this.cmb_catname);
            this.Controls.Add(this.txt_catno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Category_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORY";
            this.Load += new System.EventHandler(this.Category_master_Load);
            this.Controls.SetChildIndex(this.pnl_header, 0);
            this.Controls.SetChildIndex(this.pnl_footer, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_catno, 0);
            this.Controls.SetChildIndex(this.cmb_catname, 0);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_catno;
        private System.Windows.Forms.ComboBox cmb_catname;
        private System.Windows.Forms.ErrorProvider erp1;
    }
}
