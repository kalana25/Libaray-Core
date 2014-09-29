namespace Master_Entry_framwork
{
    partial class return_transaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCondition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rDate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bkFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_reffer = new System.Windows.Forms.TextBox();
            this.txt_borrowDate = new System.Windows.Forms.TextBox();
            this.txt_expireDate = new System.Windows.Forms.TextBox();
            this.txt_fine = new System.Windows.Forms.TextBox();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_totalFine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 102);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(455, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 43);
            this.label6.TabIndex = 0;
            this.label6.Text = "Return Books";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lbl_result);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Location = new System.Drawing.Point(0, 539);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 51);
            this.panel2.TabIndex = 5;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(23, 17);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 16);
            this.lbl_result.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(963, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 28);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(857, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(93, 28);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Exit";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fine Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Remarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reference";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Borrow Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Expire Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bName,
            this.bIsbn,
            this.bCondition,
            this.rDate,
            this.bkFine});
            this.dataGridView1.Location = new System.Drawing.Point(10, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1087, 184);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bName
            // 
            this.bName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bName.DefaultCellStyle = dataGridViewCellStyle2;
            this.bName.HeaderText = "Book Name";
            this.bName.Name = "bName";
            this.bName.ReadOnly = true;
            this.bName.ToolTipText = "Name of The Book";
            // 
            // bIsbn
            // 
            this.bIsbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIsbn.DefaultCellStyle = dataGridViewCellStyle3;
            this.bIsbn.HeaderText = "ISBN";
            this.bIsbn.Name = "bIsbn";
            this.bIsbn.ReadOnly = true;
            this.bIsbn.ToolTipText = "ISBN of the Book";
            // 
            // bCondition
            // 
            this.bCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCondition.DefaultCellStyle = dataGridViewCellStyle4;
            this.bCondition.HeaderText = "Book condition";
            this.bCondition.MinimumWidth = 30;
            this.bCondition.Name = "bCondition";
            this.bCondition.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bCondition.ToolTipText = "Choose one of those selection to record book condition.";
            this.bCondition.Width = 150;
            // 
            // rDate
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            this.rDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.rDate.HeaderText = "Returned Date";
            this.rDate.Name = "rDate";
            this.rDate.Text = "Return";
            this.rDate.ToolTipText = "Click the button if the book is returned by the borrower. Returned date will be r" +
    "ecorded  as today.";
            this.rDate.UseColumnTextForButtonValue = true;
            // 
            // bkFine
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkFine.DefaultCellStyle = dataGridViewCellStyle6;
            this.bkFine.HeaderText = "Fine";
            this.bkFine.Name = "bkFine";
            this.bkFine.ReadOnly = true;
            // 
            // txt_reffer
            // 
            this.txt_reffer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reffer.Location = new System.Drawing.Point(111, 128);
            this.txt_reffer.Name = "txt_reffer";
            this.txt_reffer.Size = new System.Drawing.Size(177, 27);
            this.txt_reffer.TabIndex = 1;
            this.txt_reffer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_reffer.Validating += new System.ComponentModel.CancelEventHandler(this.txt_reffer_Validating);
            // 
            // txt_borrowDate
            // 
            this.txt_borrowDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_borrowDate.Location = new System.Drawing.Point(111, 195);
            this.txt_borrowDate.Name = "txt_borrowDate";
            this.txt_borrowDate.ReadOnly = true;
            this.txt_borrowDate.Size = new System.Drawing.Size(177, 27);
            this.txt_borrowDate.TabIndex = 0;
            // 
            // txt_expireDate
            // 
            this.txt_expireDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expireDate.Location = new System.Drawing.Point(111, 227);
            this.txt_expireDate.Name = "txt_expireDate";
            this.txt_expireDate.ReadOnly = true;
            this.txt_expireDate.Size = new System.Drawing.Size(177, 27);
            this.txt_expireDate.TabIndex = 0;
            // 
            // txt_fine
            // 
            this.txt_fine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fine.Location = new System.Drawing.Point(111, 258);
            this.txt_fine.Name = "txt_fine";
            this.txt_fine.ReadOnly = true;
            this.txt_fine.Size = new System.Drawing.Size(177, 27);
            this.txt_fine.TabIndex = 0;
            // 
            // txt_remarks
            // 
            this.txt_remarks.BackColor = System.Drawing.SystemColors.Window;
            this.txt_remarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_remarks.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_remarks.Location = new System.Drawing.Point(311, 167);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(545, 149);
            this.txt_remarks.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Fine";
            // 
            // txt_totalFine
            // 
            this.txt_totalFine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalFine.Location = new System.Drawing.Point(111, 291);
            this.txt_totalFine.Name = "txt_totalFine";
            this.txt_totalFine.ReadOnly = true;
            this.txt_totalFine.Size = new System.Drawing.Size(177, 27);
            this.txt_totalFine.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(12, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "NIC";
            // 
            // txt_nic
            // 
            this.txt_nic.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_nic.Location = new System.Drawing.Point(111, 162);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(177, 27);
            this.txt_nic.TabIndex = 2;
            this.txt_nic.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nic_Validating);
            // 
            // return_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1107, 590);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_totalFine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_remarks);
            this.Controls.Add(this.txt_fine);
            this.Controls.Add(this.txt_expireDate);
            this.Controls.Add(this.txt_borrowDate);
            this.Controls.Add(this.txt_reffer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "return_transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RETURN BOOKS";
            this.Load += new System.EventHandler(this.return_transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_reffer;
        private System.Windows.Forms.TextBox txt_borrowDate;
        private System.Windows.Forms.TextBox txt_expireDate;
        private System.Windows.Forms.TextBox txt_fine;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_totalFine;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn bName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIsbn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bCondition;
        private System.Windows.Forms.DataGridViewButtonColumn rDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkFine;
    }
}