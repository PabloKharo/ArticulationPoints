using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskrMat
{
    class Data
    {
        public int NumbVertexes { get; set; }
        public List<List<int>> Edges { get; set; }
        public List<Edge> EdgesForDraw { get; set;}
        public List<RadioButton> RadioButtons { get; set; }

        public void ClearAllData()
        {
            NumbVertexes = 0;
            RadioButtons.Clear();
            EdgesForDraw.Clear();
            Edges.Clear();
        }

    }
}
