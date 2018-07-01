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

namespace Task16._5Pribor
{
    public partial class FormMain : Form
    {
        List<ResultOfMeasurement> mainList = new List<ResultOfMeasurement>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDoIt_Click(object sender, EventArgs e)
        {
            double a = 0;
            try
            {
                for(int i =0; i < dataGridViewForInput.RowCount; i++)
                {                    
                   ResultOfMeasurement item = new ResultOfMeasurement();
                   mainList.Add(item);                    
                }

                a = Convert.ToDouble(textBoxInputA.Text);
                if (a == 0)
                {
                    throw new Exception();
                }

                UtilsIO2sem.ReadXvaluesFromGridView(dataGridViewForInput, mainList);
                mainList = UtilsIO2sem.CalcResultsOfpribor(mainList, a);
                UtilsIO2sem.WriteListOfMeasurementsToGridOutput(dataGridViewOutPut, mainList);                             
            }
            catch
            {
                textBoxInputA.Clear();               
                label1.Text = "Введите А (число, не ноль)";
                mainList.Clear();
            }
            mainList.Clear();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(dataGridViewForInput, 50, false, true, false, true, false, 22, 6);
            dataGridViewForInput.ForeColor = Color.Crimson;
            dataGridViewForInput.Columns[0].HeaderText = "X";
            dataGridViewForInput.ColumnCount = 1;

            DataGridViewUtils.InitGridForArr(dataGridViewOutPut, 150, true, true, true, false, false, 22, 6);
            dataGridViewOutPut.ForeColor = Color.Crimson;
            dataGridViewOutPut.ColumnCount = 2;
            dataGridViewOutPut.Columns[0].HeaderText = "X";
            dataGridViewOutPut.Columns[1].HeaderText = "Res";

           
        }
    }
}
