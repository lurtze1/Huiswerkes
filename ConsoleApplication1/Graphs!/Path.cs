using System;

namespace ConsoleApplication1
{
    public class Path : IComparable<Path>
    {
        public double Cost;
        public Vertex Dest;

        public Path(Vertex d, double c)
        {
            Dest = d;
            Cost = c;
        }

        public int CompareTo(Path other)
        {
            double otherCost = other.Cost;

            return Cost < otherCost ? -1 : Cost > otherCost ? 1 : 0;
        }
    }
}