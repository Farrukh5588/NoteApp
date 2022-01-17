using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    class ProjectTest
    {
        [Test]
        public void Test_SetNotes()
        {
            var expected = new List<Note>();
            var actual = expected;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_GetNotes()
        {
            var expected = new List<Note>();
            var temp = expected;
            var actual = temp;

            Assert.AreEqual(expected, actual);
        }
    }
}
