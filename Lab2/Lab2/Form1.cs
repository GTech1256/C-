using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HelloGit");
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.MdiParent = this;
            form.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void линейнаяЗадачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aBox = new AboutBox1();
            aBox.MdiParent = this;
            aBox.Show();
        }
    }
}
