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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "БД_отдела_кадровDataSet.Информация_о_сотрудниках". При необходимости она может быть перемещена или удалена.
            this.Информация_о_сотрудникахTableAdapter.Fill(this.БД_отдела_кадровDataSet.Информация_о_сотрудниках);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Dispose();
            Close();
        }
    }
}
