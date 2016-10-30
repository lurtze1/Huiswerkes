using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4 {
    class Graph {
        private Dictionary<string, Vertex> vertexMap = new Dictionary<string, Vertex>();

        public void addVertex(string name) {
            Vertex v = new Vertex(name);
            vertexMap.Add(name, v);
        }

        public void addEdge(string sourceName, string destName, double cost) {
            Vertex v = vertexMap[sourceName];
            Vertex w = vertexMap[destName];
            v.adj.Add(new Edge(w, cost));
        }

        public void vulAfstand() {
            Queue<Vertex> q = new Queue<Vertex>();

            foreach (Vertex v in vertexMap.Values) {
                v.afstand = -1;
            }

            Vertex s = vertexMap["G"];
            s.afstand = 0;
            q.Enqueue(s);

            while (q.Count != 0) {
                Vertex v = q.Dequeue();
                foreach (Edge e in v.adj) {
                    Vertex w = e.dest;
                    if (w.afstand == -1) {
                        w.afstand = v.afstand + 1;
                        w.prev = v;
                        q.Enqueue(w);
                    }
                }
            }
        }

        public string toonAfstand() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Toon afstand");
            foreach (Vertex v in vertexMap.Values) {
                sb.Append(v.name + ": " + v.afstand + "\n");
            }
            return sb.ToString();
        }

        public bool hasCycle(string name) {
            Queue<Vertex> q = new Queue<Vertex>();
            bool hasCycle = false;

            foreach (Vertex v in vertexMap.Values) {
                v.known = false;
            }

            Vertex s = vertexMap[name];
            q.Enqueue(s);

            while (q.Count != 0) {
                Vertex v = q.Dequeue();
                foreach (Edge e in v.adj) {
                    Vertex w = e.dest;
                    if (!w.known) {
                        w.known = true;
                        q.Enqueue(w);
                    }
                    if (s.known && w.name.Equals(name)) {
                        hasCycle = true;
                    }
                }
            }
            return hasCycle;
        }

        public string toonCycles() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Toon cycles");
            foreach (Vertex v in vertexMap.Values) {
                sb.Append(v.name + ": " + hasCycle(v.name) + "\n");
            }
            return sb.ToString();
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Graph");
            sb.AppendLine("Count: " + vertexMap.Count);
            foreach (Vertex v in vertexMap.Values) {
                sb.Append(v.name + ": ");
                foreach (Edge e in v.adj) {
                    sb.Append(e.dest.name + " ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
