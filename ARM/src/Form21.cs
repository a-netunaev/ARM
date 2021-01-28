using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace АРМ_менеджера_отдела_кадров
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fill()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()).ToShortDateString();
            textBox6.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()).ToShortDateString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString()).ToShortDateString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox11.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[10].Value.ToString()).ToShortDateString();
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
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу". При необходимости она может быть перемещена или удалена.
            this.приказ_о_приеме_на_работуTableAdapter.Fill(this.бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу". При необходимости она может быть перемещена или удалена.
            this.приказ_о_приеме_на_работуTableAdapter.Fill(this.бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу". При необходимости она может быть перемещена или удалена.
            this.приказ_о_приеме_на_работуTableAdapter.Fill(this.бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу);
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
                this.приказ_о_приеме_на_работуTableAdapter.Update(this.бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу);
                int index = dataGridView1.CurrentRow.Index;
                index++;
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index];
                index--;
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index];
                this.приказ_о_приеме_на_работуTableAdapter.Update(this.бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу);
            }
            else
            {
                clear();
                this.приказ_о_приеме_на_работуTableAdapter.Update(this.бД_отдела_кадровDataSet.Приказ_о_приеме_на_работу);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = "C:\\PrikaziH/priem.dotx";
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = new Document();
            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);
            foreach (Field myMergeField in wordDoc.Fields)
            {
                Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;
                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();
                    if (fieldName == "dat1")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(textBox11.Text);
                    }
                    if (fieldName == "dat2")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(textBox5.Text);
                    }
                    if (fieldName == "dat3")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(textBox6.Text);
                    }
                    if (fieldName == "FIO")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
                    }
                    if (fieldName == "dolzh")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(textBox4.Text);
                    }
                    if (fieldName == "isp")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(textBox9.Text);
                    }
                    if (fieldName == "osnovanie")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(textBox7.Text + " " + textBox8.Text);
                    }
                    if (fieldName == "TD")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(textBox10.Text);
                    }
                }
                wordDoc.SaveAs("C:\\Prikazi/priem" + textBox1.Text + textBox2.Text + textBox3.Text + ".doc");
                wordApp.Documents.Open("C:\\Prikazi/priem" + textBox1.Text + textBox2.Text + textBox3.Text + ".doc");
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
