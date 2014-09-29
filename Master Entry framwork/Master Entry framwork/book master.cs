using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.IO;


namespace Master_Entry_framwork
{
    public partial class book_master : Master_Entry_framwork.Form1
    {
        private Database db;
        private Book b;
        private Author a;
        private Language l;
        private Category c;
        private ArrayList catNames;
        private ArrayList pubNames;
        //private DataTable dt_bnames;
        public book_master()
        {
            InitializeComponent();
        }

        private void book_master_Load(object sender, EventArgs e)
        {
            db = new Database();
            b = new Book();
            a = new Author();
            l = new Language();
            c = new Category();
            catNames = new ArrayList();
            pubNames = new ArrayList();
            //dt_bnames = db.executeReader("selectBookNames", CommandType.StoredProcedure, null);
            //db.loadComboWithAutoCmplt(cmb_bname, dt_bnames, "bName", "");
            db.loadComboWithAutoCmplt(cmb_bname, db.executeReader("selectBookNames", CommandType.StoredProcedure, null), "bName", "");
        }

        protected override void Onadd()
        {
            erp1.Dispose();
            erp2.Dispose();
            erp3.Dispose();
            erp4.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            btn_browse.Enabled = true;
            txt_pic.Enabled = true;
            txt_isbn.Enabled = true;
            txt_isbn.Clear();
            txt_pic.Clear();
            txt_price.Clear();

            ConfigComboBox();
            clb_category.Items.Clear();//new 2
            LoadCheckListBox();
            clb_publisher.Items.Clear();
            Load_Pub_CheckListBox();

            cmb_bname.Text = "";
            try
            {
                cmb_edition.SelectedIndex = 0;
                cmb_author.SelectedIndex = 0;
                cmb_language.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                cmb_edition.Text = "Close the window and Setup Editions";
            }
            

        }

        protected override void Onedit()
        {
            erp1.Dispose();
            erp2.Dispose();
            erp3.Dispose();
            erp4.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            btn_browse.Enabled = true;
            txt_pic.Enabled = true;
            txt_isbn.Enabled = true;
            txt_isbn.Clear();
            txt_pic.Clear();
            txt_price.Clear();

            ConfigComboBox();
            clb_category.Items.Clear();//new 2
            LoadCheckListBox();
            clb_publisher.Items.Clear();
            Load_Pub_CheckListBox();

            cmb_bname.Text = "";
            cmb_edition.SelectedIndex = 0;
            cmb_author.SelectedIndex = 0;
            cmb_language.SelectedIndex = 0;
        }

        protected override void Ondelete()
        {
            erp1.Dispose();
            erp2.Dispose();
            erp3.Dispose();
            erp4.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = true;
            btn_browse.Enabled = false;
            txt_isbn.Enabled = true;
            txt_isbn.Clear();
            txt_pic.Clear();
            txt_price.Clear();
            txt_pic.Enabled = false;
            cmb_bname.Text = "";

            ConfigComboBox();
            clb_category.Items.Clear();
            clb_publisher.Items.Clear();

            cmb_edition.SelectedIndex = 0;
            cmb_author.SelectedIndex = 0;
            cmb_language.SelectedIndex =0;
        }

