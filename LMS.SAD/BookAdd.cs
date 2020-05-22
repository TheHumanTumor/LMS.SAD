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
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBarcode.Clear();
            TxtBookTitle.Clear();
            TxtBookAuthor.Clear();
            TxtBookCategory.Clear();
            TxtBookPublisher.Clear();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (TxtBarcode.Text == "")
            {
                MessageBox.Show("Please enter missing fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBarcode.Text.Length <= 8)
            {
                MessageBox.Show("The Barcode's minimum accepted character length is 9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBarcode.Text.Length == 11)
            {
                MessageBox.Show("The Barcode's character length must be 9, 10, 12 or 13 only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBookTitle.Text == "")
            {
                MessageBox.Show("Please enter missing fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBookAuthor.Text == "")
            {
                MessageBox.Show("Please enter missing fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBookCategory.Text == "")
            {
                MessageBox.Show("Please enter missing fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBookPublisher.Text == "")
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
                        string command = $"INSERT INTO `lms.sad`.`tblbooks` (`Barcode`,`Book_Title`,`Book_Author`, `Book_Category`, `Publisher`) " +
                            "VALUES " +
                            $"('{TxtBarcode.Text}','{TxtBookTitle.Text}','{TxtBookAuthor.Text}','{TxtBookCategory.Text}','{TxtBookPublisher.Text}')";
                        con.Open();
                        using (var cmd = new MySqlCommand(command, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            var i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Successfully Added! Please check Book Records.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtBarcode.Clear();
                                TxtBookTitle.Clear();
                                TxtBookAuthor.Clear();
                                TxtBookCategory.Clear();
                                TxtBookPublisher.Clear();
                            }
                        }
                        con.Close();
                    }
                }
            }
        }

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
