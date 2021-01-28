using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace АРМ_менеджера_отдела_кадров
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Список вакансий пуст! Заполните вакансии для их изменения!");
            else
            {
                Form12 f12 = new Form12();
                f12.ShowDialog();
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Штатное_расписание". При необходимости она может быть перемещена или удалена.
            this.штатное_расписаниеTableAdapter.Fill(this.бД_отдела_кадровDataSet.Штатное_расписание);
        }
    }
}
