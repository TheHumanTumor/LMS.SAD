namespace LMS.SAD
{
    partial class BookReturn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BookDataGridView = new System.Windows.Forms.DataGridView();
            this.LblBookTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblLastName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblRollNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblIssueDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnReturnBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LblReturnDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblMark = new System.Windows.Forms.Label();
            this.LblBarcode = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(181, 39);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "Return Book";
            // 
            // BookDataGridView
            // 
            this.BookDataGridView.AllowUserToAddRows = false;
            this.BookDataGridView.AllowUserToDeleteRows = false;
            this.BookDataGridView.AllowUserToResizeColumns = false;
            this.BookDataGridView.AllowUserToResizeRows = false;
            this.BookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGridView.Location = new System.Drawing.Point(40, 220);
            this.BookDataGridView.MultiSelect = false;
            this.BookDataGridView.Name = "BookDataGridView";
            this.BookDataGridView.ReadOnly = true;
            this.BookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDataGridView.Size = new System.Drawing.Size(951, 284);
            this.BookDataGridView.TabIndex = 18;
            this.BookDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDataGridView_CellClick);
            // 
            // LblBookTitle
            // 
            this.LblBookTitle.AutoSize = true;
            this.LblBookTitle.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookTitle.ForeColor = System.Drawing.Color.White;
            this.LblBookTitle.Location = new System.Drawing.Point(257, 75);
            this.LblBookTitle.Name = "LblBookTitle";
            this.LblBookTitle.Size = new System.Drawing.Size(64, 24);
            this.LblBookTitle.TabIndex = 22;
            this.LblBookTitle.Text = "---------";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(49, 75);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(101, 24);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "Book Title:";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.ForeColor = System.Drawing.Color.White;
            this.LblLastName.Location = new System.Drawing.Point(257, 104);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(64, 24);
            this.LblLastName.TabIndex = 24;
            this.LblLastName.Text = "---------";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(49, 104);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(95, 24);
            this.bunifuCustomLabel4.TabIndex = 23;
            this.bunifuCustomLabel4.Text = "Borrower:";
            // 
            // LblRollNo
            // 
            this.LblRollNo.AutoSize = true;
            this.LblRollNo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRollNo.ForeColor = System.Drawing.Color.White;
            this.LblRollNo.Location = new System.Drawing.Point(257, 191);
            this.LblRollNo.Name = "LblRollNo";
            this.LblRollNo.Size = new System.Drawing.Size(64, 24);
            this.LblRollNo.TabIndex = 26;
            this.LblRollNo.Text = "---------";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(49, 191);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(68, 24);
            this.bunifuCustomLabel6.TabIndex = 25;
            this.bunifuCustomLabel6.Text = "Status:";
            // 
            // LblIssueDate
            // 
            this.LblIssueDate.AutoSize = true;
            this.LblIssueDate.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIssueDate.ForeColor = System.Drawing.Color.White;
            this.LblIssueDate.Location = new System.Drawing.Point(257, 133);
            this.LblIssueDate.Name = "LblIssueDate";
            this.LblIssueDate.Size = new System.Drawing.Size(64, 24);
            this.LblIssueDate.TabIndex = 28;
            this.LblIssueDate.Text = "---------";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(49, 133);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(103, 24);
            this.bunifuCustomLabel12.TabIndex = 27;
            this.bunifuCustomLabel12.Text = "Issue Date:";
            // 
            // BtnReturnBook
            // 
            this.BtnReturnBook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnReturnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnReturnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReturnBook.BorderRadius = 0;
            this.BtnReturnBook.ButtonText = "Update Status";
            this.BtnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturnBook.DisabledColor = System.Drawing.Color.Gray;
            this.BtnReturnBook.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnReturnBook.Iconimage = null;
            this.BtnReturnBook.Iconimage_right = null;
            this.BtnReturnBook.Iconimage_right_Selected = null;
            this.BtnReturnBook.Iconimage_Selected = null;
            this.BtnReturnBook.IconMarginLeft = 0;
            this.BtnReturnBook.IconMarginRight = 0;
            this.BtnReturnBook.IconRightVisible = true;
            this.BtnReturnBook.IconRightZoom = 0D;
            this.BtnReturnBook.IconVisible = true;
            this.BtnReturnBook.IconZoom = 90D;
            this.BtnReturnBook.IsTab = false;
            this.BtnReturnBook.Location = new System.Drawing.Point(786, 113);
            this.BtnReturnBook.Name = "BtnReturnBook";
            this.BtnReturnBook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnReturnBook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnReturnBook.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnReturnBook.selected = false;
            this.BtnReturnBook.Size = new System.Drawing.Size(162, 44);
            this.BtnReturnBook.TabIndex = 43;
            this.BtnReturnBook.Text = "Update Status";
            this.BtnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnReturnBook.Textcolor = System.Drawing.Color.White;
            this.BtnReturnBook.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // LblReturnDate
            // 
            this.LblReturnDate.AutoSize = true;
            this.LblReturnDate.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturnDate.ForeColor = System.Drawing.Color.White;
            this.LblReturnDate.Location = new System.Drawing.Point(257, 162);
            this.LblReturnDate.Name = "LblReturnDate";
            this.LblReturnDate.Size = new System.Drawing.Size(64, 24);
            this.LblReturnDate.TabIndex = 45;
            this.LblReturnDate.Text = "---------";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(49, 162);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(118, 24);
            this.bunifuCustomLabel8.TabIndex = 44;
            this.bunifuCustomLabel8.Text = "Return Date:";
            // 
            // TxtRefresh
            // 
            this.TxtRefresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TxtRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.TxtRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtRefresh.BorderRadius = 0;
            this.TxtRefresh.ButtonText = "Refresh List";
            this.TxtRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtRefresh.DisabledColor = System.Drawing.Color.Gray;
            this.TxtRefresh.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRefresh.Iconcolor = System.Drawing.Color.Transparent;
            this.TxtRefresh.Iconimage = null;
            this.TxtRefresh.Iconimage_right = null;
            this.TxtRefresh.Iconimage_right_Selected = null;
            this.TxtRefresh.Iconimage_Selected = null;
            this.TxtRefresh.IconMarginLeft = 0;
            this.TxtRefresh.IconMarginRight = 0;
            this.TxtRefresh.IconRightVisible = true;
            this.TxtRefresh.IconRightZoom = 0D;
            this.TxtRefresh.IconVisible = true;
            this.TxtRefresh.IconZoom = 90D;
            this.TxtRefresh.IsTab = false;
            this.TxtRefresh.Location = new System.Drawing.Point(641, 518);
            this.TxtRefresh.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtRefresh.Name = "TxtRefresh";
            this.TxtRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.TxtRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TxtRefresh.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtRefresh.selected = false;
            this.TxtRefresh.Size = new System.Drawing.Size(133, 35);
            this.TxtRefresh.TabIndex = 49;
            this.TxtRefresh.Text = "Refresh List";
            this.TxtRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TxtRefresh.Textcolor = System.Drawing.Color.White;
            this.TxtRefresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRefresh.Click += new System.EventHandler(this.TxtRefresh_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(294, 517);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(284, 37);
            this.TxtSearch.TabIndex = 47;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(100, 520);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(188, 29);
            this.bunifuCustomLabel9.TabIndex = 46;
            this.bunifuCustomLabel9.Text = "Search Borrower:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Returned",
            "Not Yet Returned"});
            this.comboBox1.Location = new System.Drawing.Point(794, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 27);
            this.comboBox1.TabIndex = 50;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(673, 173);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(118, 29);
            this.bunifuCustomLabel2.TabIndex = 51;
            this.bunifuCustomLabel2.Text = "Set Status:";
            // 
            // LblMark
            // 
            this.LblMark.AutoSize = true;
            this.LblMark.Location = new System.Drawing.Point(991, 554);
            this.LblMark.Name = "LblMark";
            this.LblMark.Size = new System.Drawing.Size(24, 13);
            this.LblMark.TabIndex = 52;
            this.LblMark.Text = "OFF";
            // 
            // LblBarcode
            // 
            this.LblBarcode.AutoSize = true;
            this.LblBarcode.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBarcode.ForeColor = System.Drawing.Color.White;
            this.LblBarcode.Location = new System.Drawing.Point(257, 47);
            this.LblBarcode.Name = "LblBarcode";
            this.LblBarcode.Size = new System.Drawing.Size(64, 24);
            this.LblBarcode.TabIndex = 54;
            this.LblBarcode.Text = "---------";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(49, 47);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(84, 24);
            this.bunifuCustomLabel7.TabIndex = 53;
            this.bunifuCustomLabel7.Text = "Barcode:";
            // 
            // BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1027, 576);
            this.Controls.Add(this.LblBarcode);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.LblMark);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtRefresh);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.LblReturnDate);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.BtnReturnBook);
            this.Controls.Add(this.LblIssueDate);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.LblRollNo);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.LblBookTitle);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.BookDataGridView);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookReturn";
            this.Text = "BookReturn";
            this.Load += new System.EventHandler(this.BookReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridView BookDataGridView;
        private Bunifu.Framework.UI.BunifuCustomLabel LblBookTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel LblLastName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel LblRollNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel LblIssueDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuFlatButton BtnReturnBook;
        private Bunifu.Framework.UI.BunifuCustomLabel LblReturnDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuFlatButton TxtRefresh;
        private System.Windows.Forms.TextBox TxtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public System.Windows.Forms.Label LblMark;
        private Bunifu.Framework.UI.BunifuCustomLabel LblBarcode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}