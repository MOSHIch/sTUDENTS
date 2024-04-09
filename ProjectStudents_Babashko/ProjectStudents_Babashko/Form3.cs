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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rP32BABZASTStudDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rP32BABZASTStudDataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.rP32BABZASTStudDataSet.Специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rP32BABZASTStudDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.rP32BABZASTStudDataSet.Студенты);

        }

        private void адресLabel_Click(object sender, EventArgs e)
        {

        }

        private void адресTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void паспортные_данныеTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void телефонLabel_Click(object sender, EventArgs e)
        {

        }

        private void телефонTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void курсLabel_Click(object sender, EventArgs e)
        {

        }

        private void курсTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void код_специальностиLabel_Click(object sender, EventArgs e)
        {

        }

        private void код_специальностиTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            студентыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rP32BABZASTStudDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }
    }
}
