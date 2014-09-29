using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Master_Entry_framwork
{
    class Rack
    {
        private int rackId;
        private string rackName;
        private Dictionary<int, string> sections;

        private SqlCommand cmd;
        private Database db;

        public Rack()
        {
            db = new Database();
        }

        public int RackID
        {
            set { rackId = value; }
            get{return rackId;}
        }

        public string RackName
        {
            set { rackName = value; }
            get { return rackName; }
        }

        public Dictionary<int, string> Sections
        {
            get { return sections; }
            set { sections = value; }
        }

        public int getnextNo()
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("nextIndexRackName");
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }

        public int getNextSecNo(int rackId)
        {
            int r = -9;
            try
            {
                cmd = db.giveCommand("nextIndexRackSection");
                cmd.Parameters.Add(new SqlParameter("@rId",rackId));
                r = (int)cmd.ExecuteScalar();
                db.Closecon();
            }
            catch
            { throw; }
            return r;
        }


        public DataTable selectRackName(string cmdstring)
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

        /// <summary>
        /// This method inserts the master rack Names, IDs and Section details related to Rack IDs.
        /// Before use this method RackID, RackName , Sections Properties must be set by developer.
        /// </summary>
        /// <returns>Integer value returns whether the transaction was success or not</returns>
        public int insertRack()
        {
            int r = -9;
            SqlTransaction trn = null;
            try
            {
                db.Opencon();
                trn = db.getCon().BeginTransaction();
                try
                {
                    cmd = new SqlCommand("insertRackName", db.getCon(), trn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@rId",rackId));
                    cmd.Parameters.Add(new SqlParameter("@rName",rackName));
                    cmd.Prepare();
                    r = (int)cmd.ExecuteNonQuery();
                    if (r == 1)
                    {
                        cmd.Parameters.Clear();
                        cmd = new SqlCommand("insertRackSection", db.getCon(), trn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int n = 0;
                        foreach (KeyValuePair<int, string> entry in sections)
                        {
                            cmd.Parameters.Add(new SqlParameter("@rId", rackId));
                            cmd.Parameters.Add(new SqlParameter("@secId",entry.Key));
                            cmd.Parameters.Add(new SqlParameter("@secName",entry.Value));
                            cmd.Prepare();
                            r += (int)cmd.ExecuteNonQuery();
                            n++;
                            if (n+1!= r)
                            {
                                r = -9;
                                break;
                            }
                            cmd.Parameters.Clear();
                        }
                        if (r == n + 1)
                        {
                            trn.Commit();
                        }
                        else
                        {
                            trn.Rollback();
                        }
                    }
                    else
                    {
                        trn.Rollback();
                        r = -9;
                    }
                }
                catch
                {
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
        /// <summary>
        /// This method checks whether the  rack Name is already exist or not.
        /// Before use this method RackName must be set by developer.
        /// </summary>
        /// <returns>Returns true or false</returns>
        public bool isRackNameExist()
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isRackNameExist");
                cmd.Parameters.Add(new SqlParameter("@rName",this.rackName.Trim()));
                cmd.Prepare();
                r = (bool)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        /// <summary>
        /// This method fills the all the data inside the Rack Object including rack id and sections
        /// Before use this method RackName must be provided by the developer.
        /// </summary>
        public void viewRackInfor()
        {
            SqlDataReader dtrd = null;
            sections = new Dictionary<int, string>();
            try
            {
                cmd = db.giveCommand("selectRackId");
                cmd.Parameters.Add(new SqlParameter("@rName",this.rackName));
                cmd.Prepare();
                dtrd = cmd.ExecuteReader();
                while (dtrd.Read())
                {
                    this.rackId=int.Parse(dtrd["rId"].ToString());
                }
                dtrd.Close();
            }
            catch
            { throw; }

            cmd.Parameters.Clear();
            cmd = null;
            dtrd = null;

            try
            {
                cmd=db.giveCommand("selectSections");
                cmd.Parameters.Add(new SqlParameter("@rId",this.rackId));
                cmd.Prepare();
                dtrd=cmd.ExecuteReader();
                DataTable dtbl=new DataTable();
                dtbl.Load(dtrd);
                dtrd.Close();

                foreach (DataRow dr in dtbl.Rows)
                {
                    sections.Add(int.Parse(dr[0].ToString()), dr[1].ToString().Trim());
                }
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
        }

        /// <summary>
        /// This method delete the related records from the mstRackNames and dtlRackSection tables.
        /// Before use this method RackID and SectionID properties must be set by developer.
        /// </summary>
        /// <returns>Integer value returns whether the Transaction was success or not,
        /// If value is 0 none of the record is deleted
        /// If value is more than 0 that is the number of records deleted.
        /// </returns>
        public int deleteRack()
        {
            int r = 0;
            SqlTransaction trn = null;
            try
            {
                db.Opencon();
                trn = db.getCon().BeginTransaction();
                try
                {
                    cmd = new SqlCommand("deleteRackSection", db.getCon(), trn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int n = 0;
                    foreach (KeyValuePair<int, string> entry in sections)
                    {
                        cmd.Parameters.Add(new SqlParameter("@rId", rackId));
                        cmd.Parameters.Add(new SqlParameter("@secId",entry.Key));
                        cmd.Prepare();
                        r += cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        n++;
                    }
                    if (n == r)
                    {
                        cmd = new SqlCommand("deleteRackName", db.getCon(), trn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@rId",rackId));
                        cmd.Prepare();
                        r += cmd.ExecuteNonQuery();
                        if (r == n+1)
                        {
                            trn.Commit();
                        }
                        else
                        {
                            r = 0;
                            trn.Rollback();
                        }
                    }
                    else
                    {
                        r = 0;
                        trn.Rollback();
                    }
                }
                catch
                {
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

        /// <summary>
        /// This method edit the rack names and section names of the mstRackNames and dtlRackSection tanbles.
        /// Before use this method RackID, RackName and SectionIDs and SectionNames  properties must be set by developers.
        /// </summary>
        /// <returns>
        /// Integer value returns whether the Transaction was success or not,
        /// If value is 0 none of the record is edited.
        /// If value is more than 0 that is the number of records deleted.
        /// </returns>
        public int editRack()
        {
            int r = 0;
            SqlTransaction trn = null;
            try
            {
                db.Opencon();
                trn = db.getCon().BeginTransaction();
                try
                {
                    int n = 0;
                    cmd = new SqlCommand("deleteAllRackSection", db.getCon(), trn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@rId", rackId));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    r++;
                    cmd.Parameters.Clear();
                    n++;

                    cmd = new SqlCommand("insertRackSection", db.getCon(), trn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (KeyValuePair<int, string> entry in sections)
                    {
                        cmd.Parameters.Add(new SqlParameter("@rId", rackId));
                        cmd.Parameters.Add(new SqlParameter("@secId", entry.Key));
                        cmd.Parameters.Add(new SqlParameter("@secName",entry.Value));
                        cmd.Prepare();
                        r += cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        n++;
                    }
                    if (n == r)
                    {
                        cmd = new SqlCommand("editRackName", db.getCon(), trn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@rId", rackId));
                        cmd.Parameters.Add(new SqlParameter("@rName",rackName));
                        cmd.Prepare();
                        r += cmd.ExecuteNonQuery();
                        if (r == n + 1)
                        {
                            trn.Commit();
                        }
                        else
                        {
                            r = 0;
                            trn.Rollback();
                        }
                    }
                    else
                    {
                        r = 0;
                        trn.Rollback();
                    }
                }
                catch
                {
                    trn.Rollback();
                    throw;
                }
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r-1;
        }
    }
}