        protected override void Onview()
        {
            erp1.Dispose();
            erp2.Dispose();
            erp3.Dispose();
            erp4.Dispose();
            lbl_result.Text = "";
            btn_save.Enabled = false;
            btn_browse.Enabled = false;
            txt_pic.Clear();
            txt_pic.Enabled = false;
            txt_isbn.Enabled = true;
            txt_isbn.Clear();
            txt_pic.Clear();
            txt_price.Clear();
            cmb_bname.Text = "";

            clb_category.Items.Clear();
            clb_publisher.Items.Clear();

            cmb_edition.SelectedIndex = 0;
            cmb_author.SelectedIndex = 0;
            cmb_language.SelectedIndex = 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            erp1.Dispose();
            erp2.Dispose();
            erp3.Dispose();
            erp4.Dispose();
            switch (i)
            {
                case 1:
                    if(txt_isbn.Text!="" && cmb_bname.Text!="" && txt_price.Text!="" && clb_category.CheckedItems.Count!=0 && clb_publisher.CheckedItems.Count!=0)
                    {
                        b.setIsbn(txt_isbn.Text);
                        b.setName(cmb_bname.Text);
                        if (txt_pic.Text != "")
                            b.setImage(txt_pic.Text);
                        else
                        {
                            MemoryStream ms = new MemoryStream();
                            pbx_photo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            b.setImage(ms.ToArray());
                        }
                        b.setEdition(cmb_edition.Text);
                        b.setAuthorNo(cmb_author.SelectedValue.ToString());
                        b.setLanguage(cmb_language.SelectedValue.ToString());
                        b.setPrice(Convert.ToDecimal(txt_price.Text));
                        b.setPubDate(dtp_pubdate.Value);
                        createExistingCategoryList();//05/09/2013 Testing ok
                        b.setCatNames(catNames);
                        createExistingPublisherList();// 06/09/2013
                        b.setPubNames(pubNames);// 06/09/2013
                        int r = b.insertBook();
                        if (r != 0)
                        {
                            lbl_result.Text = r.ToString() + " Rows affected";
                            clearItems();
                        }
                    }
                    else
                    {
                        if (clb_category.CheckedItems.Count == 0)
                        { giveCategorylistError(); }
                        if (txt_price.Text == "")
                        { givePriceError(); }
                        if(txt_isbn.Text=="")
                        { giveIsbnError(); }
                        if (cmb_bname.Text == "")
                        { giveBnameError(); }
                        if (clb_publisher.CheckedItems.Count == 0)
                        { givePublisherlistError(); }
                    }

                    break;
                case 2:
                    if(txt_isbn.Text!="" && cmb_bname.Text!="" && txt_price.Text!="" && clb_category.CheckedItems.Count!=0 && clb_publisher.CheckedItems.Count!=0)
                    {
                        b.setIsbn(txt_isbn.Text);
                        b.setName(cmb_bname.Text);
                        if (txt_pic.Text != "")
                            b.setImage(txt_pic.Text);
                        b.setEdition(cmb_edition.Text);
                        b.setAuthorNo(cmb_author.SelectedValue.ToString());
                        b.setLanguage(cmb_language.SelectedValue.ToString());
                        b.setPrice(Convert.ToDecimal(txt_price.Text));
                        b.setPubDate(dtp_pubdate.Value);
                        b.setCatNames(catNames);
                        createExistingCategoryList();//05/09/2013 Testing ok
                        createExistingPublisherList();
                        b.setPubNames(pubNames);
                        int r = b.editBook();
                        if (r != 0)
                        {
                            lbl_result.Text = r.ToString() + " Rows affected";
                            clearItems();
                        }
                    }
                    else
                    {
                        if (clb_category.CheckedItems.Count == 0)
                        { giveCategorylistError(); }
                        if (txt_price.Text == "")
                        { givePriceError(); }
                        if (txt_isbn.Text == "")
                        { giveIsbnError(); }
                        if (cmb_bname.Text == "")
                        { giveBnameError(); }
                        if (clb_publisher.CheckedItems.Count == 0)
                        { givePublisherlistError(); }
                    }

                    break;
                case 3:
                    if (cmb_bname.Text != "" && txt_isbn.Text!="")
                    {
                        int r = b.deleteBook(txt_isbn.Text);
                        if (r != 0)
                        {
                            lbl_result.Text = r.ToString() + " Rows affected";
                            //dt_bnames.Rows.RemoveAt(int.Parse(cmb_bname.SelectedIndex.ToString()));
                            //cmb_bname.DataSource = dt_bnames;
                            //cmb_bname.DisplayMember = "bName";
                            clearItems();
                            clb_category.Items.Clear();//new 2
                        }
                    }
                    else
                    {
                        if (cmb_bname.Text == "")
                        { giveBnameError(); }
                    }
                    break;
                case 4:

                    break;
                default:
                    MessageBox.Show("Select a mode..");
                    break;
            }
            db.loadComboWithAutoCmplt(cmb_bname, db.executeReader("selectBookNames", CommandType.StoredProcedure, null), "bName", "");
        }

