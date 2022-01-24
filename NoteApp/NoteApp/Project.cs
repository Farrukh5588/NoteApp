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

        /// <summary>
        /// Текущая заметка.
        /// </summary>
        public int CurrentNote { get; set; }

        /// <summary>
        /// Метод для сортировки списка заметок по времени последнего изменения.
        /// </summary>
        /// <returns></returns>
        public List<Note> SortByModificationTime()
        {
            var sortedNotes =
                Notes.OrderByDescending(note => note.DateOfLastEdit).ToList();

            return sortedNotes;
        }

        /// <summary>
        /// Метод для сортировки списка заметок определенной категории по времени 
        /// последнего изменения.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<Note> SortByModificationTimeAndCategory(NoteCategory category)
        {
            var sortedNotesCategory =
                Notes.Where(note => note.NoteCategory == category).ToList();
            var sortedNotes =
                sortedNotesCategory.OrderByDescending(note => note.DateOfLastEdit).ToList();

            return sortedNotes;
        }
    }
}
