namespace Master_Entry_framwork
{
    partial class book_master
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.cmb_edition = new System.Windows.Forms.ComboBox();
            this.txt_pic = new System.Windows.Forms.TextBox();
            this.cmb_language = new System.Windows.Forms.ComboBox();
            this.cmb_author = new System.Windows.Forms.ComboBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.dtp_pubdate = new System.Windows.Forms.DateTimePicker();
            this.btn_browse = new System.Windows.Forms.Button();
            this.clb_category = new System.Windows.Forms.CheckedListBox();
            this.pbx_photo = new System.Windows.Forms.PictureBox();
            this.erp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmb_bname = new System.Windows.Forms.ComboBox();
            this.clb_publisher = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.erp5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Size = new System.Drawing.Size(1214, 102);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(514, 5);
            this.label1.Size = new System.Drawing.Size(186, 43);
            this.label1.Text = "Book Master";
            // 
            // pnl_footer
            // 
            this.pnl_footer.Location = new System.Drawing.Point(0, 563);
            this.pnl_footer.Size = new System.Drawing.Size(1214, 51);
            this.pnl_footer.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1099, 11);
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(994, 11);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Edition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Picture";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Language";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Publisher";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Published Date";
            // 
            // txt_isbn
            // 
            this.txt_isbn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_isbn.Location = new System.Drawing.Point(158, 122);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(319, 29);
            this.txt_isbn.TabIndex = 0;
            this.txt_isbn.TextChanged += new System.EventHandler(this.txt_isbn_TextChanged);
            this.txt_isbn.Validating += new System.ComponentModel.CancelEventHandler(this.txt_isbn_Validating);
            // 
            // cmb_edition
            // 
            this.cmb_edition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_edition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_edition.FormattingEnabled = true;
            this.cmb_edition.Location = new System.Drawing.Point(158, 224);
            this.cmb_edition.Name = "cmb_edition";
            this.cmb_edition.Size = new System.Drawing.Size(319, 29);
            this.cmb_edition.TabIndex = 4;
            // 
            // txt_pic
            // 
            this.txt_pic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pic.Location = new System.Drawing.Point(158, 190);
            this.txt_pic.Name = "txt_pic";
            this.txt_pic.Size = new System.Drawing.Size(280, 29);
            this.txt_pic.TabIndex = 3;
            // 
            // cmb_language
            // 
            this.cmb_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_language.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_language.FormattingEnabled = true;
            this.cmb_language.Location = new System.Drawing.Point(158, 258);
            this.cmb_language.Name = "cmb_language";
            this.cmb_language.Size = new System.Drawing.Size(319, 29);
            this.cmb_language.TabIndex = 5;
            // 
            // cmb_author
            // 
            this.cmb_author.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_author.FormattingEnabled = true;
            this.cmb_author.Location = new System.Drawing.Point(158, 292);
            this.cmb_author.Name = "cmb_author";
            this.cmb_author.Size = new System.Drawing.Size(319, 29);
            this.cmb_author.TabIndex = 6;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(158, 479);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(319, 29);
            this.txt_price.TabIndex = 8;
            // 
            // dtp_pubdate
            // 
            this.dtp_pubdate.CustomFormat = "MMMM/dd/yyyy";
            this.dtp_pubdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_pubdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_pubdate.Location = new System.Drawing.Point(158, 513);
            this.dtp_pubdate.Name = "dtp_pubdate";
            this.dtp_pubdate.Size = new System.Drawing.Size(319, 29);
            this.dtp_pubdate.TabIndex = 9;
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Image = global::Master_Entry_framwork.Properties.Resources.open;
            this.btn_browse.Location = new System.Drawing.Point(444, 189);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(33, 28);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // clb_category
            // 
            this.clb_category.BackColor = System.Drawing.Color.Gainsboro;
            this.clb_category.CheckOnClick = true;
            this.clb_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_category.FormattingEnabled = true;
            this.clb_category.Location = new System.Drawing.Point(514, 158);
            this.clb_category.MultiColumn = true;
            this.clb_category.Name = "clb_category";
            this.clb_category.Size = new System.Drawing.Size(319, 364);
            this.clb_category.TabIndex = 7;
            // 
            // pbx_photo
            // 
            this.pbx_photo.BackColor = System.Drawing.Color.Gainsboro;
            this.pbx_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_photo.Image = global::Master_Entry_framwork.Properties.Resources.red_leather_book_cover;
            this.pbx_photo.ImageLocation = "";
            this.pbx_photo.InitialImage = global::Master_Entry_framwork.Properties.Resources.red_leather_book_cover;
            this.pbx_photo.Location = new System.Drawing.Point(870, 110);
            this.pbx_photo.Name = "pbx_photo";
            this.pbx_photo.Size = new System.Drawing.Size(335, 445);
            this.pbx_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_photo.TabIndex = 22;
            this.pbx_photo.TabStop = false;
            // 
            // erp1
            // 
            this.erp1.ContainerControl = this;
            // 
            // erp2
            // 
            this.erp2.ContainerControl = this;
            // 
            // erp3
            // 
            this.erp3.ContainerControl = this;
            // 
            // erp4
            // 
            this.erp4.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmb_bname
            // 
            this.cmb_bname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmb_bname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bname.FormattingEnabled = true;
            this.cmb_bname.Location = new System.Drawing.Point(158, 156);
            this.cmb_bname.Name = "cmb_bname";
            this.cmb_bname.Size = new System.Drawing.Size(319, 26);
            this.cmb_bname.TabIndex = 1;
            this.cmb_bname.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_bname_Validating);
            // 
            // clb_publisher
            // 
            this.clb_publisher.BackColor = System.Drawing.Color.Gainsboro;
            this.clb_publisher.CheckOnClick = true;
            this.clb_publisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_publisher.FormattingEnabled = true;
            this.clb_publisher.Location = new System.Drawing.Point(158, 330);
            this.clb_publisher.Name = "clb_publisher";
            this.clb_publisher.Size = new System.Drawing.Size(319, 124);
            this.clb_publisher.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(123, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 24;
            this.label11.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(514, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 32);
            this.panel1.TabIndex = 25;
            // 
            // erp5
            // 
            this.erp5.ContainerControl = this;
            // 
            // book_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1214, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clb_publisher);
            this.Controls.Add(this.cmb_bname);
            this.Controls.Add(this.pbx_photo);
            this.Controls.Add(this.clb_category);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.dtp_pubdate);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.cmb_author);
            this.Controls.Add(this.cmb_language);
            this.Controls.Add(this.txt_pic);
            this.Controls.Add(this.cmb_edition);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "book_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOOK";
            this.Load += new System.EventHandler(this.book_master_Load);
            this.Controls.SetChildIndex(this.pnl_header, 0);
            this.Controls.SetChildIndex(this.pnl_footer, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txt_isbn, 0);
            this.Controls.SetChildIndex(this.cmb_edition, 0);
            this.Controls.SetChildIndex(this.txt_pic, 0);
            this.Controls.SetChildIndex(this.cmb_language, 0);
            this.Controls.SetChildIndex(this.cmb_author, 0);
            this.Controls.SetChildIndex(this.txt_price, 0);
            this.Controls.SetChildIndex(this.dtp_pubdate, 0);
            this.Controls.SetChildIndex(this.btn_browse, 0);
            this.Controls.SetChildIndex(this.clb_category, 0);
            this.Controls.SetChildIndex(this.pbx_photo, 0);
            this.Controls.SetChildIndex(this.cmb_bname, 0);
            this.Controls.SetChildIndex(this.clb_publisher, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.ComboBox cmb_edition;
        private System.Windows.Forms.TextBox txt_pic;
        private System.Windows.Forms.ComboBox cmb_language;
        private System.Windows.Forms.ComboBox cmb_author;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.DateTimePicker dtp_pubdate;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.CheckedListBox clb_category;
        private System.Windows.Forms.PictureBox pbx_photo;
        private System.Windows.Forms.ErrorProvider erp1;
        private System.Windows.Forms.ErrorProvider erp2;
        private System.Windows.Forms.ErrorProvider erp3;
        private System.Windows.Forms.ErrorProvider erp4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmb_bname;
        private System.Windows.Forms.CheckedListBox clb_publisher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider erp5;
    }
}
