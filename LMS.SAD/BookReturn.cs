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
    public partial class BookReturn : Form
    {
        public BookReturn()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BookReturn_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status` FROM `lms.sad`.`tblissue` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BookDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void BookDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblBookTitle.Text = BookDataGridView.CurrentRow.Cells["Book_Title"].Value.ToString();
            LblRollNo.Text = BookDataGridView.CurrentRow.Cells["Status"].Value.ToString();
            LblLastName.Text = BookDataGridView.CurrentRow.Cells["Last_Name"].Value.ToString();
            LblIssueDate.Text = BookDataGridView.CurrentRow.Cells["Issue_Date"].Value.ToString();
            LblReturnDate.Text = BookDataGridView.CurrentRow.Cells["Return_Date"].Value.ToString();
            LblBarcode.Text = BookDataGridView.CurrentRow.Cells["Barcode"].Value.ToString();
        }

        private void TxtRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status` FROM `lms.sad`.`tblissue` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BookDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select Status.", "Select Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var result = MessageBox.Show("Confirm Status?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var con = new MySqlConnection(GetConnection()))
                    {
                        string command = $"UPDATE `lms.sad`.`tblissue`" +
                            $" SET " +
                            $"`Status`='{comboBox1.Text}'" +
                            $" WHERE `Book_Title`='{BookDataGridView["Book_Title", BookDataGridView.CurrentRow.Index].Value.ToString()}'";
                        con.Open();
                        using (var cmd = new MySqlCommand(command, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            var i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Successfully Updated! Please refresh Book List to view entry!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BookDataGridView.Refresh();
                            }
                        }
                        con.Close();
                    }
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
