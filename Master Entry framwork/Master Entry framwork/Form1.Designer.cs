namespace Master_Entry_framwork
{
    partial class Form1
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pbx_view = new System.Windows.Forms.PictureBox();
            this.pbx_add = new System.Windows.Forms.PictureBox();
            this.pbx_delete = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_edit = new System.Windows.Forms.PictureBox();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_edit)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_header.Controls.Add(this.pbx_view);
            this.pnl_header.Controls.Add(this.pbx_add);
            this.pnl_header.Controls.Add(this.pbx_delete);
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Controls.Add(this.pbx_edit);
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(575, 102);
            this.pnl_header.TabIndex = 0;
            // 
            // pbx_view
            // 
            this.pbx_view.BackColor = System.Drawing.Color.Gainsboro;
            this.pbx_view.BackgroundImage = global::Master_Entry_framwork.Properties.Resources.view;
            this.pbx_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_view.Location = new System.Drawing.Point(140, 54);
            this.pbx_view.Name = "pbx_view";
            this.pbx_view.Size = new System.Drawing.Size(45, 45);
            this.pbx_view.TabIndex = 5;
            this.pbx_view.TabStop = false;
            this.pbx_view.Click += new System.EventHandler(this.pbx_view_Click);
            // 
            // pbx_add
            // 
            this.pbx_add.BackColor = System.Drawing.Color.Gainsboro;
            this.pbx_add.BackgroundImage = global::Master_Entry_framwork.Properties.Resources.add;
            this.pbx_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_add.Location = new System.Drawing.Point(5, 54);
            this.pbx_add.Name = "pbx_add";
            this.pbx_add.Size = new System.Drawing.Size(45, 45);
            this.pbx_add.TabIndex = 4;
            this.pbx_add.TabStop = false;
            this.pbx_add.Click += new System.EventHandler(this.pbx_add_Click);
            // 
            // pbx_delete
            // 
            this.pbx_delete.BackColor = System.Drawing.Color.Gainsboro;
            this.pbx_delete.BackgroundImage = global::Master_Entry_framwork.Properties.Resources.delete;
            this.pbx_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_delete.Location = new System.Drawing.Point(95, 54);
            this.pbx_delete.Name = "pbx_delete";
            this.pbx_delete.Size = new System.Drawing.Size(45, 45);
            this.pbx_delete.TabIndex = 4;
            this.pbx_delete.TabStop = false;
            this.pbx_delete.Click += new System.EventHandler(this.pbx_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(232, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master";
            // 
            // pbx_edit
            // 
            this.pbx_edit.BackColor = System.Drawing.Color.Gainsboro;
            this.pbx_edit.BackgroundImage = global::Master_Entry_framwork.Properties.Resources.edit;
            this.pbx_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_edit.Location = new System.Drawing.Point(50, 54);
            this.pbx_edit.Name = "pbx_edit";
            this.pbx_edit.Size = new System.Drawing.Size(45, 45);
            this.pbx_edit.TabIndex = 3;
            this.pbx_edit.TabStop = false;
            this.pbx_edit.Click += new System.EventHandler(this.pbx_edit_Click);
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_footer.Controls.Add(this.lbl_result);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(0, 342);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(575, 51);
            this.pnl_footer.TabIndex = 1;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(12, 17);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 16);
            this.lbl_result.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(464, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 28);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(358, 11);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(93, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 393);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_header);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_edit)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_add;
        private System.Windows.Forms.PictureBox pbx_view;
        private System.Windows.Forms.PictureBox pbx_delete;
        private System.Windows.Forms.PictureBox pbx_edit;
        protected System.Windows.Forms.Panel pnl_header;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel pnl_footer;
        protected System.Windows.Forms.Button btn_save;
        protected System.Windows.Forms.Label lbl_result;
        protected System.Windows.Forms.Button btn_exit;


    }
}

