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

namespace LIS_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] fileHeaders;
        public bool HasRun = false;
        public string folderLocation = "";
        private FolderBrowserDialog fileFolder = new FolderBrowserDialog();

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        //*Set Folder*//
        private void Excel_Step01_SetFolder_Click(object sender, EventArgs e)
        {
            HasRun = false;

            if (Excel_Step01_Folder.Text != "")
                fileFolder.SelectedPath = Excel_Step01_Folder.Text;

            DialogResult dr = fileFolder.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Excel_Step01_Folder.Text = fileFolder.SelectedPath;
                folderLocation = fileFolder.SelectedPath;
            }
        }
        //*Select File Type*//
        private void checkBoxCSV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCSV.Checked)
            {
                checkBoxTXT.Checked = false;
            }
        }
        private void checkBoxTXT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTXT.Checked)
            {
                checkBoxCSV.Checked = false;
            }
        }
        //*Select file type*//
        private void checkBoxComma_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxComma.Checked)
            {
                checkBoxPipe.Checked = false;
                checkBoxTab.Checked = false;
            }
        }
        private void checkBoxPipe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPipe.Checked)
            {
                checkBoxComma.Checked = false;
                checkBoxTab.Checked = false;
            }
        }
        private void checkBoxTab_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTab.Checked)
            {
                checkBoxComma.Checked = false;
                checkBoxPipe.Checked = false;
            }
        }

        
        //*Read Headers*//
        private void ReadHeaderRow()
        {
            char delimiter = GetSelectedDelimiter();
            string fileType = GetSelectedFileTypeExtension();

            string[] files = Directory.GetFiles(folderLocation, fileType);
            if (files.Length > 0)
            {
                string firstFilePath = files[0];
                fileHeaders = GetHeaders(firstFilePath, delimiter);

                // Do something with the headers, e.g., display them or map them
                foreach (string header in fileHeaders)
                {
                    Console.WriteLine(header); // Or add to a list, display in UI, etc.
                }
            }
            else
            {
                Console.WriteLine("No files found in the selected folder.");
            }
        }
        //*Get Headers*//
        private string[] GetHeaders(string filePath, char delimiter)
        {
            string[] headers;
            using (StreamReader sr = new StreamReader(filePath))
            {
                string headerLine = sr.ReadLine();

                headers = headerLine.Split(delimiter);
            }

            return headers;
        }
        
        private char GetSelectedDelimiter()
        {
            if (checkBoxComma.Checked)
                return ',';
            else if (checkBoxPipe.Checked)
                return '|';
            else if (checkBoxTab.Checked)
                return '\t';
            else
                return ','; // Default delimiter
        }
        private string GetSelectedFileTypeExtension()
        {
            if (checkBoxCSV.Checked)
                return "*.csv";
            else if (checkBoxTXT.Checked)
                return "*.txt";
            else
                return "*.csv"; // Default file type, if needed
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ReadHeaderRow();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
