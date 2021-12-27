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
            _project = ProjectManager.LoadFromFile(ProjectManager.FolderPath);
            foreach (var item in Enum.GetValues(typeof(NoteCategory)))
            {
                NoteCategoryComboBox.Items.Add(item);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NoteNameLabel.Text = "";
            CategorySelectedLabel.Text = "";
            _project = ProjectManager.LoadFromFile(ProjectManager.FolderPath);
            FillNoteListBox();
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
            }
        }

        /// <summary>
        /// Метод редактирования заметки
        /// </summary>
        private void EditNote()
        {
            if (NoteListBox.SelectedIndex == -1)
            {
                return;
            }

            var indexNote = NoteListBox.SelectedIndex;
            var selectedData = _project.Notes[indexNote];
            var editNote = new NoteForm();
            editNote.Note = selectedData;
            editNote.ShowDialog();
            if (editNote.DialogResult == DialogResult.OK)
            {
                var updatedNote = editNote.Note;
                _project.Notes.RemoveAt(indexNote);
                _project.Notes.Add(updatedNote);
                NoteListBox.Items.RemoveAt(indexNote);
                NoteListBox.Items.Add(updatedNote.Name);
                NoteListBox.SelectedIndex = NoteListBox.Items.Count - 1;
                ProjectManager.SaveToFile(_project, ProjectManager.FolderPath);
            }
        }

        /// <summary>
        /// Метод удаления заметки
        /// </summary>
        private void DeleteNote()
        {
            if (NoteListBox.SelectedIndex == -1)
            {
                return;
            }

            var indexNote = NoteListBox.SelectedIndex;
            var selectedData = _project.Notes[indexNote];
            var dialogResult = MessageBox.Show
                (
                "Do you really want to delete this note: " + selectedData.Name,
                "Delete Note",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            _project.Notes.RemoveAt(indexNote);
            NoteListBox.Items.RemoveAt(indexNote);
            ProjectManager.SaveToFile(_project, ProjectManager.FolderPath);
            ClearMainFormData();
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedIndex == -1)
            {
                NoteNameLabel.Text = "";
                CategorySelectedLabel.Text = "";
                return;
            }

            int index = NoteListBox.SelectedIndex;
            var note = _project.Notes[index];
            NoteNameLabel.Text = note.Name;
            CategorySelectedLabel.Text = note.NoteCategory.ToString();
            CreatedTimePicker.Value = note.DateOfCreation;
            ModifiedTimePicker.Value = note.DateOfLastEdit;
            NoteTextBox.Text = note.NoteText;
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
    }
}