        public void ConfigComboBox()
        {
            loadAuthor();
            loadLanguage();
            loadEdition();
        }

        public void retrieveBook(string bn)
        {
            b.viewBook(bn);
            txt_isbn.Text = b.getIsbn();
            cmb_edition.Text = b.getEdition();
            cmb_author.Text = b.getAuthorNo();
            cmb_language.Text = b.getLanguage();
            txt_price.Text = b.getPrice().ToString("C");
            dtp_pubdate.Value = b.getPubDate();
            MemoryStream ms = new MemoryStream(b.getImage());
            Bitmap bmp = new Bitmap(ms);
            pbx_photo.Image = (Image)bmp;
            b.selectCatNameDtl(b.getIsbn());
            catNames = b.getCatNames();
            b.selectPubNamesDtl(b.getIsbn());
            pubNames = b.getPubNames();
        }


        /// <summary>
        /// This function loads the latest category list to the CheckedListBox.
        /// Loads the category list to the CheckedListBox if the existing list amount is not equal to the table list amount
        /// Doesn't load the Cateogy list to the CheckedListBox if database table is empty.
        /// </summary>
        public void LoadCheckListBox()
        {
            DataTable dtbl = db.executeReader("selectCategory", CommandType.StoredProcedure, null);
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Please create Categories first", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            else if(dtbl.Rows.Count!=clb_category.Items.Count)
            {
                foreach (DataRow dtrw in dtbl.Rows)
                {
                    string name = dtrw[1].ToString();
                    int no = int.Parse(dtrw[0].ToString());
                    clb_category.Items.Add(name);
                }
            }
        }

        public void Load_Pub_CheckListBox()
        {
            DataTable dtbl = db.executeReader("selectPublisher", CommandType.StoredProcedure, null);
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Please create Publishers first", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            else if (dtbl.Rows.Count != clb_publisher.Items.Count)
            {
                foreach (DataRow dtrw in dtbl.Rows)
                {
                    string name = dtrw[1].ToString();
                    int no = int.Parse(dtrw[0].ToString());
                    clb_publisher.Items.Add(name);
                }
            }
        }
 
        /// <summary>
        /// This function first checks whether CheckedListBox is empty or not.
        /// if CheckedListBox is not empty it marks ticks on the CheckedListBox item compared with given list.
        /// </summary>
        public void setTick(string[]cname)
        {
            //clb_category.ItemCheck -= clb_category_ItemCheck;
            if (clb_category.Items.Count != 0)
            {
                removeTick();
                foreach (string cn in cname)
                {
                        int i=0;
                        while (i < int.Parse(clb_category.Items.Count.ToString()))
                        {
                            if (cn == clb_category.Items[i].ToString())
                            {
                                clb_category.SetItemChecked(i, true);
                            }
                            i++;
                        }
                }
            }
            //clb_category.ItemCheck += clb_category_ItemCheck;
        }

        public void set_PubTick(string[] pname)
        {
            if (clb_publisher.Items.Count!=0)
            {
                remove_PubTick();
                foreach (string pn in pname)
                {
                    int i = 0;
                    while (i < int.Parse(clb_publisher.Items.Count.ToString()))
                    {
                        if (pn == clb_publisher.Items[i].ToString())
                        {
                            clb_publisher.SetItemChecked(i, true);
                        }
                        i++;
                    }
                }
            }
        }

        /// <summary>
        /// This function only shows the categories that are assigned to the book
        /// This doesn't display the Whole categories
        /// this method is only for view mode and deletemode.
        /// </summary>
        /// <param name="cname"></param>
        public void showCategorys(string[] cname)
        {
            //clb_category.ItemCheck -= clb_category_ItemCheck;
            clb_category.Items.Clear();
            catNames.Clear();
            for (int i = 0; i < cname.Length;i++ )
            {
                clb_category.Items.Add(cname[i]);
                clb_category.SetItemChecked(i, true);
            }
            //clb_category.ItemCheck +=clb_category_ItemCheck;
        }

