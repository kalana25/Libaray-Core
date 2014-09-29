namespace Master_Entry_framwork
{
    partial class MainNew
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All Books");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("All Books with Image");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Book Category Wise");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Books", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Reports", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tv_report = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_general_code = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_user_priviladges = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_user_master = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_book = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_category = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_author = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_publisher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_language = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItm_borrowing_book = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_returning_book = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_borrower = new System.Windows.Forms.ToolStripMenuItem();
            this.rackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_rack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm_pack_book = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1137, 499);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tv_report, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.63895F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.36105F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(134, 493);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tv_report
            // 
            this.tv_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_report.Location = new System.Drawing.Point(3, 228);
            this.tv_report.Name = "tv_report";
            treeNode1.Name = "allbook";
            treeNode1.NodeFont = new System.Drawing.Font("Segoe UI", 9F);
            treeNode1.Text = "All Books";
            treeNode2.Name = "allbookswithImage";
            treeNode2.NodeFont = new System.Drawing.Font("Segoe UI", 9F);
            treeNode2.Text = "All Books with Image";
            treeNode3.Name = "bookcategorywise";
            treeNode3.NodeFont = new System.Drawing.Font("Segoe UI", 9F);
            treeNode3.Text = "Book Category Wise";
            treeNode4.Name = "books";
            treeNode4.NodeFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.Text = "Books";
            treeNode5.Name = "report";
            treeNode5.NodeFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.Text = "Reports";
            this.tv_report.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.tv_report.Size = new System.Drawing.Size(128, 262);
            this.tv_report.TabIndex = 0;
            this.tv_report.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_report_NodeMouseDoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(128, 219);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Book Category";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 27);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Authors";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button3.Location = new System.Drawing.Point(0, 54);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Publishers";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button4.Location = new System.Drawing.Point(0, 81);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Books";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button5.Location = new System.Drawing.Point(0, 108);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "Borrower";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button6.Location = new System.Drawing.Point(0, 135);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "Borrow Book";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button7.Location = new System.Drawing.Point(0, 162);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 27);
            this.button7.TabIndex = 6;
            this.button7.Text = "Return Book";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button8.Location = new System.Drawing.Point(0, 189);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 27);
            this.button8.TabIndex = 7;
            this.button8.Text = "Request";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button9.Location = new System.Drawing.Point(128, 0);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(128, 27);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button10.Location = new System.Drawing.Point(128, 27);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(128, 27);
            this.button10.TabIndex = 9;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button11.Location = new System.Drawing.Point(128, 54);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(128, 27);
            this.button11.TabIndex = 10;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(143, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 493);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.userToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.borrowerToolStripMenuItem,
            this.rackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItm_general_code,
            this.mnuItm_user_priviladges});
            this.adminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuItm_general_code
            // 
            this.mnuItm_general_code.BackColor = System.Drawing.Color.Gray;
            this.mnuItm_general_code.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mnuItm_general_code.Name = "mnuItm_general_code";
            this.mnuItm_general_code.Size = new System.Drawing.Size(158, 22);
            this.mnuItm_general_code.Text = "Genenal Code";
            this.mnuItm_general_code.Click += new System.EventHandler(this.mnuItm_general_code_Click_1);
            // 
            // mnuItm_user_priviladges
            // 
            this.mnuItm_user_priviladges.BackColor = System.Drawing.Color.Gray;
            this.mnuItm_user_priviladges.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mnuItm_user_priviladges.Name = "mnuItm_user_priviladges";
            this.mnuItm_user_priviladges.Size = new System.Drawing.Size(158, 22);
            this.mnuItm_user_priviladges.Text = "User priviladege";
            this.mnuItm_user_priviladges.Click += new System.EventHandler(this.mnuItm_user_priviladges_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItm_user_master});
            this.userToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // mnuItm_user_master
            // 
            this.mnuItm_user_master.Name = "mnuItm_user_master";
            this.mnuItm_user_master.Size = new System.Drawing.Size(152, 22);
            this.mnuItm_user_master.Text = "User master";
            this.mnuItm_user_master.Click += new System.EventHandler(this.mnuItm_user_master_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItm_book,
            this.mnuItm_category,
            this.mnuItm_author,
            this.mnuItm_publisher,
            this.mnuItm_language,
            this.toolStripMenuItem3,
            this.mnuItm_borrowing_book,
            this.mnuItm_returning_book});
            this.bookToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // mnuItm_book
            // 
            this.mnuItm_book.Name = "mnuItm_book";
            this.mnuItm_book.Size = new System.Drawing.Size(159, 22);
            this.mnuItm_book.Text = "Book";
            this.mnuItm_book.Click += new System.EventHandler(this.mnuItm_book_Click);
            // 
            // mnuItm_category
            // 
            this.mnuItm_category.Name = "mnuItm_category";
            this.mnuItm_category.Size = new System.Drawing.Size(159, 22);
            this.mnuItm_category.Text = "Category";
            this.mnuItm_category.Click += new System.EventHandler(this.mnuItm_category_Click);
            // 
            // mnuItm_author
            // 
            this.mnuItm_author.Name = "mnuItm_author";
            this.mnuItm_author.Size = new System.Drawing.Size(159, 22);
            this.mnuItm_author.Text = "Author";
            this.mnuItm_author.Click += new System.EventHandler(this.mnuItm_author_Click);
            // 
            // mnuItm_publisher
            // 
            this.mnuItm_publisher.Name = "mnuItm_publisher";
            this.mnuItm_publisher.Size = new System.Drawing.Size(159, 22);
            this.mnuItm_publisher.Text = "Publisher";
            this.mnuItm_publisher.Click += new System.EventHandler(this.mnuItm_publisher_Click);
            // 
            // mnuItm_language
            // 
            this.mnuItm_language.Name = "mnuItm_language";
            this.mnuItm_language.Size = new System.Drawing.Size(159, 22);
            this.mnuItm_language.Text = "Language";
            this.mnuItm_language.Click += new System.EventHandler(this.mnuItm_language_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(156, 6);
            // 
            // mnuItm_borrowing_book
            // 
            this.mnuItm_borrowing_book.Name = "mnuItm_borrowing_book";
            this.mnuItm_borrowing_book.Size = new System.Drawing.Size(159, 22);
            this.mnuItm_borrowing_book.Text = "Borrowing Book";
            this.mnuItm_borrowing_book.Click += new System.EventHandler(this.mnuItm_borrowing_book_Click);
            // 
            // mnuItm_returning_book
            // 
            this.mnuItm_returning_book.Name = "mnuItm_returning_book";
            this.mnuItm_returning_book.Size = new System.Drawing.Size(159, 22);
            this.mnuItm_returning_book.Text = "Returning Book";
            this.mnuItm_returning_book.Click += new System.EventHandler(this.mnuItm_returning_book_Click);
            // 
            // borrowerToolStripMenuItem
            // 
            this.borrowerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItm_borrower});
            this.borrowerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.borrowerToolStripMenuItem.Name = "borrowerToolStripMenuItem";
            this.borrowerToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.borrowerToolStripMenuItem.Text = "Borrower";
            // 
            // mnuItm_borrower
            // 
            this.mnuItm_borrower.Name = "mnuItm_borrower";
            this.mnuItm_borrower.Size = new System.Drawing.Size(152, 22);
            this.mnuItm_borrower.Text = "Borrower";
            this.mnuItm_borrower.Click += new System.EventHandler(this.mnuItm_borrower_Click);
            // 
            // rackToolStripMenuItem
            // 
            this.rackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItm_rack,
            this.mnuItm_pack_book});
            this.rackToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rackToolStripMenuItem.Name = "rackToolStripMenuItem";
            this.rackToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.rackToolStripMenuItem.Text = "Rack";
            // 
            // mnuItm_rack
            // 
            this.mnuItm_rack.Name = "mnuItm_rack";
            this.mnuItm_rack.Size = new System.Drawing.Size(152, 22);
            this.mnuItm_rack.Text = "Rack";
            this.mnuItm_rack.Click += new System.EventHandler(this.mnuItm_rack_Click);
            // 
            // mnuItm_pack_book
            // 
            this.mnuItm_pack_book.Name = "mnuItm_pack_book";
            this.mnuItm_pack_book.Size = new System.Drawing.Size(152, 22);
            this.mnuItm_pack_book.Text = "Pack Book";
            this.mnuItm_pack_book.Click += new System.EventHandler(this.mnuItm_pack_book_Click);
            // 
            // MainNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainNew";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView tv_report;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_general_code;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_user_priviladges;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_user_master;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_book;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_category;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_author;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_publisher;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_language;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_borrowing_book;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_returning_book;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_borrower;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_rack;
        private System.Windows.Forms.ToolStripMenuItem mnuItm_pack_book;


    }
}