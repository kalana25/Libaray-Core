using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public class Barrow
    {
        Database db;
        SqlCommand cmd;
        private int refferNo;
        private DateTime borrowDate;
        private DateTime expireDate;
        private string nic;
        private DataTable borrowedBooks;
        private DataTable pendingBooks;
        private string remarks;
        private decimal totBkFine;          //Total Fine amount for the borrow reference no
        private decimal fineRate;           //Current Fine rate per day

        

        public Barrow()
        {
            db = new Database();
        }

        public int Refferno
        {
            get { return refferNo; }
            set { refferNo = value; }
        }
        public string Nic
        {
            get { return nic; }
            set { nic = value; }
        }
        public DateTime BorrowDate
        {
            get { return borrowDate; }
            set { borrowDate = value; }
        }
        public DateTime ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }
        public DataTable BorrowedBooks
        {
            get { return borrowedBooks; }
            set { borrowedBooks = value; }
        }
        public DataTable PendingBooks
        {
            get { return pendingBooks; }
            set { pendingBooks = value; }
        }
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        public decimal TotBkFine
        {
            get { return totBkFine; }
            set { totBkFine = value; }
        }
        public decimal FineRate
        {
            get { return fineRate; }
            set { fineRate = value; }
        }


        public int getNextRefferNo()
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("nextIndexBorrowBook");
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public bool isIsbnExistForReffrNo(int reff,string isbn)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isIsbnExistForReffrNo");
                cmd.Parameters.Add(new SqlParameter("reference",reff));
                cmd.Parameters.Add(new SqlParameter("Isbn",isbn));
                cmd.Prepare();
                r = (bool)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); } 
            return r;
        }

        public int getReffByNicAndDate(DateTime browDate, string Nic)
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("getReffByDateAndNic");
                cmd.Parameters.Add(new SqlParameter("brwDate",browDate));
                cmd.Parameters.Add(new SqlParameter("nic",Nic));
                cmd.Prepare();
                r =(int)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            return r;
        }

        public bool isExistRefferNo()
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isReferNoExist");
                cmd.Parameters.Add(new SqlParameter("reference", this.refferNo));
                cmd.Prepare();
                r = (bool)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public bool getRtnStatusOfReffNo(string typ)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("getRtnStatusOfReffNo");
                cmd.Parameters.Add(new SqlParameter("type",typ));
                if (typ =="ref")
                    cmd.Parameters.Add(new SqlParameter("para", this.refferNo));
                else
                    cmd.Parameters.Add(new SqlParameter("para", this.nic));
                cmd.Prepare();
                r = (bool)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public int getReffByNic(string nic)
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("getReffByNic");
                cmd.Parameters.Add(new SqlParameter("nic",nic));
                cmd.Parameters.Add(new SqlParameter("rtnState",false));
                cmd.Prepare();
                r = (int)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public bool isPersonBorrowed(DateTime brdate,string Nic)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isPersonBorrowed");
                cmd.Parameters.Add(new SqlParameter("brwDate",brdate));
                cmd.Parameters.Add(new SqlParameter("nic",Nic));
                cmd.Prepare();
                r = (bool)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public bool isPersonBorrowedByNic(string Nic)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isPersonBorrowedByNic");
                cmd.Parameters.Add(new SqlParameter("nic", Nic));
                cmd.Prepare();
                r = (bool)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public int borrowBook(int refer, string Nic, DateTime browdate, DateTime expdate, ArrayList isbn)
        {
            int r = 0;
            if (!isPersonBorrowed(browdate, Nic))
            {
                SqlTransaction trn;
                try
                {
                    db.Opencon();
                    trn = db.getCon().BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("insertBorrowHdr", db.getCon(), trn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@reference", refer));
                        cmd.Parameters.Add(new SqlParameter("@nic", Nic));
                        cmd.Parameters.Add(new SqlParameter("@brwDate", browdate));
                        cmd.Parameters.Add(new SqlParameter("@expDate", expdate));
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        r++;

                        cmd.Parameters.Clear();
                        cmd = new SqlCommand("insertBorrowDtl", db.getCon(), trn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (object obj in isbn)
                        {
                            cmd.Parameters.Add(new SqlParameter("@reference", refer));
                            cmd.Parameters.Add(new SqlParameter("@Isbn", obj.ToString()));
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                            r++;
                            cmd.Parameters.Clear();
                        }

                        trn.Commit();
                    }
                    catch
                    {
                        trn.Rollback();
                        r = 0;
                        throw;
                    }
                }
                catch
                { throw; }
                finally
                { db.Closecon(); }
            }
            else
            { MessageBox.Show("Already Borrowed Books for the day.", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return r;
        }

        public int editBorrowBook(int refer,ArrayList isbn)
        {
            int r = 0;
                SqlTransaction trn;
                try
                {
                    db.Opencon();
                    trn = db.getCon().BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("deleteBorrowDtl", db.getCon(), trn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@reference", refer));
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        cmd.Parameters.Clear();
                        cmd = new SqlCommand("insertBorrowDtl", db.getCon(), trn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (object obj in isbn)
                        {
                            cmd.Parameters.Add(new SqlParameter("@reference", refer));
                            cmd.Parameters.Add(new SqlParameter("@Isbn", obj.ToString()));
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                            r++;
                            cmd.Parameters.Clear();
                        }

                        trn.Commit();
                    }
                    catch
                    {
                        trn.Rollback();
                        r = 0;
                        throw;
                    }
                }
                catch
                { throw; }
                finally
                { db.Closecon(); }
            return r;
        }

        public int deleteBorrow(int refer)
        {
            int r = 0;
            SqlTransaction trn;
            try
            {
                db.Opencon();
                trn = db.getCon().BeginTransaction();
                try
                {
                    cmd = new SqlCommand("deleteBorrowDtl", db.getCon(), trn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@reference", refer));
                    cmd.Prepare();
                    r=cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd = new SqlCommand("deleteBorrowHdr", db.getCon(), trn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@reference", refer));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    r++;
                    trn.Commit();
                }
                catch
                {
                    trn.Rollback();
                    r = 0;
                    throw;
                }
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public void viewBorrowHdr()
        {
            try
            {
                SqlDataReader dtrd;
                try
                {
                    cmd = db.giveCommand("viewBorrowHdr");
                    cmd.Parameters.Add(new SqlParameter("reference", this.refferNo));
                    cmd.Prepare();
                    dtrd = cmd.ExecuteReader();
                    while (dtrd.Read())
                    {
                        this.nic = dtrd["nic"].ToString();
                        this.borrowDate = Convert.ToDateTime(dtrd["brwDate"]);
                        this.expireDate = Convert.ToDateTime(dtrd["expDate"]);
                    }
                    dtrd.Close();
                }
                catch
                { throw; }
                finally
                { db.Closecon(); }
                
            }
            catch
            { throw;}

            borrowedBooks = new DataTable();
            SqlParameter []para=new SqlParameter[]{db.addParameter("reference",this.refferNo)};
            borrowedBooks=db.executeReader("viewBorrowBooks",CommandType.StoredProcedure,para);
        }

        public int getAllowDays()
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("selectAllwDays");
                cmd.Prepare();
                r = (int)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public decimal getFineRate()
        {
            decimal r = 0;
            try
            {
                cmd = db.giveCommand("selectFineRate");
                cmd.Prepare();
                r = (decimal)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public void viewPendingBook()
        {
            try
            {
                SqlDataReader dtrd;
                try
                {
                    cmd = db.giveCommand("viewBorrowHdr");
                    cmd.Parameters.Add(new SqlParameter("reference", this.refferNo));
                    cmd.Prepare();
                    dtrd = cmd.ExecuteReader();
                    while (dtrd.Read())
                    {
                        this.nic = dtrd["nic"].ToString();
                        this.borrowDate = Convert.ToDateTime(dtrd["brwDate"]);
                        this.expireDate = Convert.ToDateTime(dtrd["expDate"]);
                        this.remarks = dtrd["remarks"].ToString();
                        this.totBkFine = (decimal)dtrd["totBkFine"];
                    }
                    dtrd.Close();
                }
                catch
                { throw; }
                finally
                { db.Closecon(); }

            }
            catch
            { throw; }

            pendingBooks = new DataTable();
            SqlParameter[] para = new SqlParameter[] { db.addParameter("reference", this.refferNo) };
            pendingBooks = db.executeReader("viewPendingBooks", CommandType.StoredProcedure, para);
        }

        public int updateBookReturn()               //before this method use all the variable and datatable should have values.
        {
            int r = 0;
            SqlTransaction trn;
            try
            {
                db.Opencon();
                trn = db.getCon().BeginTransaction();
                try
                {
                    cmd = new SqlCommand("updateReturnHdr", db.getCon(), trn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@fineRate",this.fineRate));
                    cmd.Parameters.Add(new SqlParameter("@remarks",this.remarks));
                    cmd.Parameters.Add(new SqlParameter("@totBkFine",this.totBkFine));
                    cmd.Parameters.Add(new SqlParameter("@reference",this.refferNo));
                    cmd.Prepare();
                    r=cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd = new SqlCommand("updateReturnDtl", db.getCon(), trn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataRow dr in borrowedBooks.Rows)
                    {
                        cmd.Parameters.Add(new SqlParameter("@returnDate",dr["returnDate"]));
                        cmd.Parameters.Add(new SqlParameter("@bkCondition",dr["bkCondition"]));
                        cmd.Parameters.Add(new SqlParameter("@bkFineAmt",dr["bkFineAmt"]));
                        cmd.Parameters.Add(new SqlParameter("@reference",this.refferNo));
                        cmd.Parameters.Add(new SqlParameter("@Isbn", dr["Isbn"]));
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        r++;
                        cmd.Parameters.Clear();
                    }
                    trn.Commit();
                }
                catch
                {
                    trn.Rollback();
                    r = 0;
                    throw;
                }
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

    }
}