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
		private List<Note> currentNotes;

        /// <summary>
        /// Метод заполнения NoteListBox
        /// </summary>
        private void FillNoteListBox()
        {
            NoteListBox.Items.Clear();
            for (int i = 0; i < _project.Notes.Count; i++)
            {
                NoteListBox.Items.Add(_project.Notes[i].Name);
            }
        }
        public MainForm()
        {
            InitializeComponent();
            NoteCategoryComboBox.Items.Add("All");
            _project = ProjectManager.LoadFromFile(ProjectManager.FolderPath);
            var listCategory = System.Enum.GetValues(typeof(NoteCategory));
            foreach (var category in listCategory)
            {
                NoteCategoryComboBox.Items.Add(category);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NoteNameLabel.Text = "";
            CategorySelectedLabel.Text = "";
            _project = ProjectManager.LoadFromFile(ProjectManager.FolderPath);
            FillNoteListBox();
            NoteCategoryComboBox.SelectedIndex = 0;
            NoteListBox.SelectedIndex = _project.CurrentNote;
            UpdateNoteBox(_project.Notes);
        }

        /// <summary>
        /// Метод очищения полей с данными заметки
        /// </summary>
        private void ClearMainFormData()
        {
            NoteNameLabel.Text = "";
            CategorySelectedLabel.Text = "";
            NoteTextBox.Clear();
        }

        /// <summary>
		/// Поиск категории.
		/// </summary>
		private void CurrentCategory()
        {
            if (NoteCategoryComboBox.SelectedItem.ToString() == "All") 
            {
                UpdateNoteBox(_project.Notes);
            }
            else
            {
                List<Note> findCategory = new List<Note>();
                var selected = (NoteCategory)NoteCategoryComboBox.SelectedItem;
                foreach (var note in _project.Notes)
                {
                    if (note.NoteCategory == selected)
                    {
                        findCategory.Add(note);
                    }
                }
                UpdateNoteBox(findCategory);
            }
        }

        /// <summary>
		/// Обновление списка.
		/// </summary>
		private void UpdateNoteBox(List<Note> notes)
        {
            NoteListBox.Items.Clear();
            foreach (var note in notes)
            {
                NoteListBox.Items.Add(note.Name);
            }
            currentNotes = notes;
            if (currentNotes.Count - 1 >= _project.CurrentNote)
            {
                NoteListBox.SelectedIndex = _project.CurrentNote;
            }
            else
            {
                NoteListBox.SelectedIndex = -1;
                _project.CurrentNote = -1;
            }
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
                NoteListBox.Items.Add(newNote.Name);
                NoteListBox.SelectedIndex = NoteListBox.Items.Count - 1;
                ProjectManager.SaveToFile(_project, ProjectManager.FolderPath);
                _project.Notes = _project.SortNotes(_project.Notes);
                CurrentCategory();
            }
        }

        /// <summary>
        /// Метод редактирования заметки
        /// </summary>
        private void EditNote()
        {
            var index = NoteListBox.SelectedIndex;
            if (index >= 0)
            {
                var currentIndexNote = _project.Notes.IndexOf(currentNotes[index]);
                Note selectedNote = _project.Notes[currentIndexNote];
                NoteForm noteForm = new NoteForm();
                noteForm.Note = selectedNote;

                DialogResult result = noteForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Note newNote = noteForm.Note;
                    _project.Notes.RemoveAt(currentIndexNote);
                    _project.Notes.Insert(currentIndexNote, newNote);
                    _project.Notes = _project.SortNotes(_project.Notes);
                    ProjectManager.SaveToFile(_project, ProjectManager.FolderPath);
                    CurrentCategory();
                    if (NoteListBox.Items.Count > 0)
                    {
                        NoteListBox.SelectedIndex = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Метод удаления заметки
        /// </summary>
        private void DeleteNote()
        {
            var index = NoteListBox.SelectedIndex;
            if (index >= 0)
            {
                var currentIndexNote = _project.Notes.IndexOf(currentNotes[index]);
                DialogResult result = MessageBox.Show("Do you really want to remove this note: "
                    + NoteListBox.Items[index].ToString() + "?",
                    "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _project.Notes.RemoveAt(currentIndexNote);
                    _project.Notes = _project.SortNotes(_project.Notes);
                    _project.CurrentNote = -1;
                    ProjectManager.SaveToFile(_project, ProjectManager.FolderPath);
                    NoteListBox.SelectedIndex = -1;
                    CurrentCategory();
                    ClearMainFormData();
                }
            }
        }
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var index = NoteListBox.SelectedIndex;
            if (index >= 0)
            {
                var currentIndexNote = _project.Notes.IndexOf(currentNotes[index]);
                NoteNameLabel.Text = _project.Notes[currentIndexNote].Name;
                CategorySelectedLabel.Text = _project.Notes[currentIndexNote].NoteCategory.ToString();
                CreatedTimePicker.Value = _project.Notes[currentIndexNote].DateOfCreation;
                ModifiedTimePicker.Value = _project.Notes[currentIndexNote].DateOfLastEdit;
                NoteTextBox.Text = _project.Notes[currentIndexNote].NoteText;
                _project.CurrentNote = _project.Notes.IndexOf(currentNotes[NoteListBox.SelectedIndex]);
                ProjectManager.SaveToFile(_project, ProjectManager.FolderPath);
            }
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
            NoteListBox.SelectedIndex = _project.CurrentNote;
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
            UpdateNoteBox(_project.Notes);
 
            if (NoteListBox.Items.Count > 0)
            {
                NoteListBox.SelectedIndex = 0;
                CurrentCategory();
                
            }
            if (NoteListBox.Items.Count == 0)
            {
                ClearMainFormData();
            }
            else
                return;
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
