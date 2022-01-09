using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace NoteApp.UnitTests
{
    public class Common
    {
        public static string DataFolderForTest()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(location) + @"\TestData";
        }

        public static string FilePath()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return path + @"\NoteApp\Note.json";
        }
    }
}
