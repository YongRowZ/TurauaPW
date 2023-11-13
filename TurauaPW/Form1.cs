using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

//  Используется для работы с Excel файлами
using ExcelDataReader;

//  Используется для работы с interbase
using InterBaseSql.Data.InterBaseClient;

//  Используется для работы со звуковыми файлами
using NAudio.Wave;

//  Используется для сохранения необходимых параметров
using TurauaPW.Properties;

////////////////////////////////////////////////////////////
//         く__,.ヘヽ. / ,ー､ 〉
//          　　　　　＼ ', !-─‐-i　/　/´
//          　　　 　 ／｀ｰ '　　　 L/／｀ヽ､
//                / ／,　 /| ,　 ,　　　 ',
//               ｲ / / -‐/ ｉ L_ ﾊ ヽ!　 i
//          　　　 ﾚ ﾍ 7ｲ｀ﾄ　 ﾚ'ｧ-ﾄ､!ハ|　 |
//          　　　　 !,/7 '0'　　 ´0iソ| 　 |　　　
//          　　　　 |.从"　　_　　 ,,,, / |./ 　 |
//          　　　　 ﾚ'| i＞.､,,__　_,.イ / 　.i 　|
//          　　　　　 ﾚ'| | / k_７_/ﾚ'ヽ, ﾊ.　|
//          　　　　　　 | |/i 〈|/　 i　,.ﾍ |　i　|
//          　　　　　　.|/ /　ｉ： 　 ﾍ!　　＼　|
//          　　　 　 　 kヽ>､ﾊ 　 _,.ﾍ､ 　 /､!
//          　　　　　　 !'〈//｀Ｔ´', ＼ ｀'7'ｰr'
//          　　　　　　 ﾚ'ヽL__|___i,___,ンﾚ|ノ
//          　　　　　 　　　ﾄ-,/　|___./
//          　　　　　 　　　'ｰ'　　!_,.:
//////////////////////////////////////////////////////////////





















namespace TurauaPW
{
    public partial class Form1 : Form
    {
        private DataTableCollection tableCollection;
        private string WorkDir = null;

        public Form1()
        {
            InitializeComponent();
        }






        /// <summary>   Обработка закгрузки приложения
        private void Form1_Load(object sender, EventArgs e)
        {
            tbUserName.Text = Settings.Default["UserNameDB"].ToString();
            tbPass.Text = Settings.Default["PassDB"].ToString();
            tbHost.Text = Settings.Default["HostConDB"].ToString();
            tbPort.Text = Settings.Default["PortConDB"].ToString();

        }
        /// </summary>






        /// <summary>                                                            ___███████▀◢▆▅▃ 　　　   　　 　　　 ▀▀████ONII CHAN
        ///     ФУНКЦИЯ ДЛЯ КОНВЕРТАЦИИ ФАЙЛА ТИПА .mp3 В ФОРМАТ ТИПА .wav       ___██████▌◢▀█▓▓█◣   　　　　　　▂▃▃　 ████onii chan
        /// <param name="path_mp3"> Путь к файлу типа .mp3  </param>             __▐▐█████▍▌▐▓▓▉　　　　　　　◢▓▓█ ▼ ████ONII CHAN
        /// <param name="path_wav"> Путь к создаваемому файлу типа .wav </param> __ ▌██████▎　 ▀▀▀　　　　　　 　█▓▓▌ ▌ █████▌onii chan
        ///                                                                      _▐ ██████▊　 ℳ 　　　　　　　▀◥◤▀    ▲████▉ONII CHAN
        ///                                                                      _▊ ███████◣ 　　　　　　  ′　　　ℳ　 ▃◢██████▐onii chan
        ///                                                                      _ ▉ ████████◣ 　　　　 ▃、　　　　　◢███▊███ ONII CHAN
        ///                                                                      _▉　 █████████▆▃　　　　　　　 ◢████▌ ███  onii chan
        ///                                                                      _ ▉　 ████▋████▉▀◥▅▃▃▅▇███▐██▋　▐██ONII CHAN
        private void ConverToWavFile(string path_mp3, string path_wav)
        {
            using (var reader = new Mp3FileReader(path_mp3))
            {
                WaveFileWriter.CreateWaveFile(path_wav, reader);
            }
        }
        /// </summary>
        





