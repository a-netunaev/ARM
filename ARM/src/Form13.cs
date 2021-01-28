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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Список приказов пуст! Заполните приказ для его изменения!");
            else
            {
                Form17 f17 = new Form17();
                f17.ShowDialog();
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Приказ_на_отпуск". При необходимости она может быть перемещена или удалена.
            this.приказ_на_отпускTableAdapter.Fill(this.бД_отдела_кадровDataSet.Приказ_на_отпуск);
        }
    }
}
