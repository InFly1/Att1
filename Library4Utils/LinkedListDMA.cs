using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library4Utils
{  

    public class LinkedListDMA
    {
        NodeDMAdouble head;
        NodeDMAdouble tail;
        public int Length { get; private set;}

        public void Add(double data)
        {
            NodeDMAdouble node = new NodeDMAdouble(data);

            if (head == null) {
                head = node;
            }
            else {
                tail.Next = node;
            }

            tail = node;
            Length++;
        }

        public string DoubleListToString()                   // Вывод списка
        {
            string[] st = new string[0];
            string str = String.Empty;
            int L = 0;
            NodeDMAdouble p = head;
            if (p != null)
                do
                {
                    Array.Resize<string>(ref st, ++L);
                    st[L - 1] = p.Data.ToString();
                    p = p.Next;
                }
                while (p != null);

            foreach(string s in st)
            {
                str += s + " ";
            }
            return str;
        }
    }
}
