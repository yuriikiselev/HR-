using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using xNet;


namespace VkAPITutorial
{
    public partial class MainForm : Form
    {
        VkAPI _ApiRequest;
        private string _Token;  //Токен, использующийся при запросах
        private string _UserId;  //ID пользователя
        private dynamic _Response;  //Ответ на запросы
        private dynamic _Response2;
        private dynamic _Response3;
        public string ID;

        public bool Prof(string first_name, string last_name, string bdat)
        {
            if (dataGridView1 != null)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    //dataGridView1.Rows[1].Selected = false;
                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                    {

                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(last_name)
                        || dataGridView1.Rows[i].Cells[4].Value.ToString().Contains(last_name))
                        {
                            if (dataGridView1.Rows[i].Cells[2].Value.ToString().Contains(first_name)
                            || dataGridView1.Rows[i].Cells[5].Value.ToString().Contains(first_name))
                            {
                                if (bdat != null)
                                {
                                    if (dataGridView1.Rows[i].Cells[7].Value.ToString().Contains(bdat))
                                    { return true; }
                                }
                                else
                                { return true; }

                            }

                        }

                    }

                }

            }
            return false;

        }
        public bool cheak;

        public MainForm(string ID2, bool ch)
        {
            cheak = ch;
            ID = ID2;
            InitializeComponent();
        }

        private void Button_GetToken_Click_1(object sender, EventArgs e)
        {
            AuthorizationForm GetToken = new AuthorizationForm();
            GetToken.ShowDialog();
        }
        public string t;
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            if (ID!="")
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных1DataSet.__Террористы_". При необходимости она может быть перемещена или удалена.
                this._Террористы_TableAdapter.Fill(this.база_данных1DataSet.@__Террористы_);
                string first_name; string last_name; string bdat;
                User_ID.Text = ID;
                StreamReader ControlInf = new StreamReader("UserInf.txt");
                _Token = ControlInf.ReadLine();
                ControlInf.Close();
                _ApiRequest = new VkAPI(_Token);
                _UserId = User_ID.Text;
                string[] Params = { "city", "country", "photo_max" };
                _Response = _ApiRequest.GetInformation(_UserId, Params);
                if (_Response != null)
                {
                    User_ID.Text = _UserId;
                    if (_Response["photo_max"] != null)
                        User_Photo.ImageLocation = _Response["photo_max"];
                    else
                        User_Photo.Text = "Не указана";
                    if (_Response["first_name"] != null)
                        User_Name.Text = _Response["first_name"];
                    else
                        User_Name.Text = "Не указана";
                    if (_Response["last_name"] != null)
                        User_Surname.Text = _Response["last_name"];
                    else
                        User_Surname.Text = "Не указана";
                    if (_Response["country"] != null)
                        User_Country.Text = _Response["country"]["title"];
                    else
                        User_Country.Text = "Не указана";
                    if (_Response["city"] != null)
                        User_City.Text = _Response["city"]["title"];//neposredstvenno_alena
                    else
                        User_City.Text = "Не указан";
                    Button_GetToken.Visible = false;
                    t = _Response["id"];
                }


                _ApiRequest = new VkAPI(_Token);
                _UserId = User_ID.Text;
                _Response3 = _ApiRequest.GetNumberFriends(t);
               
                int p = Convert.ToInt32(_Response3["count"]);
                label1.Text = Convert.ToString(p);
                File.WriteAllText("UserInf3.txt", "");
                _Response2 = _ApiRequest.GetFriends(t, label1.Text.Length);
                File.WriteAllText("UserInf2.txt", _Response2 + "\n");
                int tra = 0;
                for (int i = 0; i < p; i++)
                {
                    first_name = _Response2[i]["first_name"];
                    last_name = _Response2[i]["last_name"];
                    bdat = _Response2[i]["bdate"];
                    first_name = first_name.ToUpper();
                    last_name = last_name.ToUpper();
                    File.AppendAllText("UserInf3.txt", i + 1 + " " + _Response2[i]["first_name"]);
                    File.AppendAllText("UserInf3.txt", "  " + _Response2[i]["last_name"] + "\n");
                    listBox1.Items.Add(Convert.ToString(i + 1) + " " + _Response2[i]["first_name"] + " " + _Response2[i]["last_name"]);
                    if (Prof(first_name, last_name,bdat))
                    {
                        tra++;
                        listBox2.Items.Add(Convert.ToString(i + 1) + " " + _Response2[i]["first_name"] + " " + _Response2[i]["last_name"]);
                    }
                }
                if (cheak == false)
                {
                    File.WriteAllText("UserInf4.txt", tra.ToString());
                    this.Close();
                }
            }
        }
//
        private void Button_GetInformation_Click_1(object sender, EventArgs e)
        {
            if (User_ID.Text != "")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                string first_name; string last_name; string bdat;
                StreamReader ControlInf = new StreamReader("UserInf.txt");
                _Token = ControlInf.ReadLine();
                ControlInf.Close();
                _ApiRequest = new VkAPI(_Token);
                _UserId = User_ID.Text;
                string[] Params = { "city", "country", "photo_max" };
                _Response = _ApiRequest.GetInformation(_UserId, Params);
                if (_Response != null)
                {
                    User_ID.Text = _UserId;
                    if (_Response["photo_max"] != null)
                        User_Photo.ImageLocation = _Response["photo_max"];
                    else
                        User_Photo.Text = "Не указана";
                    if (_Response["first_name"] != null)
                        User_Name.Text = _Response["first_name"];
                    else
                        User_Name.Text = "Не указана";
                    if (_Response["last_name"] != null)
                        User_Surname.Text = _Response["last_name"];
                    else
                        User_Surname.Text = "Не указана";
                    if (_Response["country"] != null)
                        User_Country.Text = _Response["country"]["title"];
                    else
                        User_Country.Text = "Не указана";
                    if (_Response["city"] != null)
                        User_City.Text = _Response["city"]["title"];//neposredstvenno_alena
                    else
                        User_City.Text = "Не указан";
                    Button_GetToken.Visible = false;
                    t = _Response["id"];
                }

                _ApiRequest = new VkAPI(_Token);
                _UserId = User_ID.Text;
                _Response3 = _ApiRequest.GetNumberFriends(t);

                int p = Convert.ToInt32(_Response3["count"]);
                label1.Text = Convert.ToString(p);
                File.WriteAllText("UserInf3.txt", "");
                _Response2 = _ApiRequest.GetFriends(t, label1.Text.Length);
                File.WriteAllText("UserInf2.txt", _Response2 + "\n");
                for (int i = 0; i < 5000; i++)
                {
                    first_name = _Response2[i]["first_name"];
                    last_name = _Response2[i]["last_name"];
                    bdat = _Response2[i]["bdate"];
                    first_name = first_name.ToUpper();
                    last_name = last_name.ToUpper();
                    File.AppendAllText("UserInf3.txt", i + 1 + " " + _Response2[i]["first_name"]);
                    File.AppendAllText("UserInf3.txt", "  " + _Response2[i]["last_name"] + "\n");
                    listBox1.Items.Add(Convert.ToString(i + 1) + " " + _Response2[i]["first_name"] + " " + _Response2[i]["last_name"]);
                    if (Prof(first_name, last_name, bdat))
                    {
                        listBox2.Items.Add(Convert.ToString(i + 1) + " " + _Response2[i]["first_name"] + " " + _Response2[i]["last_name"]);
                    }
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void проверкаЧерезЧерныйСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Proverka = new Form3("","", "", "");
            Proverka.ShowDialog();
        }
    }
}