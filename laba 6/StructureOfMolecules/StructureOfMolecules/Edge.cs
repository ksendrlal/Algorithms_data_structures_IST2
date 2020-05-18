using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfMolecules
{
    [Serializable]
    public class Edges
    {
        public List<Edge> EdgesList { get; set; } = new List<Edge>();
    }

    [Serializable]
    public class Edge
    {
        public Point v1 { get; set; }
        public Point v2 { get; set; }
        public int ColorEdge { get; set; }
        public Edge() { }
        public Edge(Point V1, Point V2, int colorEdge)
        {
            v1 = V1;
            v2 = V2;
            ColorEdge = colorEdge;
        }
    }
}
