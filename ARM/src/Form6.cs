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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void picture()
        {
            byte[] a = (byte[])dataGridView1.CurrentRow.Cells[29].Value;
            Image image;
            System.IO.MemoryStream memImage = new System.IO.MemoryStream(a);
            image = Image.FromStream(memImage);
            memImage.Close();
            pictureBox1.Image = image;
        }

        private void Fill()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            if (textBox11.Text != "")
                textBox12.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[11].Value.ToString()).ToShortDateString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox14.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox15.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            textBox16.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox17.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox18.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            if(textBox18.Text != "")
                textBox19.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[18].Value.ToString()).ToShortDateString();
            textBox20.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            textBox21.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            textBox22.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            textBox23.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            textBox24.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
            textBox25.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
            textBox26.Text = dataGridView1.CurrentRow.Cells[25].Value.ToString();
            textBox27.Text = dataGridView1.CurrentRow.Cells[26].Value.ToString();
            textBox28.Text = dataGridView1.CurrentRow.Cells[27].Value.ToString();
            textBox29.Text = dataGridView1.CurrentRow.Cells[28].Value.ToString();
            if(textBox29.Text != "")
                picture();
            else
                pictureBox1.Load("Photo/empty.bmp");
        }

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
            if (textBox7.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label7.Text);
                textBox7.Undo();
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label8.Text);
                textBox8.Undo();
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label9.Text);
                textBox9.Undo();
            }
            if (textBox10.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label10.Text);
                textBox10.Undo();
            }
            if (textBox11.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label11.Text);
                textBox11.Undo();
            }
            if (textBox12.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label12.Text);
                textBox12.Undo();
            }
            if (textBox13.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label13.Text);
                textBox13.Undo();
            }
            if (textBox14.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label14.Text);
                textBox14.Undo();
            }
            if (textBox15.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label15.Text);
                textBox15.Undo();
            }
            if (textBox16.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label16.Text);
                textBox16.Undo();
            }
            if (textBox17.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label17.Text);
                textBox17.Undo();
            }
            if (textBox18.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label18.Text);
                textBox18.Undo();
            }
            if (textBox19.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label19.Text);
                textBox19.Undo();
            }
            if (textBox20.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label20.Text);
                textBox20.Undo();
            }
            if (textBox21.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label21.Text);
                textBox21.Undo();
            }
            if (textBox22.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label22.Text);
                textBox22.Undo();
            }
            if (textBox23.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label23.Text);
                textBox23.Undo();
            }
            if (textBox24.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label24.Text);
                textBox24.Undo();
            }
            if (textBox25.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label25.Text);
                textBox25.Undo();
            }
            if (textBox26.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label26.Text);
                textBox26.Undo();
            }
            if (textBox27.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label27.Text);
                textBox27.Undo();
            }
            if (textBox28.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label28.Text);
                textBox28.Undo();
            }
            if (textBox29.Text == "")
            {
                MessageBox.Show("Не введены данные в поле " + label29.Text);
                textBox29.Undo();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Информация_о_сотрудниках". При необходимости она может быть перемещена или удалена.
            this.информация_о_сотрудникахTableAdapter.Fill(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
            Fill();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            clear();
            Fill();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            clear();
            Fill();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            clear();
            Fill();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            clear();
            Fill();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog(this) == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            dataGridView1.CurrentRow.Cells[29].Value = pictureBox1.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
            string count;
            count = bindingNavigatorPositionItem.Text;
            int count2 = Convert.ToInt32(count);
            if (count2 >= 1)
            {
                ReFill();
                this.информация_о_сотрудникахTableAdapter.Update(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
                int index = dataGridView1.CurrentRow.Index;
                index++;
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index];
                index--;
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index];
                this.информация_о_сотрудникахTableAdapter.Update(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
            }
            else
            {
                clear();
                this.информация_о_сотрудникахTableAdapter.Update(this.бД_отдела_кадровDataSet.Информация_о_сотрудниках);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Form6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) 
                return;
            MessageBox.Show("Разрешен ввод только цифр!");
            e.Handled = true;
            return;
        }
    }
}
