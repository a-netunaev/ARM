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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        Bitmap image = new Bitmap("Photo/empty.bmp");

        private void ReFill()
        {
            dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
            dataGridView1.CurrentRow.Cells[4].Value = textBox5.Text;
            dataGridView1.CurrentRow.Cells[5].Value = textBox6.Text;
            dataGridView1.CurrentRow.Cells[6].Value = textBox7.Text;
            dataGridView1.CurrentRow.Cells[7].Value = textBox8.Text;
            dataGridView1.CurrentRow.Cells[8].Value = textBox9.Text;
            dataGridView1.CurrentRow.Cells[9].Value = textBox10.Text;
            dataGridView1.CurrentRow.Cells[10].Value = textBox11.Text;
            dataGridView1.CurrentRow.Cells[11].Value = textBox12.Text;
            dataGridView1.CurrentRow.Cells[12].Value = textBox13.Text;
            dataGridView1.CurrentRow.Cells[13].Value = textBox14.Text;
            dataGridView1.CurrentRow.Cells[14].Value = textBox15.Text;
            dataGridView1.CurrentRow.Cells[15].Value = textBox16.Text;
            dataGridView1.CurrentRow.Cells[16].Value = textBox17.Text;
            dataGridView1.CurrentRow.Cells[17].Value = textBox18.Text;
            dataGridView1.CurrentRow.Cells[18].Value = textBox19.Text;
            dataGridView1.CurrentRow.Cells[19].Value = textBox20.Text;
            dataGridView1.CurrentRow.Cells[20].Value = textBox21.Text;
            dataGridView1.CurrentRow.Cells[21].Value = textBox22.Text;
            dataGridView1.CurrentRow.Cells[22].Value = textBox23.Text;
            dataGridView1.CurrentRow.Cells[23].Value = textBox24.Text;
            dataGridView1.CurrentRow.Cells[24].Value = textBox25.Text;
            dataGridView1.CurrentRow.Cells[25].Value = textBox26.Text;
            dataGridView1.CurrentRow.Cells[26].Value = textBox27.Text;
            dataGridView1.CurrentRow.Cells[27].Value = textBox28.Text;
            dataGridView1.CurrentRow.Cells[28].Value = textBox29.Text;
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Информация_о_сотрудниках". При необходимости она может быть перемещена или удалена.
            this.информация_о_сотрудникахTableAdapter.Fill(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
            bindingNavigatorAddNewItem.PerformClick();
            
            pictureBox1.Image = image;
        }

        private void check()
        {
            // Проверка ввода информации
            if (textBox1.Text == "")
                MessageBox.Show("Не введены данные в поле " + label1.Text);
            if (textBox2.Text == "")
                MessageBox.Show("Не введены данные в поле " + label2.Text);
            if (textBox3.Text == "")
                MessageBox.Show("Не введены данные в поле " + label3.Text);
            if (textBox4.Text == "")
                MessageBox.Show("Не введены данные в поле " + label4.Text);
            if (textBox5.Text == "")
                MessageBox.Show("Не введены данные в поле " + label5.Text);
            if (textBox6.Text == "")
                MessageBox.Show("Не введены данные в поле " + label6.Text);
            if (textBox7.Text == "")
                MessageBox.Show("Не введены данные в поле " + label7.Text);
            if (textBox8.Text == "")
                MessageBox.Show("Не введены данные в поле " + label8.Text);
            if (textBox9.Text == "")
                MessageBox.Show("Не введены данные в поле " + label9.Text);
            if (textBox10.Text == "")
                MessageBox.Show("Не введены данные в поле " + label10.Text);
            if (textBox11.Text == "")
                MessageBox.Show("Не введены данные в поле " + label11.Text);
            if (textBox12.Text == "")
                MessageBox.Show("Не введены данные в поле " + label12.Text);
            if (textBox13.Text == "")
                MessageBox.Show("Не введены данные в поле " + label13.Text);
            if (textBox14.Text == "")
                MessageBox.Show("Не введены данные в поле " + label14.Text);
            if (textBox15.Text == "")
                MessageBox.Show("Не введены данные в поле " + label15.Text);
            if (textBox16.Text == "")
                MessageBox.Show("Не введены данные в поле " + label16.Text);
            if (textBox17.Text == "")
                MessageBox.Show("Не введены данные в поле " + label17.Text);
            if (textBox18.Text == "")
                MessageBox.Show("Не введены данные в поле " + label18.Text);
            if (textBox19.Text == "")
                MessageBox.Show("Не введены данные в поле " + label19.Text);
            if (textBox20.Text == "")
                MessageBox.Show("Не введены данные в поле " + label20.Text);
            if (textBox21.Text == "")
                MessageBox.Show("Не введены данные в поле " + label21.Text);
            if (textBox22.Text == "")
                MessageBox.Show("Не введены данные в поле " + label22.Text);
            if (textBox23.Text == "")
                MessageBox.Show("Не введены данные в поле " + label23.Text);
            if (textBox24.Text == "")
                MessageBox.Show("Не введены данные в поле " + label24.Text);
            if (textBox25.Text == "")
                MessageBox.Show("Не введены данные в поле " + label25.Text);
            if (textBox26.Text == "")
                MessageBox.Show("Не введены данные в поле " + label26.Text);
            if (textBox27.Text == "")
                MessageBox.Show("Не введены данные в поле " + label27.Text);
            if (textBox28.Text == "")
                MessageBox.Show("Не введены данные в поле " + label28.Text);
            if (textBox29.Text == "")
                MessageBox.Show("Не введены данные в поле " + label29.Text);
            if (pictureBox1.Image == image)
                MessageBox.Show("Не выбрана фотография");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
            ReFill();
            this.информация_о_сотрудникахTableAdapter.Update(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
            int index = dataGridView1.CurrentRow.Index;
            index--;
            dataGridView1.Rows[index].Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, index];
            index++;
            dataGridView1.Rows[index].Selected = true;
            dataGridView1.CurrentCell = dataGridView1[0, index];
            this.информация_о_сотрудникахTableAdapter.Update(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
            bindingNavigatorAddNewItem.PerformClick();
            clear();
            pictureBox1.Image = image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog(this) == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            dataGridView1.CurrentRow.Cells[29].Value = pictureBox1.Image;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) 
                return;
            MessageBox.Show("Разрешен ввод только букв!");
            e.Handled = true;
            return;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) 
                return;
            MessageBox.Show("Разрешен ввод только цифр!");
            e.Handled = true;
            return;
        }
    }
}
