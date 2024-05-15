namespace _3d
{
    internal class Settings
    {
        // Поле для хранения листа
        private Dictionary<string, int> _settingsList;

        // Свойство для доступа к объектам
        public Dictionary<string, int> SETTINGS { get; private set; }

        // Имя теста
        private string _name = "";

        // Свойство дял доступа к имени
        public string Name { get; set; }

        // конструктор
        public Settings()
        {
            _settingsList = new Dictionary<string, int>();
            SETTINGS = _settingsList;
            _name = Name;
        }
    }
}
