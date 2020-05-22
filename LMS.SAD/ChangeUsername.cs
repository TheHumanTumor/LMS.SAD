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
    public partial class ChangeUsername : Form
    {
        public ChangeUsername()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BtnUpdateUsername_Click(object sender, EventArgs e)
        {
            if (TxtNewUserName.Text == "")
            {
                MessageBox.Show("Username cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtNewUserName.Text.Length <= 4)
            {
                MessageBox.Show("Minimum username character length is 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var result = MessageBox.Show("Confirm new username?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var con = new MySqlConnection(GetConnection()))
                    {
                        string command = $"UPDATE `lms.sad`.`tbllogin`" +
                        $" SET " +
                        $"`Username`=sha('{TxtNewUserName.Text}')" +
                        $" WHERE `LoginID`='1'";
                        con.Open();
                        using (var cmd = new MySqlCommand(command, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            var i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Username successfuly updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtNewUserName.Clear();
                            }
                        }
                        con.Close();
                    }
                }
            }
        }

        private void TxtNewUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
