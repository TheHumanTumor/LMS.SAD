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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        MySqlDataReader dr;

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();
                using (var con = new MySqlConnection(GetConnection()))
                {
                    try
                    {
                        con.Open();

                        using (var com = new MySqlCommand($"SELECT * FROM `tbllogin` WHERE `Username`=sha('{TxtUserName.Text}') and `Password`=sha('{TxtPassword.Text}')", con))
                        {
                            com.CommandType = CommandType.Text;

                            dr = (MySqlDataReader)com.ExecuteReader();
                            if (dr.Read())
                            {
                                MessageBox.Show("Access Granted. Welcome!","Login Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                Hide();
                                HomeForm obj = new HomeForm();
                                obj.Show();

                            }
                            else
                            {
                                MessageBox.Show("Wrong Username or Password! Please try again.","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }

                        }
                    }
                    catch (Exception)
                    {


                    }
                    finally
                    {
                        dr.Close();
                        con.Close();
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    DataTable dt = new DataTable();
                    using (var con = new MySqlConnection(GetConnection()))
                    {
                        try
                        {
                            con.Open();

                            using (var com = new MySqlCommand($"SELECT * FROM `tbllogin` WHERE `Username`=sha('{TxtUserName.Text}') and `Password`=sha('{TxtPassword.Text}')", con))
                            {
                                com.CommandType = CommandType.Text;

                                dr = (MySqlDataReader)com.ExecuteReader();
                                if (dr.Read())
                                {
                                    MessageBox.Show("Access Granted. Welcome!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Hide();
                                    HomeForm obj = new HomeForm();
                                    obj.Show();

                                }
                                else
                                {
                                    MessageBox.Show("Wrong Username or Password! Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                        catch (Exception)
                        {


                        }
                        finally
                        {
                            dr.Close();
                            con.Close();
                        }
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    DataTable dt = new DataTable();
                    using (var con = new MySqlConnection(GetConnection()))
                    {
                        try
                        {
                            con.Open();

                            using (var com = new MySqlCommand($"SELECT * FROM `tbllogin` WHERE `Username`=sha('{TxtUserName.Text}') and `Password`=sha('{TxtPassword.Text}')", con))
                            {
                                com.CommandType = CommandType.Text;

                                dr = (MySqlDataReader)com.ExecuteReader();
                                if (dr.Read())
                                {
                                    MessageBox.Show("Access Granted. Welcome!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Hide();
                                    HomeForm obj = new HomeForm();
                                    obj.Show();

                                }
                                else
                                {
                                    MessageBox.Show("Wrong Username or Password! Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    TxtPassword.Clear();
                                }

                            }
                        }
                        catch (Exception)
                        {


                        }
                        finally
                        {
                            dr.Close();
                            con.Close();
                        }
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox.Checked == true)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