        /// <summary>   ФУНКЦИЯ ПОЛУЧЕНИЯ ДАННЫХ ИЗ Excel
        /// <param name="path">Путь до файла Excel</param>
        private void OpenExcelFile(string path)
        {
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

            DataSet db = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (x) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            tableCollection = db.Tables;
            tSselectListDataExcel.Items.Clear();

            foreach (DataTable table in tableCollection)
            {
                tSselectListDataExcel.Items.Add(table.TableName);
            }

            tSselectListDataExcel.SelectedIndex = 0;
        }
        /// </summary>






        /// <summary>   Возвращает строку поключения к типу БД "Interbase"
        ///                                                           ___███████▀◢▆▅▃ 　　　   　　 　　　 ▀▀████ONII CHAN
        ///      -   DB_path     ->  путь к подключаемой БД          ___██████▌◢▀█▓▓█◣   　　　　　　▂▃▃　 ████onii chan 
        ///      -   UserDB      ->  имя пользователя БД             __▐▐█████▍▌▐▓▓▉　　　　　　　◢▓▓█ ▼ ████ONII CHAN
        ///      -   UserPassDB  ->  пароль пользователя             __ ▌██████▎　 ▀▀▀　　　　　　 　█▓▓▌ ▌ █████▌onii chan
        ///      -   DB_Port     ->  порт соединения                 _▐ ██████▊　 ℳ 　　　　　　　▀◥◤▀    ▲████▉ONII CHAN
        ///      -   DB_Host     ->  хост, где расположена БД        _▊ ███████◣ 　　　　　　  ′　　　ℳ　 ▃◢██████▐onii chan
        ///                                                          _ ▉ ████████◣ 　　　　 ▃、　　　　　◢███▊███ ONII CHAN
        ///                                                          _▉　 █████████▆▃　　　　　　　 ◢████▌ ███  onii chan
        ///                                                          _ ▉　 ████▋████▉▀◥▅▃▃▅▇███▐██▋　▐██ONII CHAN
        private static IBConnectionStringBuilder
            BuildConnectionStringBuilder
                (   string DB_path,
                    string UserDB,
                    string UserPassDB,
                    string DB_Port,
                    string DB_Host  )
        {
            var builder = new IBConnectionStringBuilder();
            builder.UserID = UserDB;
            builder.Password = UserPassDB;
            builder.DataSource = DB_Host;
            builder.Database = DB_path;
            builder.Port = Convert.ToInt32(DB_Port);

            return builder;
        }
        /// </summary>






