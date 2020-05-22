using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.SAD
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            HideSubMenu();
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

        private void HideSubMenu()
        {
            PanelBookSubMenu.Visible = false;
            PanelBorrowerSubMenu.Visible = false;
            PanelTransactionsSubMenu.Visible = false;
            PanelReportSubMenu.Visible = false;
            PanelChangeSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(childForm);
            PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());
            HideSubMenu();
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelBookSubMenu);
        }

        private void BtnBorrower_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelBorrowerSubMenu);
        }

        private void BtnTransactions_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelTransactionsSubMenu);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());

            timer1.Start();
            LbLTime1.Text = DateTime.Now.ToLongTimeString();
            LblDate1.Text = DateTime.Now.ToLongDateString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LbLTime1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void BtnViewBooks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookView());
            
        }

        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookAdd());
        }

        private void BtnViewBorrowers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BorrowerView());
        }

        private void BtnRegisterBorrower_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BorrowerAdd());
        }

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnEditBookDetail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookEdit());
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookDelete());
        }

        private void BtnEditBorrower_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BorrowerEdit());
        }

        private void BtnDeleteBorrower_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BorrowerDelete());
        }

        private void BtnIssueBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookIssue());
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookReturn());
        }

        private void BtnGenReport_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelReportSubMenu);
        }

        private void BtnGenBarcode_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GenerateBarcode());
            HideSubMenu();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelChangeSubMenu);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Logout?", "Exit System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void BtnChangeUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangeUsername());
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePass());
        }

        private void BtnReportBooks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RpBook());
        }

        private void BtnViewIssued_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookViewReturned());
        }

        private void BtnReportBorrowers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RpBorrowers());
        }

        private void BtnReportTransactions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RpTransactions());
        }
    }
}
