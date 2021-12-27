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
                    NameTextBox.Text = _note.Name;
                    NoteCategoryComboBox.SelectedItem = _note.NoteCategory;
                    CreatedTimePicker.Value = _note.DateOfCreation;
                    ModifiedTimePicker.Value = _note.DateOfLastEdit;
                    TextBox.Text = _note.NoteText;
                }
                else
                {
                    NameTextBox.Text = "Unnamed";
                    _note.Name = NameTextBox.Text;
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
                _note.Name = NameTextBox.Text;
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
                text:exception.Message,
                caption:"Error",
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

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Note.Name = NameTextBox.Text;
                NameTextBox.BackColor = _correctInputColor;
            }

            catch (ArgumentException exception)
            {
                NameTextBox.BackColor = _incorrectInputColor;
            }
        }
    }
}