        /// <summary>   Выполнение SQL запроса к БД(INSERT SPR_SPEECH_TABLE)
        /// <param name="conn"> Строка подключение к БД </param>
        /// 
        /// <param name="S_TYPE"> Категория сообщения: 0 -> сеанс связи, 
        ///                                            1 -> текстовое сообщение, 
        ///                                            2 -> служебное сообщение 
        /// </param>
        /// 
        /// <param name="S_DATETIME"> Дата + время </param>
        /// 
        /// <param name="S_STANDARD"> Стандарт связи (GSM, Thuraya.....) </param>
        ///
        /// <param name="S_CALLTYPE">  Тип вызова: 0 -> входящий
        ///                                        1 -> исходящий
        ///                                        2 -> неизвестно
        /// </param>
        /// 
        /// <param name="S_PRIORITY"> Приоритет абонента (По умолчанию 16) </param>
        /// 
        /// <param name="S_TALKER"> Номер телефона </param>
        /// 
        /// <param name="S_BASESTATION"> Базовая станция </param>
        /// 
        /// <param name="S_POSTID"> Наименование поста </param>
        /// 
        /// <param name="S_SYSNUMBER3"> Идентификатор IMEI </param>
        /// 
        /// <param name="S_DURATION"> Длительность сеанса </param>
        /// 
        /// <param name="S_EVENTCODE"> Тип записи сенса: wavefile -> для звуковых
        ///                                              text     -> для текстовых
        /// </param>
        /// 
        public void InsertDataSPEECH
            (   IBConnection conn,
                string S_TYPE,
                string S_DATETIME,
                string S_STANDARD,
                string S_CALLTYPE,
                string S_PRIORITY,
                string S_TALKER,
                string S_BASESTATION,
                string S_POSTID,
                string S_SYSNUMBER3,
                string S_DURATION,
                string S_EVENTCODE         )
        {
            DbCommand cmd = conn.CreateCommand();

            cmd.CommandText = String.Format
                ("insert into SPR_SPEECH_TABLE " +
                    "(S_TYPE, S_DATETIME, S_STANDARD, " +
                     "S_CALLTYPE, S_PRIORITY, S_TALKER, " +
                     "S_BASESTATION, S_POSTID, S_SYSNUMBER3, " +
                     "S_DURATION, S_EVENTCODE) " +
                     "values " +
                     "({0},'{1}','{2}'," +
                      "{3},{4},{5}," +
                      "{6},_win1251 '{7}','{8}'," +
                      "'{9}','{10}');",
                      S_TYPE, S_DATETIME, S_STANDARD,
                      S_CALLTYPE, S_PRIORITY, S_TALKER,
                      S_BASESTATION, S_POSTID, S_SYSNUMBER3,
                      S_DURATION, S_EVENTCODE
                 );

            cmd.CommandType = CommandType.Text;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        /// </summary> 






        /// <summary>    Выполнение SQL запроса к БД (INSERT SPR_SP_DATA_1_TABLE)
        /// <param name="conn"> Строка подключения к БД </param>
        /// <param name="S_RECORTYPE"> Тип записи   </param>
        /// <param name="fileNameFSPEECH">  Путь до файла прямомого канала  </param>
        /// <param name="fileNameRSPEECH">  Путь до файла обратного канала  </param>
        private void InsertDataFILE
            (   IBConnection conn,
                string S_RECORTYPE,
                string fileNameFSPEECH,
                string fileNameRSPEECH      ) 
        {
            DbCommand cmd = conn.CreateCommand();

            cmd.CommandText = String.Format
                (   "insert into SPR_SP_DATA_1_TABLE" +
                    "(S_INCKEY, S_ORDER, S_RECORDTYPE, S_FSPEECH)" +
                    "values" +
                    "((select MAX(S_INCKEY) from SPR_SPEECH_TABLE)," +
                    "0," +
                    "'{0}'," +
                    "@S_FSPEECH);",S_RECORTYPE);

            DbParameter fspeech = cmd.CreateParameter();
            fspeech.ParameterName = "@S_FSPEECH";
            byte[] fileAsBytesFSPEECH = File.ReadAllBytes(fileNameFSPEECH);
            fspeech.Value = fileAsBytesFSPEECH;
            cmd.Parameters.Add(fspeech);


            if (fileNameRSPEECH != "NULL") 
            {
                DbParameter rspeech = cmd.CreateParameter();
                rspeech.ParameterName = "@S_RSPEECH";
                byte[] fileAsBytesRSPEECH = File.ReadAllBytes(fileNameRSPEECH);
                rspeech.Value = fileAsBytesRSPEECH;
                cmd.Parameters.Add(rspeech);
            }

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        /// </summary>






        /// <summary>  Функции для работы интерфейса
                /// Функция открытия\закрытия панели настроек
        private void OpenCloseSetingsPanel(int param) 
        {
            switch (param) 
            {
                case 0:

                    if (panelSETINGS.Visible == false)
                    {
                        panelSETINGS.Visible = true;
                    }

                    else
                    {
                        panelSETINGS.Visible = false;
                    }
                    break;

                case 1:

                    panelSETINGS.Visible = false;
                    break;
            }
        }
                /// Функция сохранение необходимых параметров
        private void SaveDataSettings() 
        {
            Settings.Default["UserNameDB"] = tbUserName.Text;
            Settings.Default["PassDB"] = tbPass.Text;
            Settings.Default["HostConDB"] = tbHost.Text;
            Settings.Default["PortConDB"] = tbPort.Text;
            Settings.Default.Save();
        }
        /// </summary>






        /// <summary>   Функция копирования пустой БД
        /// <param name="fileName">Путь и имя файла для копирования файла</param>
        /// <param name="pathDB">TextBox для хранения пути БД в которую еплицируются данные</param>
        /// <param name="tsl">Label в панели ToolStrip для отображения пользователю БД для репликации</param>
        private void CopyEmptyDbIBS(string fileName, TextBox pathDB, ToolStripLabel tsl)
        {
            try
            {
                File.Copy(@"data\EMPTY.IBS", fileName, false);
                pathDB.Text = fileName;
                tsl.Text = Path.GetFileName(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// </summary>






        /// <summary>   Функция определения номера столбца с данными
        /// <param name="dgv">DataGridView от куда берутся данные для проверки</param>
        /// <param name="Date">TextBox который храит номер стобца (Дата)</param>
        /// <param name="Time">TextBox который храит номер стобца (Время)</param>
        /// <param name="Standart">TextBox который храит номер стобца (Стандарт)</param>
        /// <param name="CallType">TextBox который храит номер стобца (Тип вызова)</param>
        /// <param name="Sobesednik">TextBox который храит номер стобца (Собеседник)</param>
        /// <param name="BS">TextBox который храит номер стобца (Базовая станция)</param>
        /// <param name="Post">TextBox который храит номер стобца (Пост)</param>
        /// <param name="IMEI">TextBox который храит номер стобца (IMEI)</param>
        /// <param name="Dlitelnost">TextBox который храит номер стобца (Длительность)</param>
        /// <param name="File">TextBox который храит номер стобца (Файл)</param>
        private void GetNumberColumnForData
            (   DataGridView dgv,
                TextBox Date,
                TextBox Time,
                TextBox Standart,
                TextBox CallType,
                TextBox Sobesednik,
                TextBox BS,
                TextBox Post,
                TextBox IMEI,
                TextBox Dlitelnost,
                TextBox File        )
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (!dataGridView1.Columns[i].HeaderText.Contains(@"Столбец №"))
                    dataGridView1.Columns[i].HeaderText += "\nСтолбец № " + (i + 1).ToString();

                if (    dataGridView1[i, 0].Value.ToString().Contains(@"mp3") ||
                        dataGridView1[i, 0].Value.ToString().Contains(@"txt")       )
                    File.Text = (i + 1).ToString();

                switch (dataGridView1.Columns[i].Name.ToString())
                {
                    case string a when a.Contains(@"Дата"):
                        Date.Text = (i + 1).ToString();
                        break;

                    case string a when a.Contains(@"Время"):
                        Time.Text = (i + 1).ToString();
                        break;

                    case string a when a.Contains(@"Стандарт") || a.Contains(@"Система связи"):
                        Standart.Text = (i + 1).ToString();
                        break;

                    case string a when a.Contains(@"Направление"):
                        CallType.Text = (i + 1).ToString();
                        break;

                    case string a when a.Contains(@"ТФОП (кор)"):
                        Sobesednik.Text = (i + 1).ToString();
                        break;

                    case string a when a.Contains(@"Луч"):
                        BS.Text = (i + 1).ToString();
                        break;

                    case string a when a.Contains(@"Пост") || a.Contains(@"АПК"):
                        Post.Text = (i + 1).ToString();
                        break;

                    case string a when a.Contains(@"IMEI"):
                        IMEI.Text = (i + 1).ToString();
                        break;

                    case string a when a.Contains(@"Длит"):
                        Dlitelnost.Text = (i + 1).ToString();
                        break;

                    case string a when a.Contains(@"Запись"):
                        File.Text = (i + 1).ToString();
                        break;
                }
            }
        }
        /// </summary>






        /// <summary>
        /// <param name="dgv">  DataGridView в котором небходимые данные для репликации в БД    </param>
        /// <param name="ResulFile">    label в котором выводиться успешное колво обработыных файлов    </param>
        /// <param name="button">   ToolStripButton отвечающий за начало репликации в БД    </param>
        private async void Replicated
            (   DataGridView dgv, 
                Label ResulFile, 
                ToolStripButton button, 
                ToolStripProgressBar progressBar    )
        {
            button.Text = "Идет репликация";
            button.Enabled = false;
            timer1.Start();

            int ResultOKParam = 0;
            ResulFile.Visible = true;
            ResulFile.Text = ResultOKParam.ToString();

            await Task.Run(() =>
            {
                try
                {
                    using (var connection =
                        new IBConnection(BuildConnectionStringBuilder(tbPathDB.Text,
                                                                        tbUserName.Text,
                                                                        tbPass.Text,
                                                                        tbPort.Text,
                                                                        tbHost.Text).ToString()))
                    {
                        for (int row = 0; row < dgv.RowCount; row++)
                        {
                            string callType = string.Empty;
                            string namesFiles = string.Empty;
                            string nameFile = string.Empty;
                            int countFiles = 0;

                            if (dgv[Convert.ToInt32(tbCallTypeExcel.Text) - 1, row].Value.ToString() == "→")
                            {
                                callType = "1";
                            }
                            else if (dgv[Convert.ToInt32(tbCallTypeExcel.Text) - 1, row].Value.ToString() == "←")
                            {
                                callType = "0";
                            }
                            else
                            {
                                callType = "2";
                            }

                            string duration = dgv[Convert.ToInt32(tbDlitelnostExcel.Text) - 1, row].Value.ToString();

                            int countDuration = 0;
                            foreach (Match m in Regex.Matches(duration, ":"))
                                countDuration++;

                            if (countDuration != 2)
                            {
                                duration = "00:" + duration;
                            }

                            switch (dgv[Convert.ToInt32(tbFileExcel.Text) - 1, row].Value.ToString())
                            {
                                //  Один звуковой файл
                                case string a when a.Contains(@".mp3") && !a.Contains(@";"):

                                    ConverToWavFile
                                        (   String.Format("{0}\\{1}", WorkDir, a),
                                            String.Format("{0}\\{1}.wav", WorkDir, Path.GetFileNameWithoutExtension(a)) );

                                    InsertDataSPEECH
                                        (connection,
                                            "0",
                                            String.Format
                                                ("{0} {1}",
                                                    dgv[Convert.ToInt32(tbDateExcel.Text) - 1, row].Value.ToString(),
                                                    dgv[Convert.ToInt32(tbTimeExcel.Text) - 1, row].Value.ToString()),
                                            dgv[Convert.ToInt32(tbStandartExcel.Text) - 1, row].Value.ToString(),
                                            callType,
                                            "16",
                                            dgv[Convert.ToInt32(tbSobesExcel.Text) - 1, row].Value.ToString(),
                                            dgv[Convert.ToInt32(tbBsExcel.Text) - 1, row].Value.ToString(),
                                            dgv[Convert.ToInt32(tbPostExcel.Text) - 1, row].Value.ToString(),
                                            dgv[Convert.ToInt32(tbImeiExcel.Text) - 1, row].Value.ToString(),
                                            duration,
                                            "WAVEFILE");

                                    InsertDataFILE
                                        (connection,
                                            "WAVEFILE",
                                            String.Format("{0}\\{1}.wav", WorkDir, Path.GetFileNameWithoutExtension(a)),
                                            "NULL");

                                    File.Delete(String.Format("{0}\\{1}.wav", WorkDir, Path.GetFileNameWithoutExtension(a)));

                                    ResultOKParam++;
                                    break;

                                //  Без файлов, однин биллинг
                                case string a when !a.Contains(@".mp3") && !a.Contains(@".txt"):

                                    InsertDataSPEECH
                                        (connection,
                                            "2",
                                            String.Format
                                                ("{0} {1}",
                                                    dgv[Convert.ToInt32(tbDateExcel.Text) - 1, row].Value.ToString(),
                                                    dgv[Convert.ToInt32(tbTimeExcel.Text) - 1, row].Value.ToString()),
                                            dgv[Convert.ToInt32(tbStandartExcel.Text) - 1, row].Value.ToString(),
                                            callType,
                                            "16",
                                            dgv[Convert.ToInt32(tbSobesExcel.Text) - 1, row].Value.ToString(),
                                            dgv[Convert.ToInt32(tbBsExcel.Text) - 1, row].Value.ToString(),
                                            dgv[Convert.ToInt32(tbPostExcel.Text) - 1, row].Value.ToString(),
                                            dgv[Convert.ToInt32(tbImeiExcel.Text) - 1, row].Value.ToString(),
                                            duration,
                                            "NULL");

                                    ResultOKParam++;
                                    break;

                                //  Текстовые записи
                                case string a when a.Contains(@".txt") && !a.Contains(@";"):

                                    InsertDataSPEECH
                                       (connection,
                                           "1",
                                           String.Format
                                               ("{0} {1}",
                                                   dgv[Convert.ToInt32(tbDateExcel.Text) - 1, row].Value.ToString(),
                                                   dgv[Convert.ToInt32(tbTimeExcel.Text) - 1, row].Value.ToString()),
                                           dgv[Convert.ToInt32(tbStandartExcel.Text) - 1, row].Value.ToString(),
                                           callType,
                                           "16",
                                           dgv[Convert.ToInt32(tbSobesExcel.Text) - 1, row].Value.ToString(),
                                           dgv[Convert.ToInt32(tbBsExcel.Text) - 1, row].Value.ToString(),
                                           dgv[Convert.ToInt32(tbPostExcel.Text) - 1, row].Value.ToString(),
                                           dgv[Convert.ToInt32(tbImeiExcel.Text) - 1, row].Value.ToString(),
                                           duration,
                                           "windows-1251");

                                    InsertDataFILE
                                       (connection,
                                           "windows-1251",
                                           String.Format("{0}\\{1}", WorkDir, a),
                                           "NULL");

                                    ResultOKParam++;
                                    break;

                                //  Несколько звуковых файлов
                                case string a when a.Contains(@".mp3") && a.Contains(@";") && !a.Contains(@".txt"):

                                    namesFiles = a;
                                    countFiles = 0;
                                    foreach (Match m in Regex.Matches(namesFiles, ";"))
                                        countFiles++;

                                    for (int countFile = 0; countFile < countFiles + 1; countFile++) 
                                    {
                                        if (countFile != countFiles) 
                                        {
                                            nameFile = namesFiles.Substring(0, namesFiles.IndexOf(";"));
                                            namesFiles = namesFiles.Remove(0, namesFiles.IndexOf(";") + 1);
                                        }

                                        else 
                                        {
                                            nameFile = namesFiles;
                                        }

                                        ConverToWavFile
                                        (   String.Format("{0}\\{1}", WorkDir, nameFile),
                                            String.Format("{0}\\{1}.wav", WorkDir, Path.GetFileNameWithoutExtension(nameFile))  );

                                        InsertDataSPEECH
                                        (   connection,
                                            "0",
                                            String.Format
                                                ("{0} {1}",
                                                    dgv[Convert.ToInt32(tbDateExcel.Text) - 1, row].Value.ToString(),
                                                    dgv[Convert.ToInt32(tbTimeExcel.Text) - 1, row].Value.ToString()),
                                            dgv[Convert.ToInt32(tbStandartExcel.Text) - 1, row].Value.ToString(),
                                            callType,
                                            "16",
                                            dgv[Convert.ToInt32(tbSobesExcel.Text) - 1, row].Value.ToString(),
                                            dgv[Convert.ToInt32(tbBsExcel.Text) - 1, row].Value.ToString(),
                                            dgv[Convert.ToInt32(tbPostExcel.Text) - 1, row].Value.ToString(),
                                            dgv[Convert.ToInt32(tbImeiExcel.Text) - 1, row].Value.ToString(),
                                            duration,
                                            "WAVEFILE"  );

                                        InsertDataFILE
                                            (   connection,
                                                "WAVEFILE",
                                                String.Format ("{0}\\{1}.wav", WorkDir, Path.GetFileNameWithoutExtension(nameFile)),
                                                "NULL"  );

                                        File.Delete
                                            (   String.Format("{0}\\{1}.wav", WorkDir, Path.GetFileNameWithoutExtension(nameFile)));
                                    }

                                    ResultOKParam++;
                                    break;

                                //  Звуковые + Текст
                                case string a when a.Contains(@".mp3") && a.Contains(@".txt") && a.Contains(@";"):
                                    
                                    namesFiles = a;
                                    countFiles = 0;
                                    foreach (Match m in Regex.Matches(namesFiles, ";"))
                                        countFiles++;

                                    for (int countFile = 0; countFile < countFiles + 1; countFile++) 
                                    {
                                        if (countFile != countFiles)
                                        {
                                            nameFile = namesFiles.Substring(0, namesFiles.IndexOf(";"));
                                            namesFiles = namesFiles.Remove(0, namesFiles.IndexOf(";") + 1);
                                        }

                                        else
                                        {
                                            nameFile = namesFiles;
                                        }

                                        switch (nameFile) 
                                        {
                                            //  Если звук
                                            case string b when b.Contains(@".mp3"):

                                                ConverToWavFile
                                                (   String.Format("{0}\\{1}", WorkDir, nameFile),
                                                    String.Format("{0}\\{1}.wav", WorkDir, Path.GetFileNameWithoutExtension(nameFile))  );

                                                InsertDataSPEECH
                                                (   connection,
                                                    "0",
                                                    String.Format
                                                        ("{0} {1}",
                                                            dgv[Convert.ToInt32(tbDateExcel.Text) - 1, row].Value.ToString(),
                                                            dgv[Convert.ToInt32(tbTimeExcel.Text) - 1, row].Value.ToString()),
                                                    dgv[Convert.ToInt32(tbStandartExcel.Text) - 1, row].Value.ToString(),
                                                    callType,
                                                    "16",
                                                    dgv[Convert.ToInt32(tbSobesExcel.Text) - 1, row].Value.ToString(),
                                                    dgv[Convert.ToInt32(tbBsExcel.Text) - 1, row].Value.ToString(),
                                                    dgv[Convert.ToInt32(tbPostExcel.Text) - 1, row].Value.ToString(),
                                                    dgv[Convert.ToInt32(tbImeiExcel.Text) - 1, row].Value.ToString(),
                                                    duration,
                                                    "WAVEFILE"  );

                                                InsertDataFILE
                                                    (   connection,
                                                        "WAVEFILE",
                                                        String.Format("{0}\\{1}.wav", WorkDir, Path.GetFileNameWithoutExtension(nameFile)),
                                                        "NULL"  );

                                                File.Delete
                                                    (String.Format("{0}\\{1}.wav", WorkDir, Path.GetFileNameWithoutExtension(nameFile)));

                                                break;

                                            //  Если текст
                                            case string b when b.Contains(@".txt"):

                                                InsertDataSPEECH
                                                (   connection,
                                                    "1",
                                                    String.Format
                                                    ("{0} {1}",
                                                        dgv[Convert.ToInt32(tbDateExcel.Text) - 1, row].Value.ToString(),
                                                        dgv[Convert.ToInt32(tbTimeExcel.Text) - 1, row].Value.ToString()),
                                                    dgv[Convert.ToInt32(tbStandartExcel.Text) - 1, row].Value.ToString(),
                                                    callType,
                                                    "16",
                                                    dgv[Convert.ToInt32(tbSobesExcel.Text) - 1, row].Value.ToString(),
                                                    dgv[Convert.ToInt32(tbBsExcel.Text) - 1, row].Value.ToString(),
                                                    dgv[Convert.ToInt32(tbPostExcel.Text) - 1, row].Value.ToString(),
                                                    dgv[Convert.ToInt32(tbImeiExcel.Text) - 1, row].Value.ToString(),
                                                    duration,
                                                    "windows-1251"  );

                                                InsertDataFILE
                                                   (    connection,
                                                       "windows-1251",
                                                       String.Format("{0}\\{1}", WorkDir, nameFile),
                                                       "NULL"   );
                                                break;
                                        }
                                    }

                                    ResultOKParam++;
                                    break;
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            ResulFile.Text = ResultOKParam.ToString();
            timer1.Stop();
            progressBar.Value = 0;

            button.Text = "Реплицировать";
            button.Enabled = true;

        }
        /// </summary>





        
        /// <summary> ВЕРХНЕЕ МЕНЮ
            ///  Обработка открытия файла
        private void TSMItemFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel(*.xls;*.xlsx)|*.xls*";

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) 
                {
                    OpenExcelFile(openFileDialog1.FileName);
                    WorkDir = Path.GetDirectoryName(openFileDialog1.FileName);

                    toolStrip1.Visible = true;
                    InformationData.Visible = true;

                    GetNumberColumnForData
                        (   dataGridView1,
                            tbDateExcel,
                            tbTimeExcel,
                            tbStandartExcel,
                            tbCallTypeExcel,
                            tbSobesExcel,
                            tbBsExcel,
                            tbPostExcel,
                            tbImeiExcel,
                            tbDlitelnostExcel,
                            tbFileExcel     );

                    AllFileDataParam.Text = dataGridView1.RowCount.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            ///  Открытие\закрытие панели настроек
        private void TSMItemSetings_Click(object sender, EventArgs e)
        {
            OpenCloseSetingsPanel(0);
        }
            ///  Открытие справочной информации          
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
        /// </summary>






        /// <summary> ПАНЕЛЬ НИЖЕ МЕНЮ
        ///  Открытие определенного листа в Excel
        private void tSselectListDataExcel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tableCollection[tSselectListDataExcel.SelectedIndex];
        }
            /// Обработка репликации
        private void tSBreturnResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbPathDB.Text != String.Empty)
                {
                    ResultOKFileText.Visible = true;
                    Replicated(dataGridView1, ResultOKFileParam, tSBreturnResult, toolStripProgressBar1);
                }

                else
                {
                    DialogResult result =
                        MessageBox.Show("Создать БД SPRUT версии 3.8?",
                                            "База данных для репликации не выбрана",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Information);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            saveFileDialog1.Filter = "ibs(*.ibs)|*.ibs";

                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                                CopyEmptyDbIBS(saveFileDialog1.FileName, tbPathDB, toolStripLabel3);

                            ResultOKFileText.Visible = true;
                            Replicated(dataGridView1, ResultOKFileParam, tSBreturnResult, toolStripProgressBar1);
                            break;

                        case DialogResult.No:
                            MessageBox.Show("Выберите БД в которую реплицировать данные.", "", MessageBoxButtons.OK);
                            break;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// </summary>






        /// <summary>   ПАНЕЛЬ НАСТРОЕК
            ///  Закрытие панели настроек
        private void ClosePanelSetings_Click(object sender, EventArgs e)
        {
            OpenCloseSetingsPanel(0);
        }
            ///  Установка настроек подключение к БД(По умолчанию)
        private void SetingsConnDef_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "sysdba";
            tbPass.Text = "masterkey";
            tbPort.Text = "3050";
            tbHost.Text = "localhost";
        }
            ///  Выбор БД для подключения
        private void SelectDbPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Interbase(*.IBS)|*.IBS";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                tbPathDB.Text = openFileDialog1.FileName;
                toolStripLabel3.Text = Path.GetFileName(openFileDialog1.FileName);
            }

        }
            ///  Проверка соеденеия с БД
        private void ConectionTest_Click(object sender, EventArgs e)
        {
            if (    tbPathDB.Text == String.Empty || 
                    tbUserName.Text == String.Empty || 
                    tbPass.Text == String.Empty || 
                    tbPort.Text == String.Empty ||
                    tbHost.Text == String.Empty     )
            {
                MessageBox.Show(    "Заполните поля в настройках",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information    );
            }

            else 
            {
                try
                {
                    using (var connection =
                        new IBConnection(BuildConnectionStringBuilder(tbPathDB.Text,
                                                                        tbUserName.Text,
                                                                        tbPass.Text,
                                                                        tbPort.Text,
                                                                        tbHost.Text).ToString()))
                    {
                        connection.Open();
                        MessageBox.Show("Соединение успешное.");
                    }
                }

                catch (Exception ErrorConn)
                {
                    MessageBox.Show(    ErrorConn.ToString(),
                                        "Ошибка соединения",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error    );
                }
            }
        }
        /// Сохранение настроек подключения
        private void SaveSettingsConnect_Click(object sender, EventArgs e)
        {
            SaveDataSettings();
        }
        /// </summary>






        /// <summary>   Обработка ввода только цифровых значений в TextBox для номеров столбцов
        private void tbDateExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void tbTimeExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void tbStandartExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void tbCallTypeExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void tbSobesExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void tbBsExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void tbPostExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void tbImeiExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void tbDlitelnostExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void tbFileExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        /// </summary>






        /// <summary>   Обработка закрытия приложения
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataSettings();
        }
        /// </summary>






        /// <summary>   Обработка закрытия панели настроек
        ///                 при активирование других элементов интерфейса
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            OpenCloseSetingsPanel(1);
        }
        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            OpenCloseSetingsPanel(1);
        }
        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            OpenCloseSetingsPanel(1);
        }
        private void toolStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            OpenCloseSetingsPanel(1);
        }
        /// </summary>






        /// <summary>   Обработка индикации репликации (progressBar)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value == 100)
            {
                toolStripProgressBar1.Value = 0;
            }

            else
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Value + 1;
            }
        }
        /// </summary>
    }
}