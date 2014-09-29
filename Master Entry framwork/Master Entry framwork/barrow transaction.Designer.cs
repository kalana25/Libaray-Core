namespace Master_Entry_framwork
{
    partial class barrow_transaction
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_nic = new System.Windows.Forms.ComboBox();
            this.dtpkr_borrowDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_isbn = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.erp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpkr_expireDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_refer = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.tabControl1);
            this.pnl_header.Size = new System.Drawing.Size(1107, 102);
            this.pnl_header.Controls.SetChildIndex(this.tabControl1, 0);
            this.pnl_header.Controls.SetChildIndex(this.label1, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(451, 5);
            this.label1.Size = new System.Drawing.Size(205, 43);
            this.label1.Text = "Borrow Books";
            // 
            // pnl_footer
            // 
            this.pnl_footer.Location = new System.Drawing.Point(0, 498);
            this.pnl_footer.Size = new System.Drawing.Size(1107, 51);
            this.pnl_footer.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(963, 11);
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(857, 11);
            this.btn_exit.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reference";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(79, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "NIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Borrow date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Expire date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Books";
            // 
            // cmb_nic
            // 
            this.cmb_nic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nic.FormattingEnabled = true;
            this.cmb_nic.Location = new System.Drawing.Point(122, 191);
            this.cmb_nic.MaxLength = 10;
            this.cmb_nic.Name = "cmb_nic";
            this.cmb_nic.Size = new System.Drawing.Size(257, 29);
            this.cmb_nic.TabIndex = 2;
            // 
            // dtpkr_borrowDate
            // 
            this.dtpkr_borrowDate.CustomFormat = "MMMM/dd/yyyy";
            this.dtpkr_borrowDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_borrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkr_borrowDate.Location = new System.Drawing.Point(122, 235);
            this.dtpkr_borrowDate.Name = "dtpkr_borrowDate";
            this.dtpkr_borrowDate.Size = new System.Drawing.Size(257, 29);
            this.dtpkr_borrowDate.TabIndex = 3;
            this.dtpkr_borrowDate.ValueChanged += new System.EventHandler(this.dtpkr_borrowDate_ValueChanged);
            // 
            // cmb_isbn
            // 
            this.cmb_isbn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_isbn.FormattingEnabled = true;
            this.cmb_isbn.Location = new System.Drawing.Point(473, 147);
            this.cmb_isbn.Name = "cmb_isbn";
            this.cmb_isbn.Size = new System.Drawing.Size(496, 29);
            this.cmb_isbn.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(975, 147);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 26);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.isbn,
            this.name});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(399, 191);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(673, 250);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            // 
            // isbn
            // 
            this.isbn.Text = "ISBN";
            this.isbn.Width = 292;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 377;
            // 
            // erp1
            // 
            this.erp1.ContainerControl = this;
            // 
            // erp2
            // 
            this.erp2.ContainerControl = this;
            // 
            // dtpkr_expireDate
            // 
            this.dtpkr_expireDate.CustomFormat = "MMMM/dd/yyyy";
            this.dtpkr_expireDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_expireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkr_expireDate.Location = new System.Drawing.Point(122, 280);
            this.dtpkr_expireDate.Name = "dtpkr_expireDate";
            this.dtpkr_expireDate.Size = new System.Drawing.Size(257, 29);
            this.dtpkr_expireDate.TabIndex = 0;
            // 
            // cmb_refer
            // 
            this.cmb_refer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmb_refer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmb_refer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmb_refer.FormattingEnabled = true;
            this.cmb_refer.Location = new System.Drawing.Point(122, 147);
            this.cmb_refer.Name = "cmb_refer";
            this.cmb_refer.Size = new System.Drawing.Size(257, 29);
            this.cmb_refer.TabIndex = 1;
            this.cmb_refer.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_refer_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Master_Entry_framwork.Properties.Resources.borrow;
            this.pictureBox1.Location = new System.Drawing.Point(39, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 145);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // barrow_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1107, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_refer);
            this.Controls.Add(this.dtpkr_expireDate);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_isbn);
            this.Controls.Add(this.dtpkr_borrowDate);
            this.Controls.Add(this.cmb_nic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Name = "barrow_transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BORROW BOOKS";
            this.Load += new System.EventHandler(this.barrow_transaction_Load);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.pnl_header, 0);
            this.Controls.SetChildIndex(this.pnl_footer, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cmb_nic, 0);
            this.Controls.SetChildIndex(this.dtpkr_borrowDate, 0);
            this.Controls.SetChildIndex(this.cmb_isbn, 0);
            this.Controls.SetChildIndex(this.btn_add, 0);
            this.Controls.SetChildIndex(this.dtpkr_expireDate, 0);
            this.Controls.SetChildIndex(this.cmb_refer, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_nic;
        private System.Windows.Forms.DateTimePicker dtpkr_borrowDate;
        private System.Windows.Forms.ComboBox cmb_isbn;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader isbn;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ErrorProvider erp1;
        private System.Windows.Forms.ErrorProvider erp2;
        private System.Windows.Forms.DateTimePicker dtpkr_expireDate;
        private System.Windows.Forms.ComboBox cmb_refer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
