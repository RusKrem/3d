namespace _3d
{
    internal class Settings
    {

        // Свойство для доступа к объектам
        public Dictionary<string, int> SettingsList { get; private set; }

        // Свойство дял доступа к имени
        public string Name { get; set; }

        // конструктор
        public Settings()
        {
            SettingsList = new Dictionary<string, int>();

        }
    }
}
