using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace ConsoleApplication1
{
    public class Vertex
    {
        public String Name;
        public LinkedList<Edge> Adj;
        public double Dist;
        public Vertex Prev;
        public int Scratch;

        public Vertex(String nm)
        {
            Name = nm; Adj = new LinkedList<Edge>(); ;
        }

        public void Reset()
        {
            Dist = int.MaxValue;
            Prev = null;
            Scratch = 0;
        }
    }
}