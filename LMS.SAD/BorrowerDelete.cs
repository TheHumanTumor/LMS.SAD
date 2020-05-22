﻿using System;
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
    public partial class BorrowerDelete : Form
    {
        public BorrowerDelete()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BorrowerDelete_Load(object sender, EventArgs e)
        {
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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Delete record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var con = new MySqlConnection(GetConnection()))
                {
                    string command = $"DELETE FROM `lms.sad`.`tblusers` WHERE `User_ID` = '{BorrowerDataGridView["User_ID", BorrowerDataGridView.CurrentRow.Index].Value.ToString()}' ";
                    con.Open();
                    using (var cmd = new MySqlCommand(command, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        var i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Successfully Deleted! Please refresh list.");
                        }
                    }
                    con.Close();
                }
            }
        }
    }
}
