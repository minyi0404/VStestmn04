using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listView1.Items.Add(i + ".go");
                listView1.Items[listView1.Items.Count - 1].BackColor = Color.Gray;
                listView1.Items.Add("to");
                listView1.Items[listView1.Items.Count - 1].BackColor = Color.RoyalBlue;
                listView1.Items.Add("github");
                listView1.Items[listView1.Items.Count - 1].BackColor = Color.Wheat;
            }
        }
    }
}
