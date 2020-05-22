namespace LMS.SAD
{
    partial class BookEdit
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
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BookDataGridView = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnUpdateBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBookTitle = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtBookAuthor = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtBookCategory = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtBookPublisher = new System.Windows.Forms.TextBox();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.TxtBarcode = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(82, 520);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(284, 29);
            this.TxtSearch.TabIndex = 27;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(78, 493);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(112, 23);
            this.bunifuCustomLabel8.TabIndex = 26;
            this.bunifuCustomLabel8.Text = "Search Book:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(20, 12);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(137, 39);
            this.bunifuCustomLabel7.TabIndex = 25;
            this.bunifuCustomLabel7.Text = "Book List";
            // 
            // BookDataGridView
            // 
            this.BookDataGridView.AllowUserToAddRows = false;
            this.BookDataGridView.AllowUserToDeleteRows = false;
            this.BookDataGridView.AllowUserToResizeColumns = false;
            this.BookDataGridView.AllowUserToResizeRows = false;
            this.BookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGridView.Location = new System.Drawing.Point(27, 61);
            this.BookDataGridView.MultiSelect = false;
            this.BookDataGridView.Name = "BookDataGridView";
            this.BookDataGridView.ReadOnly = true;
            this.BookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDataGridView.Size = new System.Drawing.Size(541, 410);
            this.BookDataGridView.TabIndex = 24;
            this.BookDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDataGridView_CellClick);
            this.BookDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.BookDataGridView_DataBindingComplete);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(587, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(242, 39);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "Edit Book Details";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(19, 100);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(95, 23);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Book Title:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(19, 183);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(115, 23);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Book Author:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(19, 266);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(125, 23);
            this.bunifuCustomLabel5.TabIndex = 7;
            this.bunifuCustomLabel5.Text = "Book Category";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(19, 345);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(129, 23);
            this.bunifuCustomLabel6.TabIndex = 8;
            this.bunifuCustomLabel6.Text = "Book Publisher";
            // 
            // BtnUpdateBook
            // 
            this.BtnUpdateBook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnUpdateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.BtnUpdateBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdateBook.BorderRadius = 0;
            this.BtnUpdateBook.ButtonText = "Update Details";
            this.BtnUpdateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateBook.DisabledColor = System.Drawing.Color.Gray;
            this.BtnUpdateBook.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnUpdateBook.Iconimage = null;
            this.BtnUpdateBook.Iconimage_right = null;
            this.BtnUpdateBook.Iconimage_right_Selected = null;
            this.BtnUpdateBook.Iconimage_Selected = null;
            this.BtnUpdateBook.IconMarginLeft = 0;
            this.BtnUpdateBook.IconMarginRight = 0;
            this.BtnUpdateBook.IconRightVisible = true;
            this.BtnUpdateBook.IconRightZoom = 0D;
            this.BtnUpdateBook.IconVisible = true;
            this.BtnUpdateBook.IconZoom = 90D;
            this.BtnUpdateBook.IsTab = false;
            this.BtnUpdateBook.Location = new System.Drawing.Point(40, 432);
            this.BtnUpdateBook.Name = "BtnUpdateBook";
            this.BtnUpdateBook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.BtnUpdateBook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnUpdateBook.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnUpdateBook.selected = false;
            this.BtnUpdateBook.Size = new System.Drawing.Size(156, 41);
            this.BtnUpdateBook.TabIndex = 4;
            this.BtnUpdateBook.Text = "Update Details";
            this.BtnUpdateBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnUpdateBook.Textcolor = System.Drawing.Color.White;
            this.BtnUpdateBook.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClear.BorderRadius = 0;
            this.BtnClear.ButtonText = "Clear";
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.DisabledColor = System.Drawing.Color.Gray;
            this.BtnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnClear.Iconimage = null;
            this.BtnClear.Iconimage_right = null;
            this.BtnClear.Iconimage_right_Selected = null;
            this.BtnClear.Iconimage_Selected = null;
            this.BtnClear.IconMarginLeft = 0;
            this.BtnClear.IconMarginRight = 0;
            this.BtnClear.IconRightVisible = true;
            this.BtnClear.IconRightZoom = 0D;
            this.BtnClear.IconVisible = true;
            this.BtnClear.IconZoom = 90D;
            this.BtnClear.IsTab = false;
            this.BtnClear.Location = new System.Drawing.Point(214, 432);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.BtnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnClear.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnClear.selected = false;
            this.BtnClear.Size = new System.Drawing.Size(156, 41);
            this.BtnClear.TabIndex = 21;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnClear.Textcolor = System.Drawing.Color.White;
            this.BtnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(63, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 1);
            this.panel1.TabIndex = 22;
            // 
            // TxtBookTitle
            // 
            this.TxtBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TxtBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookTitle.Location = new System.Drawing.Point(61, 138);
            this.TxtBookTitle.Name = "TxtBookTitle";
            this.TxtBookTitle.Size = new System.Drawing.Size(294, 22);
            this.TxtBookTitle.TabIndex = 23;
            this.TxtBookTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(63, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 1);
            this.panel3.TabIndex = 24;
            // 
            // TxtBookAuthor
            // 
            this.TxtBookAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TxtBookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookAuthor.Location = new System.Drawing.Point(61, 219);
            this.TxtBookAuthor.Name = "TxtBookAuthor";
            this.TxtBookAuthor.Size = new System.Drawing.Size(294, 22);
            this.TxtBookAuthor.TabIndex = 25;
            this.TxtBookAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(63, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 1);
            this.panel4.TabIndex = 26;
            // 
            // TxtBookCategory
            // 
            this.TxtBookCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TxtBookCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookCategory.Location = new System.Drawing.Point(61, 302);
            this.TxtBookCategory.Name = "TxtBookCategory";
            this.TxtBookCategory.Size = new System.Drawing.Size(294, 22);
            this.TxtBookCategory.TabIndex = 27;
            this.TxtBookCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(63, 407);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 1);
            this.panel5.TabIndex = 28;
            // 
            // TxtBookPublisher
            // 
            this.TxtBookPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TxtBookPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookPublisher.Location = new System.Drawing.Point(61, 379);
            this.TxtBookPublisher.Name = "TxtBookPublisher";
            this.TxtBookPublisher.Size = new System.Drawing.Size(294, 22);
            this.TxtBookPublisher.TabIndex = 29;
            this.TxtBookPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.PanelAdd.Controls.Add(this.TxtBookPublisher);
            this.PanelAdd.Controls.Add(this.panel5);
            this.PanelAdd.Controls.Add(this.TxtBookCategory);
            this.PanelAdd.Controls.Add(this.panel4);
            this.PanelAdd.Controls.Add(this.TxtBookAuthor);
            this.PanelAdd.Controls.Add(this.panel3);
            this.PanelAdd.Controls.Add(this.TxtBookTitle);
            this.PanelAdd.Controls.Add(this.panel1);
            this.PanelAdd.Controls.Add(this.BtnClear);
            this.PanelAdd.Controls.Add(this.BtnUpdateBook);
            this.PanelAdd.Controls.Add(this.TxtBarcode);
            this.PanelAdd.Controls.Add(this.panel2);
            this.PanelAdd.Controls.Add(this.bunifuCustomLabel6);
            this.PanelAdd.Controls.Add(this.bunifuCustomLabel5);
            this.PanelAdd.Controls.Add(this.bunifuCustomLabel4);
            this.PanelAdd.Controls.Add(this.bunifuCustomLabel3);
            this.PanelAdd.Controls.Add(this.bunifuCustomLabel2);
            this.PanelAdd.Location = new System.Drawing.Point(594, 61);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(407, 488);
            this.PanelAdd.TabIndex = 30;
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TxtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBarcode.Location = new System.Drawing.Point(61, 58);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.ReadOnly = true;
            this.TxtBarcode.Size = new System.Drawing.Size(294, 22);
            this.TxtBarcode.TabIndex = 12;
            this.TxtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(63, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 1);
            this.panel2.TabIndex = 11;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(19, 23);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(80, 23);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Barcode:";
            // 
            // TxtRefresh
            // 
            this.TxtRefresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TxtRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
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
            this.TxtRefresh.Location = new System.Drawing.Point(417, 520);
            this.TxtRefresh.Name = "TxtRefresh";
            this.TxtRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.TxtRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TxtRefresh.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtRefresh.selected = false;
            this.TxtRefresh.Size = new System.Drawing.Size(109, 29);
            this.TxtRefresh.TabIndex = 29;
            this.TxtRefresh.Text = "Refresh List";
            this.TxtRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TxtRefresh.Textcolor = System.Drawing.Color.White;
            this.TxtRefresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRefresh.Click += new System.EventHandler(this.TxtRefresh_Click);
            // 
            // BookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1027, 576);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.TxtRefresh);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.BookDataGridView);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookEdit";
            this.Text = "BookEdit";
            this.Load += new System.EventHandler(this.BookEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.DataGridView BookDataGridView;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuFlatButton BtnUpdateBook;
        private Bunifu.Framework.UI.BunifuFlatButton BtnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBookTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtBookAuthor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtBookCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TxtBookPublisher;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.TextBox TxtBarcode;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton TxtRefresh;
    }
}