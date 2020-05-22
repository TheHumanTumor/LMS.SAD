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
    public partial class DelRecordConf : Form
    {
        public DelRecordConf()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        MySqlDataReader dr;

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();
                using (var con = new MySqlConnection(GetConnection()))
                {
                    try
                    {
                        con.Open();

                        using (var com = new MySqlCommand($"SELECT * FROM `tbllogin` WHERE `Password`=sha('{TxtPass.Text}')", con))
                        {
                            com.CommandType = CommandType.Text;

                            dr = (MySqlDataReader)com.ExecuteReader();
                            if (dr.Read())
                            {
                                
                            }
                            else
                            {
                                MessageBox.Show("Invalid Password!", "Acess Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
