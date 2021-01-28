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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Информация о сотрудниках нету! Заполните информацию о сотрудниках!");
            else
            {
                Form6 f6 = new Form6();
                f6.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Информация_о_сотрудниках". При необходимости она может быть перемещена или удалена.
            this.информация_о_сотрудникахTableAdapter.Fill(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
        }
    }
}
