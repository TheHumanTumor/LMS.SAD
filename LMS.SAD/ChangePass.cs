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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (TxtNewPassword.Text != TxtRepeatPassword.Text)
            {
                MessageBox.Show("Passwords doesn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtNewPassword.Text == "")
            {
                MessageBox.Show("Password cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtNewPassword.Text.Length <= 5)
            {
                MessageBox.Show("Minimum password character length is 6.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var result = MessageBox.Show("Confirm editing username?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var con = new MySqlConnection(GetConnection()))
                    {
                        string command = $"UPDATE `lms.sad`.`tbllogin`" +
                            $" SET " +
                            $"`Password`=sha('{TxtNewPassword.Text}')" +
                            $" WHERE `LoginID`='1'";
                        con.Open();
                        using (var cmd = new MySqlCommand(command, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            var i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Password successfuly updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtRepeatPassword.Clear();
                                TxtNewPassword.Clear();
                            }
                        }
                        con.Close();
                    }
                }
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox.Checked == true)
            {
                TxtNewPassword.UseSystemPasswordChar = false;
                TxtRepeatPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtNewPassword.UseSystemPasswordChar = true;
                TxtRepeatPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void TxtRepeatPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
