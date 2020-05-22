using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.SAD.DataSet;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace LMS.SAD
{
    public partial class RpBorrowers : Form
    {
        public RpBorrowers()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BtnView_Click(object sender, EventArgs e)
        {
            DS _ds = new DS();
            BindingSource binding = new BindingSource();

            RpViewerBorrower.LocalReport.EnableExternalImages = true;
            RpViewerBorrower.LocalReport.DataSources.Clear();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT * FROM `lms.sad`.`tblusers` WHERE " +
                    $"CONCAT (`User_ID`,`First_Name`,`Last_Name`,`Year_Level`,`Address`,`Contact_Number`) LIKE '%{TxtSearch.Text}%' ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(_ds.tblusers);

                    binding.DataSource = _ds.tblusers;
                    RpViewerBorrower.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", binding));
                    RpViewerBorrower.LocalReport.ReportEmbeddedResource = "LMS.SAD.Report.ReportBorrowers.rdlc";

                    RpViewerBorrower.ZoomPercent = 100;
                    RpViewerBorrower.RefreshReport();
                }
                con.Close();
            }
        }
    }
}
