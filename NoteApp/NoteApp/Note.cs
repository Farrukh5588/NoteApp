using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс "Заметки", содержащий информацию о каждой заметке.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Имя заметки. Взаимодействует с Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Конструктор, вызываемый при создании экземпляра класса "Note"
        /// </summary>
        /// <param name="name">Входящий параметр, определяющий заголовок заметки (необяз.)</param>
        /// <param name="noteText">Входящий параметр, определяющий текст заметки (необяз.)</param>
        /// <param name="noteCategory">Входящий параметр, определяющий категорию заметки (необяз.)</param>
        public Note(string name = "Без названия", string noteText = "", NoteCategory noteCategory = NoteCategory.Other)
        {
            Name = name;
            NoteText = noteText;
            NoteCategory = noteCategory;

            LastModifyTime = DateTime.Now;
            CreationTime = LastModifyTime;
        }

        /// <summary>
        /// Заголовок заметки. Выбрасывает исключение при попытке установить длину заголовка больше 50
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length <= 50)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Введенное значение больше 50 символов!");
                }
            }
        }
        /// <summary>
        /// Категория заметки
        /// </summary>
        public NoteCategory NoteCategory { get; set; }

        /// <summary>
        /// Текст заметки
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// Время создания заметки
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        public DateTime LastModifyTime { get; set; }

        /// <summary>
        /// Метод, осуществляющий создание копии выбранной заметки
        /// </summary>
        /// <returns>Новый экземпляр заметки с идентичными параметрами</returns>
        public object Clone()
        {
            return new Note
            {
                Name = this.Name,
                NoteText = this.NoteText,
                CreationTime = this.CreationTime,
                LastModifyTime = this.LastModifyTime,
                NoteCategory = this.NoteCategory
            };
        }

        /// <summary>
        /// Сравнивает значения двух заметок
        /// </summary>
        /// <param name="obj">Заметка, с которой идет сравнение</param>
        /// <returns>true, если все поля одной заметки совпадают с другой, иначе - false</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Note other))
            {
                return false;
            }

            return Name == other.Name && NoteText == other.NoteText && NoteCategory == other.NoteCategory &&
                CreationTime == other.CreationTime && LastModifyTime == other.LastModifyTime;
        }

        /// <summary>
        /// Отображает заметку в списке только по её заголовку
        /// </summary>
        /// <returns>Имя заметки</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
