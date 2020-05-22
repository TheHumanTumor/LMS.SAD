using BarcodeLib;
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
    public partial class GenerateBarcode : Form
    {
        public GenerateBarcode()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            string latinchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (TxtBarcode.Text.Length <= 8)
                MessageBox.Show("The minimum character length accepted is 9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (TxtBarcode.Text.Contains(latinchars))
                MessageBox.Show("Please enter numbers only.");
            else if (TxtBarcode.Text.Length == 11)
                MessageBox.Show("The character length must be 9, 10, 12 or 13 only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (TxtBarcode.Text == "")
                MessageBox.Show("Please enter barcode number!", "Empty String", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (TxtBarcode.Text == "987")
                MessageBox.Show("The minimum character length accepted is 9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (TxtBarcode.Text.StartsWith("978"))
            {
                Barcode barcode = new Barcode();
                Color foreColor = Color.Black;
                Color backColor = Color.Transparent;
                Image img = barcode.Encode(TYPE.ISBN, TxtBarcode.Text, foreColor, backColor, (int)(PicBarcode.Width * 1.0), (int)(PicBarcode.Height * 1.0));
                PicBarcode.Image = img;
            }
            else
            {
                MessageBox.Show("ISBN Barcodes must begin with 978.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (PicBarcode.Image == null)
                return;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    PicBarcode.Image.Save(saveFileDialog.FileName);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBarcode.Clear();
            PicBarcode.Image = null;
        }

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
