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
using System.Diagnostics;

namespace VkAPITutorial
{
    public partial class Form1 : Form
    {
        public dynamic familia;
        public dynamic test;
        public Form1()
        {
            InitializeComponent();
        }

        private void проверкаДрузейВВконтактеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm GetToken = new MainForm(IDVK.Text, true);
            GetToken.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void perenos(dynamic t, dynamic c)
        {
            familia = t;
            test = c;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "00.00.0000";
            
                }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm GetToken = new MainForm(IDVK.Text,true);
            GetToken.ShowDialog();
        }

        private void проверкаЧерезЧерныйСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // BDTER BD = new BDTER(Imya.Text, Family.Text, Otchestvo.Text, maskedTextBox1.Text);
            //BD.ShowDialog();
            // BD.Visible = false;
           Form3 Proverka = new Form3(Imya.Text, Family.Text, Otchestvo.Text, maskedTextBox1.Text);
            Proverka.ShowDialog();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Imya.Text = "";
            Family.Text = "";
            Otchestvo.Text = "";
            maskedTextBox1.Text = "";
            IDVK.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Proverka = new Form3(Imya.Text, Family.Text, Otchestvo.Text, maskedTextBox1.Text);
            Proverka.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AuthorizationForm GetToken = new AuthorizationForm();
            GetToken.ShowDialog();
        }
        public string BD, CV;
        private void button5_Click(object sender, EventArgs e)
        {
            bool cs;
            BD = "" + maskedTextBox1.Text[0] + maskedTextBox1.Text[1] + "." + maskedTextBox1.Text[3] + maskedTextBox1.Text[4] + "." + maskedTextBox1.Text[6] + maskedTextBox1.Text[7] + maskedTextBox1.Text[8] + maskedTextBox1.Text[9];
            MainForm fa = new MainForm(IDVK.Text, false);
            fa.ShowDialog();
            cs = fa.Prof(Imya.Text, Family.Text, BD);
            StreamReader ControlInf = new StreamReader("UserInf4.txt");
            CV = ControlInf.ReadLine();
            if (cs == false &&
                ((checkBox3.Checked && checkBox6.Checked == false) || checkBox4.Checked)
                && Convert.ToInt32(CV) < 2 &&
                Convert.ToInt32(textBox5.Text) < 1 &&
                comboBox1.Text == "Высшее" &&
               (comboBox2.Text == "Годен, служил"|| comboBox2.Text == "Не годен") &&
               comboBox3.Text == "Хорошее" &&
               checkBox8.Checked == false &&
               checkBox9.Checked == false &&
               checkBox10.Checked &&
               checkBox11.Checked == false &&
               checkBox12.Checked == false)
            {
                Form4 fm = new Form4(1);
                fm.ShowDialog();

            }
            else if (cs == false &&
                ((checkBox3.Checked && checkBox6.Checked == false)|| (checkBox5.Checked && checkBox6.Checked == false) || checkBox4.Checked|| (checkBox3.Checked && checkBox6.Checked&&Convert.ToInt32(textBox4.Text)<2)|| (checkBox5.Checked && checkBox6.Checked && Convert.ToInt32(textBox4.Text)<2)) &&
                Convert.ToInt32(textBox5.Text) < 9 &&
                (comboBox1.Text == "Высшее"|| comboBox1.Text == "Среднее") &&
               (comboBox3.Text == "Хорошее"|| comboBox3.Text == "Удовлетворительное") &&
               checkBox8.Checked == false &&
               checkBox11.Checked == false)
            {
                Form4 fm = new Form4(2);
                fm.ShowDialog();
            }
            else
            {
                Form4 fm = new Form4(3);
                fm.ShowDialog();

            }
        }
        public string ga;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Text = "Холост";
                checkBox4.Text = "Женат";
                checkBox5.Text = "Разведен";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Text = "Не замужем";
                checkBox4.Text = "Замужем";
                checkBox5.Text = "Разведена";
                checkBox3.Font = new Font( "Times New Roman", 9);
                checkBox4.Font = new Font("Times New Roman", 9);
                checkBox5.Font = new Font("Times New Roman", 9);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked)
            {
                label8.Visible = true;
                textBox4.Visible = true;
            }
            else
            {
                label8.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Process.Start("Анкета.doc");

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("INFO.docx");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Family.Text = ga;
        }
    }
}
