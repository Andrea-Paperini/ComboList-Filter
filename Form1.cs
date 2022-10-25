using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    //textBox1.Text = text;
                    string input = text;


                    string pattern = @"([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+[^\s]+)";
                    RegexOptions options = RegexOptions.IgnoreCase;
                    string finale = "";
                    foreach (Match m in Regex.Matches(input, pattern, options))
                    {
                        Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                        finale += m.Value+"\n";
                    }
                    textBox1.Text = finale;
                }
                catch (IOException)
                {
                }
            }
            

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file | *.txt";
            saveFileDialog1.Title = "Save Playlist";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Andrea-Paperini") { UseShellExecute = true });
        }
    }
}
