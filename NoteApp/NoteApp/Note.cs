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

        private string _notetext;

        /// <summary>
        /// Конструктор описывающий Заметки
        /// </summary>
        /// <param name="name">Входящий параметр, определяющий заголовок заметки (необяз.)</param>
        /// <param name="noteText">Входящий параметр, определяющий текст заметки (необяз.)</param>
        /// <param name="noteCategory">Входящий параметр, определяющий категорию заметки (необяз.)</param>
        public Note(string name = "Без названия", string noteText = "", NoteCategory noteCategory = NoteCategory.Other)
        {
            Name = name;
            NoteText = noteText;
            NoteCategory = noteCategory;

            DateOfLastEdit = DateTime.Now;
            DateOfCreation = DateTime.Now;
        }

        /// <summary>
        /// Заголовок заметки
        /// </summary>
        public string Name
        {
            get
            { 
                return _name;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Введенное значение больше 50 символов!");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Категория заметки
        /// </summary>
        public NoteCategory NoteCategory { get; set; }

        /// <summary>
        /// Текст заметки
        /// </summary>
        public string NoteText
        { 
            get
            {
                return _notetext; 
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Нет значениния содержимого");
                }
                _notetext = value;
            }
        }

        /// <summary>
        /// Время создания заметки
        /// </summary>
        public DateTime DateOfCreation { get; set; }

        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        public DateTime DateOfLastEdit { get; set; }

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
                DateOfCreation = this.DateOfCreation,
                DateOfLastEdit = this.DateOfLastEdit,
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
                DateOfCreation == other.DateOfCreation && DateOfLastEdit == other.DateOfLastEdit;
        }
    }
}
