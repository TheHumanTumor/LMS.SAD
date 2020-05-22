using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using LMS.SAD.DataSet;
using Microsoft.Reporting.WinForms;

namespace LMS.SAD
{
    public partial class RpBook : Form
    {
        public RpBook()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BtnView_Click(object sender, EventArgs e)
        {
            DS _ds = new DS();
            BindingSource binding = new BindingSource();

            RpViewerBook.LocalReport.EnableExternalImages = true;
            RpViewerBook.LocalReport.DataSources.Clear();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`Book_Author`,`Book_Category`,`Publisher` FROM `lms.sad`.`tblbooks`" +
                    $"WHERE CONCAT(`Barcode`,`Book_Title`,`Book_Author`,`Book_Category`,`Publisher`) LIKE '%{TxtSearch.Text}%' ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(_ds.tblbooks);

                    binding.DataSource = _ds.tblbooks;
                    RpViewerBook.LocalReport.DataSources.Add(new ReportDataSource("DataSet", binding));
                    RpViewerBook.LocalReport.ReportEmbeddedResource = "LMS.SAD.Report.ReportBooks.rdlc";

                    RpViewerBook.ZoomPercent = 100;
                    RpViewerBook.RefreshReport();
                }
                con.Close();
            }
        }
    }
}
