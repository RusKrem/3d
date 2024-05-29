namespace _3d
{
    internal class Settings
    {

        // Свойство для доступа к объектам
        public Dictionary<string, int> SETTINGS { get; private set; }

        // Свойство дял доступа к имени
        public string Name { get; set; }

        // конструктор
        public Settings()
        {
            SETTINGS = new Dictionary<string, int>();

        }
    }
}
