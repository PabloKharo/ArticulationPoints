using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace DiskrMat
{
    class Delete : MakeTruePoint
    {
        public void RdButtonClicked(Data data, int id)
        {
            for (int i = 0; i < data.EdgesForDraw.Count(); i++)
            {
                if (data.EdgesForDraw[i].a == id || data.EdgesForDraw[i].b == id)
                {
                    data.EdgesForDraw.RemoveAt(i);
                    i--;
                }
                else
                {
                    if (data.EdgesForDraw[i].a > id && data.EdgesForDraw[i].b > id)
                    {
                        data.EdgesForDraw[i].a--;
                        data.EdgesForDraw[i].b--;
                    }
                    else if (data.EdgesForDraw[i].a > id)
                        data.EdgesForDraw[i].a--;
                    else if (data.EdgesForDraw[i].b > id)
                        data.EdgesForDraw[i].b--;
                }
            }

            data.Edges.RemoveAt(id);
            data.RadioButtons.RemoveAt(id);
            for (int i = 0; i < data.Edges.Count(); i++)
            {
                for (int j = 0; j < data.Edges[i].Count; j++)
                {
                    if (data.Edges[i][j] == id)
                    {
                        data.Edges[i].RemoveAt(j);
                        j--;
                    }
                    else if (data.Edges[i][j] > id)
                    {
                        data.Edges[i][j]--;
                    }
                }

                if (i >= id)
                {
                    data.RadioButtons[i].Text = (i + 1).ToString();
                    data.RadioButtons[i].Name = i.ToString();
                }

            }
            data.NumbVertexes--;
        }
        public bool IsEdge { get; private set; }

        private bool CheckIsEdge(Point pointClicked, Edge edge)
        {
            double x = pointClicked.X; double y = pointClicked.Y;
            double x1 = edge.point_a.X; double y1 = edge.point_a.Y;
            double x2 = edge.point_b.X; double y2 = edge.point_b.Y;

            if (x + 7 > Math.Min(x1, x2) && x - 7 < Math.Max(x1, x2) &&
                y + 7 > Math.Min(y1, y2) && y - 7 < Math.Max(y1, y2))
            {
                double right, left;
                if (y - y1 == 0)
                    y++;
                if (x - x1 == 0)
                    x++;
                if (y2 - y1 == 0)
                    y2++;
                if (x2 - x1 == 0)
                    x2++;

                left = Math.Abs((y - y1) / (y2 - y1));
                right = Math.Abs((x - x1) / (x2 - x1));

                double osmall = Math.Abs(right - left);
                double obig = 5 / (Math.Min(Math.Abs(x2 - x1), Math.Abs(y2 - y1)));
                if (osmall <= obig)
                    return true;
            }

            return false;
        }

        public void PanelClicked(Data data, MakeTruePoint makeTruePoint)
        {
            for (int i = data.EdgesForDraw.Count() - 1; i >= 0; i--)
            {
                IsEdge = CheckIsEdge(makeTruePoint.TruePoint, data.EdgesForDraw[i]);

                if (IsEdge == true)
                {
                    data.Edges[data.EdgesForDraw[i].a].Remove(data.EdgesForDraw[i].b);
                    data.Edges[data.EdgesForDraw[i].b].Remove(data.EdgesForDraw[i].a);
                    data.EdgesForDraw.RemoveAt(i);
                    break;
                }

            }
        }

    }
}
