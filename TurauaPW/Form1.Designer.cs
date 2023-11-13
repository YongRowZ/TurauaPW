namespace TurauaPW
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSselectListDataExcel = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBreturnResult = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelSETINGS = new System.Windows.Forms.Panel();
            this.SaveSettingsConnect = new System.Windows.Forms.Button();
            this.ClosePanelSetings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConectionTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPathDB = new System.Windows.Forms.TextBox();
            this.SelectDbPath = new System.Windows.Forms.Button();
            this.SetingsConnDef = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbFileExcel = new System.Windows.Forms.TextBox();
            this.tbDlitelnostExcel = new System.Windows.Forms.TextBox();
            this.tbImeiExcel = new System.Windows.Forms.TextBox();
            this.tbPostExcel = new System.Windows.Forms.TextBox();
            this.tbBsExcel = new System.Windows.Forms.TextBox();
            this.tbSobesExcel = new System.Windows.Forms.TextBox();
            this.tbCallTypeExcel = new System.Windows.Forms.TextBox();
            this.tbStandartExcel = new System.Windows.Forms.TextBox();
            this.tbTimeExcel = new System.Windows.Forms.TextBox();
            this.tbDateExcel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InformationData = new System.Windows.Forms.GroupBox();
            this.ResultOKFileParam = new System.Windows.Forms.Label();
            this.AllFileDataParam = new System.Windows.Forms.Label();
            this.ResultOKFileText = new System.Windows.Forms.Label();
            this.AllFileDataText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.TSMItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItemSetings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelSETINGS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.InformationData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItemFile,
            this.TSMItemSetings,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tSselectListDataExcel,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.tSBreturnResult,
            this.toolStripSeparator3,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            this.toolStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseUp);
            // 
            // tSselectListDataExcel
            // 
            this.tSselectListDataExcel.Name = "tSselectListDataExcel";
            this.tSselectListDataExcel.Size = new System.Drawing.Size(200, 31);
            this.tSselectListDataExcel.SelectedIndexChanged += new System.EventHandler(this.tSselectListDataExcel_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(92, 28);
            this.toolStripLabel3.Text = "не выбрана";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tSBreturnResult
            // 
            this.tSBreturnResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBreturnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSBreturnResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBreturnResult.Name = "tSBreturnResult";
            this.tSBreturnResult.Size = new System.Drawing.Size(121, 28);
            this.tSBreturnResult.Text = "Реплицировать";
            this.tSBreturnResult.Click += new System.EventHandler(this.tSBreturnResult_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 28);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelSETINGS
            // 
            this.panelSETINGS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSETINGS.Controls.Add(this.SaveSettingsConnect);
            this.panelSETINGS.Controls.Add(this.ClosePanelSetings);
            this.panelSETINGS.Controls.Add(this.groupBox1);
            this.panelSETINGS.Location = new System.Drawing.Point(12, 31);
            this.panelSETINGS.Name = "panelSETINGS";
            this.panelSETINGS.Size = new System.Drawing.Size(364, 315);
            this.panelSETINGS.TabIndex = 4;
            this.panelSETINGS.Visible = false;
            // 
            // SaveSettingsConnect
            // 
            this.SaveSettingsConnect.Location = new System.Drawing.Point(74, 278);
            this.SaveSettingsConnect.Name = "SaveSettingsConnect";
            this.SaveSettingsConnect.Size = new System.Drawing.Size(193, 28);
            this.SaveSettingsConnect.TabIndex = 6;
            this.SaveSettingsConnect.Text = "Сохранить настройки подключения";
            this.SaveSettingsConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveSettingsConnect.UseVisualStyleBackColor = true;
            this.SaveSettingsConnect.Click += new System.EventHandler(this.SaveSettingsConnect_Click);
            // 
            // ClosePanelSetings
            // 
            this.ClosePanelSetings.Location = new System.Drawing.Point(273, 278);
            this.ClosePanelSetings.Name = "ClosePanelSetings";
            this.ClosePanelSetings.Size = new System.Drawing.Size(83, 28);
            this.ClosePanelSetings.TabIndex = 11;
            this.ClosePanelSetings.Text = "Закрыть";
            this.ClosePanelSetings.UseVisualStyleBackColor = true;
            this.ClosePanelSetings.Click += new System.EventHandler(this.ClosePanelSetings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConectionTest);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SetingsConnDef);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbHost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения:";
            // 
            // ConectionTest
            // 
            this.ConectionTest.Location = new System.Drawing.Point(15, 231);
            this.ConectionTest.Name = "ConectionTest";
            this.ConectionTest.Size = new System.Drawing.Size(322, 31);
            this.ConectionTest.TabIndex = 10;
            this.ConectionTest.Text = "Проверка соединения";
            this.ConectionTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConectionTest.UseVisualStyleBackColor = true;
            this.ConectionTest.Click += new System.EventHandler(this.ConectionTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPathDB);
            this.groupBox2.Controls.Add(this.SelectDbPath);
            this.groupBox2.Location = new System.Drawing.Point(9, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 53);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подключеная БД:";
            // 
            // tbPathDB
            // 
            this.tbPathDB.Location = new System.Drawing.Point(43, 21);
            this.tbPathDB.Name = "tbPathDB";
            this.tbPathDB.Size = new System.Drawing.Size(285, 22);
            this.tbPathDB.TabIndex = 11;
            // 
            // SelectDbPath
            // 
            this.SelectDbPath.Location = new System.Drawing.Point(6, 21);
            this.SelectDbPath.Name = "SelectDbPath";
            this.SelectDbPath.Size = new System.Drawing.Size(35, 23);
            this.SelectDbPath.TabIndex = 10;
            this.SelectDbPath.Text = "...";
            this.SelectDbPath.UseVisualStyleBackColor = true;
            this.SelectDbPath.Click += new System.EventHandler(this.SelectDbPath_Click);
            // 
            // SetingsConnDef
            // 
            this.SetingsConnDef.Location = new System.Drawing.Point(52, 135);
            this.SetingsConnDef.Name = "SetingsConnDef";
            this.SetingsConnDef.Size = new System.Drawing.Size(219, 31);
            this.SetingsConnDef.TabIndex = 8;
            this.SetingsConnDef.Text = "Параметры (По умолчанию)";
            this.SetingsConnDef.UseVisualStyleBackColor = true;
            this.SetingsConnDef.Click += new System.EventHandler(this.SetingsConnDef_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(71, 107);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(227, 22);
            this.tbPort.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port:";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(71, 79);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(227, 22);
            this.tbHost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host:";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(71, 51);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(227, 22);
            this.tbPass.TabIndex = 3;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(71, 24);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(227, 22);
            this.tbUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbFileExcel);
            this.groupBox3.Controls.Add(this.tbDlitelnostExcel);
            this.groupBox3.Controls.Add(this.tbImeiExcel);
            this.groupBox3.Controls.Add(this.tbPostExcel);
            this.groupBox3.Controls.Add(this.tbBsExcel);
            this.groupBox3.Controls.Add(this.tbSobesExcel);
            this.groupBox3.Controls.Add(this.tbCallTypeExcel);
            this.groupBox3.Controls.Add(this.tbStandartExcel);
            this.groupBox3.Controls.Add(this.tbTimeExcel);
            this.groupBox3.Controls.Add(this.tbDateExcel);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(773, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 312);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Номера столбцов:";
            // 
            // tbFileExcel
            // 
            this.tbFileExcel.Location = new System.Drawing.Point(135, 276);
            this.tbFileExcel.Name = "tbFileExcel";
            this.tbFileExcel.Size = new System.Drawing.Size(48, 22);
            this.tbFileExcel.TabIndex = 23;
            this.tbFileExcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFileExcel_KeyPress);
            // 
            // tbDlitelnostExcel
            // 
            this.tbDlitelnostExcel.Location = new System.Drawing.Point(135, 248);
            this.tbDlitelnostExcel.Name = "tbDlitelnostExcel";
            this.tbDlitelnostExcel.Size = new System.Drawing.Size(48, 22);
            this.tbDlitelnostExcel.TabIndex = 22;
            this.tbDlitelnostExcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDlitelnostExcel_KeyPress);
            // 
            // tbImeiExcel
            // 
            this.tbImeiExcel.Location = new System.Drawing.Point(135, 220);
            this.tbImeiExcel.Name = "tbImeiExcel";
            this.tbImeiExcel.Size = new System.Drawing.Size(48, 22);
            this.tbImeiExcel.TabIndex = 21;
            this.tbImeiExcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbImeiExcel_KeyPress);
            // 
            // tbPostExcel
            // 
            this.tbPostExcel.Location = new System.Drawing.Point(135, 192);
            this.tbPostExcel.Name = "tbPostExcel";
            this.tbPostExcel.Size = new System.Drawing.Size(48, 22);
            this.tbPostExcel.TabIndex = 20;
            this.tbPostExcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostExcel_KeyPress);
            // 
            // tbBsExcel
            // 
            this.tbBsExcel.Location = new System.Drawing.Point(135, 164);
            this.tbBsExcel.Name = "tbBsExcel";
            this.tbBsExcel.Size = new System.Drawing.Size(48, 22);
            this.tbBsExcel.TabIndex = 19;
            this.tbBsExcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBsExcel_KeyPress);
            // 
            // tbSobesExcel
            // 
            this.tbSobesExcel.Location = new System.Drawing.Point(135, 136);
            this.tbSobesExcel.Name = "tbSobesExcel";
            this.tbSobesExcel.Size = new System.Drawing.Size(48, 22);
            this.tbSobesExcel.TabIndex = 18;
            this.tbSobesExcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSobesExcel_KeyPress);
            // 
            // tbCallTypeExcel
            // 
            this.tbCallTypeExcel.Location = new System.Drawing.Point(135, 108);
            this.tbCallTypeExcel.Name = "tbCallTypeExcel";
            this.tbCallTypeExcel.Size = new System.Drawing.Size(48, 22);
            this.tbCallTypeExcel.TabIndex = 17;
            this.tbCallTypeExcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCallTypeExcel_KeyPress);
            // 
            // tbStandartExcel
            // 
            this.tbStandartExcel.Location = new System.Drawing.Point(135, 80);
            this.tbStandartExcel.Name = "tbStandartExcel";
            this.tbStandartExcel.Size = new System.Drawing.Size(48, 22);
            this.tbStandartExcel.TabIndex = 16;
            this.tbStandartExcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStandartExcel_KeyPress);
            // 
            // tbTimeExcel
            // 
            this.tbTimeExcel.Location = new System.Drawing.Point(135, 52);
            this.tbTimeExcel.Name = "tbTimeExcel";
            this.tbTimeExcel.Size = new System.Drawing.Size(48, 22);
            this.tbTimeExcel.TabIndex = 15;
            this.tbTimeExcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTimeExcel_KeyPress);
            // 
            // tbDateExcel
            // 
            this.tbDateExcel.Location = new System.Drawing.Point(135, 24);
            this.tbDateExcel.Name = "tbDateExcel";
            this.tbDateExcel.Size = new System.Drawing.Size(48, 22);
            this.tbDateExcel.TabIndex = 14;
            this.tbDateExcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDateExcel_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Запись сеанса:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Длительность:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "IMEI:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Пост:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Базовая станция:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Собеседник:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Тип вызова:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Стандарт:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Время:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дата:";
            // 
            // InformationData
            // 
            this.InformationData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationData.Controls.Add(this.ResultOKFileParam);
            this.InformationData.Controls.Add(this.AllFileDataParam);
            this.InformationData.Controls.Add(this.ResultOKFileText);
            this.InformationData.Controls.Add(this.AllFileDataText);
            this.InformationData.Location = new System.Drawing.Point(773, 377);
            this.InformationData.Name = "InformationData";
            this.InformationData.Size = new System.Drawing.Size(197, 126);
            this.InformationData.TabIndex = 6;
            this.InformationData.TabStop = false;
            this.InformationData.Text = "Информация:";
            this.InformationData.Visible = false;
            // 
            // ResultOKFileParam
            // 
            this.ResultOKFileParam.AutoSize = true;
            this.ResultOKFileParam.Location = new System.Drawing.Point(123, 88);
            this.ResultOKFileParam.Name = "ResultOKFileParam";
            this.ResultOKFileParam.Size = new System.Drawing.Size(51, 16);
            this.ResultOKFileParam.TabIndex = 3;
            this.ResultOKFileParam.Text = "label16";
            this.ResultOKFileParam.Visible = false;
            // 
            // AllFileDataParam
            // 
            this.AllFileDataParam.AutoSize = true;
            this.AllFileDataParam.Location = new System.Drawing.Point(123, 35);
            this.AllFileDataParam.Name = "AllFileDataParam";
            this.AllFileDataParam.Size = new System.Drawing.Size(51, 16);
            this.AllFileDataParam.TabIndex = 2;
            this.AllFileDataParam.Text = "label15";
            // 
            // ResultOKFileText
            // 
            this.ResultOKFileText.AutoSize = true;
            this.ResultOKFileText.Location = new System.Drawing.Point(21, 72);
            this.ResultOKFileText.Name = "ResultOKFileText";
            this.ResultOKFileText.Size = new System.Drawing.Size(88, 48);
            this.ResultOKFileText.TabIndex = 1;
            this.ResultOKFileText.Text = "Обработано\r\n(Успешно)\r\nзаписей:";
            this.ResultOKFileText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultOKFileText.Visible = false;
            // 
            // AllFileDataText
            // 
            this.AllFileDataText.AutoSize = true;
            this.AllFileDataText.Location = new System.Drawing.Point(8, 27);
            this.AllFileDataText.Name = "AllFileDataText";
            this.AllFileDataText.Size = new System.Drawing.Size(109, 32);
            this.AllFileDataText.TabIndex = 0;
            this.AllFileDataText.Text = "Кол-во записей\r\nв файле:";
            this.AllFileDataText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::TurauaPW.Properties.Resources.th_list;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 28);
            this.toolStripLabel1.Text = "Лист:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::TurauaPW.Properties.Resources.database;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(132, 28);
            this.toolStripLabel2.Text = "БД для записи:";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Image = global::TurauaPW.Properties.Resources.export;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(20, 28);
            // 
            // TSMItemFile
            // 
            this.TSMItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItemFileOpen});
            this.TSMItemFile.Image = global::TurauaPW.Properties.Resources.folder;
            this.TSMItemFile.Name = "TSMItemFile";
            this.TSMItemFile.Size = new System.Drawing.Size(82, 24);
            this.TSMItemFile.Text = "Файл:";
            // 
            // TSMItemFileOpen
            // 
            this.TSMItemFileOpen.Image = global::TurauaPW.Properties.Resources.document_text;
            this.TSMItemFileOpen.Name = "TSMItemFileOpen";
            this.TSMItemFileOpen.Size = new System.Drawing.Size(150, 26);
            this.TSMItemFileOpen.Text = "Открыть";
            this.TSMItemFileOpen.Click += new System.EventHandler(this.TSMItemFileOpen_Click);
            // 
            // TSMItemSetings
            // 
            this.TSMItemSetings.Image = global::TurauaPW.Properties.Resources.cog_outline;
            this.TSMItemSetings.Name = "TSMItemSetings";
            this.TSMItemSetings.Size = new System.Drawing.Size(118, 24);
            this.TSMItemSetings.Text = "Настройки";
            this.TSMItemSetings.Click += new System.EventHandler(this.TSMItemSetings_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::TurauaPW.Properties.Resources.info_large_outline;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(34, 24);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.InformationData);
            this.Controls.Add(this.panelSETINGS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "ТураяPW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelSETINGS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.InformationData.ResumeLayout(false);
            this.InformationData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMItemFile;
        private System.Windows.Forms.ToolStripMenuItem TSMItemFileOpen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tSselectListDataExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem TSMItemSetings;
        private System.Windows.Forms.Panel panelSETINGS;
        private System.Windows.Forms.Button ClosePanelSetings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ConectionTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPathDB;
        private System.Windows.Forms.Button SelectDbPath;
        private System.Windows.Forms.Button SetingsConnDef;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tSBreturnResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbTimeExcel;
        private System.Windows.Forms.TextBox tbDateExcel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFileExcel;
        private System.Windows.Forms.TextBox tbDlitelnostExcel;
        private System.Windows.Forms.TextBox tbImeiExcel;
        private System.Windows.Forms.TextBox tbPostExcel;
        private System.Windows.Forms.TextBox tbBsExcel;
        private System.Windows.Forms.TextBox tbSobesExcel;
        private System.Windows.Forms.TextBox tbCallTypeExcel;
        private System.Windows.Forms.TextBox tbStandartExcel;
        private System.Windows.Forms.Button SaveSettingsConnect;
        private System.Windows.Forms.GroupBox InformationData;
        private System.Windows.Forms.Label ResultOKFileText;
        private System.Windows.Forms.Label AllFileDataText;
        private System.Windows.Forms.Label ResultOKFileParam;
        private System.Windows.Forms.Label AllFileDataParam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

