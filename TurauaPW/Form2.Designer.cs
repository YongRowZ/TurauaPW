namespace TurauaPW
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.AutoScrollMinSize = new System.Drawing.Size(0, 1650);
            this.tabPage2.Controls.Add(this.listBox7);
            this.tabPage2.Controls.Add(this.listBox6);
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Controls.Add(this.listBox5);
            this.tabPage2.Controls.Add(this.listBox4);
            this.tabPage2.Controls.Add(this.listBox3);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(823, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа с програмным обеспечением";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            " 1 - Файл (Пункт меню,",
            "который позволяет ",
            "выбрать и открыть файл ",
            "формата Excel в котором ",
            "содержиться биллинговая ",
            "информация (ТУРАЯ)",
            "",
            " 2 - Настройки (Пункт меню,",
            "который открывает окно ",
            "с настройками ",
            "подключения к БД)",
            "",
            "3 - Номера столбцов ",
            "(После открытия файла ",
            "Excel, заполняються ",
            "автоматчески если же нет ",
            "необходимо указать",
            "нужный номер вручную)"});
            this.listBox1.Location = new System.Drawing.Point(586, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 288);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            " 1 - Поля (\"Логин\",\"Пароль\",",
            "\"Host\", \"Port\" заполняються ",
            "вручную если настройки",
            "подключения отличаються",
            "от типовых)",
            "",
            " 2 - Кнопка \"По умолчанию\" ",
            "(Позволяет установить ",
            "типовые настройки ",
            "подключения к БД)",
            "",
            "3 - Поле \"Подключеная БД\" ",
            "(указываем путь до БД, в ",
            "том случае если хотим ",
            "использовать для ",
            "репликации ",
            "существующую БД)",
            "",
            "4 - Кнопка ",
            "\"Сохранить настройки\""});
            this.listBox2.Location = new System.Drawing.Point(586, 443);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(213, 320);
            this.listBox2.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Items.AddRange(new object[] {
            "Отображение интерфейса с подлюченым биллинговым файлом \"Турая\""});
            this.listBox3.Location = new System.Drawing.Point(100, 808);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(545, 16);
            this.listBox3.TabIndex = 5;
            // 
            // listBox4
            // 
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Items.AddRange(new object[] {
            "Основной интерфейс Програмного обеспечения"});
            this.listBox4.Location = new System.Drawing.Point(228, 6);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(382, 16);
            this.listBox4.TabIndex = 6;
            // 
            // listBox5
            // 
            this.listBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Items.AddRange(new object[] {
            "Интерфейс панели  настроек"});
            this.listBox5.Location = new System.Drawing.Point(292, 408);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(237, 16);
            this.listBox5.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::TurauaPW.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::TurauaPW.Properties.Resources._4;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(9, 1191);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(570, 344);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TurauaPW.Properties.Resources._3;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(85, 834);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(570, 344);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TurauaPW.Properties.Resources._2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(10, 434);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(570, 344);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TurauaPW.Properties.Resources._1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(10, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(570, 344);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // listBox6
            // 
            this.listBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Items.AddRange(new object[] {
            " 1 - Лист (Позволяет ",
            "выбрать лист файла ",
            "Excel на котором",
            "находиться необходимая",
            "биллинговая информация)",
            "",
            " 2 - Показывает",
            "активное подключение",
            "к БД в которую будет",
            "выполняться репликация",
            "",
            "3 - Кнопка \"Репликация\" ",
            "(Начинает процесс",
            "репликации в БД)",
            "",
            "4 - Заполненые столбцы",
            "с номерами ",
            "соответсвующих значений"});
            this.listBox6.Location = new System.Drawing.Point(583, 1216);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(213, 288);
            this.listBox6.TabIndex = 9;
            // 
            // listBox7
            // 
            this.listBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 16;
            this.listBox7.Items.AddRange(new object[] {
            "5 - Указывает общее кол-во записей в файле Excel",
            "",
            "Если начать процесс репликации без подключенной БД, для записи откроется диологов" +
                "ое окно",
            "в котором надо указать о согласии создания новой БД и места ее расположения "});
            this.listBox7.Location = new System.Drawing.Point(6, 1541);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(790, 80);
            this.listBox7.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Информация";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox6;
    }
}