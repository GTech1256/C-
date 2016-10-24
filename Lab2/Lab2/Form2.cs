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
            Save();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }

        void Remove()
        {
            DialogResult = MessageBox.Show("Удалить данные по сотруднику", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            switch (DialogResult)
            {
                case DialogResult.Yes:
                        //выполнить действия по удалению данных по сотруднику
                        MessageBox.Show("Удаление данных");
                        break;
                case DialogResult.No:
                    MessageBox.Show("Отмена удаления данных");
                    break;
            }
        }

        void Save()
        { 
            DialogResult = MessageBox.Show("Во время сохранения произошла ошибка", "Сохранить", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            switch (DialogResult)
            {
                case DialogResult.Abort:
                    //выполнить действия по удалению данных по сотруднику
                    MessageBox.Show("Abort");
                    break;
                case DialogResult.Retry:
                    Save();
                    break;
                case DialogResult.Ignore:
                    //Nothing
                    break;
            }
        }
    }
}
