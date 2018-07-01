using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library4Utils
{
    public class NodeStackDMA
    {
        NodeDMAdouble head;
        int count;

        public bool IsEmpty
        {
            get { return count == 0; } 
        }
        public int Count
        {
            get { return count; } //доступ к полю count
        }

        public void Clear()
        {
            count = 0;
            head = null;
        }

        public void Push(double item)// увеличиваем стек
        {            
            NodeDMAdouble node = new NodeDMAdouble(item);
            node.Next = head; // переставляем верхушку стека на новый элемент
            head = node;
            count++;
        }
        public double Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Stack is Empty");
            NodeDMAdouble temp = head;
            head = head.Next; // переставляем верхушку стека на следующий элемент
            count--;
            return temp.Data;
        }

        public double Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is Empty");
            return head.Data;
        }

        public string DoubleStackToString()
        {
            int L = 0;
            string str = String.Empty;
            string[] st = new string[0];
            NodeDMAdouble p = head;
            while (p != null)
            {
                Array.Resize<string>(ref st, ++L);
                st[L - 1] = p.Data.ToString();
                p = p.Next;
            }
            foreach(string s in st)
            {
                str += s + " ";
            }
            return str;
        }
    }
}
