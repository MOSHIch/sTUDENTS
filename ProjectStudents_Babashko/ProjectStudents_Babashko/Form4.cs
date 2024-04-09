using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectStudents_Babashko
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rP32BABZASTStudDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rP32BABZASTStudDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.rP32BABZASTStudDataSet.Оценки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            средний_баллTextBox.Text = Convert.ToString((Convert.ToDouble(оценка_1TextBox.Text) + Convert.ToDouble(оценка_2TextBox.Text) + Convert.ToDouble(оценка_3TextBox.Text)) / 3.0);
        }
    }
}
