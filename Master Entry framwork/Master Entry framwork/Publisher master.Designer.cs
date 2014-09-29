namespace Master_Entry_framwork
{
    partial class Publisher_master
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
            this.txt_pubNo = new System.Windows.Forms.TextBox();
            this.erp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmb_pubName = new System.Windows.Forms.ComboBox();
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(166, 5);
            this.label1.Size = new System.Drawing.Size(243, 43);
            this.label1.Text = "Publisher Master";
            // 
            // btn_save
            // 
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Publilsher No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Publisher";
            // 
            // txt_pubNo
            // 
            this.txt_pubNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_pubNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pubNo.Location = new System.Drawing.Point(225, 179);
            this.txt_pubNo.Name = "txt_pubNo";
            this.txt_pubNo.ReadOnly = true;
            this.txt_pubNo.Size = new System.Drawing.Size(256, 24);
            this.txt_pubNo.TabIndex = 4;
            this.txt_pubNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // erp1
            // 
            this.erp1.ContainerControl = this;
            // 
            // cmb_pubName
            // 
            this.cmb_pubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pubName.FormattingEnabled = true;
            this.cmb_pubName.Location = new System.Drawing.Point(225, 223);
            this.cmb_pubName.Name = "cmb_pubName";
            this.cmb_pubName.Size = new System.Drawing.Size(256, 26);
            this.cmb_pubName.TabIndex = 5;
            this.cmb_pubName.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_pubName_Validating);
            // 
            // Publisher_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(575, 393);
            this.Controls.Add(this.cmb_pubName);
            this.Controls.Add(this.txt_pubNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Publisher_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUBLISHER";
            this.Load += new System.EventHandler(this.Publisher_master_Load);
            this.Controls.SetChildIndex(this.pnl_header, 0);
            this.Controls.SetChildIndex(this.pnl_footer, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_pubNo, 0);
            this.Controls.SetChildIndex(this.cmb_pubName, 0);
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
        private System.Windows.Forms.TextBox txt_pubNo;
        private System.Windows.Forms.ErrorProvider erp1;
        private System.Windows.Forms.ComboBox cmb_pubName;
    }
}
