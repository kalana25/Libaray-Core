namespace Master_Entry_framwork
{
    partial class gencode_master
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
            this.cmb_genType = new System.Windows.Forms.ComboBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.erp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_genCode = new System.Windows.Forms.ComboBox();
            this.erp2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(189, 5);
            this.label1.Size = new System.Drawing.Size(197, 43);
            this.label1.Text = "General Code";
            // 
            // pnl_footer
            // 
            this.pnl_footer.Location = new System.Drawing.Point(0, 376);
            // 
            // btn_save
            // 
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gencode Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // cmb_genType
            // 
            this.cmb_genType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_genType.FormattingEnabled = true;
            this.cmb_genType.Location = new System.Drawing.Point(205, 157);
            this.cmb_genType.Name = "cmb_genType";
            this.cmb_genType.Size = new System.Drawing.Size(294, 26);
            this.cmb_genType.TabIndex = 4;
            this.cmb_genType.SelectedIndexChanged += new System.EventHandler(this.cmb_genType_SelectedIndexChanged);
            this.cmb_genType.Leave += new System.EventHandler(this.cmb_genType_Leave);
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(205, 201);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(294, 81);
            this.txt_desc.TabIndex = 5;
            // 
            // erp1
            // 
            this.erp1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "General Code";
            // 
            // cmb_genCode
            // 
            this.cmb_genCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_genCode.FormattingEnabled = true;
            this.cmb_genCode.Location = new System.Drawing.Point(205, 300);
            this.cmb_genCode.Name = "cmb_genCode";
            this.cmb_genCode.Size = new System.Drawing.Size(294, 26);
            this.cmb_genCode.TabIndex = 7;
            this.cmb_genCode.SelectedIndexChanged += new System.EventHandler(this.cmb_genCode_SelectedIndexChanged);
            this.cmb_genCode.Leave += new System.EventHandler(this.cmb_genCode_Leave);
            // 
            // erp2
            // 
            this.erp2.ContainerControl = this;
            // 
            // erp3
            // 
            this.erp3.ContainerControl = this;
            // 
            // gencode_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(575, 427);
            this.Controls.Add(this.cmb_genCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.cmb_genType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "gencode_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENCODE";
            this.Load += new System.EventHandler(this.gencode_master_Load);
            this.Controls.SetChildIndex(this.pnl_header, 0);
            this.Controls.SetChildIndex(this.pnl_footer, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmb_genType, 0);
            this.Controls.SetChildIndex(this.txt_desc, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmb_genCode, 0);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_genType;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.ErrorProvider erp1;
        private System.Windows.Forms.ComboBox cmb_genCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider erp2;
        private System.Windows.Forms.ErrorProvider erp3;
    }
}