        public void showPublishers(string[] pname)
        {
            clb_publisher.Items.Clear();
            pubNames.Clear();
            for (int i = 0; i < pname.Length; i++)
            {
                clb_publisher.Items.Add(pname[i]);
                clb_publisher.SetItemChecked(i, true);
            }
        }

        /// <summary>
        /// This function create category array list including categories what CheckedListBox have.
        /// In other words, create category list with what category has been checked on the CheckedListBox.
        /// This is used for modify mode.
        /// </summary>
        public void createExistingCategoryList()
        {
            for (int i = 0; i < clb_category.Items.Count; i++)
            {
                if (clb_category.GetItemChecked(i))
                {
                    catNames.Add(clb_category.Items[i].ToString());
                }
            }
        }

        public void createExistingPublisherList()
        {
            for (int i = 0; i < clb_publisher.Items.Count; i++)
            {
                if (clb_publisher.GetItemChecked(i))
                {
                    pubNames.Add(clb_publisher.Items[i].ToString());
                }
            }
        }

        public void removeTick()
        {
            catNames.Clear();//new
            if (clb_category.Items.Count != 0)
            {
                int i = 0;
                while (i < int.Parse(clb_category.Items.Count.ToString()))
                {
                    clb_category.SetItemChecked(i, false);
                    i++;
                } 
            }
        }

        public void remove_PubTick()
        {
            pubNames.Clear();//// 06/09/2013
            if (clb_publisher.Items.Count != 0)
            {
                int i = 0;
                while (i < int.Parse(clb_publisher.Items.Count.ToString()))
                {
                    clb_publisher.SetItemChecked(i, false);
                    i++;
                }

            }
        }

        public void loadAuthor()
        {
            DataTable dtbl = a.selectAuthor("selectAuthor");
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Please create Authors first", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            else
            {
                cmb_author.DataSource = dtbl;
                cmb_author.DisplayMember = "Author Name";
                cmb_author.ValueMember = "Author ID";
            }
        }

        public void loadLanguage()
        {
            DataTable dtbl = l.selectLanguage("selectLanguage");
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Please create Languages first", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            else
            {
                cmb_language.DataSource = dtbl;
                cmb_language.ValueMember = "Language ID";
                cmb_language.DisplayMember = "Language";
            }
        }

        public void loadEdition()
        {
            DataTable dtbl = db.executeReader("selectEdition", CommandType.StoredProcedure, null);
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Please Create General code for Editions", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            else
            {
                cmb_edition.DataSource = dtbl;
                cmb_edition.DisplayMember = "gencode";
                cmb_edition.ValueMember = "";
            }
        }

        public void givePriceError()
        {
            erp4.SetError(txt_price, "Price can not be empty.");
            erp4.SetIconPadding(txt_price, 6);
            erp4.BlinkRate = 200;
            txt_price.Focus();
        }

        public void giveIsbnError()
        {
            erp1.SetError(txt_isbn, "ISBN can not be empty.");
            erp1.SetIconPadding(txt_isbn, 6);
            erp1.BlinkRate = 200;
            txt_isbn.Focus();
        }

        public void giveBnameError()
        {
            erp2.SetError(cmb_bname, "Book name can not be empty.");
            erp2.SetIconPadding(cmb_bname, 6);
            erp2.BlinkRate = 200;
            cmb_bname.Focus();
        }

        public void giveCategorylistError()
        {
            erp3.SetError(clb_category, "Category can not be leave");
            erp3.SetIconPadding(clb_category, 6);
            erp3.BlinkRate = 200;
            clb_category.Focus();
        }

        public void givePublisherlistError()
        {
            erp5.SetError(clb_publisher, "Publisher can not be leave");
            erp5.SetIconPadding(clb_publisher, 6);
            erp5.BlinkRate = 200;
            clb_publisher.Focus();
        }

