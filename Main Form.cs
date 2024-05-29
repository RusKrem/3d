namespace _3d
{
    public partial class MainForm : Form
    {
        Settings settings = new Settings();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка добавления данных для записи в словарь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddInDictionady_Click(object sender, EventArgs e)
        {
            // Записываю имя теста
            AddTestName(textBoxTestName);
            AddingData();
            
        }

        /// <summary>
        /// Добавляет имя теста
        /// </summary>
        /// <param name="textBox"></param>
        private void AddTestName(TextBox textBox)
        {
            textBox.Text = textBoxTestName.Text;
            if (textBoxTestName.Text.Length == 0)
            {
                settings.Name = "No Name";
            }
            else
            {
                settings.Name = textBoxTestName.Text;
            }
        }

        /// <summary>
        /// Добавляет данные в словарь
        /// </summary>
        private void AddingData()
        {
            try // попытка добавить данные в словарь
            {
                settings.SettingsList.Add(labelSpeed.Text, Convert.ToInt32(textBoxSpeed.Text));
                settings.SettingsList.Add(labelPrintingTemperature.Text, Convert.ToInt32(textBoxPrintTemp.Text));
                settings.SettingsList.Add(labelTableTemp.Text, Convert.ToInt32(textBoxTableTemp.Text));
                settings.SettingsList.Add(labelMinVentilationSpeed.Text, Convert.ToInt32(textBoxMinVentSped.Text));
                settings.SettingsList.Add(labelMaxVentilationSpeed.Text, Convert.ToInt32(textBoxMaxVentSped.Text));
                AddForm addForm = new AddForm("Data added.");
                addForm.ShowDialog();
            }
            catch (Exception)
            {
                // Второе окно с ошибкой
                AddForm errorForm = new AddForm("Error! Unknown format data.");
                errorForm.ShowDialog();
                settings.SettingsList.Clear();
                return;
            }
        }

        /// <summary>
        /// Кнопка записи данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            // флаг проверки данных
            bool count = dataIsAdding(settings);
            if (!count)
            {
                AddForm noDataForm = new AddForm("No find data field.");
                noDataForm.ShowDialog();
                ClearColumns();
                return;
            }
            else
            {
                // Запись данных
                RecordData();
            }
        }

        /// <summary>
        /// Проверяет наличие данных в словаре
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        private bool dataIsAdding(Settings settings)
        {
            return settings.SettingsList.Count > 0;
        }

        /// <summary>
        /// Записывает данные
        /// </summary>
        private void RecordData()
        {
            Recording rec = new Recording();
            rec.Record(settings, settings.SettingsList);
            ClearColumns();
            AddForm successfulForm = new AddForm("Successful recording.");
            successfulForm.ShowDialog();
            settings.SettingsList.Clear();
            return;
        }

        /// <summary>
        /// Очищает колонки формы от данных
        /// </summary>
        private void ClearColumns()
        {
            textBoxTestName.Clear();
            textBoxSpeed.Clear();
            textBoxPrintTemp.Clear();
            textBoxTableTemp.Clear();
            textBoxMinVentSped.Clear();
            textBoxMaxVentSped.Clear();
        }

        /// <summary>
        /// Закрываю завершения программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
