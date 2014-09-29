using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Master_Entry_framwork
{
    public class Category
    {
        private string catName;
        private Database db;
        private SqlCommand cmd;

        public Category()
        {
            db = new Database();
        }

        public void setcatName(string catNam)
        {
            catName = catNam;
        }

        public bool isexistCatName(string catname)
        {
            bool result = false;
            try
            {
                cmd = db.giveCommand("isCategoryExistPro");
                cmd.Parameters.Add(new SqlParameter("@cName", catname));
                result = (bool)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int insertCategory(string catName,int catNo)
        {
            int r = -9;
            try
            {
                if (!isexistCatName(catName))
                {
                    try
                    {
                        cmd = db.giveCommand("insertCategory");
                        cmd.Parameters.Add(new SqlParameter("@cName", catName));
                        cmd.Parameters.Add(new SqlParameter("@cId", catNo));
                        r = cmd.ExecuteNonQuery();
                        db.Closecon();
                    }
                    catch (Exception ex)
                    { throw ex;}
                }
                else
                {
                    MessageBox.Show("That Category name is already exist..", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            { throw e; }
            return r;
        }

        public int deleteCategory(int catNo)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("deleteCategory");
                cmd.Parameters.Add(new SqlParameter("@cId", catNo));
                r = cmd.ExecuteNonQuery();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int editCategory(string catName, int catNo)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("editCategory");
                cmd.Parameters.Add(new SqlParameter("@cId", catNo));
                cmd.Parameters.Add(new SqlParameter("@cName", catName));
                r = cmd.ExecuteNonQuery();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public DataTable selectCategory(string cmdstring)
        {
            SqlDataReader dtrd = null;
            DataTable dtbl = new DataTable();
            try
            {
                cmd = db.giveCommand(cmdstring);
                dtrd = cmd.ExecuteReader();
                dtbl.Load(dtrd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtbl;
        }

        public int getNextNo()
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("nextIndexCategory");
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return r;
        }

        public int getcatNo(string catName)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("selectcatNo");
                cmd.Parameters.Add(new SqlParameter("@cName", catName));
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            {
                throw;
            }
            return r;
        }

        /*
        public string[] selectCatNameDtl(string isbn)
        {
            string[] r=null;
            try
            {
                cmd = db.giveCommand("selectCatNameDtl");
                cmd.Parameters.Add(new SqlParameter("@Isbn",isbn));
                SqlDataReader dtrd=cmd.ExecuteReader();
                while(dtrd.Read())
                {
                    int i=0;
                    r[i] = (string)dtrd[0];
                    i++;
                }
                dtrd.Close();
            }
            catch
            { throw; }
            return r;
        }
         */
        
        public DataSet selectCatDetail(string isbn)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da=new SqlDataAdapter();
            try
            {
                cmd = db.giveCommand("selectCatDetail");
                cmd.Parameters.Add(new SqlParameter("@Isbn", isbn));
                db.Closecon();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return ds;

        }
        
        /*
        public int insertCatDetail(string isbn, int[] catNo)
        {
            int r = 0;
            SqlTransaction trn;
            db.Opencon();
            trn = db.getCon().BeginTransaction();
            try
            {
                cmd = new SqlCommand("insertCatDetail", db.getCon(), trn);
                foreach(int cid in catNo)
                {
                    cmd.Parameters.Add(new SqlParameter("@Isbn",isbn));
                    cmd.Parameters.Add(new SqlParameter("@cId",cid));
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                r=1;
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
        */

    }
}
