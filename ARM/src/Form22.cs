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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "БД_отдела_кадровDataSet.Приказ_на_отпуск". При необходимости она может быть перемещена или удалена.
            this.Приказ_на_отпускTableAdapter.Fill(this.БД_отдела_кадровDataSet.Приказ_на_отпуск);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Dispose();
            Close();
        }
    }
}
