using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfMolecules
{ 

    [Serializable]
    public class ListEdgesAndVertexes
    {
        public Edges EdgesList { get; set; } = new Edges();
        public Vertexes VertexesList { get; set; } = new Vertexes();

        public ListEdgesAndVertexes() { }

        public ListEdgesAndVertexes(Edges edgesList, Vertexes vertexesList)
        {
            EdgesList = edgesList;
            VertexesList = vertexesList;
        }
    }
}
