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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 f20 = new Form20();
            f20.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Список приказов пуст! Заполните приказ для его изменения!");
            else
            {
                Form21 f21 = new Form21();
                f21.ShowDialog();
            }
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Информация_о_сотрудниках". При необходимости она может быть перемещена или удалена.
            this.информация_о_сотрудникахTableAdapter.Fill(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу". При необходимости она может быть перемещена или удалена.
            this.приказ_о_приеме_на_работуTableAdapter.Fill(this.бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    bindingNavigatorAddNewItem.PerformClick();
                    dataGridView2.CurrentRow.Cells[0].Value = dataGridView1.CurrentRow.Cells[0].Value;
                    dataGridView2.CurrentRow.Cells[1].Value = dataGridView1.CurrentRow.Cells[1].Value;
                    dataGridView2.CurrentRow.Cells[2].Value = dataGridView1.CurrentRow.Cells[2].Value;
                    dataGridView2.CurrentRow.Cells[7].Value = dataGridView1.CurrentRow.Cells[3].Value;
                    dataGridView2.CurrentRow.Cells[9].Value = dataGridView1.CurrentRow.Cells[9].Value;
                    this.информация_о_сотрудникахTableAdapter.Update(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
                    int index = dataGridView2.CurrentRow.Index;
                    index--;
                    dataGridView2.Rows[index].Selected = true;
                    dataGridView2.CurrentCell = dataGridView2[0, index];
                    index++;
                    dataGridView2.Rows[index].Selected = true;
                    dataGridView2.CurrentCell = dataGridView2[0, index];
                    this.информация_о_сотрудникахTableAdapter.Update(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                }
            this.приказ_о_приеме_на_работуTableAdapter.Update(this.бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу);
        }
    }
}
