using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    public class NoteTests
    {
        [Test]
        public void Test_Name_CorrectName_ReturnsSameName()
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
        public void Test_Notetext_CorrectNotetext_ReturnsSameNotetext()
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
        public void Test_Notecategory_CorrectNotecategory_ReturnsSameNotecategory()
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
        public void Test_DateTime_CorrectDateOfCreation_ReturnsSameDateTime()
        {
            //Setup
            var note = new Note();
            var sourceName = new DateTime(2021, 12, 09);
            var expectedName = sourceName;

            //Act
            note.DateOfCreation = sourceName;
            var actualName = note.DateOfCreation;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Test_DateTime_CorrectDateLastEdit_ReturnsSameDateTime()
        {
            //Setup
            var note = new Note();
            var sourceName = new DateTime(2021, 12, 09);
            var expectedName = sourceName;

            //Act
            note.DateOfLastEdit = sourceName;
            var actualName = note.DateOfLastEdit;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Test_Name_WrongName_ThrowsException()
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
        public void Test_Clone_CorrectClone_ReturnSameDataTime()
        {
            //Setup
            var sourceCategory = NoteCategory.Job;
            var notesCategory = sourceCategory;
            var expectedNote = new Note
            {
                Name = "Работка",
                NoteText = "qwertyuiop",
                NoteCategory = notesCategory,
                DateOfCreation = new DateTime(2021, 12, 09),
                DateOfLastEdit = new DateTime(2021, 12, 09)
            };

            //Act
            var actualNote = expectedNote.Clone() as Note;
           
            //Assert
            NUnit.Framework.Assert.AreEqual(expectedNote, actualNote);
        }
    }
}
