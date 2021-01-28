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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fill()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void ReFill()
        {
            dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
            dataGridView1.CurrentRow.Cells[4].Value = textBox5.Text;
            dataGridView1.CurrentRow.Cells[5].Value = textBox6.Text;
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Штатное_расписание". При необходимости она может быть перемещена или удалена.
            this.штатное_расписаниеTableAdapter.Fill(this.бД_отдела_кадровDataSet.Штатное_расписание);
            Fill();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void check()
        {
            // Проверка ввода информации
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label1.Text);
                textBox1.Undo();
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label2.Text);
                textBox2.Undo();
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label3.Text);
                textBox3.Undo();
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label4.Text);
                textBox4.Undo();
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label5.Text);
                textBox5.Undo();
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label6.Text);
                textBox6.Undo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check();
            string count;
            count = bindingNavigatorPositionItem.Text;
            int count2 = Convert.ToInt32(count);
            if (count2 >= 1)
            {
                ReFill();
                this.штатное_расписаниеTableAdapter.Update(this.бД_отдела_кадровDataSet.Штатное_расписание);
                int index = dataGridView1.CurrentRow.Index;
                index++;
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index];
                index--;
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index];
                this.штатное_расписаниеTableAdapter.Update(this.бД_отдела_кадровDataSet.Штатное_расписание);
            }
            else
            {
                this.штатное_расписаниеTableAdapter.Update(this.бД_отдела_кадровDataSet.Штатное_расписание);
                clear();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string count;
            count = bindingNavigatorPositionItem.Text;
            int count2 = Convert.ToInt32(count);
            if (count2 >= 1)
                Fill();
            else
            {
                clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) 
                return;
            MessageBox.Show("Разрешен ввод только букв!");
            e.Handled = true;
            return;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) 
                return;
            MessageBox.Show("Разрешен ввод только цифр!");
            e.Handled = true;
            return;
        }
    }
}
