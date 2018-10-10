using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        Bitmap kaynak, islem;
        public Form7()
        {
            InitializeComponent();
        }

        private void aÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = kaynak;
            }
        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    int a, b;
                    Color renlirenk = kaynak.GetPixel(x, y);
                    if (renlirenk.R>renlirenk.G && renlirenk.R>renlirenk.B )
                    {
                        a = renlirenk.R;
                    }
                    else if (renlirenk.G>renlirenk.B)
                    {
                        a = renlirenk.G;
                    }
                    else
                    {
                        a = renlirenk.B;
                    }
                    if (renlirenk.R < renlirenk.G && renlirenk.R < renlirenk.B)
                    {
                        b = renlirenk.R;
                    }
                    else if (renlirenk.G < renlirenk.B)
                    {
                        b = renlirenk.G;
                    }
                    else
                    {
                        b = renlirenk.B;
                    }
                    int gri = (a+b) / 2;
                    Color grirenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, grirenk);
                }
            }
            pictureBox2.Image = islem;
        }
    }
}
