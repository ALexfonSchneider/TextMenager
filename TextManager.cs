using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TextMenager
{
    static class TextManager
    {
        public static string FilePathWithExtention(string filePath)
        {
            if (filePath == null) throw new Exception(" filePath == null ");

            if (Path.GetExtension(filePath) == "") filePath += ".txt";

            return filePath;
        }
        public static string FilePathWithoutExtention(string filePath)
        {
            if (filePath == null) throw new Exception(" filePath == null ");

            if (Path.GetExtension(filePath) != "") filePath = filePath.Replace(Path.GetExtension(filePath), "");

            return filePath;
        }
        public static void mkNewRecord(string path)
        {
            if (File.Exists(path)) throw new IOException(path + " is already exist ");

            path = FilePathWithExtention(path);

            File.Create(path).Close();
        }

        public static string ReadFile(string path)
        {
            if (!File.Exists(path)) throw new IOException(path + " is does not exist ");

            path = FilePathWithExtention(path);

            StreamReader reader = new(path);

            string returnValue = reader.ReadToEnd();

            reader.Close();

            return returnValue;
        }
        public static void WriteFile(string path, string text)
        {
            if (!File.Exists(path)) throw new IOException(path + " is does not exist ");

            path = FilePathWithExtention(path);

            StreamWriter writer = new(path);

            writer.Write(text);

            writer.Close();
        }
        public static void inBox(RichTextBox box, string path)
        {
            path = FilePathWithExtention(path);

            StreamReader reader = new(path);

            box.Text = reader.ReadToEnd();

            reader.Close();
        }
        public static void outBox(RichTextBox box, string path)
        {
            path = FilePathWithExtention(path);

            StreamWriter writer = new(path);

            writer.WriteLine(box.Text);

            writer.Close();
        }
        public static void deleteRecord(string path)
        {
            if (!File.Exists(path)) throw new Exception(" Some trouble here ");

            path = FilePathWithExtention(path);
                
            File.Delete(path);
        }
    }
}
