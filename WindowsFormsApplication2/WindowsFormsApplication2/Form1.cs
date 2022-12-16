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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("./res.txt");
                string line = sr.ReadLine();
                string result = line;
                int n = line.Length;
                while (line != null)
                {
                    if (line.Length > n)
                    {
                        result = line;
                        n = line.Length;
                    }
                    line = sr.ReadLine();
                }
                textBox1.Text = result;
                textBox2.Text = n.ToString();
                sr.Close();

            }
            catch { MessageBox.Show("Файл не найден!!!"); }
        }
    }
}
