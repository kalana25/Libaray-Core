namespace Master_Entry_framwork
{
    partial class language_master
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
            this.cmb_lanName = new System.Windows.Forms.ComboBox();
            this.txt_lanNo = new System.Windows.Forms.TextBox();
            this.erp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(164, 5);
            this.label1.Size = new System.Drawing.Size(247, 43);
            this.label1.Text = "Language Master";
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
            this.label2.Location = new System.Drawing.Point(101, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Language No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Language Name";
            // 
            // cmb_lanName
            // 
            this.cmb_lanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_lanName.FormattingEnabled = true;
            this.cmb_lanName.Location = new System.Drawing.Point(229, 217);
            this.cmb_lanName.Name = "cmb_lanName";
            this.cmb_lanName.Size = new System.Drawing.Size(256, 26);
            this.cmb_lanName.TabIndex = 1;
            this.cmb_lanName.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_lanName_Validating);
            // 
            // txt_lanNo
            // 
            this.txt_lanNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_lanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lanNo.Location = new System.Drawing.Point(229, 173);
            this.txt_lanNo.Name = "txt_lanNo";
            this.txt_lanNo.ReadOnly = true;
            this.txt_lanNo.Size = new System.Drawing.Size(256, 24);
            this.txt_lanNo.TabIndex = 0;
            this.txt_lanNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // erp1
            // 
            this.erp1.ContainerControl = this;
            // 
            // language_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(575, 393);
            this.Controls.Add(this.txt_lanNo);
            this.Controls.Add(this.cmb_lanName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "language_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LANGUAGE";
            this.Load += new System.EventHandler(this.language_master_Load);
            this.Controls.SetChildIndex(this.pnl_header, 0);
            this.Controls.SetChildIndex(this.pnl_footer, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmb_lanName, 0);
            this.Controls.SetChildIndex(this.txt_lanNo, 0);
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
        private System.Windows.Forms.ComboBox cmb_lanName;
        private System.Windows.Forms.TextBox txt_lanNo;
        private System.Windows.Forms.ErrorProvider erp1;
    }
}
