using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace NoteApp
{
    /// <summary>
    /// Сервисный класс, предоставляющий методы для сериализации/десериализации класса "Project"
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Путь к папке с файлом
        /// </summary>
        public static string FolderPath
        {
            get
            {
                var appDataFolder =
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var path = appDataFolder + @"\NoteApp\Note.json";
                return path;
            }
        }

        /// <summary>
        /// Сохранение проекта в файл
        /// </summary>
        /// <param name="project">Проект, содержащий список заметок</param>
        public static void SaveToFile(Project project, string filePath)
        {
            var directoryFile = Path.GetDirectoryName(filePath);
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryFile);
            if (!Directory.Exists(directoryFile))
            {
                directoryInfo.Create();
            }

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, project);
                }
            }
        }

        /// <summary>
        /// Загружает (десериализует) данные из файла JSON
        /// </summary>
        /// <returns>Новый экземпляр класса Project</returns>
        public static Project LoadFromFile(string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    Project emptyProject = new Project();
                    return emptyProject;
                }
                var project = new Project();
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(filename))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = serializer.Deserialize<Project>(reader);
                }
                return project;
            }
            catch (Exception exception)
            {
                return new Project();
            }
        }
    }
}
