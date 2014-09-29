using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public class Publisher
    {
        private SqlCommand cmd;
        private Database db;
        private string pubName;

        public Publisher()
        {
            db = new Database();
        }

        public void setpubName(string pn)
        {
            pubName = pn;
        }

        public bool isexistPubName(string pn)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isPublisherExistPro");
                cmd.Parameters.Add(new SqlParameter("@pName", pn));
                r = (bool)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int insertPublisher(string pn, int pno)
        {
            int r = -9;
            try
            {
                if(!isexistPubName(pn))
                {
                    try
                    {
                        cmd = db.giveCommand("insertPublisher");
                        cmd.Parameters.Add(new SqlParameter("@pId",pno));
                        cmd.Parameters.Add(new SqlParameter("@pName",pn));
                        r = cmd.ExecuteNonQuery();
                        db.Closecon();
                    }
                    catch
                    { throw; }
                }
                else
                {
                    MessageBox.Show("That Publisher is already exist..", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            { throw; }
            return r;
        }

        public int editPublisher(string pname, int pno)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("editPublisher");
                cmd.Parameters.Add(new SqlParameter("@pId",pno));
                cmd.Parameters.Add(new SqlParameter("@pName",pname));
                r = cmd.ExecuteNonQuery();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int deletePublisher(int pno)
        {
            int r=-9;
            try
            {
                cmd = db.giveCommand("deletePublisher");
                cmd.Parameters.Add(new SqlParameter("@pId",pno));
                r = cmd.ExecuteNonQuery();
                db.Closecon();
            }
            catch
            {throw;}
            return r;
        }

        public DataTable selectPublisher(string cmdstring)
        {
            SqlDataReader dtrd = null;
            DataTable dtbl = new DataTable();
            try
            {
                cmd = db.giveCommand(cmdstring);
                dtrd = cmd.ExecuteReader();
                dtbl.Load(dtrd);
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
                cmd = db.giveCommand("nextIndexPublisher");
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int getPubNo(string pname)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("selectPublisherNo");
                cmd.Parameters.Add(new SqlParameter("@pName",pname));
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

    }
}
