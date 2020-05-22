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
    public partial class RpTransactions : Form
    {
        public RpTransactions()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select Status.", "Select Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (comboBox1.Text == "All")
                {
                    DS _ds = new DS();
                    BindingSource binding = new BindingSource();

                    RpViewerTransactions.LocalReport.EnableExternalImages = true;
                    RpViewerTransactions.LocalReport.DataSources.Clear();

                    using (var con = new MySqlConnection(GetConnection()))
                    {
                        con.Open();
                        using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status`" +
                            $"FROM `lms.sad`.`tblissue` WHERE CONCAT (`Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status`)" +
                            $"LIKE '%{TxtSearch.Text}%' ", con))
                        {
                            da.SelectCommand.CommandType = CommandType.Text;
                            da.Fill(_ds.tblissue);

                            binding.DataSource = _ds.tblissue;
                            RpViewerTransactions.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", binding));
                            RpViewerTransactions.LocalReport.ReportEmbeddedResource = "LMS.SAD.Report.ReportTransactions.rdlc";

                            RpViewerTransactions.ZoomPercent = 100;
                            RpViewerTransactions.RefreshReport();
                        }
                        con.Close();
                    }
                }
                if (comboBox1.Text == "Returned")
                {
                    DS _ds = new DS();
                    BindingSource binding = new BindingSource();

                    RpViewerTransactions.LocalReport.EnableExternalImages = true;
                    RpViewerTransactions.LocalReport.DataSources.Clear();

                    using (var con = new MySqlConnection(GetConnection()))
                    {
                        con.Open();
                        using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status`" +
                            $"FROM `lms.sad`.`tblissue` WHERE CONCAT (`Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status`)" +
                            $"LIKE '%{TxtSearch.Text}%' AND `Status`='Returned' ", con))
                        {
                            da.SelectCommand.CommandType = CommandType.Text;
                            da.Fill(_ds.tblissue);

                            binding.DataSource = _ds.tblissue;
                            RpViewerTransactions.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", binding));
                            RpViewerTransactions.LocalReport.ReportEmbeddedResource = "LMS.SAD.Report.ReportTransactions.rdlc";

                            RpViewerTransactions.ZoomPercent = 100;
                            RpViewerTransactions.RefreshReport();
                        }
                        con.Close();
                    }
                }
                if (comboBox1.Text == "Not Yet Returned")
                {
                    DS _ds = new DS();
                    BindingSource binding = new BindingSource();

                    RpViewerTransactions.LocalReport.EnableExternalImages = true;
                    RpViewerTransactions.LocalReport.DataSources.Clear();

                    using (var con = new MySqlConnection(GetConnection()))
                    {
                        con.Open();
                        using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status`" +
                            $"FROM `lms.sad`.`tblissue` WHERE CONCAT (`Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status`)" +
                            $"LIKE '%{TxtSearch.Text}%' AND `Status`='Not Yet Returned' ", con))
                        {
                            da.SelectCommand.CommandType = CommandType.Text;
                            da.Fill(_ds.tblissue);

                            binding.DataSource = _ds.tblissue;
                            RpViewerTransactions.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", binding));
                            RpViewerTransactions.LocalReport.ReportEmbeddedResource = "LMS.SAD.Report.ReportTransactions.rdlc";

                            RpViewerTransactions.ZoomPercent = 100;
                            RpViewerTransactions.RefreshReport();
                        }
                        con.Close();
                    }
                }
            }
        }

        private void RpTransactions_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("All");
        }
    }
}
