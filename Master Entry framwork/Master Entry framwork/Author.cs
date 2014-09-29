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
    public class Author
    {
        private string authorName;
        private SqlCommand cmd;
        private Database db;

        public Author()
        {
            db = new Database();
        }

        public void setauthorName(string an)
        {
            authorName = an;
        }

        public bool isexistAutorName(string an)
        {
            bool result = false;
            try
            {
                cmd = db.giveCommand("isAuthorExistPro");
                cmd.Parameters.Add(new SqlParameter("@aName", an));
                result = (bool)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return result;
        }

        public int insertAuthor(string aname,int aid)
        {
            int r = -9;
            try
            {
                if (!isexistAutorName(aname))
                {
                    try
                    {
                        cmd = db.giveCommand("insertAuthor");
                        cmd.Parameters.Add(new SqlParameter("@aName", aname));
                        cmd.Parameters.Add(new SqlParameter("@aId", aid));
                        r = (int)cmd.ExecuteNonQuery();
                        db.Closecon();
                    }
                    catch
                    { throw; }
                }
                else
                {
                    MessageBox.Show("That Author is already exist..", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            { throw; }
            return r;
        }

        public int editAuthor(string aname, int aid)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("editAuthor");
                cmd.Parameters.Add(new SqlParameter("@aName", aname));
                cmd.Parameters.Add(new SqlParameter("@aId", aid));
                r = (int)cmd.ExecuteNonQuery();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int deleteAuthor(int aid)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("deleteAuthor");
                cmd.Parameters.Add(new SqlParameter("@aId", aid));
                r = (int)cmd.ExecuteNonQuery();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public DataTable selectAuthor(string cmdstring)
        {
            SqlDataReader drd = null;
            DataTable dtbl = new DataTable();
            try
            {
                cmd = db.giveCommand(cmdstring);
                drd = cmd.ExecuteReader();
                dtbl.Load(drd);
            }
            catch
            { throw; }
            return dtbl;
        }

        public int getnextNo()
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("nextIndexAuthor");
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int getAuthorNo(string aname)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("selectAuthrNo");
                cmd.Parameters.Add(new SqlParameter("@aName", aname));
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

    }
}
