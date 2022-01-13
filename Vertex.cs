using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{
    class Vertex
    {
        public int Number { get; set; }
        public bool IsVisited;
        public override string ToString()
        {
            return Number.ToString();
        }
        public Vertex(int number)
        {
            Number = number;
        }
    }
}
