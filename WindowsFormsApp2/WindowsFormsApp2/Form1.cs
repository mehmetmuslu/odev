using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rENKGETİRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 renkal = new Form2();
            renkal.ShowDialog();
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 bt = new Form3();
            bt.ShowDialog();
        }

        private void oRTALAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ort = new Form4();
            ort.ShowDialog();
        }

        private void kANALSIRALAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 kanal = new Form5();
            kanal.ShowDialog();
        }

        private void lUMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 luma = new Form6();
            luma.ShowDialog();
        }

        private void aÇIKLIKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 acıklık = new Form7();
            acıklık.ShowDialog();
        }
    }
}
