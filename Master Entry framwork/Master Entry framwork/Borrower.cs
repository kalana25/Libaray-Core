using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Master_Entry_framwork
{
    public class Borrower
    {
        private string name;
        private string email;
        private string phone;
        private string nic;
        private string houseNo;
        private string streetNo;
        private string city;
        private string estate;

        Database db;
        SqlCommand cmd;
        public Borrower()
        {
            db = new Database();
        }

        public void setName(string n)
        {
            name = n.Trim();
        }
        public void setEmail(string e)
        {
            email = e.Trim();
        }
        public void setPhone(string p)
        {
            phone = p.Trim();
        }
        public void setNic(string nc)
        {
            nic = nc.Trim();
        }
        public void setHouseNo(string hn)
        {
            houseNo = hn;
        }
        public void setStreetNo(string sn)
        {
            streetNo = sn;
        }
        public void setCity(string c)
        {
            city = c;
        }
        public void setEstate(string es)
        {
            estate = es;
        }
        public string getName()
        {
            return name;
        }
        public string getEmail()
        {
            return email;
        }
        public string getPhone()
        {
            return phone;
        }
        public string getNic()
        {
            return nic;
        }
        public string getHouseNo()
        { return houseNo; }
        public string getStreetNo()
        { return streetNo; }
        public string getCity()
        { return city; }
        public string getEstate()
        { return estate; }

        public int insertBorrower()
        {
            int r=0;
            try
            {
                if(!isNicExist())
                {
                    try
                    {
                        cmd = db.giveCommand("insertBorrower");
                        cmd.Parameters.Add(new SqlParameter("@name",name));
                        cmd.Parameters.Add(new SqlParameter("@nic",nic));
                        cmd.Parameters.Add(new SqlParameter("@phone",phone));
                        cmd.Parameters.Add(new SqlParameter("@email", email));
                        cmd.Parameters.Add(new SqlParameter("@houseNo",houseNo));
                        cmd.Parameters.Add(new SqlParameter("@StreetNo",streetNo));        
                        cmd.Parameters.Add(new SqlParameter("@city",city));
                        cmd.Parameters.Add(new SqlParameter("@estate",estate));
                        r = cmd.ExecuteNonQuery();
                        db.Closecon();
                    }
                    catch
                    { throw ; }
                }
                else
                { MessageBox.Show("That NIC is already exist..", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (SqlException ex)
            {
                if (int.Parse(ex.Number.ToString()) == 2627)
                { MessageBox.Show("That Name is already exist..", "Library CORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            finally
            { db.Closecon();}
            return r;
        }

        public int editBorrower()
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("updateBorrower");
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@nic", nic));
                cmd.Parameters.Add(new SqlParameter("@phone", phone));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@houseNo", houseNo));
                cmd.Parameters.Add(new SqlParameter("@StreetNo", streetNo));
                cmd.Parameters.Add(new SqlParameter("@city", city));
                cmd.Parameters.Add(new SqlParameter("@estate", estate));
                r = cmd.ExecuteNonQuery();
                db.Closecon();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public bool isNicExist()
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isNicExist");
                cmd.Parameters.Add(new SqlParameter("@nic", nic));
                r = (bool)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public bool isNameExist(string nam)
        {
            bool r = false;
            try
            {
                cmd = db.giveCommand("isNameExist");
                cmd.Parameters.Add(new SqlParameter("@name", nam));
                r = (bool)cmd.ExecuteScalar();
            }
            catch
            { throw; }
            finally
            { db.Closecon(); }
            return r;
        }

        public void viewBorrower(string nam)
        {
            SqlDataReader rdr= null;
            try
            {
                cmd = db.giveCommand("selectBorrower");
                cmd.Parameters.Add(new SqlParameter("@name",nam));
                cmd.Prepare();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    name = rdr["name"].ToString();
                    nic = rdr["nic"].ToString();
                    phone = rdr["phone"].ToString();
                    email = rdr["email"].ToString();
                    houseNo = rdr["houseNo"].ToString();
                    streetNo = rdr["StreetNo"].ToString();
                    city = rdr["city"].ToString();
                    estate = rdr["estate"].ToString();
                }
                rdr.Close(); 
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { db.Closecon(); }
        }

        public void viewBorrwrByNic(string nc)
        {
            SqlDataReader rdr = null;
            try
            {
                cmd = db.giveCommand("selectBorrowerByNic");
                cmd.Parameters.Add(new SqlParameter("@nic",nc));
                cmd.Prepare();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    name = rdr["name"].ToString();
                    nic = rdr["nic"].ToString();
                    phone = rdr["phone"].ToString();
                    email = rdr["email"].ToString();
                    houseNo = rdr["houseNo"].ToString();
                    streetNo = rdr["StreetNo"].ToString();
                    city = rdr["city"].ToString();
                    estate = rdr["estate"].ToString();
                }
                rdr.Close(); 
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { db.Closecon(); }
        }

        public int deleteBorrower(string nc)
        {
            int r = 0;
            try
            {
                cmd = db.giveCommand("deleteBorrower");
                cmd.Parameters.Add(new SqlParameter("@nic",nc));
                cmd.Prepare();
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { db.Closecon(); }
            return r;
        }
    }
}
