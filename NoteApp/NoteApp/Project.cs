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
		private int _currentNote = -1;

		/// <summary>
		/// Функиця для сортировки списка заметок по дате изменения.
		/// </summary>
		public List<Note> SortNotes(List<Note> noteList = null)
		{
			var sortingList = noteList ?? Notes;

			sortingList.Sort(delegate (Note x, Note y)
			{
				if (x.DateOfLastEdit == null && y.DateOfLastEdit == null) return 0;
				else if (x.DateOfLastEdit == null) return 1;
				else if (y.DateOfLastEdit == null) return -1;
				else return y.DateOfLastEdit.CompareTo(x.DateOfLastEdit);
			});
			return sortingList;
		}

		/// <summary>
		/// Свойство текущей заметки.
		/// </summary>
		public int CurrentNote
		{
			get
			{
				return _currentNote;
			}
			set
			{
				_currentNote = value;
			}
		}
	}
}
