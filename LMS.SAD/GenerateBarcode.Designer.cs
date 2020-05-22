namespace LMS.SAD
{
    partial class GenerateBarcode
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
            this.PicBarcode = new System.Windows.Forms.PictureBox();
            this.TxtBarcode = new System.Windows.Forms.TextBox();
            this.BtnGenerate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(263, 39);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Generate Barcode:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(235, 406);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(114, 33);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Barcode:";
            // 
            // PicBarcode
            // 
            this.PicBarcode.BackColor = System.Drawing.Color.DarkGray;
            this.PicBarcode.Location = new System.Drawing.Point(97, 104);
            this.PicBarcode.Name = "PicBarcode";
            this.PicBarcode.Size = new System.Drawing.Size(850, 278);
            this.PicBarcode.TabIndex = 3;
            this.PicBarcode.TabStop = false;
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.TxtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBarcode.Location = new System.Drawing.Point(369, 411);
            this.TxtBarcode.MaxLength = 13;
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.Size = new System.Drawing.Size(440, 29);
            this.TxtBarcode.TabIndex = 15;
            this.TxtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBarcode_KeyPress);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.BtnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGenerate.BorderRadius = 0;
            this.BtnGenerate.ButtonText = "Generate";
            this.BtnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerate.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGenerate.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGenerate.Iconimage = null;
            this.BtnGenerate.Iconimage_right = null;
            this.BtnGenerate.Iconimage_right_Selected = null;
            this.BtnGenerate.Iconimage_Selected = null;
            this.BtnGenerate.IconMarginLeft = 0;
            this.BtnGenerate.IconMarginRight = 0;
            this.BtnGenerate.IconRightVisible = true;
            this.BtnGenerate.IconRightZoom = 0D;
            this.BtnGenerate.IconVisible = true;
            this.BtnGenerate.IconZoom = 90D;
            this.BtnGenerate.IsTab = false;
            this.BtnGenerate.Location = new System.Drawing.Point(241, 471);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.BtnGenerate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnGenerate.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnGenerate.selected = false;
            this.BtnGenerate.Size = new System.Drawing.Size(156, 41);
            this.BtnGenerate.TabIndex = 17;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGenerate.Textcolor = System.Drawing.Color.White;
            this.BtnGenerate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSave.BorderRadius = 0;
            this.BtnSave.ButtonText = "Save";
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSave.Iconimage = null;
            this.BtnSave.Iconimage_right = null;
            this.BtnSave.Iconimage_right_Selected = null;
            this.BtnSave.Iconimage_Selected = null;
            this.BtnSave.IconMarginLeft = 0;
            this.BtnSave.IconMarginRight = 0;
            this.BtnSave.IconRightVisible = true;
            this.BtnSave.IconRightZoom = 0D;
            this.BtnSave.IconVisible = true;
            this.BtnSave.IconZoom = 90D;
            this.BtnSave.IsTab = false;
            this.BtnSave.Location = new System.Drawing.Point(653, 471);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnSave.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnSave.selected = false;
            this.BtnSave.Size = new System.Drawing.Size(156, 41);
            this.BtnSave.TabIndex = 18;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSave.Textcolor = System.Drawing.Color.White;
            this.BtnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.BtnClear.Location = new System.Drawing.Point(454, 471);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.BtnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnClear.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnClear.selected = false;
            this.BtnClear.Size = new System.Drawing.Size(156, 41);
            this.BtnClear.TabIndex = 19;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnClear.Textcolor = System.Drawing.Color.White;
            this.BtnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(203, 533);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(661, 19);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Note: ISBN barcodes must start with 978 and the length must be 9, 10, 12 or 13 ch" +
    "aracters only.";
            // 
            // GenerateBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1027, 576);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.TxtBarcode);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.PicBarcode);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "GenerateBarcode";
            this.Text = "GenerateBarcode";
            ((System.ComponentModel.ISupportInitialize)(this.PicBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox PicBarcode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox TxtBarcode;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGenerate;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSave;
        private Bunifu.Framework.UI.BunifuFlatButton BtnClear;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}