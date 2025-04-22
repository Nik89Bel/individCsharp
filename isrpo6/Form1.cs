using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isrpo6
{
    public partial class Form1 : Form
    {
        int j = 0;
        public Form1()
        {
            InitializeComponent();
            label16.Text = DateTime.Now.ToString().Remove(11);
            label19.Text = label16.Text;
            label17.Text = DateTime.Today.DayOfWeek.ToString();
            label18.Text = label17.Text;
        }

        private void add_and_delete_task(object sender, EventArgs e)
        {
            Button clickedbutton = (Button)sender;
            string but = clickedbutton.Name.ToString(), tboxname = "", tboxname1 = "", lboxname = "";
            TextBox tbox = textBox1, tbox1 = textBox1;
            int i = int.Parse(but.Substring(6));
            if (i < 7)
            {
                tboxname = "textBox" + i;
                lboxname = "listBox" + i;
                tbox = this.Controls.Find(tboxname, true).FirstOrDefault() as TextBox;
            }
            else
            if (i < 13)
                lboxname = "listBox" + (i - 6);
            else
            if (i < 19)
            {
                tboxname1 = "textBox" + (i - 6);
                lboxname = "listBox" + (i - 6);
                tbox1 = this.Controls.Find(tboxname1, true).FirstOrDefault() as TextBox;
            }
            else
                lboxname = "listBox" + (i - 12);
            ListBox lbox = this.Controls.Find(lboxname, true).FirstOrDefault() as ListBox;
            switch (i)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:

                    if (tbox.Text != "Введите задачу" && tbox != null)
                    {
                        lbox.Items.Add(tbox.Text);
                        tbox.Text = "Введите задачу";
                    }
                    else
                        MessageBox.Show("Для начала введите новую задачу для добавления в список", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    if (lbox.SelectedIndex != -1)
                    {
                        lbox.Items.RemoveAt(lbox.SelectedIndex);
                    }
                    else
                        MessageBox.Show("Для начала выберите задачу для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    if (tbox1.Text != "Введите продукт" && tbox1 != null)
                    {
                        lbox.Items.Add(tbox1.Text);
                        tbox1.Text = "Введите продукт";
                    }
                    else
                        MessageBox.Show("Для начала введите новый продукт для добавления в список", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                    if (lbox.SelectedIndex != -1)
                    {
                        lbox.Items.RemoveAt(lbox.SelectedIndex);
                    }
                    else
                        MessageBox.Show("Для начала выберите продукт для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
            }
        }

        private void clear_tbox(object sender, EventArgs e)
        {
            TextBox clickedbox = (TextBox)sender;
            clickedbox.Clear();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Insert(j);
            dataGridView1[0, j].Value = dateTimePicker1.Value;
            dataGridView1[1, j].Value = numericUpDown1.Value;
            dataGridView1[2, j].Value = numericUpDown2.Value;
            dataGridView1[3, j].Value = numericUpDown3.Value;
            dataGridView1[4, j].Value = numericUpDown4.Value;
            j++;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
                MessageBox.Show("Для начала выберите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
