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
    public partial class BorrowerEdit : Form
    {
        public BorrowerEdit()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BorrowerEdit_Load(object sender, EventArgs e)
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtFirstName.Clear();
            TxtLastName.Clear();
            TxtGrade.Clear();
            TxtAddress.Clear();
            TxtContactNo.Clear();
            TxtUserID.Clear();
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtFirstName.Text == "")
            {
                MessageBox.Show("Please fill empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtLastName.Text == "")
            {
                MessageBox.Show("Please fill empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtGrade.Text == "")
            {
                MessageBox.Show("Please fill empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtAddress.Text == "")
            {
                MessageBox.Show("Please fill empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtContactNo.Text == "")
            {
                MessageBox.Show("Please fill empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var result = MessageBox.Show("Confirm editing new record?", "Edit New Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var con = new MySqlConnection(GetConnection()))
                    {
                        string command = $"UPDATE `lms.sad`.`tblusers`" +
                            $" SET " +
                            $"`First_Name`='{TxtFirstName.Text}',`Last_Name`='{TxtLastName.Text}',`Year_Level`='{TxtGrade.Text}',`Address`='{TxtAddress.Text}',`Contact_Number`='{TxtContactNo.Text}'" +
                            $" WHERE `User_ID`='{TxtUserID.Text}'";
                        con.Open();
                        using (var cmd = new MySqlCommand(command, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            var i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Successfully Updated! Please refresh Book List to view entry!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtFirstName.Clear();
                                TxtLastName.Clear();
                                TxtGrade.Clear();
                                TxtAddress.Clear();
                                TxtContactNo.Clear();
                                TxtUserID.Clear();
                            }
                        }
                        con.Close();
                    }
                }
            }
        }

        private void BorrowerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            TxtUserID.Text = BorrowerDataGridView["User_ID", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtFirstName.Text = BorrowerDataGridView["First_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtLastName.Text = BorrowerDataGridView["Last_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtGrade.Text = BorrowerDataGridView["Year_Level", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtAddress.Text = BorrowerDataGridView["Address", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtContactNo.Text = BorrowerDataGridView["Contact_Number", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            if (e.ColumnIndex == 1)
            TxtUserID.Text = BorrowerDataGridView["User_ID", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtFirstName.Text = BorrowerDataGridView["First_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtLastName.Text = BorrowerDataGridView["Last_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtGrade.Text = BorrowerDataGridView["Year_Level", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtAddress.Text = BorrowerDataGridView["Address", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtContactNo.Text = BorrowerDataGridView["Contact_Number", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            if (e.ColumnIndex == 2)
            TxtUserID.Text = BorrowerDataGridView["User_ID", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtFirstName.Text = BorrowerDataGridView["First_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtLastName.Text = BorrowerDataGridView["Last_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtGrade.Text = BorrowerDataGridView["Year_Level", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtAddress.Text = BorrowerDataGridView["Address", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtContactNo.Text = BorrowerDataGridView["Contact_Number", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            if (e.ColumnIndex == 3)
            TxtUserID.Text = BorrowerDataGridView["User_ID", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtFirstName.Text = BorrowerDataGridView["First_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtLastName.Text = BorrowerDataGridView["Last_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtGrade.Text = BorrowerDataGridView["Year_Level", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtAddress.Text = BorrowerDataGridView["Address", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtContactNo.Text = BorrowerDataGridView["Contact_Number", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            if (e.ColumnIndex == 4)
            TxtUserID.Text = BorrowerDataGridView["User_ID", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtFirstName.Text = BorrowerDataGridView["First_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtLastName.Text = BorrowerDataGridView["Last_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtGrade.Text = BorrowerDataGridView["Year_Level", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtAddress.Text = BorrowerDataGridView["Address", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtContactNo.Text = BorrowerDataGridView["Contact_Number", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            if (e.ColumnIndex == 5)
            TxtUserID.Text = BorrowerDataGridView["User_ID", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtFirstName.Text = BorrowerDataGridView["First_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtLastName.Text = BorrowerDataGridView["Last_Name", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtGrade.Text = BorrowerDataGridView["Year_Level", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtAddress.Text = BorrowerDataGridView["Address", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
            TxtContactNo.Text = BorrowerDataGridView["Contact_Number", BorrowerDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                int i = 0;
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT `User_ID`,`First_Name`,`Last_Name`,`Year_Level`,`Address`,`Contact_Number` FROM `lms.sad`.`tblusers` " +
                        $" WHERE CONCAT (`First_Name`,`Last_Name`," +
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

        private void BorrowerDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            BorrowerDataGridView.ClearSelection();
        }
    }
}
