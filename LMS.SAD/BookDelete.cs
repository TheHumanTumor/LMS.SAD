using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace LMS.SAD
{
    public partial class BookDelete : Form
    {
        public BookDelete()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BookDelete_Load(object sender, EventArgs e)
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Delete record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var con = new MySqlConnection(GetConnection()))
                {
                    string command = $"DELETE FROM `lms.sad`.`tblbooks` WHERE `Barcode` = '{BookDataGridView[1, BookDataGridView.CurrentRow.Index].Value.ToString()}' ";
                    con.Open();
                    using (var cmd = new MySqlCommand(command, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        var i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Successfully Deleted! Please refresh list.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
    }
}
