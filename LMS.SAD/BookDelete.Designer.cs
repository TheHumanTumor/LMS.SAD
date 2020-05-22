namespace LMS.SAD
{
    partial class BookDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDelete));
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BookDataGridView = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(225, 498);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(423, 31);
            this.TxtSearch.TabIndex = 18;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(58, 494);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(161, 33);
            this.bunifuCustomLabel2.TabIndex = 17;
            this.bunifuCustomLabel2.Text = "Search Book:";
            // 
            // BookDataGridView
            // 
            this.BookDataGridView.AllowUserToAddRows = false;
            this.BookDataGridView.AllowUserToDeleteRows = false;
            this.BookDataGridView.AllowUserToResizeColumns = false;
            this.BookDataGridView.AllowUserToResizeRows = false;
            this.BookDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGridView.Location = new System.Drawing.Point(36, 65);
            this.BookDataGridView.MultiSelect = false;
            this.BookDataGridView.Name = "BookDataGridView";
            this.BookDataGridView.ReadOnly = true;
            this.BookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDataGridView.Size = new System.Drawing.Size(959, 419);
            this.BookDataGridView.TabIndex = 16;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(219, 39);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "Book Inventory";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRefresh.BorderRadius = 0;
            this.BtnRefresh.ButtonText = "Refresh List";
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRefresh.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRefresh.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Iconimage")));
            this.BtnRefresh.Iconimage_right = null;
            this.BtnRefresh.Iconimage_right_Selected = null;
            this.BtnRefresh.Iconimage_Selected = null;
            this.BtnRefresh.IconMarginLeft = 25;
            this.BtnRefresh.IconMarginRight = 0;
            this.BtnRefresh.IconRightVisible = true;
            this.BtnRefresh.IconRightZoom = 0D;
            this.BtnRefresh.IconVisible = true;
            this.BtnRefresh.IconZoom = 75D;
            this.BtnRefresh.IsTab = false;
            this.BtnRefresh.Location = new System.Drawing.Point(842, 494);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnRefresh.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnRefresh.selected = false;
            this.BtnRefresh.Size = new System.Drawing.Size(146, 39);
            this.BtnRefresh.TabIndex = 20;
            this.BtnRefresh.Text = "Refresh List";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefresh.Textcolor = System.Drawing.Color.White;
            this.BtnRefresh.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.BorderRadius = 0;
            this.BtnDelete.ButtonText = "Delete";
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDelete.Iconimage = global::LMS.SAD.Properties.Resources.trash_32px;
            this.BtnDelete.Iconimage_right = null;
            this.BtnDelete.Iconimage_right_Selected = null;
            this.BtnDelete.Iconimage_Selected = null;
            this.BtnDelete.IconMarginLeft = 25;
            this.BtnDelete.IconMarginRight = 0;
            this.BtnDelete.IconRightVisible = true;
            this.BtnDelete.IconRightZoom = 0D;
            this.BtnDelete.IconVisible = true;
            this.BtnDelete.IconZoom = 75D;
            this.BtnDelete.IsTab = false;
            this.BtnDelete.Location = new System.Drawing.Point(688, 494);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnDelete.selected = false;
            this.BtnDelete.Size = new System.Drawing.Size(146, 39);
            this.BtnDelete.TabIndex = 22;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Textcolor = System.Drawing.Color.White;
            this.BtnDelete.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BookDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1027, 576);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.BookDataGridView);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookDelete";
            this.Text = "BookDelete";
            this.Load += new System.EventHandler(this.BookDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnRefresh;
        private System.Windows.Forms.TextBox TxtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridView BookDataGridView;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDelete;
    }
}