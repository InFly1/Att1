using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library4Utils;

//9. Создать список, информационные поля которой содержат числа  из текстового файла. 
//Вставить в конец списка (после последнего элемента) новый элемент с информационным  полем d.

namespace Task15._9
{
    public partial class Form1 : Form 
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        LinkedListDMA mainWorkingList = new LinkedListDMA();

        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDisplay.ReadOnly = true;
            openFileDialog.Filter = "(*.txt) | *.txt";
            saveFileDialog.Filter = "(*.txt) | *.txt";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;            
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Multiselect = false;
            openFileDialog.DefaultExt = ".txt";
            saveFileDialog.DefaultExt = ".txt";
        }


        private void buttonLoadFromfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            mainWorkingList = UtilsIO2sem.ReadDoubleListFROMfile(openFileDialog.FileName);
            textBoxDisplay.Text = mainWorkingList.DoubleListToString();            
        }

        private void buttonAddD_Click(object sender, EventArgs e)
        {
            try
            {                            
                mainWorkingList.Add(Convert.ToDouble(textBox1.Text));
                textBoxDisplay.Text = mainWorkingList.DoubleListToString();
                textBox1.Clear();
            }
            catch
            {
                textBox1.Clear();
                textBox1.Text = "Только для чисел";
                textBoxDisplay.Clear();
                textBoxDisplay.Text = "Пожалуйста, введите корректное значение D";
            }
            
            
        }

    }
}
