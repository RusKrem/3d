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
        /// ������ ���������� ������ ��� ������ � �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddInDictionady_Click(object sender, EventArgs e)
        {
            // ��������� ��� �����
            AddTestName(textBoxTestName);
            AddingData();
            
        }

        /// <summary>
        /// ��������� ��� �����
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
        /// ��������� ������ � �������
        /// </summary>
        private void AddingData()
        {
            try // ������� �������� ������ � �������
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
                // ������ ���� � �������
                AddForm errorForm = new AddForm("Error! Unknown format data.");
                errorForm.ShowDialog();
                settings.SettingsList.Clear();
                return;
            }
        }

        /// <summary>
        /// ������ ������ ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            // ���� �������� ������
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
                // ������ ������
                RecordData();
            }
        }

        /// <summary>
        /// ��������� ������� ������ � �������
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        private bool dataIsAdding(Settings settings)
        {
            return settings.SettingsList.Count > 0;
        }

        /// <summary>
        /// ���������� ������
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
        /// ������� ������� ����� �� ������
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
        /// �������� ���������� ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
