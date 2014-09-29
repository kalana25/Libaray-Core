using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Master_Entry_framwork
{
    public class User
    {
        private Database db;
        private SqlCommand cmd;

        public User()
        {
            db = new Database();
        }

        public bool isExistUsername(string un)
        {
            bool result = false;
            try
            {
                cmd = db.giveCommand("isuserExistPro");
                cmd.Parameters.Add(new SqlParameter("@uName", un.Trim()));
                result = (bool)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return result;
        }

        public string getPassword(string un)
        {
            string pw = "";
            try
            {
                cmd = db.giveCommand("selectPw");
                cmd.Parameters.Add(new SqlParameter("@uName", un.Trim()));
                pw = (string)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return pw;
        }

        public int authenticate(string un, string pw)
        {
            try
            {
                if (isExistUsername(un))
                {
                    if (getPassword(un.Trim()) == pw.Trim())
                    {
                        return 0;   //successfully loged in.
                    }
                    else
                    {
                        return -1; //password incorrect.
                    }
                }
                else
                {
                    return 1;   //user does not exist.
                }
            }
            catch
            { throw; }
        }

        public DataTable viewUsers()
        {
            return db.executeReader("viewUser", CommandType.StoredProcedure, null);
        }

        public DataTable viewUserType()
        {
            return db.executeReader("selectUserType", CommandType.StoredProcedure, null);
        }

        public int insertUser(string un, string pw, string typ)
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("insertUser");
                cmd.Parameters.Add(new SqlParameter("@uName", un));
                cmd.Parameters.Add(new SqlParameter("@pWord", pw));
                cmd.Parameters.Add(new SqlParameter("@uType", typ));
                cmd.Prepare();
                r = cmd.ExecuteNonQuery();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public int deleteUser(string un)
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("deleteUser");
                cmd.Parameters.Add(new SqlParameter("@uName", un));
                cmd.Prepare();
                r = cmd.ExecuteNonQuery();
            }
            catch { throw; }
            finally { db.Closecon(); }
            return r;
        }

        public DataTable viewUAProgram(string un)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                db.addParameter("@uName",un)
            };
            return db.executeReader("selectUAProgram", CommandType.StoredProcedure, parameter);
        }

        public DataTable viewAProgram(string un)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                db.addParameter("@uName",un)
            };
            return db.executeReader("selectAProgram", CommandType.StoredProcedure, parameter);
        }

        public int updatePrivileges(DataGridViewRow[] dgwr, string un)
        {
            int r = 0;
            int rawCount = dgwr.Length;
            SqlTransaction trn = null;
            db.Opencon();
            trn = db.getCon().BeginTransaction();
            try
            {
                cmd = new SqlCommand("updatePrivileges", db.getCon(), trn);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < rawCount; i++)
                {
                    bool entry = checkState(dgwr[i].Cells[2].Value);
                    int pId = int.Parse(dgwr[i].Cells[0].Value.ToString());
                    bool add = checkState(dgwr[i].Cells[3].Value);
                    bool edit = checkState(dgwr[i].Cells[4].Value);
                    bool delete = checkState(dgwr[i].Cells[5].Value);
                    bool view = checkState(dgwr[i].Cells[6].Value);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@pId", pId));
                    cmd.Parameters.Add(new SqlParameter("@uName", un));
                    cmd.Parameters.Add(new SqlParameter("@new", add));
                    cmd.Parameters.Add(new SqlParameter("@edit", edit));
                    cmd.Parameters.Add(new SqlParameter("@remove", delete));
                    cmd.Parameters.Add(new SqlParameter("@show", view));
                    cmd.Parameters.Add(new SqlParameter("@window", entry));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
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
            {
                db.Closecon();
            }
            return r;
        }

        public bool checkState(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (bool.Parse(obj.ToString()) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
