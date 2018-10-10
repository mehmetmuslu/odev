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
    public partial class Form3 : Form
    {
        Bitmap kaynak,islem;
        public Form3()
        {
            InitializeComponent();
        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (sonuc==DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for(int y=0; y<yuk;y++)
            {
                for(int x=0;x<gen;x++)
                {
                    Color renlirenk = kaynak.GetPixel(x, y);
                    int gri = (renlirenk.R * 2125 + renlirenk.G * 7154 + renlirenk.B * 720) / 10000;
                    Color grirenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, grirenk);
                }
            }
            pictureBox2.Image = islem;
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
    }
}
