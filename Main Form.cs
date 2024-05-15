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
            Addingdata();
            
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
        private void Addingdata()
        {
            try // ������� �������� ������ � �������
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
                // ������ ���� � �������
                ErrorForm form2 = new ErrorForm();
                form2.ShowDialog();
                settings.SETTINGS.Clear();
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
            Recording rec = new Recording();
            rec.Record(settings, settings.SETTINGS);
            ClearColumns();
            Form formSucc = new Sucsess();
            formSucc.ShowDialog();
            settings.SETTINGS.Clear();
        }

        /// <summary>
        /// ������� ������� ������� ������
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
