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

namespace WindowsFormsApplication1
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
                int n = Convert.ToInt32(textBox1.Text);
                int[] nums = new int[n];
                string[] num = textBox2.Text.Split(' ');
                if (num.Length > n) MessageBox.Show("Данные буду урезаны!!!");
                for (int i = 0; i < n; i++)
                {
                    nums[i] = Convert.ToInt32(num[i]);
                }
                StreamWriter sw = new StreamWriter("./res.dat");
                for (int i = 0; i < n; i++)
                {
                    if (nums[i] % 2 == 0) sw.WriteLine(nums[i]);
                }
                sw.Close();


                textBox3.Text = "";
                StreamReader sr = new StreamReader("./res.dat");
                string line = sr.ReadLine();
                while (line != null)
                {
                    textBox3.Text += line + " ";
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных!!!");
            }
        }
    }
}

