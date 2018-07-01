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
using Library4Utils;

//9. Создать очередь, информационные поля которой содержат строки  из файла(список фамилий учащихся). 
//Удалить из  списка фамилии, начинающиеся с буквы Х.

namespace Task15._9Queue
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        QueueDMA queueMain = new QueueDMA();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDisplay.ReadOnly = true;//
            openFileDialog.Filter = "(*.txt) | *.txt";
            saveFileDialog.Filter = "(*.txt) | *.txt";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Multiselect = false;
            openFileDialog.DefaultExt = ".txt";
            saveFileDialog.DefaultExt = ".txt";
            textBoxDisplayRes.ReadOnly = true;//
        }

        private void buttonLoadFROMfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            queueMain = UtilsIO2sem.ReadStringQueueFROMfile(openFileDialog.FileName);
            
            textBoxDisplay.Text = queueMain.QueueToOnestring();            
        }

        private void buttonDeleteXnames_Click(object sender, EventArgs e)
        {
            try
            {
                UtilsIO2sem.RemoveXnames(queueMain, Convert.ToChar(textBoxEnterChar.Text));
                textBoxDisplayRes.Text = queueMain.QueueToOnestring();
            }
            catch
            {
                textBoxEnterChar.Clear();
            }
        }

      

        
    }
}
