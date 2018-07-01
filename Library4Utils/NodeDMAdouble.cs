using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library4Utils
{
    public  class NodeDMAdouble
    {
        public NodeDMAdouble(double data)
        {
            Data = data; 
        }
        public double Data { get; set; }
        public NodeDMAdouble Next { get; set; }
    }
}
