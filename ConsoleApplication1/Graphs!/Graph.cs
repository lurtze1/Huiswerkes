using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class Graph
    {
        public const double Infinity = double.MaxValue;

        private readonly Dictionary<string, Vertex> _vertexMap = new Dictionary<string, Vertex>();

        private Vertex GetVertex(string vertexName)
        {
            Vertex v;
            if (!_vertexMap.ContainsKey(vertexName))
            {
                v = new Vertex(vertexName);
                _vertexMap.Add(vertexName, v);
            }
            else
            {
                v = _vertexMap[vertexName];
            }
            return v;
        }

        public void AddEdge(string sourceName, string destName, double cost)
        {
            var v = GetVertex(sourceName);
            var w = GetVertex(destName);
            v.Adj.AddLast(new Edge(w, cost));
        }

        private void ClearAll()
        {
            foreach (KeyValuePair<string, Vertex> keyValuePair in _vertexMap)
            {
                keyValuePair.Value.Reset();
            }
        }

        private void PrintPath(Vertex dest)
        {
            if (dest.Prev != null)
            {
                PrintPath(dest.Prev);
                Console.WriteLine(" to");
            }
            Console.WriteLine(dest.Name);
        }

        public void PrintPath(string destName)
        {
            if (_vertexMap[destName] == null)
            {
                throw new ArgumentException();
            }
            var w = _vertexMap[destName];
            if (w.Dist == Infinity)
            {
                Console.WriteLine(destName + " is unreachable");
            }
            else
            {
                Console.Write("(Cost is: " + w.Dist + ")");
                PrintPath(w);
                Console.WriteLine();
            }
        }

        public void Unweighted(string startName)
        {
            ClearAll();
            if (_vertexMap[startName] == null)
            {
                throw new GraphException("Start vertex not found");
            }
            var start = _vertexMap[startName];
            Queue<Vertex> q = new Queue<Vertex>();
            start.Dist = 0;
            q.Enqueue(start);
            while (q.Count != 0)
            {
                var v = q.Dequeue();

                foreach (var e in v.Adj)
                {
                    var w = e.Dest;
                    if (w.Dist == Infinity)
                    {
                        w.Dist = v.Dist + 1;
                        w.Prev = v;
                        q.Enqueue(w);
                    }
                }
            }
        }

        public void Dijsktra(string startName)
        {
            PriorityQueueT<Path> pq = new PriorityQueueT<Path>();


            if (_vertexMap[startName] == null)
            {
                throw new GraphException("No such vertex found");
            }
            var start = _vertexMap[startName];
            ClearAll();
            start.Dist = 0;
            pq.Add(new Path(start, 0.0));
            int nodesSeen = 0;
            while ((pq.Element() != null) && (nodesSeen < _vertexMap.Count))
            {
                var vrec = pq.Remove();
                var v = vrec.Dest;
                if (v.Scratch != 0)
                {
                    continue;
                }
                v.Scratch = 1;
                nodesSeen++;

                foreach (var e in v.Adj)
                {
                    var w = e.Dest;
                    double cvw = e.Cost;

                    if (cvw < 0)
                    {
                        throw new GraphException("Graph has negative Edges");
                    }
                    if (w.Dist > v.Dist + cvw)
                    {
                        w.Dist = v.Dist + cvw;
                        w.Prev = v;
                        pq.Add(new Path(w, w.Dist));
                    }
                }
            }
        }

        public void Negative(string startName)
        {
            ClearAll();

            if (_vertexMap[startName] == null)
            {
                throw new ArgumentException("Start doesn't exist");
            }
            var start = _vertexMap[startName];
            Queue<Vertex> q = new Queue<Vertex>();
            start.Dist = 0;
            start.Scratch++;
            q.Enqueue(start);
            while (q.Peek() != null)
            {
                var v = q.Dequeue();
                if (v.Scratch++ > 2*_vertexMap.Count)
                {
                    throw new GraphException("Negative Cycle Detected");
                }

                foreach (var e in v.Adj)
                {
                    var w = e.Dest;
                    double cvw = e.Cost;

                    if (w.Dist > v.Dist + cvw)
                    {
                        w.Dist = v.Dist + cvw;
                        w.Prev = v;
                        if (w.Scratch++%2 == 0)
                        {
                            q.Enqueue(w);
                        }
                        else
                        {
                            w.Scratch++;
                        }
                    }
                }
            }
        }

        public void Acyclic(string startName)
        {
            ClearAll();


            if (_vertexMap[startName] == null)
            {
                throw new GraphException("Start doesn't exist");
            }
            var start = _vertexMap[startName];
            Queue<Vertex> q = new Queue<Vertex>();
            start.Dist = 0;

            var vertexSet = _vertexMap.Values;
            foreach (var vertex in vertexSet)
            {
                foreach (var edge in vertex.Adj)
                {
                    edge.Dest.Scratch++;
                }
            }
            foreach (var vertex in vertexSet)
            {
                if (vertex.Scratch == 0)
                {
                    q.Enqueue(vertex);
                }
            }

            int iterations;
            for (iterations = 0; q.Peek() != null; iterations++)
            {
                var v = q.Dequeue();

                foreach (var edge in v.Adj)
                {
                    var w = edge.Dest;
                    double cvw = edge.Cost;

                    if (--w.Scratch == 0)
                    {
                        q.Enqueue(w);
                    }

                    if (v.Dist == Infinity)
                    {
                        continue;
                    }

                    if (w.Dist > v.Dist + cvw)
                    {
                        w.Dist = v.Dist + cvw;
                        w.Prev = v;
                    }
                }
            }
            if (iterations != _vertexMap.Count)
            {
                throw new GraphException("Graph has a cycle");
            }
        }

        public bool IsConnected()
        {
            bool isConnect = true;
            Unweighted(_vertexMap.Keys.First());
            foreach (var vertex in _vertexMap.Values)
            {
                if (vertex.Dist == Infinity)
                {
                    isConnect = false;
                }
            }
            return isConnect;
        }
    }

    internal class GraphException : SystemException
    {
        public GraphException(string name) : base(name)
        {
        }
    }
}