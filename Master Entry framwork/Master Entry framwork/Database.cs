using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace Master_Entry_framwork
{
    public class Database
    {
        private string constring;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlParameter parm;

        //newly added
        private SqlTransaction trn;

        public Database()
        {
            constring = System.Configuration.ConfigurationManager.ConnectionStrings["Master_Entry_framwork.Properties.Settings.libraryConnectionString"].ConnectionString.ToString();
        }

        public SqlConnection getCon()
        {
            return con;
        }

        public void Opencon()
        {
            try
            {
                con = new SqlConnection(constring);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

            }
            catch (Exception e1)
            {
                throw e1;
            }
        }

        public void Closecon()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    cmd.Parameters.Clear();
                    con.Close();
                }

            }
            catch (Exception e1)
            {
                throw e1;
            }
        }

        public SqlCommand giveCommand(string command)
        {
            Opencon();
            cmd = new SqlCommand(command, con);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public void loadComboBox(ComboBox cmb, DataTable dtbl, string dMember, string vMember)
        {
            cmb.DataSource = dtbl;
            cmb.ValueMember = vMember;
            cmb.DisplayMember = dMember;
        }

        public void loadComboWithAutoCmplt(ComboBox cmb,DataTable dtbl,string dMember,string vMember)
        {
            cmb.DataSource=dtbl;
            cmb.ValueMember = vMember;
            cmb.DisplayMember = dMember;
            cmb.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb.SelectedIndex = -1;
        }

        public DataTable executeReader(string command,CommandType cmdType,SqlParameter[] paraList)
        {
            Opencon();
            cmd=new SqlCommand(command,con);
            cmd.CommandType = cmdType;
            if (paraList != null)
                cmd.Parameters.AddRange(paraList);
            cmd.Prepare();
            SqlDataReader dtrd = cmd.ExecuteReader();
            DataTable dtbl = new DataTable();
            dtbl.Load(dtrd);
            return dtbl;
        }

        public SqlParameter addParameter(string name, object value)
        {
            parm = new SqlParameter();
            parm.ParameterName = name;
            parm.Value = value;
            return parm;
        }

        public int executeNonQuery(string command, CommandType cmdType, SqlParameter[] paraList)
        {
            int returnVal = 0;
            try
            {
                Opencon();
                cmd = new SqlCommand(command, con);
                cmd.CommandType = cmdType;
                if (paraList != null)
                    cmd.Parameters.AddRange(paraList);
                cmd.Prepare();
                returnVal = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return returnVal;
            }
            catch
            { throw; }
            finally
            {
                Closecon();
                cmd = null;
            }
        }

        public int executeNonQueryTrans(string[] command, CommandType cmdType, SqlParameter[][] paraList)
        {
            int returnVal = 0;
            int noOfCommand=command.Length;
            try
            {
                con.Open();
                trn=con.BeginTransaction();
                for(int i=0;i<command.Length;i++)
                {
                    cmd = new SqlCommand(command[i], con, trn);
                    cmd.CommandType = cmdType;
                    if (paraList[i] != null)
                        cmd.Parameters.AddRange(paraList[i]);
                    cmd.Prepare();
                    returnVal = cmd.ExecuteNonQuery();
                    if (returnVal == 0)
                    {
                        trn.Rollback();
                        break;
                    }
                }
                if (returnVal != 0)
                {
                    trn.Commit();
                }

            }
            catch
            {
                trn.Rollback();
                throw;
            }
            finally
            {
                Closecon();
                cmd = null;
            }
            return returnVal;   
        }


    }
}
