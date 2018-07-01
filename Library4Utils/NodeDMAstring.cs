using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library4Utils
{
    public class NodeDMAstring
    {
        public NodeDMAstring(string data)
        {
            Data = data;
        }

        public string Data { get; set; }
        public NodeDMAstring Next { get; set; }
    }
}
