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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Список приказов пуст! Заполните приказ для его изменения!");
            else
            {
                Form19 f19 = new Form19();
                f19.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Информация_о_сотрудниках". При необходимости она может быть перемещена или удалена.
            this.информация_о_сотрудникахTableAdapter.Fill(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Приказ_на_увольнение". При необходимости она может быть перемещена или удалена.
            this.приказ_на_увольнениеTableAdapter.Fill(this.бД_отдела_кадровDataSet.Приказ_на_увольнение);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while(dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string num = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                    textBox1.Text = num;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                }
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            dataGridView2.Rows.Remove(dataGridView2.Rows[i]);
                            this.информация_о_сотрудникахTableAdapter.Update(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
                            break;
                        }
            }
            this.приказ_на_увольнениеTableAdapter.Update(this.бД_отдела_кадровDataSet.Приказ_на_увольнение);
        }
    }
}
