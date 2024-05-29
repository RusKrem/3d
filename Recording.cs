namespace _3d
{
    internal class Recording
    {
        /// <summary>
        /// Запись данных в файл
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="dictionary"></param>
        public void Record(Settings settings, Dictionary<string, int> dictionary)
        {
            // Путь для создания файла (корневой каталог программы)
            string path = AppDomain.CurrentDomain.BaseDirectory;

            // Имя создаваемого файла
            string fileName = "data.txt";

            // Создаю ЭК для записи
            StreamWriter streamWriter = new StreamWriter(path + fileName, true);

            dictionary = settings.SETTINGS;
            string name = settings.Name;

            streamWriter.WriteLine($"{name}:");

            // записываю данные в файл
            foreach (var kvp in dictionary)
            {
                string key = kvp.Key;
                int value = kvp.Value;
                streamWriter.WriteLine($"{key}: {value}");
            }
            streamWriter.WriteLine();

            //  закрываю (заканчиваю) запись
            streamWriter.Close();
        }
    }
}
