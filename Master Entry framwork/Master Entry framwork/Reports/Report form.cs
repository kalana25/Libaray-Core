using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;

namespace Master_Entry_framwork.Reports
{
    public partial class Report_form : Form
    {
        private string serverName;
        private string databaseName;
        private string userName;
        private string password;
        private ReportDocument crystlReptDoc;

        public Report_form(ReportDocument rd)
        {
            InitializeComponent();
            crystlReptDoc = rd;
        }

        private void Report_form_Load(object sender, EventArgs e)
        {
            Load_DB_Profile();

            //this.flag = flg;
            TableLogOnInfos crtableLogonInfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogonInfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables crstlTables = null;

            crConnectionInfo.ServerName = this.serverName;
            crConnectionInfo.DatabaseName = this.databaseName;
            crConnectionInfo.UserID = this.userName;
            crConnectionInfo.Password = this.password;

            crstlTables = crystlReptDoc.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table crtable in crstlTables)
            {
                crtableLogonInfo = crtable.LogOnInfo;
                crtableLogonInfo.ConnectionInfo = crConnectionInfo;
                crtable.ApplyLogOnInfo(crtableLogonInfo);
            }
            crystalReportViewer1.ReportSource = crystlReptDoc;
            crystalReportViewer1.Show();
        }

        private void Load_DB_Profile()
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                switch (key)
                {
                    case "SERVERNAME":
                        serverName = ConfigurationManager.AppSettings[key];
                        break;
                    case "DATABASE":
                        databaseName = ConfigurationManager.AppSettings[key];
                        break;
                    case "LOGIN":
                        userName = ConfigurationManager.AppSettings[key];
                        break;
                    case "PASSWRD":
                        password = ConfigurationManager.AppSettings[key];
                        break;
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
