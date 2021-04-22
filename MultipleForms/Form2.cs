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

namespace MultipleForms
{
    public partial class Form2 : Form
    {
        public string FName;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FName = File.ReadAllText(openFileDialog1.FileName);
            textBox1.Text = FName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(openFileDialog1.FileName.Length == 0)
           /// {
                saveFileDialog1.ShowDialog();
                FName = saveFileDialog1.FileName;
            
           // } 

            using(StreamWriter sw = new StreamWriter(FName))
            {
                for (int i=0; i<textBox1.Lines.Length; i++)
                {
                    sw.WriteLine(textBox1.Lines[i]);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            textBox1.Text = sr.ReadToEnd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(); 
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }
    }
}
