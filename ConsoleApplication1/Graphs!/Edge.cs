namespace ConsoleApplication1
{
    public class Edge
    {
        public double Cost;
        public Vertex Dest;

        public Edge(Vertex d, double c)
        {
            Dest = d;
            Cost = c;
        }
    }
}