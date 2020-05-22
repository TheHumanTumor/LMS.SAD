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
    public partial class BorrowerAdd : Form
    {
        public BorrowerAdd()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtFirstName.Clear();
            TxtLastName.Clear();
            TxtGrade.Clear();
            TxtAddress.Clear();
            TxtContactNo.Clear();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {           
            if (TxtFirstName.Text == "")
            {
                MessageBox.Show("Please enter missing fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtLastName.Text == "")
            {
                MessageBox.Show("Please enter missing fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtGrade.Text == "")
            {
                MessageBox.Show("Please enter missing fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtAddress.Text == "")
            {
                MessageBox.Show("Please enter missing fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtContactNo.Text == "")
            {
                MessageBox.Show("Please enter missing fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var result = MessageBox.Show("Confirm adding new record?", "Add New Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var con = new MySqlConnection(GetConnection()))
                    {
                        string command = $"INSERT INTO `lms.sad`.`tblusers` (`First_Name`,`Last_Name`, `Year_Level`, `Address`,`Contact_Number`) " +
                            "VALUES " +
                            $"('{TxtFirstName.Text}','{TxtLastName.Text}','{TxtGrade.Text}','{TxtAddress.Text}','{TxtContactNo.Text}')";
                        con.Open();
                        using (var cmd = new MySqlCommand(command, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            var i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Successfully Added! Please refresh Borrower List to view entry!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtFirstName.Clear();
                                TxtLastName.Clear();
                                TxtGrade.Clear();
                                TxtAddress.Clear();
                                TxtContactNo.Clear();
                            }
                        }
                        con.Close();
                    }
                }
            }
        }

        private void TxtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //REMOVED
        private void TxtRollNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
