using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleKruume
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string line in System.IO.File.ReadAllLines("input.txt"))
            {
                listView1.Items.Add(new ListViewItem(line.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries)));
            }
        }
    }
}
