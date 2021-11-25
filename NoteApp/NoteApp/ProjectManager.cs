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
        private static string FolderPath { get; } = 
            $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\NoteApp\";

        /// <summary>
        /// Название файла
        /// </summary>
        private static string FileName { get; } = "NoteList.json";

        /// <summary>
        /// Сохранение проекта в файл
        /// </summary>
        /// <param name="project">Проект, содержащий список заметок</param>
        public static void SaveTo(Project project)
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            if (!File.Exists(FileName))
            {
                File.Create(FileName);
            }

            using (StreamWriter streamwriter = new StreamWriter(FolderPath + FileName))
            using (JsonWriter jsonwriter = new JsonTextWriter(streamwriter))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(jsonwriter, project);
            }
        }

        /// <summary>
        /// Загружает (десериализует) данные из файла JSON
        /// </summary>
        /// <returns>Новый экземпляр класса Project</returns>
        public static Project LoadFrom()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            if (!File.Exists(FileName))
            {
                return new Project();
            }

            try
            {
                using (StreamReader streamreader = new StreamReader(FolderPath + FileName))
                {
                    using (JsonReader jsonreader = new JsonTextReader(streamreader))
                    {
                        var serializer = new JsonSerializer();
                        var project = serializer.Deserialize<Project>(jsonreader);

                        return project ?? new Project();
                    }
                }
            }
            catch (Exception)
            {
                return new Project();
            }
        }
    }
}
