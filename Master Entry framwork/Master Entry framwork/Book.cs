using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections;

namespace Master_Entry_framwork
{
    public class Book
    {
        private string isbn;
        private string name;
        private string edition;
        private byte[] image;
        private decimal price;
        private DateTime bookpubDate;
        private string author;
        private string language;
        private ArrayList catNames;
        private ArrayList pubNames;

        
        private SqlCommand cmd;
        private Database db;
        private Category c;

        public void setImage(string filepath)
        {
            FileInfo finfo = new FileInfo(filepath);
            long filelength = finfo.Length;
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)filelength);
        }
        public void setImage(byte[] img)            //10/26/2013
        {
            image = img;
        }       
        public void setIsbn(string isbnno)
        {
            isbn = isbnno;
        }
        public string getIsbn()
        { return isbn; }
        public void setName(string nam)
        {
            name = nam;
        }
        public string getName()
        { return name; }
        public void setEdition(string edit)
        {
            edition = edit;
        }
        public string getEdition()
        { return edition; }
        public void setPrice(decimal pri)
        {
            price = pri;
        }
        public decimal getPrice()
        { return price; }
        public void setAuthorNo(string an)
        {
            author = an;
        }
        public string getAuthorNo()
        { return author; }
        public void setLanguage(string ln)
        {
            language = ln;
        }
        public string getLanguage()
        { return language; }
        public void setPubDate(DateTime dt)
        {
            bookpubDate = Convert.ToDateTime(dt.ToShortDateString());
        }
        public DateTime getPubDate()
        { return bookpubDate; }
        public void setCatNames(ArrayList arlst)
        {
            catNames = arlst;
        }
        public ArrayList getCatNames()
        {
            return catNames;
        }
        public void setPubNames(ArrayList arlst)
        {
            pubNames = arlst;
        }
        public ArrayList getPubNames()
        {
            return pubNames;
        }
        public byte[] getImage()
        { return image; }

        public Book()
        {
            db = new Database();
            c = new Category();
            catNames = new ArrayList();
            pubNames = new ArrayList();
        }

        public bool isExistBook(string isbn)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isBookExistPro");
                cmd.Parameters.Add(new SqlParameter("@Isbn",isbn));
                r = (bool)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public bool isExistBookNam(string name)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isBookNameExistPro");
                cmd.Parameters.Add(new SqlParameter("@bName", name));
                r = (bool)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int insertBook()
        {
            int r = 0;
            SqlTransaction trn;
            try
            {
                if (!isExistBook(isbn))
                {
                    db.Opencon();
                    trn = db.getCon().BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("insertBooks", db.getCon(), trn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Isbn", isbn));
                        cmd.Parameters.Add(new SqlParameter("@bName", name));
                        cmd.Parameters.Add(new SqlParameter("@bEdition", edition));
                        cmd.Parameters.Add(new SqlParameter("@bPicture", image));
                        cmd.Parameters.Add(new SqlParameter("@bPrice", price));
                        cmd.Parameters.Add(new SqlParameter("@bpbDate", bookpubDate));
                        cmd.Parameters.Add(new SqlParameter("@avalable", true));
                        cmd.Parameters.Add(new SqlParameter("@lId", Convert.ToInt32(language)));
                        cmd.Parameters.Add(new SqlParameter("@aId", Convert.ToInt32(author)));
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        cmd.Parameters.Clear();
                        cmd = new SqlCommand("insertCatDetail", db.getCon(), trn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach(object catName in catNames)
                        {
                            cmd.Parameters.Add(new SqlParameter("@Isbn",isbn));
                            cmd.Parameters.Add(new SqlParameter("@cName",catName.ToString()));
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }

                        cmd.Parameters.Clear();
                        cmd = new SqlCommand("insertPubDetail", db.getCon(), trn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (object pubName in pubNames)
                        {
                            cmd.Parameters.Add(new SqlParameter("@Isbn",isbn));
                            cmd.Parameters.Add(new SqlParameter("@pName",pubName));
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        trn.Commit();
                        r = 1;
                    }
                    catch
                    {
                        trn.Rollback();
                        throw;
                    }
                }
                else
                { MessageBox.Show("That Book is already exist..", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public void viewBook(string bname)
        {
            SqlDataReader dtrd;
            try
            {
                cmd = db.giveCommand("selectBooks");
                cmd.Parameters.Add(new SqlParameter("@bName", bname));
                cmd.Prepare();
                dtrd = cmd.ExecuteReader();
                while (dtrd.Read())
                {
                    isbn = dtrd["Isbn"].ToString();
                    name = dtrd["bName"].ToString();
                    edition = dtrd["bEdition"].ToString();
                    price = (decimal)dtrd["bPrice"];
                    author = dtrd["aName"].ToString();
                    language = dtrd["languages"].ToString();
                    bookpubDate = Convert.ToDateTime(dtrd["bpbDate"]);
                    image = (byte[])dtrd["bPicture"];
                }
                dtrd.Close();              
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
        }

        public void selectCatNameDtl(string isbn)
        {
            try
            {
                cmd = db.giveCommand("selectCatNameDtl");
                cmd.Parameters.Add(new SqlParameter("@Isbn", isbn));
                cmd.Prepare();
                SqlDataReader dtrd = cmd.ExecuteReader();
                while (dtrd.Read())
                {
                    catNames.Add((object)dtrd[0]);
                }
                dtrd.Close();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
        }

        public void selectPubNamesDtl(string isbn)
        {
            try
            {
                cmd = db.giveCommand("selectPubNameDtl");
                cmd.Parameters.Add(new SqlParameter("@Isbn",isbn));
                cmd.Prepare();
                SqlDataReader dtrd = cmd.ExecuteReader();
                while (dtrd.Read())
                {
                    pubNames.Add((object)dtrd[0]);
                }
                dtrd.Close();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
        }

        public int deleteBook(string bisbn)
        {
            int r = 0;
            SqlTransaction trn = null;
            db.Opencon();
            trn = db.getCon().BeginTransaction();
            try
            {
                cmd = new SqlCommand("deleteCatDtl", db.getCon(), trn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Isbn",bisbn));
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd = new SqlCommand("deletePubDtl", db.getCon(), trn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Isbn", bisbn));
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd = new SqlCommand("deleteBook", db.getCon(), trn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Isbn", bisbn));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                r = 1;
                trn.Commit();
            }
            catch
            {
                trn.Rollback();
                throw;
            }
            finally
            { db.Closecon(); }
            return r;
        }

        public int editBook()
        {
            int r = 0;
            SqlTransaction trn=null;
            db.Opencon();
            trn=db.getCon().BeginTransaction();
            try
            {
                cmd = new SqlCommand("editBooks",db.getCon(),trn);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Isbn",isbn));
                cmd.Parameters.Add(new SqlParameter("@bName",name));
                cmd.Parameters.Add(new SqlParameter("@bEdition",edition));
                cmd.Parameters.Add(new SqlParameter("@bPicture",image));
                cmd.Parameters.Add(new SqlParameter("@bPrice",price));
                cmd.Parameters.Add(new SqlParameter("@bpbDate",bookpubDate));
                cmd.Parameters.Add(new SqlParameter("@lId",language));
                cmd.Parameters.Add(new SqlParameter("@aId",author));
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd=new SqlCommand("deleteCatDetail",db.getCon(),trn);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Isbn",isbn));
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd = new SqlCommand("deletePubDtl", db.getCon(), trn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Isbn", isbn));
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd = new SqlCommand("insertCatDetail", db.getCon(), trn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (object catName in catNames)
                {
                    cmd.Parameters.Add(new SqlParameter("@Isbn", isbn));
                    cmd.Parameters.Add(new SqlParameter("@cName", catName.ToString()));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                cmd.Parameters.Clear();
                cmd = new SqlCommand("insertPubDetail", db.getCon(), trn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (object pubName in pubNames)
                {
                    cmd.Parameters.Add(new SqlParameter("@Isbn", isbn));
                    cmd.Parameters.Add(new SqlParameter("@pName", pubName));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                trn.Commit();
                r = 1;
            }
            catch
            {
                trn.Rollback();
                throw;
            }
            finally
            { db.Closecon(); }
            return r;
        }

        public bool isBookAvailable(string isbn)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isBookAvailable");
                cmd.Parameters.Add(new SqlParameter("Isbn",isbn));
                r=(bool)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }


    }
}
