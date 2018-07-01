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
using System.IO;

//9. Преобразовать последовательность действительных чисел, записанных в файле, расположив 
//сначала отрицательные числа последовательности, а затем неотрицательные. 
//При этом порядок  как отрицательных, так и неотрицательных чисел изменяется на  обратный. 
//Указание: для решения задачи создать два стека: с отрицательными и с неотрицательными числами 
//последовательности.

namespace Task15._9.Stack
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        public string writeFilename = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog.Filter = "(*.txt) | *.txt";
            saveFileDialog.Filter = "(*.txt) | *.txt";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Multiselect = false;
            openFileDialog.DefaultExt = ".txt";
            saveFileDialog.DefaultExt = ".txt";
        }     

        private void buttonDoTask_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string openFilename = openFileDialog.FileName;

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            writeFilename = saveFileDialog.FileName;
            UtilsIO2sem.DoStackTask(openFilename, writeFilename);
        }

        private void buttonOpenResultFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(writeFilename);
            }
            catch
            {

            }
        }
    }
}
