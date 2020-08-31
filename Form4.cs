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
using Newtonsoft.Json;
using xNet;

namespace VkAPITutorial
{
    public partial class Form4 : Form
    {
        public int res1;
        public Form4(int res)
        {
            res1 = res;
            InitializeComponent();
        }




        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (res1 == 1)
            {
                label1.Text = "Кандидат обладает признаками благонадежности! \n Рекомендуется к принятию на работу.";
                pictureBox1.Visible = true;
            }
            else if (res1 == 2)
            {
                label1.Text = "Кандидат обладает не всеми признаками благонадежности! \n Рекомендуется более детальный анализ.";
                pictureBox2.Visible = true;
            }
            else 
            {
                label1.Text = "Кандидат не обладает признаками благонадежности! \n Рекомендуется отказать кандидату в должности.";
                pictureBox3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
