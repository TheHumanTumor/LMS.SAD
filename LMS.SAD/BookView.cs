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
    public partial class BookView : Form
    {
        public BookView()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT * FROM `lms.sad`.`tblbooks` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BookDataGridView.DataSource = dt;
                    LblBookRowCount.Text = BookDataGridView.RowCount.ToString();
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
                using (var da = new MySqlDataAdapter($"SELECT * FROM `lms.sad`.`tblbooks` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BookDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                int i = 0;
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT * FROM `lms.sad`.`tblbooks` " +
                        $" WHERE CONCAT (`Book_ID`,`Barcode`,`Book_Title`,`Book_Author`," +
                    $"`Book_Category`,`Publisher`) LIKE '%{TxtSearch.Text}%' ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    BookDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void BookDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            BookDataGridView.ClearSelection();
        }
    }
}
