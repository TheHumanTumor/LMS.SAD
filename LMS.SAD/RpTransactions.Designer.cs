namespace LMS.SAD
{
    partial class RpTransactions
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
            this.RpViewerTransactions = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnView = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // RpViewerTransactions
            // 
            this.RpViewerTransactions.Location = new System.Drawing.Point(26, 94);
            this.RpViewerTransactions.Name = "RpViewerTransactions";
            this.RpViewerTransactions.ServerReport.BearerToken = null;
            this.RpViewerTransactions.Size = new System.Drawing.Size(668, 434);
            this.RpViewerTransactions.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(319, 39);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Assigned Books Report";
            // 
            // BtnView
            // 
            this.BtnView.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
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
            this.BtnView.Location = new System.Drawing.Point(797, 314);
            this.BtnView.Name = "BtnView";
            this.BtnView.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.BtnView.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnView.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnView.selected = false;
            this.BtnView.Size = new System.Drawing.Size(156, 41);
            this.BtnView.TabIndex = 9;
            this.BtnView.Text = "View";
            this.BtnView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnView.Textcolor = System.Drawing.Color.White;
            this.BtnView.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(725, 253);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(284, 37);
            this.TxtSearch.TabIndex = 58;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(720, 209);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(188, 29);
            this.bunifuCustomLabel9.TabIndex = 57;
            this.bunifuCustomLabel9.Text = "Search Borrower:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Returned",
            "Not Yet Returned"});
            this.comboBox1.Location = new System.Drawing.Point(725, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 31);
            this.comboBox1.TabIndex = 59;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(720, 104);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(118, 29);
            this.bunifuCustomLabel2.TabIndex = 60;
            this.bunifuCustomLabel2.Text = "Set Status:";
            // 
            // RpTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1027, 576);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.RpViewerTransactions);
            this.Name = "RpTransactions";
            this.Text = "RpTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpViewerTransactions;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnView;
        private System.Windows.Forms.TextBox TxtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}