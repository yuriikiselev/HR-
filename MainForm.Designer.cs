namespace VkAPITutorial
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.User_Photo = new System.Windows.Forms.PictureBox();
            this.Label_User_Name = new System.Windows.Forms.Label();
            this.Label_User_Surname = new System.Windows.Forms.Label();
            this.Label_User_City = new System.Windows.Forms.Label();
            this.Label_User_Country = new System.Windows.Forms.Label();
            this.Label_User_UserID = new System.Windows.Forms.Label();
            this.User_ID = new System.Windows.Forms.TextBox();
            this.User_Name = new System.Windows.Forms.Label();
            this.User_Country = new System.Windows.Forms.Label();
            this.User_City = new System.Windows.Forms.Label();
            this.User_Surname = new System.Windows.Forms.Label();
            this.Button_GetToken = new System.Windows.Forms.Button();
            this.Button_GetInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаЧерезЧерныйСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиТемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиБазыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратнаяСвязьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.втораяФамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.второеИмяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.второеОтчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.террористыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных1DataSet = new VkAPITutorial.База_данных1DataSet();
            this._Террористы_TableAdapter = new VkAPITutorial.База_данных1DataSetTableAdapters._Террористы_TableAdapter();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.User_Photo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.террористыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // User_Photo
            // 
            this.User_Photo.Location = new System.Drawing.Point(21, 51);
            this.User_Photo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.User_Photo.Name = "User_Photo";
            this.User_Photo.Size = new System.Drawing.Size(298, 303);
            this.User_Photo.TabIndex = 0;
            this.User_Photo.TabStop = false;
            // 
            // Label_User_Name
            // 
            this.Label_User_Name.AutoSize = true;
            this.Label_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_User_Name.Location = new System.Drawing.Point(328, 51);
            this.Label_User_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_User_Name.Name = "Label_User_Name";
            this.Label_User_Name.Size = new System.Drawing.Size(69, 29);
            this.Label_User_Name.TabIndex = 1;
            this.Label_User_Name.Text = "Имя:";
            // 
            // Label_User_Surname
            // 
            this.Label_User_Surname.AutoSize = true;
            this.Label_User_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_User_Surname.Location = new System.Drawing.Point(328, 82);
            this.Label_User_Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_User_Surname.Name = "Label_User_Surname";
            this.Label_User_Surname.Size = new System.Drawing.Size(129, 29);
            this.Label_User_Surname.TabIndex = 2;
            this.Label_User_Surname.Text = "Фамилия:";
            // 
            // Label_User_City
            // 
            this.Label_User_City.AutoSize = true;
            this.Label_User_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_User_City.Location = new System.Drawing.Point(328, 112);
            this.Label_User_City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_User_City.Name = "Label_User_City";
            this.Label_User_City.Size = new System.Drawing.Size(89, 29);
            this.Label_User_City.TabIndex = 3;
            this.Label_User_City.Text = "Город:";
            // 
            // Label_User_Country
            // 
            this.Label_User_Country.AutoSize = true;
            this.Label_User_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_User_Country.Location = new System.Drawing.Point(328, 143);
            this.Label_User_Country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_User_Country.Name = "Label_User_Country";
            this.Label_User_Country.Size = new System.Drawing.Size(103, 29);
            this.Label_User_Country.TabIndex = 4;
            this.Label_User_Country.Text = "Страна:";
            // 
            // Label_User_UserID
            // 
            this.Label_User_UserID.AutoSize = true;
            this.Label_User_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_User_UserID.Location = new System.Drawing.Point(759, 51);
            this.Label_User_UserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_User_UserID.Name = "Label_User_UserID";
            this.Label_User_UserID.Size = new System.Drawing.Size(215, 29);
            this.Label_User_UserID.TabIndex = 5;
            this.Label_User_UserID.Text = "ID Пользователя:";
            // 
            // User_ID
            // 
            this.User_ID.Location = new System.Drawing.Point(826, 86);
            this.User_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(148, 26);
            this.User_ID.TabIndex = 7;
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Name.Location = new System.Drawing.Point(578, 51);
            this.User_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(67, 29);
            this.User_Name.TabIndex = 8;
            this.User_Name.Text = "none";
            // 
            // User_Country
            // 
            this.User_Country.AutoSize = true;
            this.User_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Country.Location = new System.Drawing.Point(578, 143);
            this.User_Country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_Country.Name = "User_Country";
            this.User_Country.Size = new System.Drawing.Size(67, 29);
            this.User_Country.TabIndex = 9;
            this.User_Country.Text = "none";
            // 
            // User_City
            // 
            this.User_City.AutoSize = true;
            this.User_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_City.Location = new System.Drawing.Point(578, 112);
            this.User_City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_City.Name = "User_City";
            this.User_City.Size = new System.Drawing.Size(67, 29);
            this.User_City.TabIndex = 10;
            this.User_City.Text = "none";
            // 
            // User_Surname
            // 
            this.User_Surname.AutoSize = true;
            this.User_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Surname.Location = new System.Drawing.Point(578, 82);
            this.User_Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_Surname.Name = "User_Surname";
            this.User_Surname.Size = new System.Drawing.Size(67, 29);
            this.User_Surname.TabIndex = 11;
            this.User_Surname.Text = "none";
            // 
            // Button_GetToken
            // 
            this.Button_GetToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_GetToken.Location = new System.Drawing.Point(334, 214);
            this.Button_GetToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_GetToken.Name = "Button_GetToken";
            this.Button_GetToken.Size = new System.Drawing.Size(310, 55);
            this.Button_GetToken.TabIndex = 12;
            this.Button_GetToken.Text = "Получить token";
            this.Button_GetToken.UseVisualStyleBackColor = true;
            this.Button_GetToken.Click += new System.EventHandler(this.Button_GetToken_Click_1);
            // 
            // Button_GetInformation
            // 
            this.Button_GetInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_GetInformation.Location = new System.Drawing.Point(686, 174);
            this.Button_GetInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_GetInformation.Name = "Button_GetInformation";
            this.Button_GetInformation.Size = new System.Drawing.Size(291, 95);
            this.Button_GetInformation.TabIndex = 13;
            this.Button_GetInformation.Text = "Получение информации";
            this.Button_GetInformation.UseVisualStyleBackColor = true;
            this.Button_GetInformation.Click += new System.EventHandler(this.Button_GetInformation_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(578, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "none";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(334, 338);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 144);
            this.listBox1.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.проверкаToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 35);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // проверкаToolStripMenuItem
            // 
            this.проверкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверкаЧерезЧерныйСписокToolStripMenuItem});
            this.проверкаToolStripMenuItem.Name = "проверкаToolStripMenuItem";
            this.проверкаToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.проверкаToolStripMenuItem.Text = "Проверка";
            // 
            // проверкаЧерезЧерныйСписокToolStripMenuItem
            // 
            this.проверкаЧерезЧерныйСписокToolStripMenuItem.Name = "проверкаЧерезЧерныйСписокToolStripMenuItem";
            this.проверкаЧерезЧерныйСписокToolStripMenuItem.Size = new System.Drawing.Size(378, 34);
            this.проверкаЧерезЧерныйСписокToolStripMenuItem.Text = "Проверка через черный список";
            this.проверкаЧерезЧерныйСписокToolStripMenuItem.Click += new System.EventHandler(this.проверкаЧерезЧерныйСписокToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиТемыToolStripMenuItem,
            this.настройкиБазыДанныхToolStripMenuItem,
            this.обратнаяСвязьToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиТемыToolStripMenuItem
            // 
            this.настройкиТемыToolStripMenuItem.Name = "настройкиТемыToolStripMenuItem";
            this.настройкиТемыToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.настройкиТемыToolStripMenuItem.Text = "Настройки темы";
            // 
            // настройкиБазыДанныхToolStripMenuItem
            // 
            this.настройкиБазыДанныхToolStripMenuItem.Name = "настройкиБазыДанныхToolStripMenuItem";
            this.настройкиБазыДанныхToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.настройкиБазыДанныхToolStripMenuItem.Text = "Настройки базы данных";
            // 
            // обратнаяСвязьToolStripMenuItem
            // 
            this.обратнаяСвязьToolStripMenuItem.Name = "обратнаяСвязьToolStripMenuItem";
            this.обратнаяСвязьToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.обратнаяСвязьToolStripMenuItem.Text = "Обратная связь";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.втораяФамилияDataGridViewTextBoxColumn,
            this.второеИмяDataGridViewTextBoxColumn,
            this.второеОтчествоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.местоРожденияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.террористыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(978, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(15, 15);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.Visible = false;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 150;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 150;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 150;
            // 
            // втораяФамилияDataGridViewTextBoxColumn
            // 
            this.втораяФамилияDataGridViewTextBoxColumn.DataPropertyName = "Вторая фамилия";
            this.втораяФамилияDataGridViewTextBoxColumn.HeaderText = "Вторая фамилия";
            this.втораяФамилияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.втораяФамилияDataGridViewTextBoxColumn.Name = "втораяФамилияDataGridViewTextBoxColumn";
            this.втораяФамилияDataGridViewTextBoxColumn.Width = 150;
            // 
            // второеИмяDataGridViewTextBoxColumn
            // 
            this.второеИмяDataGridViewTextBoxColumn.DataPropertyName = "Второе Имя";
            this.второеИмяDataGridViewTextBoxColumn.HeaderText = "Второе Имя";
            this.второеИмяDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.второеИмяDataGridViewTextBoxColumn.Name = "второеИмяDataGridViewTextBoxColumn";
            this.второеИмяDataGridViewTextBoxColumn.Width = 150;
            // 
            // второеОтчествоDataGridViewTextBoxColumn
            // 
            this.второеОтчествоDataGridViewTextBoxColumn.DataPropertyName = "Второе отчество";
            this.второеОтчествоDataGridViewTextBoxColumn.HeaderText = "Второе отчество";
            this.второеОтчествоDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.второеОтчествоDataGridViewTextBoxColumn.Name = "второеОтчествоDataGridViewTextBoxColumn";
            this.второеОтчествоDataGridViewTextBoxColumn.Width = 150;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.Width = 150;
            // 
            // местоРожденияDataGridViewTextBoxColumn
            // 
            this.местоРожденияDataGridViewTextBoxColumn.DataPropertyName = "Место рождения";
            this.местоРожденияDataGridViewTextBoxColumn.HeaderText = "Место рождения";
            this.местоРожденияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.местоРожденияDataGridViewTextBoxColumn.Name = "местоРожденияDataGridViewTextBoxColumn";
            this.местоРожденияDataGridViewTextBoxColumn.Width = 150;
            // 
            // террористыBindingSource
            // 
            this.террористыBindingSource.DataMember = "\"Террористы\"";
            this.террористыBindingSource.DataSource = this.база_данных1DataSet;
            // 
            // база_данных1DataSet
            // 
            this.база_данных1DataSet.DataSetName = "База_данных1DataSet";
            this.база_данных1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _Террористы_TableAdapter
            // 
            this._Террористы_TableAdapter.ClearBeforeFill = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(584, 338);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(178, 144);
            this.listBox2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(328, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Количество друзей:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(328, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Друзья:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(578, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 63);
            this.label4.TabIndex = 21;
            this.label4.Text = "Совадение с черным списком";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(994, 489);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_GetInformation);
            this.Controls.Add(this.Button_GetToken);
            this.Controls.Add(this.User_Surname);
            this.Controls.Add(this.User_City);
            this.Controls.Add(this.User_Country);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.Label_User_UserID);
            this.Controls.Add(this.Label_User_Country);
            this.Controls.Add(this.Label_User_City);
            this.Controls.Add(this.Label_User_Surname);
            this.Controls.Add(this.Label_User_Name);
            this.Controls.Add(this.User_Photo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_Photo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.террористыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox User_Photo;
        private System.Windows.Forms.Label Label_User_Name;
        private System.Windows.Forms.Label Label_User_Surname;
        private System.Windows.Forms.Label Label_User_City;
        private System.Windows.Forms.Label Label_User_Country;
        private System.Windows.Forms.Label Label_User_UserID;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Label User_Country;
        private System.Windows.Forms.Label User_City;
        private System.Windows.Forms.Label User_Surname;
        private System.Windows.Forms.Button Button_GetToken;
        private System.Windows.Forms.Button Button_GetInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаЧерезЧерныйСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиТемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиБазыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратнаяСвязьToolStripMenuItem;
        public System.Windows.Forms.TextBox User_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private База_данных1DataSet база_данных1DataSet;
        private System.Windows.Forms.BindingSource террористыBindingSource;
        private База_данных1DataSetTableAdapters._Террористы_TableAdapter _Террористы_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn втораяФамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn второеИмяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn второеОтчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}