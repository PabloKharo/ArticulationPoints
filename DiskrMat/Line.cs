using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskrMat
{
    class Line : MakeTruePoint
    {
        public bool Lineded { get; set; }

        private Point PointFrom { get; set; }
        private Point PointTo { get; set; }
        private int Vertex1 { get; set; }
        private int Vertex2 { get; set; }

        public void RdButtonClicked(Data data, object sender, Color lineColor)
        {
            if (Lineded == false)
                SaveFirstPoint(sender);
            else if ((sender as RadioButton).Name == Vertex1.ToString())
            {
                MessageBox.Show("Нельзя провести линию в ту же точку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Lineded = false;
            }
            else
            {
                SaveSecondPoint(sender);

                if (data.Edges[Vertex1].Contains(Vertex2))
                {
                    MessageBox.Show("Нельзя дважды провести линию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Lineded = false;
                }
                else
                    CreateLine(data, lineColor);
            }
        }

        private void SaveFirstPoint(object sender)
        {
            Lineded = true;
            LineMake((sender as RadioButton).Location);
            PointFrom = TruePoint;
            Vertex1 = Convert.ToInt32((sender as RadioButton).Name);
        }

        private void SaveSecondPoint(object sender)
        {
            LineMake((sender as RadioButton).Location);
            PointTo = TruePoint;
            Vertex2 = Convert.ToInt32((sender as RadioButton).Name);
        }

        private void CreateLine(Data data, Color lineColor)
        {
            Edge edge = new Edge
            {
                a = Vertex1,
                b = Vertex2,
                point_a = PointFrom,
                point_b = PointTo,
                color = lineColor
            };

            data.Edges[Vertex1].Add(Vertex2);
            data.Edges[Vertex2].Add(Vertex1);
            data.EdgesForDraw.Add(edge);

            Lineded = false;
        }
            
    }
}
