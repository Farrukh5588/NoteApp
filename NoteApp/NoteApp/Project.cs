using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;

namespace NoteApp
{
    /// <summary>
    /// Класс "Проект", хранящий список всех заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
