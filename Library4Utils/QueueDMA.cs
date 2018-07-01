using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library4Utils
{
    public class QueueDMA
    {
        NodeDMAstring head; 
        NodeDMAstring tail; 
        int count;

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Add(string data)
        {
            NodeDMAstring node = new NodeDMAstring(data);
            NodeDMAstring tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }

        public string TakeFirst()
        {
            if (count == 0)
                throw new InvalidOperationException();
            string output = head.Data;
            head = head.Next;
            count--;
            return output;
        }

        public string QueueToOnestring()
        {
            int L = 0;
            string str = String.Empty;
            string[] st = new string[0];
            NodeDMAstring p = head;
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
