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
    public class GeneralCode
    {
        private string genCode;
        private int genId;
        private SqlCommand cmd;
        private Database db;

        public GeneralCode()
        {
            db = new Database();
        }

        int GenId
        {
            set { genId = value; }
            get { return genId; }
        }

        public void setGencode(string gc)
        {
            genCode = gc;
        }

        public int countGencode(string type)
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("countGCPro");
                cmd.Parameters.Add(new SqlParameter("@genType",type));
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int getId(string type, string code)
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("selectId");
                cmd.Parameters.Add(new SqlParameter("@genType",type));
                cmd.Parameters.Add(new SqlParameter("@gencode",code));
                cmd.Prepare();
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            {
                throw new Exception("Parameter doesn't exist");
            }
            return r;
        }

        public bool isExistGenType(string gentype)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isGenTypeExistPro");
                cmd.Parameters.Add(new SqlParameter("@genType", gentype));
                r= (bool)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public bool isExistGenCode(string gentype,string gencode)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isGenCodeExistPro");
                cmd.Parameters.Add(new SqlParameter("@genType", gentype));
                cmd.Parameters.Add(new SqlParameter("@gencode", gencode));
                r = (bool)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int insertGencode(string type,string description,string gencode)
        {
            int r = 0;
            if (isExistGenType(type))
            {
                try
                {
                    if (!isExistGenCode(type, gencode))
                    {
                        try
                        {
                            cmd = db.giveCommand("insertdtlGC");
                            cmd.Parameters.Add(new SqlParameter("@genType", type));
                            cmd.Parameters.Add(new SqlParameter("@gencode", gencode));
                            r = cmd.ExecuteNonQuery();
                        }
                        catch
                        { throw; }
                        finally
                        { db.Closecon(); }
                    }
                    else
                    { MessageBox.Show("That Gencode is already exist..", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch
                { throw; }
            }
            else
            {
                SqlTransaction trn;
                db.Opencon();
                trn = db.getCon().BeginTransaction();
                try
                {
                    cmd = new SqlCommand("insertmstGCT", db.getCon(), trn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@genType", type));
                    cmd.Parameters.Add(new SqlParameter("@descrip", description));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd = new SqlCommand("insertdtlGC", db.getCon(), trn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@genType", type));
                    cmd.Parameters.Add(new SqlParameter("@gencode", gencode));
                    cmd.ExecuteNonQuery();
                    trn.Commit();
                    r = 2;
                }
                catch
                {
                    trn.Rollback();
                    throw;
                }
                finally
                { db.Closecon(); }
            }
            return r;
        }

        public int editGencode(int id,string type, string description, string gencode)
        {
            int r = 0;
            SqlTransaction trn;
            db.Opencon();
            trn = db.getCon().BeginTransaction();
            try
            {
                cmd = new SqlCommand("editmstGencode", db.getCon(), trn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@genType", type));
                cmd.Parameters.Add(new SqlParameter("@descrip", description));
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd = new SqlCommand("editdtlGencode", db.getCon(), trn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id",id));
                cmd.Parameters.Add(new SqlParameter("@gencode", gencode));
                cmd.ExecuteNonQuery();
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

        public int deleteGencode(string type, string description, string gencode)
        {
            int r = 0;
            if (countGencode(type)!=0 && gencode.Trim()!="")
            {
                try
                {
                    cmd = db.giveCommand("deleteGencode");
                    cmd.Parameters.Add(new SqlParameter("@genType", type));
                    cmd.Parameters.Add(new SqlParameter("@gencode", gencode));
                    r=cmd.ExecuteNonQuery();
                }
                catch
                { throw; }
                finally
                { db.Closecon(); }
            }
            else
            {
                try
                {
                    cmd = db.giveCommand("deleteGentype");
                    cmd.Parameters.Add(new SqlParameter("@genType", type));
                    r = cmd.ExecuteNonQuery();
                }
                catch
                {throw;}
                finally
                { db.Closecon(); }
            }
            return r;
        }


        public DataTable selectGentype(string cmdstring)
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

        public DataTable selectGencode(string type)
        {
            SqlDataReader dtrd = null;
            DataTable dtbl = new DataTable();
            try
            {
                cmd = db.giveCommand("selectGenCode");
                cmd.Parameters.Add(new SqlParameter("@genType", type));
                dtrd = cmd.ExecuteReader();
                dtbl.Load(dtrd);
            }
            catch
            { throw; }
            return dtbl;
        }

    }
}