        public void clearItems()
        {
            txt_isbn.TextChanged -= txt_isbn_TextChanged;
            txt_isbn.Enabled = true;//newly added 02/09/2013
            txt_isbn.Clear();
            txt_isbn.TextChanged += txt_isbn_TextChanged;
            cmb_bname.Text = "";
            txt_pic.Clear();
            txt_price.Clear();
            cmb_edition.SelectedIndex = 0;
            cmb_author.SelectedIndex = 0;
            cmb_language.SelectedIndex = 0;
            dtp_pubdate.Value = DateTime.Today;
            catNames.Clear();
            removeTick();
            pubNames.Clear();
            remove_PubTick();
            pbx_photo.Image = pbx_photo.InitialImage;
        }

 /*       private void clb_category_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue.ToString() == "Unchecked" && e.NewValue.ToString() == "Checked")
            {
                catNames.Add(clb_category.SelectedItem);
            }
            else
            {
                catNames.Remove(clb_category.SelectedItem);
            }
        }*/

        private void btn_browse_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select Your Book Cover";
            openFileDialog1.Filter = "JPEG Image|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_pic.Text = openFileDialog1.FileName;
            }
        }

        private void cmb_bname_Validating(object sender, CancelEventArgs e)
        {
            lbl_result.Text = "";
            //if(i==2||i==3||i==4)
            //{
            //    if (cmb_bname.Text != "")
            //    {
            //        if (b.isExistBookNam(cmb_bname.Text.Trim()))
            //        {
            //            retrieveBook(cmb_bname.Text);
            //            if (i == 2)
            //                setTick(catNames.ToArray(typeof(string)) as string[]);
            //            if (i == 3 || i == 4)
            //                showCategorys(catNames.ToArray(typeof(string)) as string[]);
            //        }
            //        else
            //        {
            //            lbl_result.Text = "Book doesn't exist";
            //        }
            //    }
            //}

            if (i == 3 || i == 4)
            {
                if (cmb_bname.Text != "")
                {
                    if (b.isExistBookNam(cmb_bname.Text.Trim()))
                    {
                        retrieveBook(cmb_bname.Text);
                        showCategorys(catNames.ToArray(typeof(string)) as string[]);
                        showPublishers(pubNames.ToArray(typeof(string)) as string[]);// 06/09/2013
                        if (i == 3)                             //newly added 02/09/2013
                            txt_isbn.Enabled = false;           //newly added 02/09/2013
                    }
                    else
                    {
                        lbl_result.Text = "Book doesn't exist";
                    }
                }
            }
            if (i == 2)
            {
                if (cmb_bname.Text != "" && txt_isbn.Text=="")
                {
                    if (b.isExistBookNam(cmb_bname.Text.Trim()))
                    {
                        retrieveBook(cmb_bname.Text);
                        setTick(catNames.ToArray(typeof(string)) as string[]);
                        set_PubTick(pubNames.ToArray(typeof(string)) as string[]);// 06/09/2013
                    }
                    else
                    {
                        lbl_result.Text = "Book doesn't exist";
                    }
                }
            }
        }

        private void txt_isbn_Validating(object sender, CancelEventArgs e)
        {
            lbl_result.Text = "";
            bool isIsbnExist = b.isExistBook(txt_isbn.Text);
            if (txt_isbn.Text != "")
            {
                if (i == 1)
                {
                    if (isIsbnExist)
                    {
                        lbl_result.Text = "Book's ISBN is already Exist..";
                        txt_isbn.Focus();
                    }
                    else
                        txt_isbn.Enabled = false;
                }
            }
        }

        private void txt_isbn_TextChanged(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            bool isIsbnExist = b.isExistBook(txt_isbn.Text);
            if (txt_isbn.Text != "")
            {
                if (i == 2)
                {
                    if (isIsbnExist)
                    {
                        txt_isbn.Enabled = false;
                    }
                    else
                    {
                        lbl_result.Text = "ISBN doesn't exist.. Invalid Book.";
                        txt_isbn.Focus();
                    }
                }
            }
        }





    }
}
