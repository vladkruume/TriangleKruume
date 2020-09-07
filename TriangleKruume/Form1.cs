using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleKruume
{
    public partial class Form1 : Form
    {
        public int x;
        public Form1()
        {

            InitializeComponent();
            
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double a, b, c,h;
            if (radioButton1.Checked)
            {
                a = Convert.ToDouble(txtA.Text);
                h = Convert.ToDouble(txtH.Text);
                Triangle triangle = new Triangle(a, h);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Сторона h");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");
                listView1.Items[0].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(triangle.outputH());
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.SurfaceH()));
            }
            
            else if (radioButton2.Checked)
            {
                b = Convert.ToDouble(txtB.Text);
                h = Convert.ToDouble(txtH.Text);
                Triangle triangle = new Triangle(b, h);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Сторона h");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");
                listView1.Items[3].SubItems.Add(triangle.outputH());
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.SurfaceH()));
            }
            else if (radioButton3.Checked)
            {
                c = Convert.ToDouble(txtC.Text);
                h = Convert.ToDouble(txtH.Text);
                Triangle triangle = new Triangle(c, h);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Сторона h");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");

                listView1.Items[3].SubItems.Add(triangle.outputH());
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.SurfaceH()));
            }
            else
            {
                try
                {
                    a = Convert.ToDouble(txtA.Text);
                    b = Convert.ToDouble(txtB.Text);
                    c = Convert.ToDouble(txtC.Text);
                    Triangle triangle = new Triangle(a, b, c);
                    listView1.Items.Add("Сторона a");
                    listView1.Items.Add("Сторона b");
                    listView1.Items.Add("Сторона c");
                    listView1.Items.Add("Сторона h");
                    listView1.Items.Add("Периметр");
                    listView1.Items.Add("Площадь");
                    listView1.Items.Add("Существует?");
                    listView1.Items.Add("Спецификатор");
                    listView1.Items[0].SubItems.Add(triangle.outputĆ());
                    listView1.Items[1].SubItems.Add(triangle.outputB());
                    listView1.Items[2].SubItems.Add(triangle.outputC());
                    listView1.Items[3].SubItems.Add(triangle.outputH());
                    listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                    listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface()));
                    if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); }
                    else listView1.Items[6].SubItems.Add("Не существует");
                    if (triangle.ravnbedr) { listView1.Items[7].SubItems.Add("Равнобедренный"); pictureBox1.Image = Image.FromFile("ravnbedr.png"); }
                    if (triangle.ravn) { listView1.Items[7].SubItems.Add("Равносторонний"); pictureBox1.Image = Image.FromFile("ravn.png"); }
                    if (triangle.razn) { listView1.Items[7].SubItems.Add("Разносторонний"); pictureBox1.Image = Image.FromFile("razn.jpg"); }

                }
                catch (Exception)
                {
                    MessageBox.Show("Введите значение", " Ты Ошибка");
                }
            }
            
            var delimeteredListviewData = new List<string>();

            foreach (ListViewItem lvi in listView1.Items)
            {
                string delimeteredItems = string.Empty;
                foreach (ListViewItem.ListViewSubItem lvsi in lvi.SubItems)
                {
                    delimeteredItems += lvsi.Text + "#";
                }
                delimeteredListviewData.Add(delimeteredItems);
            }

            System.IO.File.WriteAllLines("input.txt", delimeteredListviewData.ToArray());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtB.Enabled = false;
            txtC.Enabled = false;
            txtA.Enabled = true;
            txtH.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtB.Enabled = true;
            txtC.Enabled = false;
            txtA.Enabled = false;
            txtH.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtB.Enabled = false;
            txtC.Enabled = true;
            txtA.Enabled = false;
            txtH.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtB.Enabled = true;
            txtC.Enabled = true;
            txtA.Enabled = true;
            txtH.Enabled = false;
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtH.Text = "";
            listView1.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
