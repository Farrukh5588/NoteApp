using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json;


namespace NoteApp.UnitTests
{
    class NoteTest
    {
        [Test]
        public void Name_GoodName_ReturnsSameName()
        {
            //Setup
            var note = new Note();
            var sourceName = "qwertyuiop";
            var expectedName = sourceName;

            //Act
            note.Name = sourceName;
            var actualName = note.Name;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Text_GoodText_ReturnsSameText()
        {
            //Setup
            var note = new Note();
            var sourceName = "qwertyuiop";
            var expectedName = sourceName;

            //Act
            note.NoteText = sourceName;
            var actualName = note.NoteText;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Category_GoodCategory_ReturnsSameCategory()
        {
            //Setup
            var note = new Note();
            var sourceName = NoteCategory.Documents;
            var expectedName = sourceName;

            //Act
            note.NoteCategory = sourceName;
            var actualName = note.NoteCategory;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Create_GoodTimeCreate_ReturnsSameDate()
        {
            //Setup
            var note = new Note();
            var sourceName = new DateTime(2020, 12, 09);
            var expectedName = sourceName;

            //Act
            note.DateOfCreation = sourceName;
            var actualName = note.DateOfCreation;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Modify_GoodTimeModify_ReturnsSameDate()
        {
            //Setup
            var note = new Note();
            var sourceName = new DateTime(2020, 12, 09);
            var expectedName = sourceName;

            //Act
            note.DateOfLastEdit = sourceName;
            var actualName = note.DateOfLastEdit;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Name_BadName_ThrowsException()
        {
            //Setup
            var note = new Note();
            var sourceName = "qwertyuiop qwertyuiop qwertyuiop qwertyuiop qwertyuiop";

            //Assert
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    note.Name = sourceName;
                }
            );
        }

        [Test]
        public void Clone_GoodClone_ReturnSameData()
        {
            //Setup
            var sourceCategory = NoteCategory.Job;
            var notesCategory = sourceCategory;
            var expectedNote = new Note
            {
                Name = "Работка",
                NoteText = "qwertyuiop",
                NoteCategory = notesCategory,
                DateOfCreation = new DateTime(2020, 12, 09),
                DateOfLastEdit = new DateTime(2020, 12, 09)
            };

            //Act
            var actualNote = expectedNote.Clone() as Note;
            var expected = JsonConvert.SerializeObject(expectedNote);
            var actual = JsonConvert.SerializeObject(actualNote);

            //Assert
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
