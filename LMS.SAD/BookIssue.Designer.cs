namespace LMS.SAD
{
    partial class BookIssue
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
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblBookID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblBarcode = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblBookTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BookDataGridView = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TxtRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnIssue = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(159, 39);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "Issue Book";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(40, 104);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(120, 29);
            this.bunifuCustomLabel2.TabIndex = 17;
            this.bunifuCustomLabel2.Text = "Book Title:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(41, 63);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(97, 29);
            this.bunifuCustomLabel3.TabIndex = 18;
            this.bunifuCustomLabel3.Text = "Book ID:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(41, 147);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(102, 29);
            this.bunifuCustomLabel4.TabIndex = 19;
            this.bunifuCustomLabel4.Text = "Barcode:";
            // 
            // LblBookID
            // 
            this.LblBookID.AutoSize = true;
            this.LblBookID.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookID.ForeColor = System.Drawing.Color.White;
            this.LblBookID.Location = new System.Drawing.Point(249, 63);
            this.LblBookID.Name = "LblBookID";
            this.LblBookID.Size = new System.Drawing.Size(76, 29);
            this.LblBookID.TabIndex = 20;
            this.LblBookID.Text = "---------";
            // 
            // LblBarcode
            // 
            this.LblBarcode.AutoSize = true;
            this.LblBarcode.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBarcode.ForeColor = System.Drawing.Color.White;
            this.LblBarcode.Location = new System.Drawing.Point(249, 147);
            this.LblBarcode.Name = "LblBarcode";
            this.LblBarcode.Size = new System.Drawing.Size(76, 29);
            this.LblBarcode.TabIndex = 21;
            this.LblBarcode.Text = "---------";
            // 
            // LblBookTitle
            // 
            this.LblBookTitle.AutoSize = true;
            this.LblBookTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookTitle.ForeColor = System.Drawing.Color.White;
            this.LblBookTitle.Location = new System.Drawing.Point(249, 104);
            this.LblBookTitle.Name = "LblBookTitle";
            this.LblBookTitle.Size = new System.Drawing.Size(76, 29);
            this.LblBookTitle.TabIndex = 22;
            this.LblBookTitle.Text = "---------";
            // 
            // BookDataGridView
            // 
            this.BookDataGridView.AllowUserToAddRows = false;
            this.BookDataGridView.AllowUserToDeleteRows = false;
            this.BookDataGridView.AllowUserToResizeColumns = false;
            this.BookDataGridView.AllowUserToResizeRows = false;
            this.BookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGridView.Location = new System.Drawing.Point(35, 194);
            this.BookDataGridView.MultiSelect = false;
            this.BookDataGridView.Name = "BookDataGridView";
            this.BookDataGridView.ReadOnly = true;
            this.BookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDataGridView.Size = new System.Drawing.Size(963, 293);
            this.BookDataGridView.TabIndex = 23;
            this.BookDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDataGridView_CellClick);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(30, 519);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(87, 29);
            this.bunifuCustomLabel5.TabIndex = 26;
            this.bunifuCustomLabel5.Text = "Search:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(123, 507);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(423, 31);
            this.TxtSearch.TabIndex = 27;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
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
            this.TxtRefresh.Location = new System.Drawing.Point(732, 512);
            this.TxtRefresh.Name = "TxtRefresh";
            this.TxtRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.TxtRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.TxtRefresh.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtRefresh.selected = false;
            this.TxtRefresh.Size = new System.Drawing.Size(146, 39);
            this.TxtRefresh.TabIndex = 38;
            this.TxtRefresh.Text = "Refresh List";
            this.TxtRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TxtRefresh.Textcolor = System.Drawing.Color.White;
            this.TxtRefresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRefresh.Click += new System.EventHandler(this.TxtRefresh_Click);
            // 
            // BtnIssue
            // 
            this.BtnIssue.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIssue.BorderRadius = 0;
            this.BtnIssue.ButtonText = "Assign Borrower";
            this.BtnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIssue.DisabledColor = System.Drawing.Color.Gray;
            this.BtnIssue.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnIssue.Iconimage = global::LMS.SAD.Properties.Resources.box_important_80px;
            this.BtnIssue.Iconimage_right = null;
            this.BtnIssue.Iconimage_right_Selected = null;
            this.BtnIssue.Iconimage_Selected = null;
            this.BtnIssue.IconMarginLeft = 25;
            this.BtnIssue.IconMarginRight = 0;
            this.BtnIssue.IconRightVisible = true;
            this.BtnIssue.IconRightZoom = 0D;
            this.BtnIssue.IconVisible = true;
            this.BtnIssue.IconZoom = 60D;
            this.BtnIssue.IsTab = false;
            this.BtnIssue.Location = new System.Drawing.Point(781, 53);
            this.BtnIssue.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIssue.Name = "BtnIssue";
            this.BtnIssue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnIssue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnIssue.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnIssue.selected = false;
            this.BtnIssue.Size = new System.Drawing.Size(182, 39);
            this.BtnIssue.TabIndex = 25;
            this.BtnIssue.Text = "Assign Borrower";
            this.BtnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnIssue.Textcolor = System.Drawing.Color.White;
            this.BtnIssue.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIssue.Click += new System.EventHandler(this.BtnIssue_Click);
            // 
            // BookIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1027, 576);
            this.Controls.Add(this.TxtRefresh);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.BtnIssue);
            this.Controls.Add(this.BookDataGridView);
            this.Controls.Add(this.LblBookTitle);
            this.Controls.Add(this.LblBarcode);
            this.Controls.Add(this.LblBookID);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookIssue";
            this.Text = "BookIssue";
            this.Load += new System.EventHandler(this.BookIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel LblBookID;
        private Bunifu.Framework.UI.BunifuCustomLabel LblBarcode;
        private Bunifu.Framework.UI.BunifuCustomLabel LblBookTitle;
        private Bunifu.Framework.UI.BunifuFlatButton BtnIssue;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TextBox TxtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton TxtRefresh;
        public System.Windows.Forms.DataGridView BookDataGridView;
    }
}