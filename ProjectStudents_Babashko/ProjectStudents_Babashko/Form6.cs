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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rP32BABZASTStudDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.rP32BABZASTStudDataSet.Студенты);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn col = dataGridView1.Columns[listBox1.SelectedIndex];

            if (radioButton1.Checked)
                dataGridView1.Sort(col, ListSortDirection.Ascending);
            else
                dataGridView1.Sort(col, ListSortDirection.Descending);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "ФИО = '" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().IndexOf(textBox1.Text) > -1)
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.AliceBlue;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                        }
        

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

