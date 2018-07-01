using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;

namespace Library4Utils
{
    public class UtilsIO2sem
    {
        public static List<ResultOfMeasurement> CalcResultsOfpribor(List<ResultOfMeasurement> list, double a)
        {
            foreach(ResultOfMeasurement obj in list)
            {
                obj.Result = a * Math.Sin(a * obj.X) * Math.Pow(Math.Cos(obj.X / a), 2);
            }
            //list = SortInsertion(list);
            //BubbleSort(list);
            InsertSort111(list);
            return list;
        }               

        public static List<ResultOfMeasurement> SortInsertion(List<ResultOfMeasurement> list)
        {
            //сортировка с созданием доп. Листа (КАК В ЛЕКЦИИ НИКОЛАЯ АРКАДИЕВИЧА ТЮКАЧЕВА)
            List<ResultOfMeasurement> resultList = new List<ResultOfMeasurement>();
            for(int i = 0; i < list.Count; i++)
            {
                ResultOfMeasurement item = new ResultOfMeasurement();
                resultList.Add(item);
            }
            int j = 0;
            for (int i = 0; i < list.Count; i++)
            {
                // перебор входного списка
                // поиск места для list[i] в выходном списке
                j = 0;
                while ((j < i) & (resultList[j].Result >= list[i].Result))
                {
                    j++;
                }                    
                // освобождение места для нового элемента
                for (int k = i; k >= j + 1; k--)
                {
                    resultList[k] = resultList[k - 1];                    
                }
                resultList[j] = list[i];  // запись в выходной список
            }
            return resultList;
        }

        public static void BubbleSort(List<ResultOfMeasurement> list) 
        {
            
            ResultOfMeasurement tmp = new ResultOfMeasurement();
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = i; j > 0 && list[j - 1].Result <= list[j].Result; j--)
                {                    
                    tmp = list[j - 1];
                    list[j - 1] = list[j];
                    list[j] = tmp;
                }
            }
        }

        public static void InsertSort111(List<ResultOfMeasurement> list)
        {
            //сортировка без создания доп. Листа
            ResultOfMeasurement tmp = new ResultOfMeasurement();
            int j = 0;
            for (int i = 0; i < list.Count; i++)
            {
                // перебор входного списка
                // поиск места для list[i] в выходном списке
                tmp = list[i];
                j = 0;
                while ((j < i) & (tmp.Result <= list[j].Result))
                {
                    j++;
                }
                // освобождение места для нового элемента
                for (int k = i; k >= j + 1; k--)
                {
                    list[k] = list[k - 1];
                }
                list[j] = tmp;  // запись в выходной список
            }
        }

        public static void WriteListOfMeasurementsToGridOutput(DataGridView dgv, List<ResultOfMeasurement> list)
        {
            DataGridViewSelectionMode originalSelectionMode = dgv.SelectionMode;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.RowCount = list.Count;
            dgv.ColumnCount = 2;
            dgv.SelectionMode = originalSelectionMode;

            for (int r = 0; r < list.Count; r++)
            {
                dgv[0, r].Value = list[r].X;
                dgv[1, r].Value = list[r].Result;                
            }
            dgv.Columns[0].HeaderText = "X";
            dgv.Columns[1].HeaderText = "Res";
        }

        public static void ReadXvaluesFromGridView(DataGridView dgv, List<ResultOfMeasurement> list)
        {
            DataGridViewSelectionMode originalSelectionMode = dgv.SelectionMode;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;            
            dgv.ColumnCount = 1;
            dgv.SelectionMode = originalSelectionMode;
            //dgv.RowCount = list.Count;

            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv[0, i].Value != null)
                {
                    list[i].X = Convert.ToInt32(dgv[0, i].Value);
                }
            }
        }

        public static LinkedListDMA ReadDoubleListFROMfile(string filename)
        {
            LinkedListDMA linkedList = new LinkedListDMA();
            StreamReader reader = new StreamReader(filename, Encoding.Default);
            string line = String.Empty;
            while ((line = reader.ReadLine()) != null)
            {
                linkedList.Add(Convert.ToDouble(line));
            }
            reader.Close();
            return linkedList;
        }

        public static NodeStackDMA ReadDoubleStackFROMfile(string filename)
        {
            NodeStackDMA nodeStack = new NodeStackDMA();
            StreamReader reader = new StreamReader(filename, Encoding.Default);
            string str = String.Empty;
            while ((str = reader.ReadLine())!=null)
            {
                nodeStack.Push(Convert.ToDouble(str));
            }
            reader.Close();
            return nodeStack;
        }

        public static QueueDMA ReadStringQueueFROMfile(string filename)
        {
            QueueDMA queue = new QueueDMA();
            StreamReader reader = new StreamReader(filename, Encoding.Default);
            string str = String.Empty;
            while((str=reader.ReadLine())!=null)
            {
                queue.Add(str);
            }
            reader.Close();
            return queue;
        }

        public static void WriteDoubleStackTOfile(NodeStackDMA nodeStack, string filename)
        {
            StreamWriter writer = new StreamWriter(filename, true);
            while(!nodeStack.IsEmpty)
            {
                writer.WriteLine(Convert.ToString(nodeStack.Pop()));
            }
            writer.Close();
        }

        public static void  DoStackTask(string readFilename, string writeFilename)
        {
            NodeStackDMA negativeStack = new NodeStackDMA();
            NodeStackDMA positiveStack = new NodeStackDMA();
            StreamReader reader = new StreamReader(readFilename, Encoding.Default);
            string str = String.Empty;
            double data;
            while ((str = reader.ReadLine()) != null)
            {
                data = Convert.ToDouble(str);
                if (data < 0)
                {
                    negativeStack.Push(data);
                }
                else
                {
                    positiveStack.Push(data);
                }
            }
            reader.Close();

            StreamWriter writer = new StreamWriter(writeFilename, true);
            while (!negativeStack.IsEmpty)
            {
                //File.AppendAllText(writeFilename, Convert.ToString(negativeStack.Pop()) + Environment.NewLine);
                writer.WriteLine(Convert.ToString(negativeStack.Pop())+"\n");
            }
            while(!positiveStack.IsEmpty)
            {
                //File.AppendAllText(writeFilename, Convert.ToString(positiveStack.Pop()) + Environment.NewLine);
                writer.WriteLine(Convert.ToString(positiveStack.Pop()) + "\n");
            }
            writer.Close();
            
        }

        public static void RemoveXnames(QueueDMA queue, char x)
        {
            string element = String.Empty;
            int initialSize = queue.Count;
            //no additional queues
            for (int i = 0; i < initialSize; i++)
            {
                element = queue.TakeFirst();
                if (element[0] != x)
                {
                    queue.Add(element);                    
                }
            }
        }
    }
}
