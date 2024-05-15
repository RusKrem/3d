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
            Addingdata();
            
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
        private void Addingdata()
        {
            try // попытка добавить данные в словарь
            {
                settings.SETTINGS.Add(labelSpeed.Text, Convert.ToInt32(textBoxSpeed.Text));
                settings.SETTINGS.Add(labelPrintingTemperature.Text, Convert.ToInt32(textBoxPrintTemp.Text));
                settings.SETTINGS.Add(labelTableTemp.Text, Convert.ToInt32(textBoxTableTemp.Text));
                settings.SETTINGS.Add(labelMinVentilationSpeed.Text, Convert.ToInt32(textBoxMinVentSped.Text));
                settings.SETTINGS.Add(labelMaxVentilationSpeed.Text, Convert.ToInt32(textBoxMaxVentSped.Text));
                AddForm addForm = new AddForm();
                addForm.ShowDialog();
            }
            catch (Exception)
            {
                // Второе окно с ошибкой
                ErrorForm form2 = new ErrorForm();
                form2.ShowDialog();
                settings.SETTINGS.Clear();
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
            Recording rec = new Recording();
            rec.Record(settings, settings.SETTINGS);
            ClearColumns();
            Form formSucc = new Sucsess();
            formSucc.ShowDialog();
            settings.SETTINGS.Clear();
        }

        /// <summary>
        /// Очищает колонки формыот данных
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
