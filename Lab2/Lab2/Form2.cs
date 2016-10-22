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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Zagluska(object a)
        {
            MessageBox.Show(a.ToString());
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zagluska(sender);
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zagluska(sender);
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zagluska(sender);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zagluska(sender);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zagluska(sender);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zagluska(sender);
        }
    }
}
