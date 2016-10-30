using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4 {
    class Edge {
        public Vertex dest;   /* Second vertex in Edge */
        public double cost;   // Edge cost        
        
        public Edge(Vertex dest, double cost) {
            this.dest = dest;
            this.cost = cost;
        }
    }
}
