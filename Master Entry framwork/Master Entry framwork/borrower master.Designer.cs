namespace Master_Entry_framwork
{
    partial class borrower_master
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
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.erp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_blackList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_houseNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_streetNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_estate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(215, 5);
            this.label1.Size = new System.Drawing.Size(144, 43);
            this.label1.Text = "Borrower";
            // 
            // pnl_footer
            // 
            this.pnl_footer.Location = new System.Drawing.Point(0, 486);
            this.pnl_footer.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.TabIndex = 2;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F);
            this.label2.Location = new System.Drawing.Point(107, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.Location = new System.Drawing.Point(94, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F);
            this.label4.Location = new System.Drawing.Point(92, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F);
            this.label5.Location = new System.Drawing.Point(96, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // cmb_name
            // 
            this.cmb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmb_name.Font = new System.Drawing.Font("Georgia", 12F);
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(163, 163);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(319, 26);
            this.cmb_name.TabIndex = 2;
            this.cmb_name.SelectedIndexChanged += new System.EventHandler(this.cmb_name_SelectedIndexChanged);
            this.cmb_name.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_name_Validating);
            // 
            // txt_nic
            // 
            this.txt_nic.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_nic.Location = new System.Drawing.Point(163, 129);
            this.txt_nic.MaxLength = 10;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(319, 26);
            this.txt_nic.TabIndex = 1;
            this.txt_nic.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nic_Validating);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_phone.Location = new System.Drawing.Point(163, 197);
            this.txt_phone.MaxLength = 10;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(319, 26);
            this.txt_phone.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_email.Location = new System.Drawing.Point(163, 231);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(319, 26);
            this.txt_email.TabIndex = 4;
            // 
            // erp1
            // 
            this.erp1.ContainerControl = this;
            // 
            // erp2
            // 
            this.erp2.ContainerControl = this;
            // 
            // btn_blackList
            // 
            this.btn_blackList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_blackList.Location = new System.Drawing.Point(13, 449);
            this.btn_blackList.Name = "btn_blackList";
            this.btn_blackList.Size = new System.Drawing.Size(75, 25);
            this.btn_blackList.TabIndex = 9;
            this.btn_blackList.Text = "Black List";
            this.btn_blackList.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F);
            this.label6.Location = new System.Drawing.Point(68, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "House No";
            // 
            // txt_houseNo
            // 
            this.txt_houseNo.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_houseNo.Location = new System.Drawing.Point(163, 290);
            this.txt_houseNo.Name = "txt_houseNo";
            this.txt_houseNo.Size = new System.Drawing.Size(319, 26);
            this.txt_houseNo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F);
            this.label7.Location = new System.Drawing.Point(68, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Street No";
            // 
            // txt_streetNo
            // 
            this.txt_streetNo.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_streetNo.Location = new System.Drawing.Point(163, 323);
            this.txt_streetNo.Name = "txt_streetNo";
            this.txt_streetNo.Size = new System.Drawing.Size(319, 26);
            this.txt_streetNo.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F);
            this.label8.Location = new System.Drawing.Point(107, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F);
            this.label9.Location = new System.Drawing.Point(91, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Estate";
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_city.Location = new System.Drawing.Point(163, 356);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(319, 26);
            this.txt_city.TabIndex = 7;
            // 
            // txt_estate
            // 
            this.txt_estate.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_estate.Location = new System.Drawing.Point(163, 389);
            this.txt_estate.Name = "txt_estate";
            this.txt_estate.Size = new System.Drawing.Size(319, 26);
            this.txt_estate.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F);
            this.groupBox1.Location = new System.Drawing.Point(45, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // borrower_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(575, 538);
            this.Controls.Add(this.txt_estate);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_streetNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_houseNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_blackList);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.cmb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "borrower_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BORROWER";
            this.Load += new System.EventHandler(this.borrower_master_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnl_header, 0);
            this.Controls.SetChildIndex(this.pnl_footer, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmb_name, 0);
            this.Controls.SetChildIndex(this.txt_nic, 0);
            this.Controls.SetChildIndex(this.txt_phone, 0);
            this.Controls.SetChildIndex(this.txt_email, 0);
            this.Controls.SetChildIndex(this.btn_blackList, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txt_houseNo, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txt_streetNo, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txt_city, 0);
            this.Controls.SetChildIndex(this.txt_estate, 0);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_name;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ErrorProvider erp1;
        private System.Windows.Forms.ErrorProvider erp2;
        private System.Windows.Forms.Button btn_blackList;
        private System.Windows.Forms.TextBox txt_estate;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_streetNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_houseNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
