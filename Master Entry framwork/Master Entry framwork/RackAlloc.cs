using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Master_Entry_framwork
{
    class RackAlloc
    {
        Database db;
        SqlCommand cmd;
        public RackAlloc()
        {
            db = new Database();
        }

        public int insertRackAllocation(DataTable dt,string un)
        {
            int r = 0;
            SqlTransaction trn = null;
            try
            {
                db.Opencon();
                trn = db.getCon().BeginTransaction();
                try
                {
                    cmd = db.giveCommand("insertRackAllocation");
                    for(int i=0;i<=dt.Rows.Count-1;i++)
                    {
                        cmd.Parameters.Add(new SqlParameter("@rName",dt.Rows[i][0].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@secName", dt.Rows[i][1].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@bName", dt.Rows[i][2].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@Isbn", dt.Rows[i][3].ToString()));
                        cmd.Parameters.Add(new SqlParameter("@uName", un));
                        r += cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    trn.Commit();
                }
                catch
                {
                    r=0;
                    trn.Rollback();
                    throw;
                }
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public DataTable viewRackAllocation(string isbn)
        {
            SqlDataReader drd = null;
            DataTable dtbl = new DataTable();
            try
            {
                cmd = db.giveCommand("viewRackAlloca");
                cmd.Parameters.Add(new SqlParameter("@isbn",isbn));
                drd = cmd.ExecuteReader();
                dtbl.Load(drd);
                drd.Close();
            }
            catch
            { throw; }
            finally
            {
                db.Closecon();     
            }
            return dtbl;
        }

        public int deleteRackAllocation(string isbn)
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("deleteRackAlloc");
                cmd.Parameters.Add(new SqlParameter("@Isbn", isbn));
                r = cmd.ExecuteNonQuery();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }
        
    }
}
