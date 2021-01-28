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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.ShowDialog();
        }
    }
}
