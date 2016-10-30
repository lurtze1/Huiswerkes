using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4 {
    class Vertex {
        public string name;   // Vertex name    
        public List<Edge> adj;    // Adjacent vertices    
        public double afstand;
        public Vertex prev;   // Previous vertex on shortest path
        public bool known; // Dijkstra

        public Vertex(string name) {
            this.name = name;
            this.adj = new List<Edge>();
        }
    }
}
