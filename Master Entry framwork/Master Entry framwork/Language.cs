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
    public class Language
    {
        private string lanName;
        private Database db;
        private SqlCommand cmd;

        public Language()
        {
            db = new Database();
        }

        public void setlanName(string lname)
        {
            lanName=lname;
        }

        public bool isexistLanName(string lang)
        {
            bool result=false;
            try
            {
                cmd=db.giveCommand("isLanguageExistPro");
                cmd.Parameters.Add(new SqlParameter("@languages", lang));
                result = (bool)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return result;
        }

        public int insertLanguage(string lan, int lanid)
        {
            int result = -9;
            try
            {
                if (!isexistLanName(lan))
                {
                    try
                    {
                        cmd = db.giveCommand("insertLanguage");
                        cmd.Parameters.Add(new SqlParameter("@lId",lanid));
                        cmd.Parameters.Add(new SqlParameter("@languages",lan));
                        result = cmd.ExecuteNonQuery();
                        db.Closecon();
                    }
                    catch
                    { throw; }
                }
                else
                {
                    MessageBox.Show("That Language is already exist..", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            { throw; }
            return result;
        }

        public int editLanguage(string lan, int lanid)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("editLanguage");
                cmd.Parameters.Add(new SqlParameter("@lId",lanid));
                cmd.Parameters.Add(new SqlParameter("@languages",lan));
                r = cmd.ExecuteNonQuery();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int deleteLanguage(int lanid)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("deleteLanguage");
                cmd.Parameters.Add(new SqlParameter("@lId", lanid));
                r = cmd.ExecuteNonQuery();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public DataTable selectLanguage(string cmdstring)
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
                cmd = db.giveCommand("nextIndexLanguage");
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int getLanNo(string lanName)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("selectlanNo");
                cmd.Parameters.Add(new SqlParameter("@languages", lanName));
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }


    }
}
