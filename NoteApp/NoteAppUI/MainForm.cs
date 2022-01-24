using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список всех заметок
        /// </summary>
        private Project _project = new Project();

        /// <summary>
		/// Список текущих заметок.
		/// </summary>
		private List<Note> _currentNotes;

        /// <summary>
        /// Метод заполнения
        /// </summary>
        private void FillNoteCategoryComboBox()
        {
            NoteCategoryComboBox.Items.Add("All");

            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                NoteCategoryComboBox.Items.Add(category);
            }
            NoteCategoryComboBox.SelectedIndex = 0;
        }

        public MainForm()
        {
            InitializeComponent();
            _project = ProjectManager.LoadFromFile(ProjectManager.FolderPath);
            FillNoteCategoryComboBox();
            UpdateNoteBox();
            if (_currentNotes.Count != 0)
            {
                NoteListBox.SelectedIndex = _project.CurrentNote;
            }
        }

        /// <summary>
        /// Метод очищения полей с данными заметки
        /// </summary>
        private void ClearCurrentNote()
        {
            NoteNameLabel.Text = "";
            CategorySelectedLabel.Text = "";
            CreatedTimePicker.Value = DateTime.Now;
            ModifiedTimePicker.Value = DateTime.Now;
            NoteTextBox.Clear();
        }

        /// <summary>
		/// Обновление списка.
		/// </summary>
		private void UpdateNoteBox()
        {
            if (NoteCategoryComboBox.SelectedIndex == 0)
            {
                _project.Notes = _project.SortByModificationTime();
                _currentNotes = _project.Notes.ToList();
            }
            else
            {
                _currentNotes = _project.SortByModificationTimeAndCategory(
                    (NoteCategory)NoteCategoryComboBox.SelectedItem);
            }

            NoteListBox.DataSource = null;
            NoteListBox.DataSource = _currentNotes;
            NoteListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Метод, обновляющий индекс текущей заметки.
        /// </summary>
        private void UpdateCurrentNoteIndex()
        {
            _project.CurrentNote = NoteListBox.Items.Count != 0 ?
            NoteListBox.SelectedIndex : 0;
        }

        /// <summary>
        /// Метод добавления заметки
        /// </summary>
        private void AddNote()
        {
            var addNote = new NoteForm();
            addNote.ShowDialog();
            if (addNote.DialogResult == DialogResult.OK)
            {
                var newNote = addNote.Note;
                _project.Notes.Add(newNote);

                UpdateCurrentNoteIndex();
                SaveProject();
            }
        }

        /// <summary>
        /// Метод редактирования заметки
        /// </summary>
        private void EditNote()
        {
            var selectedIndex = NoteListBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            var selectedNote = _currentNotes[selectedIndex];
            var currentIndexNote = _project.Notes.IndexOf(selectedNote);
            var noteForm = new NoteForm();

            noteForm.Note = (Note)selectedNote.Clone();
            noteForm.ShowDialog();

            if (noteForm.DialogResult == DialogResult.OK)
            {
                var editedNote = noteForm.Note;

                _project.Notes.RemoveAt(currentIndexNote);
                _project.Notes.Insert(currentIndexNote, editedNote);

                UpdateCurrentNoteIndex();
                SaveProject();
            }
        }

        /// <summary>
        /// Метод удаления заметки
        /// </summary>
        private void DeleteNote()
        {
            var index = NoteListBox.SelectedIndex;
            var selectedNote = (Note)NoteListBox.SelectedItem;
            var currentIndexNote = _project.Notes.IndexOf(selectedNote);

            DialogResult result = MessageBox.Show("Do you really want to delete this note: " +
                      $" {selectedNote.Name}?", "Delete Note",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _project.Notes.RemoveAt(currentIndexNote);

                UpdateCurrentNoteIndex();
                SaveProject();

                if (_currentNotes.Count == 0)
                {
                    ClearCurrentNote();
                }
            }
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = (Note)NoteListBox.SelectedItem;
            if (index != null)
            {
                NoteNameLabel.Text = index.Name;
                CategoryLabel.Text = index.NoteCategory.ToString();
                NoteTextBox.Text = index.NoteText;
                CreatedTimePicker.Value = index.DateOfCreation;
                ModifiedTimePicker.Value = index.DateOfLastEdit;
                return;
            }

            ClearCurrentNote();
        }

        /// <summary>
        /// Сохраниение заметки
        /// </summary>
        private void SaveProject()
        {
            UpdateNoteBox();
            ProjectManager.SaveToFile(_project, ProjectManager.FolderPath);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateCurrentNoteIndex();
            ProjectManager.SaveToFile(_project, ProjectManager.FolderPath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void NoteCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNoteBox();
        }

        private void NoteListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteNote();
            }
        }
    }
}
