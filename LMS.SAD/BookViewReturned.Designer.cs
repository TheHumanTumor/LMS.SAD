namespace LMS.SAD
{
    partial class BookViewReturned
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
            this.BookDataGridView = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnView = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookDataGridView
            // 
            this.BookDataGridView.AllowUserToAddRows = false;
            this.BookDataGridView.AllowUserToDeleteRows = false;
            this.BookDataGridView.AllowUserToResizeColumns = false;
            this.BookDataGridView.AllowUserToResizeRows = false;
            this.BookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGridView.Location = new System.Drawing.Point(32, 125);
            this.BookDataGridView.MultiSelect = false;
            this.BookDataGridView.Name = "BookDataGridView";
            this.BookDataGridView.ReadOnly = true;
            this.BookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDataGridView.Size = new System.Drawing.Size(967, 360);
            this.BookDataGridView.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(588, 82);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(82, 29);
            this.bunifuCustomLabel2.TabIndex = 54;
            this.bunifuCustomLabel2.Text = "Status:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Returned",
            "Not Yet Returned"});
            this.comboBox1.Location = new System.Drawing.Point(676, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 27);
            this.comboBox1.TabIndex = 53;
            // 
            // BtnView
            // 
            this.BtnView.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnView.BorderRadius = 0;
            this.BtnView.ButtonText = "View";
            this.BtnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnView.DisabledColor = System.Drawing.Color.Gray;
            this.BtnView.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnView.Iconimage = null;
            this.BtnView.Iconimage_right = null;
            this.BtnView.Iconimage_right_Selected = null;
            this.BtnView.Iconimage_Selected = null;
            this.BtnView.IconMarginLeft = 0;
            this.BtnView.IconMarginRight = 0;
            this.BtnView.IconRightVisible = true;
            this.BtnView.IconRightZoom = 0D;
            this.BtnView.IconVisible = true;
            this.BtnView.IconZoom = 90D;
            this.BtnView.IsTab = false;
            this.BtnView.Location = new System.Drawing.Point(828, 65);
            this.BtnView.Name = "BtnView";
            this.BtnView.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnView.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnView.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnView.selected = false;
            this.BtnView.Size = new System.Drawing.Size(162, 44);
            this.BtnView.TabIndex = 52;
            this.BtnView.Text = "View";
            this.BtnView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnView.Textcolor = System.Drawing.Color.White;
            this.BtnView.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRefresh.BorderRadius = 0;
            this.BtnRefresh.ButtonText = "Refresh";
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRefresh.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRefresh.Iconimage = null;
            this.BtnRefresh.Iconimage_right = null;
            this.BtnRefresh.Iconimage_right_Selected = null;
            this.BtnRefresh.Iconimage_Selected = null;
            this.BtnRefresh.IconMarginLeft = 0;
            this.BtnRefresh.IconMarginRight = 0;
            this.BtnRefresh.IconRightVisible = true;
            this.BtnRefresh.IconRightZoom = 0D;
            this.BtnRefresh.IconVisible = true;
            this.BtnRefresh.IconZoom = 90D;
            this.BtnRefresh.IsTab = false;
            this.BtnRefresh.Location = new System.Drawing.Point(660, 505);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnRefresh.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnRefresh.selected = false;
            this.BtnRefresh.Size = new System.Drawing.Size(162, 44);
            this.BtnRefresh.TabIndex = 55;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRefresh.Textcolor = System.Drawing.Color.White;
            this.BtnRefresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 65);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(248, 39);
            this.bunifuCustomLabel1.TabIndex = 56;
            this.bunifuCustomLabel1.Text = "View Book Status";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(355, 507);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(284, 37);
            this.TxtSearch.TabIndex = 58;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(161, 510);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(188, 29);
            this.bunifuCustomLabel9.TabIndex = 57;
            this.bunifuCustomLabel9.Text = "Search Borrower:";
            // 
            // BookViewReturned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1027, 576);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.BookDataGridView);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookViewReturned";
            this.Text = "BookViewReturned";
            this.Load += new System.EventHandler(this.BookViewReturned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BookDataGridView;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnView;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRefresh;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox TxtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
    }
}