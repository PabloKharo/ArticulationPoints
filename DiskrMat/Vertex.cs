using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DiskrMat
{
    class Vertex
    {

        public bool IsVertex(Data data, MakeTruePoint makeTruePoint, bool caged, bool doted, int cageSize)
        {
            Point point = new Point();
            if (caged == true || doted == true)
                point = MakeCagedPoint(makeTruePoint.TruePoint, cageSize);
            else
                point = makeTruePoint.TruePoint;
            for (int i = 0; i < data.RadioButtons.Count(); i++)
            {
                if (data.RadioButtons[i].Location == point)
                    return true;
            }
            return false;
        }

        protected Point MakeCagedPoint(Point point, int cageSize)
        {
            Point resPoint = new Point();
            point.X += 4;
            point.Y += 6;
            if (point.X % cageSize <= cageSize / 2)
            {
                if (point.Y % cageSize <= cageSize / 2)
                {
                    resPoint.X = (point.X / cageSize) * cageSize - 6;
                    resPoint.Y = (point.Y / cageSize) * cageSize - 6;
                }
                else
                {
                    resPoint.X = (point.X / cageSize) * cageSize - 6;
                    resPoint.Y = (point.Y / cageSize + 1) * cageSize - 6;
                }
            }
            else
            {
                if (point.Y % cageSize <= cageSize / 2)
                {
                    resPoint.X = (point.X / cageSize + 1) * cageSize - 6;
                    resPoint.Y = (point.Y / cageSize) * cageSize - 6;
                }
                else
                {
                    resPoint.X = (point.X / cageSize + 1) * cageSize - 6;
                    resPoint.Y = (point.Y / cageSize + 1) * cageSize - 6;
                }
            }
            return resPoint;
        }

        public void CreateVertex(Data data, MakeTruePoint makeTruePoint, bool caged, bool doted, int cageSize)
        {
            Point point = new Point();
            if (caged == true || doted == true)
                point = MakeCagedPoint(makeTruePoint.TruePoint, cageSize);
            else
                point = makeTruePoint.TruePoint;

            RadioButton rd_button = new RadioButton
            {
                Name = data.NumbVertexes.ToString(),
                Enabled = true,
                Checked = true,
                Text = (data.NumbVertexes + 1).ToString(),
                Visible = true,
                Location = point,
                AutoSize = true
            };

            data.RadioButtons.Add(rd_button);
            data.Edges.Add(new List<int>());
            data.NumbVertexes++;
        }
    }
}
