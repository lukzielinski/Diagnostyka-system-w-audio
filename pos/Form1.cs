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
using System.Windows.Markup;
using System.Reflection;

namespace pos
{
    public partial class SoundAnalyzer : Form
    {
        public SoundAnalyzer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            dir = dir.Replace(@"\\", @"\");

            MLApp.MLApp matlab = new MLApp.MLApp();

            var ml_path_command = @"cd " + dir;

            matlab.Execute(ml_path_command);

            object result = null;

            // Call the MATLAB function myfunc
            matlab.Feval("audio_analysis", 0, out result);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SoundAnalyzer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK);
            {
                string[] values = new string[] { };
                using (var reader = new StreamReader(fileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        values = line.Split(',');
                    }
                    if (values.Length >= 6)
                    {
                        textBox1.Text = values[0];
                        textBox6.Text = values[1];
                        textBox2.Text = values[2];
                        textBox3.Text = values[3];
                        textBox7.Text = values[4];
                        textBox4.Text = values[5];
                    }

                }
            }
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK) ;
            {
                string[] values = new string[] { };
                using (var reader = new StreamReader(fileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        values = line.Split(',');
                    }
                    if (values.Length >= 8)
                    {
                        textBox12.Text = values[0];
                        textBox9.Text = values[1];
                        textBox5.Text = values[2];
                        textBox13.Text = values[3];
                        textBox11.Text = values[4];
                        textBox10.Text = values[5];
                        textBox14.Text = values[6];
                        textBox8.Text = values[7];
                    }

                }
            }
        }
    }
}
