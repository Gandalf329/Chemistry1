using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemistry1
{
    public partial class Form1 : Form
    {
        int number1 = 1;
        int number2 = 1;
        int number3 = 1;
        string result1 = "";
        string result2 = "";
        string result3 = "";
        List<string> formula1 = new List<string> { "H2SO4" };
        List<string> formula2 = new List<string> { "KOH" };
        List<string> formula3 = new List<string> { "NaCl" };

        public Form1()
        {   
            formula1 = ReadFile1(formula1);
            formula2 = ReadFile2(formula2);
            formula3 = ReadFile3(formula3);
            InitializeComponent();
        }
        public List<string> ReadFile1(List<string> textFromFile1)
        {

            var baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var relativePath = @"Chem\formula1.txt";
            var fullPath = Path.Combine(baseFolder, relativePath);
            textFromFile1 = File.ReadAllLines(fullPath).ToList();
            return textFromFile1;
        }
        public List<string> ReadFile2(List<string> textFromFile2)
        {

            var baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var relativePath = @"Chem\formula2.txt";
            var fullPath = Path.Combine(baseFolder, relativePath);
            textFromFile2 = File.ReadAllLines(fullPath).ToList();
            return textFromFile2;
        }
        public List<string> ReadFile3(List<string> textFromFile3)
        {

            var baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var relativePath = @"Chem\formula3.txt";
            var fullPath = Path.Combine(baseFolder, relativePath);
            textFromFile3 = File.ReadAllLines(fullPath).ToList();
            return textFromFile3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (number1 == 1)
            {
                Random rnd1 = new Random();
                int ind1 = rnd1.Next(formula1.Count);
                result1 = formula1[ind1];
                
            }
            else
            {
                
                result1 = "";
                List<int> check1 = new List<int>();
                if (number1 > formula1.Count)
                {
                    MessageBox.Show("Сильно большое число!");
                }
                else
                {
                    for (int i = 0; i < number1; i++)
                    {
                        if (i == 0)
                        {
                            Random rnd1 = new Random();
                            int ind1 = rnd1.Next(formula1.Count);
                            result1 += " " + formula1[ind1];
                            check1.Add(ind1);
                        }
                        else
                        {

                            Random rnd1 = new Random();
                            int ind1 = rnd1.Next(formula1.Count);
                            bool findInd = check1.Contains(ind1);
                            while (findInd == true)
                            {
                                ind1 = rnd1.Next(formula1.Count);
                                findInd = check1.Contains(ind1);
                            }
                            check1.Add(ind1);
                            result1 += " " + formula1[ind1];
                        }
                    }
                }
            }
            textBox1.Text = Text = result1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (number2 == 1)
            {
                Random rnd2 = new Random();
                int ind2 = rnd2.Next(formula2.Count);
                result2 = formula2[ind2];

            }
            else
            {
                result2 = "";
                List<int> check2 = new List<int>();
                if (number2 > formula2.Count)
                {
                    MessageBox.Show("Сильно большое число!");
                }
                else
                {
                    for (int i = 0; i < number2; i++)
                    {
                        if (i == 0)
                        {
                            Random rnd2 = new Random();
                            int ind2 = rnd2.Next(formula2.Count);
                            result2 += " " + formula2[ind2];
                            check2.Add(ind2);
                        }
                        else
                        {

                            Random rnd2 = new Random();
                            int ind2 = rnd2.Next(formula2.Count);
                            bool findInd = check2.Contains(ind2);
                            while (findInd == true)
                            {
                                ind2 = rnd2.Next(formula2.Count);
                                findInd = check2.Contains(ind2);
                            }
                            check2.Add(ind2);
                            result2 += " " + formula2[ind2];
                        }
                    }
                }
            }
            textBox2.Text = Text = result2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (number3 == 1)
            {
                Random rnd3 = new Random();
                int ind3 = rnd3.Next(formula3.Count);
                result3 = formula3[ind3];

            }
            else
            {

                result3 = "";
                List<int> check3 = new List<int>();
                if (number3 > formula3.Count)
                {
                    MessageBox.Show("Сильно большое число!");
                }
                else
                {
                    for (int i = 0; i < number3; i++)
                    {
                        if (i == 0)
                        {
                            Random rnd3 = new Random();
                            int ind3 = rnd3.Next(formula3.Count);
                            result3 += " " + formula3[ind3];
                            check3.Add(ind3);
                        }
                        else
                        {

                            Random rnd3 = new Random();
                            int ind3 = rnd3.Next(formula3.Count);
                            bool findInd = check3.Contains(ind3);
                            while (findInd == true)
                            {
                                ind3 = rnd3.Next(formula3.Count);
                                findInd = check3.Contains(ind3);
                            }
                            check3.Add(ind3);
                            result3 += " " + formula3[ind3];
                        }
                    }
                }
            }
            textBox3.Text = Text = result3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result1 = "";
            result2 = "";
            result3 = "";
            textBox1.Text = Text = result1;
            textBox2.Text = Text = result2;
            textBox3.Text = Text = result3;
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            number1 = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            number2 = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            number3 = (int)numericUpDown3.Value;
        }
    }
}
