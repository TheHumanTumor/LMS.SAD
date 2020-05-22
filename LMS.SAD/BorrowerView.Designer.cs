namespace LMS.SAD
{
    partial class BorrowerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowerView));
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BorrowerDataGridView = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblBorrowerRowCount = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(286, 509);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(423, 38);
            this.TxtSearch.TabIndex = 18;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(95, 512);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(188, 29);
            this.bunifuCustomLabel2.TabIndex = 17;
            this.bunifuCustomLabel2.Text = "Search Borrower:";
            // 
            // BorrowerDataGridView
            // 
            this.BorrowerDataGridView.AllowUserToAddRows = false;
            this.BorrowerDataGridView.AllowUserToDeleteRows = false;
            this.BorrowerDataGridView.AllowUserToResizeColumns = false;
            this.BorrowerDataGridView.AllowUserToResizeRows = false;
            this.BorrowerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrowerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BorrowerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowerDataGridView.Location = new System.Drawing.Point(35, 71);
            this.BorrowerDataGridView.MultiSelect = false;
            this.BorrowerDataGridView.Name = "BorrowerDataGridView";
            this.BorrowerDataGridView.ReadOnly = true;
            this.BorrowerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorrowerDataGridView.Size = new System.Drawing.Size(959, 419);
            this.BorrowerDataGridView.TabIndex = 16;
            this.BorrowerDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.BorrowerDataGridView_DataBindingComplete);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(28, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(195, 39);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "Borrower List";
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
            this.BtnRefresh.Location = new System.Drawing.Point(770, 509);
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
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(807, 29);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(133, 26);
            this.bunifuCustomLabel3.TabIndex = 22;
            this.bunifuCustomLabel3.Text = "Total Records:";
            // 
            // LblBorrowerRowCount
            // 
            this.LblBorrowerRowCount.AutoSize = true;
            this.LblBorrowerRowCount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBorrowerRowCount.ForeColor = System.Drawing.Color.White;
            this.LblBorrowerRowCount.Location = new System.Drawing.Point(933, 29);
            this.LblBorrowerRowCount.Name = "LblBorrowerRowCount";
            this.LblBorrowerRowCount.Size = new System.Drawing.Size(24, 26);
            this.LblBorrowerRowCount.TabIndex = 21;
            this.LblBorrowerRowCount.Text = "--";
            // 
            // BorrowerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1027, 576);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.LblBorrowerRowCount);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.BorrowerDataGridView);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BorrowerView";
            this.Text = "BorrowerView";
            this.Load += new System.EventHandler(this.BorrowerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BorrowerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnRefresh;
        private System.Windows.Forms.TextBox TxtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridView BorrowerDataGridView;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel LblBorrowerRowCount;
    }
}