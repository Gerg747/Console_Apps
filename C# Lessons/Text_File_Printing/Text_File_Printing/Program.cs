/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: Printing Files Lmao
*/
using System.IO;

namespace Greg
{
    public class donut_shop
    {
        public static void Main()
        {
            string test = "AMOGUS";
            string location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            TextWriter text = new StreamWriter(location + "\\Test.txt");
            text.Write(test);
            text.Flush();
        }

    }
}