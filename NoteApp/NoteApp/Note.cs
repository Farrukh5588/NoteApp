using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        /// Текст заметки 
        /// </summary>
        private string _notetext;

        /// <summary>
        /// Конструктор описывающий Заметки
        /// </summary>
        /// <param name="name"></param>
        /// <param name="noteText"></param>
        /// <param name="noteCategory"></param>
        /// <param name="dateOfCreation"></param>
        /// <param name="dateOfLastEdit"></param>
        
        [JsonConstructor]
        public Note (string name, string noteText, NoteCategory noteCategory, 
            DateTime dateOfCreation, DateTime dateOfLastEdit)
        {
            Name = name;
            NoteText = noteText;
            NoteCategory = noteCategory;

            DateOfLastEdit = dateOfLastEdit;
            DateOfCreation = dateOfCreation;
        }

        /// <summary>
        /// Конструктор класса без параметров
        /// </summary>
        public Note()
        {

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
                    throw new ArgumentException("Note name is greater than 50 characters!");
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
                    throw new ArgumentException("No content value");
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
            return this.MemberwiseClone();
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
