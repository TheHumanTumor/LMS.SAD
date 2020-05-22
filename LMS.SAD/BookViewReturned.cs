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

namespace LMS.SAD
{
    public partial class BookViewReturned : Form
    {
        public BookViewReturned()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BookViewReturned_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status` " +
                    $"FROM `lms.sad`.`tblissue` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BookDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status` " +
                    $"FROM `lms.sad`.`tblissue` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BookDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select Status.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (comboBox1.Text == "All")
            {
                DataTable dt = new DataTable();

                using (var con = new MySqlConnection(GetConnection()))
                {
                    con.Open();
                    using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status`" +
                        $"FROM `lms.sad`.`tblissue`", con))
                    {
                        da.SelectCommand.CommandType = CommandType.Text;
                        da.Fill(dt);

                        BookDataGridView.DataSource = dt;
                    }
                    con.Close();
                }
            }
            if (comboBox1.Text == "Returned")
            {
                DataTable dt = new DataTable();

                using (var con = new MySqlConnection(GetConnection()))
                {
                    con.Open();
                    using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status`" +
                        $"FROM `lms.sad`.`tblissue` WHERE `Status`='Returned' ", con))
                    {
                        da.SelectCommand.CommandType = CommandType.Text;
                        da.Fill(dt);

                        BookDataGridView.DataSource = dt;
                    }
                    con.Close();
                }
            }
            if (comboBox1.Text == "Not Yet Returned")
            {
                DataTable dt = new DataTable();

                using (var con = new MySqlConnection(GetConnection()))
                {
                    con.Open();
                    using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status` " +
                        $"FROM `lms.sad`.`tblissue` WHERE `Status`='Not Yet Returned' ", con))
                    {
                        da.SelectCommand.CommandType = CommandType.Text;
                        da.Fill(dt);

                        BookDataGridView.DataSource = dt;
                    }
                    con.Close();
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                int i = 0;
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status` FROM `lms.sad`.`tblissue` " +
                        $" WHERE CONCAT (`Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status`)" +
                    $" LIKE '%{TxtSearch.Text}%' ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    BookDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }
    }
}
