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
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Константа цвета некорректного ввода
        /// </summary>
        private readonly Color _incorrectInputColor = Color.LightSalmon;

        /// <summary>
        /// Константа цвета корректного ввода
        /// </summary>
        private readonly Color _correctInputColor = Color.White;

        /// <summary>
        /// Поле, хранящее заметку
        /// </summary>
        private Note _note = new Note();

        public NoteForm()
        {
            InitializeComponent();
            var values = System.Enum.GetValues(typeof(NoteCategory));
            NoteCategoryComboBox.DataSource = values;
            NoteCategoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Свойство создания или редактирования заметки
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = (Note)value.Clone();
                if (_note != null)
                {
                    TitleTextBox.Text = _note.Name;
                    NoteCategoryComboBox.SelectedItem = _note.NoteCategory;
                    CreatedTimePicker.Value = _note.DateOfCreation;
                    ModifiedTimePicker.Value = _note.DateOfLastEdit;
                    TextBox.Text = _note.NoteText;
                }
                else
                {
                    TitleTextBox.Text = "Untitled";
                    _note.Name = TitleTextBox.Text;
                    CreatedTimePicker.Value = DateTime.Now;
                    ModifiedTimePicker.Value = DateTime.Now;
                }
            }
        }

        private void NoteCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _note.NoteCategory = (NoteCategory)NoteCategoryComboBox.SelectedItem;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                _note.Name = TitleTextBox.Text;
                _note.NoteCategory = (NoteCategory)NoteCategoryComboBox.SelectedItem;
                _note.DateOfCreation = CreatedTimePicker.Value;
                _note.DateOfLastEdit = ModifiedTimePicker.Value;
                _note.NoteText = TextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException exception)
            {
                DialogResult result = MessageBox.Show
                (
                "Note name is too large: more than 50 characters",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Note.Name = TitleTextBox.Text;
                TitleTextBox.BackColor = _correctInputColor;
            }
            catch (ArgumentException exception)
            {
                TitleTextBox.BackColor = _incorrectInputColor;
            }
        }
    }
}
