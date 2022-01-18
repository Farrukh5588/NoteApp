using System;
using System.IO;
using System.Reflection;

namespace NoteApp.UnitTests
{
    /// <summary>
    /// Класс для генерации данных
    /// </summary>
    public class Common
    {
        /// <summary>
        /// Обращение к пути
        /// </summary>
        public static string DataFolderForTest()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(location) + @"\TestData";
        }

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public static string FilePath()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return path + @"\NoteApp\Note.json";
        }
    }
}
