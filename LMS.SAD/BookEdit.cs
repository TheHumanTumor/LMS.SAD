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
    public partial class BookEdit : Form
    {
        public BookEdit()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BookEdit_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`Book_Author`," +
                    $"`Book_Category`,`Publisher` FROM `lms.sad`.`tblbooks` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BookDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBookTitle.Clear();
            TxtBookAuthor.Clear();
            TxtBookCategory.Clear();
            TxtBookPublisher.Clear();
            TxtBarcode.Clear();
        }

        
        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            if (TxtBookTitle.Text == "")
            {
                MessageBox.Show("Please fill empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBookAuthor.Text == "")
            {
                MessageBox.Show("Please fill empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBookCategory.Text == "")
            {
                MessageBox.Show("Please fill empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBookPublisher.Text == "")
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
                        string command = $"UPDATE `lms.sad`.`tblbooks`" +
                            $" SET " +
                            $"`Book_Title`='{TxtBookTitle.Text}',`Book_Author`='{TxtBookAuthor.Text}',`Book_Category`='{TxtBookCategory.Text}',`Publisher`='{TxtBookPublisher.Text}'" +
                            $" WHERE `Barcode`='{TxtBarcode.Text}'";
                        con.Open();
                        using (var cmd = new MySqlCommand(command, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            var i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Successfully Updated! Please refresh Book List to view entry!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtBookTitle.Clear();
                                TxtBookAuthor.Clear();
                                TxtBookCategory.Clear();
                                TxtBookPublisher.Clear();
                                TxtBarcode.Clear();
                            }
                        }
                        con.Close();
                    }
                }
            }
        }

        private void BookDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                TxtBarcode.Text = BookDataGridView["Barcode", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookTitle.Text = BookDataGridView["Book_Title", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookAuthor.Text = BookDataGridView["Book_Author", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookCategory.Text = BookDataGridView["Book_Category", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookPublisher.Text = BookDataGridView["Publisher", BookDataGridView.CurrentRow.Index].Value.ToString();
            if (e.ColumnIndex == 1)
                TxtBarcode.Text = BookDataGridView["Barcode", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookTitle.Text = BookDataGridView["Book_Title", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookAuthor.Text = BookDataGridView["Book_Author", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookCategory.Text = BookDataGridView["Book_Category", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookPublisher.Text = BookDataGridView["Publisher", BookDataGridView.CurrentRow.Index].Value.ToString();
            if (e.ColumnIndex == 2)
                TxtBarcode.Text = BookDataGridView["Barcode", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookTitle.Text = BookDataGridView["Book_Title", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookAuthor.Text = BookDataGridView["Book_Author", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookCategory.Text = BookDataGridView["Book_Category", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookPublisher.Text = BookDataGridView["Publisher", BookDataGridView.CurrentRow.Index].Value.ToString();
            if (e.ColumnIndex == 3)
                TxtBarcode.Text = BookDataGridView["Barcode", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookTitle.Text = BookDataGridView["Book_Title", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookAuthor.Text = BookDataGridView["Book_Author", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookCategory.Text = BookDataGridView["Book_Category", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookPublisher.Text = BookDataGridView["Publisher", BookDataGridView.CurrentRow.Index].Value.ToString();
            if (e.ColumnIndex == 4)
                TxtBarcode.Text = BookDataGridView["Barcode", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookTitle.Text = BookDataGridView["Book_Title", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookAuthor.Text = BookDataGridView["Book_Author", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookCategory.Text = BookDataGridView["Book_Category", BookDataGridView.CurrentRow.Index].Value.ToString();
                TxtBookPublisher.Text = BookDataGridView["Publisher", BookDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                int i = 0;
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`Book_Author`,`Book_Category`,`Publisher` FROM `lms.sad`.`tblbooks` " +
                        $" WHERE CONCAT (`Barcode`,`Book_Title`,`Book_Author`," +
                    $"`Book_Category`,`Publisher`) LIKE '%{TxtSearch.Text}%' ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    BookDataGridView.DataSource = dt;
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
                using (var da = new MySqlDataAdapter($"SELECT `Barcode`,`Book_Title`,`Book_Author`," +
                    $"`Book_Category`,`Publisher` FROM `lms.sad`.`tblbooks` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BookDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void BookDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            BookDataGridView.ClearSelection();
        }
    }
}
