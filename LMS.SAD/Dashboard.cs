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
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        public string MyCount { get; set; }

        public Dashboard(string count)
        {
            InitializeComponent();
            LblTotalBooks.Text = count;
            LblTotalBorrowers.Text = count;
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void Dashboard_Load(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var com = new MySqlCommand($"SELECT count(*) FROM `lms.sad`.`tblbooks` ", con))
                {
                    com.CommandType = CommandType.Text;

                    LblTotalBooks.Text += com.ExecuteScalar();

                    con.Close();
                }
            }

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var com = new MySqlCommand($"SELECT count(*) FROM `lms.sad`.`tblusers` ", con))
                {
                    com.CommandType = CommandType.Text;

                    LblTotalBorrowers.Text += com.ExecuteScalar();

                    con.Close();
                }
            }
        }
    }
}
