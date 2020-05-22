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
    public partial class BookIssue : Form
    {
        public BookIssue()
        {
            InitializeComponent();
        }

        public string GetConnection() => ConfigurationManager.ConnectionStrings["dbconstringlms"].ConnectionString;

        private void BookIssue_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT * FROM `lms.sad`.`tblbooks` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

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
                using (var da = new MySqlDataAdapter($"SELECT * FROM `lms.sad`.`tblbooks` ", con))
                {
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);

                    BookDataGridView.DataSource = dt;
                }
                con.Close();
            }
        }

        private void BookDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblBookID.Text = BookDataGridView.CurrentRow.Cells["Book_ID"].Value.ToString();
            LblBarcode.Text = BookDataGridView.CurrentRow.Cells["Barcode"].Value.ToString();
            LblBookTitle.Text = BookDataGridView.CurrentRow.Cells["Book_Title"].Value.ToString();
        }

        private void BtnIssue_Click(object sender, EventArgs e)
        {
            BookIssueAssign bookIssueAssign = new BookIssueAssign();
            bookIssueAssign.LblBookID.Text = this.BookDataGridView.CurrentRow.Cells["Book_ID"].Value.ToString();
            bookIssueAssign.LblBookTitle.Text = this.BookDataGridView.CurrentRow.Cells["Book_Title"].Value.ToString();
            bookIssueAssign.LblBarcode.Text = this.BookDataGridView.CurrentRow.Cells["Barcode"].Value.ToString();
            bookIssueAssign.ShowDialog();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(GetConnection()))
            {
                int i = 0;
                con.Open();
                using (var da = new MySqlDataAdapter($"SELECT * FROM `lms.sad`.`tblbooks` " +
                        $" WHERE CONCAT (`Book_ID`,`Barcode`,`Book_Title`,`Book_Author`," +
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
    }
}
