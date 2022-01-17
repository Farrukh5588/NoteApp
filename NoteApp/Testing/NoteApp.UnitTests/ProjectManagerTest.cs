using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace NoteApp.UnitTests
{
    class ProjectManagerTest
    {

        public Project PrepareProject()
        {
            var sourseProject = new Project();
            sourseProject.Notes.Add(new Note()
            {
                Name = "Note",
                NoteText = "Text",
                NoteCategory = NoteCategory.Documents,
                DateOfCreation = new DateTime(2021, 12, 09),
                DateOfLastEdit = new DateTime(2021, 12, 09)
            });
            sourseProject.Notes.Add(new Note()
            {
                Name = "qwert",
                NoteText = "qwerty",
                NoteCategory = NoteCategory.Job,
                DateOfCreation = new DateTime(2021, 12, 09),
                DateOfLastEdit = new DateTime(2021, 12, 09)
            });
            return sourseProject;
        }

        [Test]
        public void Test_SaveToFile_CorrectProject_FileSavedCorrectly()
        {
            // Setup
            var sourceProject = PrepareProject();
            var testDataFolder = Common.DataFolderForTest();
            var actualFileName = testDataFolder + @"\actualProject.json";
            var expectedFileName = testDataFolder + @"\expectedProject.json";
            if (File.Exists(actualFileName))
            {
                File.Delete(actualFileName);
            }

            // Act
            ProjectManager.SaveToFile(sourceProject, expectedFileName);
            ProjectManager.SaveToFile(sourceProject, actualFileName);

            var isFileExist = File.Exists(actualFileName);
            Assert.AreEqual(true, isFileExist);

            // Assert
            var actualFileContent = File.ReadAllText(actualFileName);
            var expectedFileContent = File.ReadAllText(expectedFileName);
            NUnit.Framework.Assert.AreEqual(expectedFileContent, actualFileContent);
        }

        [Test]
        public void Test_LoadFromFile_CorrectProject_FileLoadedCorrectly()
        {
            //Setup
            var expectedProject = PrepareProject();
            var testDataFolder = Common.DataFolderForTest();
            var testFileName = testDataFolder + @"\expectedProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(testFileName);

            //Assert
            Assert.AreEqual(expectedProject.Notes.Count, actualProject.Notes.Count);

            Assert.Multiple(() =>
            {
                for (int i = 0; i < expectedProject.Notes.Count; i++)
                {
                    Assert.AreEqual(expectedProject.Notes[i], actualProject.Notes[i]);
                }
            });
        }

        [Test]
        public void Test_LoadFromFile_UnCorrectPath_ReturnEmptyProject()
        {
            //Setup
            var testFileName = Common.DataFolderForTest() + "wrong";

            //Act
            var actualProject = ProjectManager.LoadFromFile(testFileName);

            //Assert
            Assert.IsEmpty(actualProject.Notes);
        }

        [Test]
        public void Test_LoadFromFile_UnCorrectFile_ReturnEmptyProject()
        {
            //Setup
            var testDataFolder = Common.DataFolderForTest();
            var testFileName = testDataFolder + @"\defectiveProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(testFileName);

            //Assert
            Assert.IsEmpty(actualProject.Notes);
        }

        [Test]
        public void Test_FilePath_GoodFilePath_ReturnSamePath()
        {
            //Setup
            var expectedPath = Common.FilePath();
            //Act
            var actualPath = ProjectManager.FolderPath;

            //Assert
            Assert.AreEqual(expectedPath, actualPath);
        }
    }
}
