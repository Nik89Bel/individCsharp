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
            string but = clickedbutton.Name.ToString();
            int i = int.Parse(but.Substring(6));
            string tboxname = "textBox" + i;
            TextBox tbox = this.Controls.Find(tboxname, true).FirstOrDefault() as TextBox;
            string lboxname;
            if (i < 7)
                lboxname = "listBox" + i;
            else
                lboxname = "listBox" + (i - 6);
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
            }
        }

        private void add_task_in_tbox(object sender, EventArgs e)
        {
            TextBox clickedbox = (TextBox)sender;
            clickedbox.Clear();
        }
    }
}
