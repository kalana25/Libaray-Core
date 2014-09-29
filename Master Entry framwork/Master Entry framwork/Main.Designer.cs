namespace Master_Entry_framwork
{
    partial class Main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.borrowingBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returningBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.putBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.userToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.borrowerToolStripMenuItem,
            this.rackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.userPrivilegesToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gToolStripMenuItem.Text = "General Code";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // userPrivilegesToolStripMenuItem
            // 
            this.userPrivilegesToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.userPrivilegesToolStripMenuItem.Name = "userPrivilegesToolStripMenuItem";
            this.userPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userPrivilegesToolStripMenuItem.Text = "User privileges";
            this.userPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.userPrivilegesToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMasterToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // userMasterToolStripMenuItem
            // 
            this.userMasterToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.userMasterToolStripMenuItem.Name = "userMasterToolStripMenuItem";
            this.userMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userMasterToolStripMenuItem.Text = "User master";
            this.userMasterToolStripMenuItem.Click += new System.EventHandler(this.userMasterToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem1,
            this.categoryToolStripMenuItem,
            this.authorToolStripMenuItem,
            this.publisherToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.borrowingBookToolStripMenuItem,
            this.returningBooksToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // bookToolStripMenuItem1
            // 
            this.bookToolStripMenuItem1.BackColor = System.Drawing.Color.Gainsboro;
            this.bookToolStripMenuItem1.Name = "bookToolStripMenuItem1";
            this.bookToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.bookToolStripMenuItem1.Text = "Book";
            this.bookToolStripMenuItem1.Click += new System.EventHandler(this.bookToolStripMenuItem1_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // publisherToolStripMenuItem
            // 
            this.publisherToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.publisherToolStripMenuItem.Name = "publisherToolStripMenuItem";
            this.publisherToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.publisherToolStripMenuItem.Text = "Publisher";
            this.publisherToolStripMenuItem.Click += new System.EventHandler(this.publisherToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.languageToolStripMenuItem.Text = "Language";
            this.languageToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // borrowingBookToolStripMenuItem
            // 
            this.borrowingBookToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.borrowingBookToolStripMenuItem.Name = "borrowingBookToolStripMenuItem";
            this.borrowingBookToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.borrowingBookToolStripMenuItem.Text = "Borrowing Books";
            this.borrowingBookToolStripMenuItem.Click += new System.EventHandler(this.borrowingBookToolStripMenuItem_Click);
            // 
            // returningBooksToolStripMenuItem
            // 
            this.returningBooksToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.returningBooksToolStripMenuItem.Name = "returningBooksToolStripMenuItem";
            this.returningBooksToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.returningBooksToolStripMenuItem.Text = "Returning Books";
            this.returningBooksToolStripMenuItem.Click += new System.EventHandler(this.returningBooksToolStripMenuItem_Click);
            // 
            // borrowerToolStripMenuItem
            // 
            this.borrowerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowerToolStripMenuItem1});
            this.borrowerToolStripMenuItem.Name = "borrowerToolStripMenuItem";
            this.borrowerToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.borrowerToolStripMenuItem.Text = "Borrower";
            // 
            // borrowerToolStripMenuItem1
            // 
            this.borrowerToolStripMenuItem1.BackColor = System.Drawing.Color.Gainsboro;
            this.borrowerToolStripMenuItem1.Name = "borrowerToolStripMenuItem1";
            this.borrowerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.borrowerToolStripMenuItem1.Text = "Borrower";
            this.borrowerToolStripMenuItem1.Click += new System.EventHandler(this.borrowerToolStripMenuItem1_Click);
            // 
            // rackToolStripMenuItem
            // 
            this.rackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rackToolStripMenuItem1,
            this.putBooksToolStripMenuItem});
            this.rackToolStripMenuItem.Name = "rackToolStripMenuItem";
            this.rackToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.rackToolStripMenuItem.Text = "Rack";
            // 
            // rackToolStripMenuItem1
            // 
            this.rackToolStripMenuItem1.BackColor = System.Drawing.Color.Gainsboro;
            this.rackToolStripMenuItem1.Name = "rackToolStripMenuItem1";
            this.rackToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.rackToolStripMenuItem1.Text = "Rack";
            this.rackToolStripMenuItem1.Click += new System.EventHandler(this.rackToolStripMenuItem1_Click);
            // 
            // putBooksToolStripMenuItem
            // 
            this.putBooksToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.putBooksToolStripMenuItem.Name = "putBooksToolStripMenuItem";
            this.putBooksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.putBooksToolStripMenuItem.Text = "Pack Books";
            this.putBooksToolStripMenuItem.Click += new System.EventHandler(this.putBooksToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 420);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem publisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrowingBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returningBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem putBooksToolStripMenuItem;
    }
}