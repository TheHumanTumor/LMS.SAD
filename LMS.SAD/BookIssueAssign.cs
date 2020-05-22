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
    public partial class BookIssueAssign : Form
    {
        public BookIssueAssign()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BookIssueAssign_Load(object sender, EventArgs e)
        {
            Text = "Set Book Issue Details";

            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT * FROM `lms.sad`.`tblusers` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BorrowerDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void TxtRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT `User_ID`,`First_Name`,`Last_Name`," +
                    $"`Year_Level`,`Address`,`Contact_Number` FROM `lms.sad`.`tblusers` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BorrowerDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm Book Issue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var con = new MySqlConnection(GetConnection()))
                {
                    string command = $"INSERT INTO `lms.sad`.`tblissue` (`Barcode`,`Book_ID`,`Book_Title`,`User_ID`,`First_Name`,`Last_Name`,`Issue_Date`,`Return_Date`,`Status`)" +
                        $" SELECT A.`Barcode`,A.`Book_ID`,A.`Book_Title`,B.`User_ID`,B.`First_Name`,B.`Last_Name`,'{DtPickerBorrow.Text}','{DtPickerReturn.Text}','Not Yet Returned' " +
                        $" FROM `lms.sad`.`tblbooks` A,`tblusers` B " +
                        $"WHERE A.`Book_ID`= '{LblBookID.Text}' AND B.`User_ID`= '{BorrowerDataGridView["User_ID", BorrowerDataGridView.CurrentRow.Index].Value.ToString()}'";
                    con.Open();
                    using (var cmd = new MySqlCommand(command, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        var i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Successfully Assigned! Please check issued book records.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
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
                using (var da = new MySqlDataAdapter($"SELECT * FROM `lms.sad`.`tblusers` " +
                        $" WHERE CONCAT (`User_ID`,`First_Name`,`Last_Name`," +
                    $"`Year_Level`,`Address`,`Contact_Number`) LIKE '%{TxtSearch.Text}%' ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    BorrowerDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void BorrowerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblLastName.Text = BorrowerDataGridView.CurrentRow.Cells["Last_Name"].Value.ToString();
            LblYearLevel.Text = BorrowerDataGridView.CurrentRow.Cells["Year_Level"].Value.ToString();
            LblAddress.Text = BorrowerDataGridView.CurrentRow.Cells["Address"].Value.ToString();
            LblFirstName.Text = BorrowerDataGridView.CurrentRow.Cells["First_Name"].Value.ToString();
        }
    }
}
