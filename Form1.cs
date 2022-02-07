using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextMenager
{
    public partial class Form1 : Form
    {
        static class BUFFER
        {
            public static string target = null;
            public static string buffer = null;
        }


        string directoryPath; // always selected => != null
        string DirectoryPath // if set file - it sets its directory path, if set directory - it sets directory.| file path 'A' -> sets 'A' directory path . directory path 'A' -> sets 'A'.
        {
            get
            {
                if (directoryPath == null) throw new Exception("directoryPath == null");
                else if (File.Exists(directoryPath)) throw new Exception("some trouble here. directoryPath can't be file");
                else if (!Directory.Exists(directoryPath)) throw new Exception("some trouble here. directory isn't exist");

                return directoryPath;
            }
            set
            {
                if (Directory.Exists(value)) directoryPath = value;
                else if (File.Exists(value)) directoryPath = value.Replace(Path.GetFileName(value), "");
                else throw new Exception("some throuble here. That directry isn't exist");
            }
        }

        string selectedFile; // null если файл не выбран
        string SelectedFile
        {
            get => selectedFile;
            set
            {
                selectedFile = value;

                if (RC_box != null)
                {
                    if (selectedFile == null) RC_box.Clear();
                    else TextManager.inBox(RC_box, selectedFile);
                }
                
            }

        } 

        string[] files{ get; set; }

        string contextMenuSelectedPath { get; set; } // null if does not selected

        void LoadList(ListBox lstRecord, string dpath)
        {
            //savety
            lstRecord.Items.Clear();

            if (!Directory.Exists(dpath)) throw new Exception("some trouble here"); // проверка

            files = Directory.GetFiles(dpath);

            foreach(string file in files)
            {
                string name = Path.GetFileName(file)    .Replace(@"\", "");

                if (Path.GetExtension(name) == ".txt") lstRecord.Items.Add(name);
            }
        }
        public Form1()
        {
            InitializeComponent();

            string[] argv = Environment.GetCommandLineArgs();

            // set directoryPath and selectedFile
            if(argv != null && argv.Length > 1)
            {
                try
                {
                    string somePath = argv[1];

                    DirectoryPath = somePath;

                    if (Directory.Exists(somePath))
                    {
                        SelectedFile = null;
                    }
                    else if (File.Exists(somePath))
                    {
                        SelectedFile = somePath;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    MessageBox.Show("Unknow Error");
                    this.Close();
                }
            } 
            else
            {
                DirectoryPath = @".\Records";
            }

            LoadList(lstRecord, DirectoryPath);
        }

        private void TimerForList_Tick(object sender, EventArgs e)
        {
            //savety
            LoadList(lstRecord, DirectoryPath);
        }
        private void TimerForMenu_Tick(object sender, EventArgs e)
        {
            //savety
            if (SelectedFile == null)
            {
                menu_saveRecord.Enabled = false;
                menu_deleteRecord.Enabled = false;
            }
            else
            {
                menu_saveRecord.Enabled = true;
                menu_deleteRecord.Enabled = true;
            }
        }

        private void lstRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            //savety
            int selectedIndex = lstRecord.SelectedIndex;

            if (selectedIndex >= 0)
            {
                SelectedFile = files[selectedIndex];
            }
            // пока не буду добавлять очистку при нажатии на лист
        }
        private void menu_saveRecord_Click(object sender, EventArgs e)
        {
            // savety
            if (SelectedFile != null)
            {
                TextManager.outBox(RC_box, SelectedFile);
            }
        }
        private void menu_deleteRecord_Click(object sender, EventArgs e)
        {
            //savaty
            if (SelectedFile != null)
            {
                TextManager.deleteRecord(SelectedFile);

                SelectedFile = null;

                LoadList(lstRecord, DirectoryPath);
            }
        }
        private void menu_new_file_Click(object sender, EventArgs e)
        {
            //savety
            Form2 form2 = new Form2();
            form2.ShowDialog();

            string Rezult = form2.inputString; // получили строку с именем нового файла

            form2.Close();
            try
            {
                if (Rezult != null) // проверка на то, что пользователь закрыл окно ввода имени
                {
                    TextManager.mkNewRecord(DirectoryPath + @"\" + Rezult);

                    SelectedFile = DirectoryPath + @"\" + Rezult + ".txt";

                    LoadList(lstRecord, DirectoryPath);
                }
            }
            catch(IOException except)
            {
                MessageBox.Show(except.ToString());
            }
        }
        private void menu_selectDirectory_Click(object sender, EventArgs e)
        {
            //savety
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.ShowDialog();

            string selectedDirectory = folderBrowserDialog.SelectedPath;

            if (selectedDirectory != null && selectedDirectory != "")
            {
                DirectoryPath = selectedDirectory;
                SelectedFile = null;
                LoadList(lstRecord, DirectoryPath);
            }

            folderBrowserDialog.Dispose();
        }

        private void menu_saveRecordAs_Click(object sender, EventArgs e)
        {
            //savely
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = false;
            saveFileDialog.ShowDialog();

            string saveFileDialogSelectedFile = saveFileDialog.FileName;

            if(saveFileDialogSelectedFile != "" && saveFileDialogSelectedFile != null)
            {
                try
                {
                    TextManager.mkNewRecord(saveFileDialogSelectedFile);
                    TextManager.outBox(RC_box, saveFileDialogSelectedFile);

                    SelectedFile = saveFileDialogSelectedFile;
                    DirectoryPath = SelectedFile;
                }
                catch(IOException except)
                {
                    MessageBox.Show(except.ToString());
                }
            }
        }

        private void lstRecord_MouseDown(object sender, MouseEventArgs e)
        {
            //savaty
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    int index = lstRecord.IndexFromPoint(e.X, e.Y);
                    if (index >= 0)
                    {
                        LstContextMenuStrip.Items["copyToolStripMenuItem"].Enabled = true;
                        LstContextMenuStrip.Items["deleteToolStripMenuItem"].Enabled = false;

                        contextMenuSelectedPath = files[index];
                    }
                    else
                    {
                        LstContextMenuStrip.Items["copyToolStripMenuItem"].Enabled = false;
                        LstContextMenuStrip.Items["deleteToolStripMenuItem"].Enabled = false;

                        contextMenuSelectedPath = null;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unknown Exception. Error");
                this.Close();
            }
        }
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            if (contextMenuSelectedPath != "" && contextMenuSelectedPath != null)
            {
                try
                {
                    BUFFER.target = contextMenuSelectedPath;

                    BUFFER.buffer = TextManager.ReadFile(contextMenuSelectedPath);

                    contextMenuSelectedPath = null;
                }
                catch(IOException except)
                {
                    MessageBox.Show(except.ToString());
                    except.ToString();
                }
            }
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            if(contextMenuSelectedPath != "" && contextMenuSelectedPath != null)
            {
                try
                {
                    if (contextMenuSelectedPath == SelectedFile) SelectedFile = null; // if in context menu selected record that was selected for redit - SelectedFile = null

                    TextManager.deleteRecord(contextMenuSelectedPath);

                    contextMenuSelectedPath = null;
                }
                catch(IOException except)
                {
                    MessageBox.Show(except.ToString());
                }
            }
        }
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (contextMenuSelectedPath != "" && contextMenuSelectedPath != null)
                {
                    TextManager.WriteFile(contextMenuSelectedPath, BUFFER.buffer);

                    TextManager.inBox(RC_box, contextMenuSelectedPath);
                }
                else
                {
                    string newRecordPath = TextManager.FilePathWithoutExtention(BUFFER.target) + " - copy.txt";

                    TextManager.mkNewRecord(newRecordPath);

                    TextManager.WriteFile(newRecordPath, BUFFER.buffer);
                }
            }
            catch (IOException except)
            {
                MessageBox.Show(except.Message);
            }
        }
    }
}
