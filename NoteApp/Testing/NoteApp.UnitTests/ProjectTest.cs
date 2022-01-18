using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    public class ProjectTest
    {
        [Test]
        public void Test_Project_CreateProject_ReturnRegulatedProject()
        {
            //Setup
            var note = new Note()
            {
                Name = "Note",
                NoteText = "Text",
                NoteCategory = NoteCategory.Documents,
                DateOfCreation = new DateTime(2021, 12, 09),
                DateOfLastEdit = new DateTime(2021, 12, 09)
            };
            var sourseProject = new Project();

            //Act
            sourseProject.Notes.Add(note);

            //Assert
            Assert.IsNotNull(sourseProject);
        }
    }
}
