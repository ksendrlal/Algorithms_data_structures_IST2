using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfMolecules
{
    [Serializable]
    public class Vertexes
    {
        public List<Vertex> VertexesList { get; set; } = new List<Vertex>();
    }

    [Serializable]

    public class Vertex
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int ColorVertex { get; set; }
        public string Name { get; set; }
        public Vertex() { }
        public Vertex(int x, int y, int colorVertex, string name = " ")
        {
            X = x;
            Y = y;
            ColorVertex = colorVertex;
            if (Name != " ")
            {
                Name = name;

            }
        }

    }
}
