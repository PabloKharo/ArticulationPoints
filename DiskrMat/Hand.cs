using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskrMat
{
    class Hand : MakeTruePoint
    {
        public bool Handed { get; set; }
        public int Id { get; set; }

        public void RdButtonClicked(object sender)
        {
            Handed = true;
            Id = Convert.ToInt32((sender as RadioButton).Name);
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

        public void PanelClicked(Data data, Line line, MakeTruePoint makeTruePoint, bool caged, bool doted, int cageSize)
        {
            if (doted == true || caged == true)
                data.RadioButtons[Id].Location = MakeCagedPoint(makeTruePoint.TruePoint, cageSize);
            else
                data.RadioButtons[Id].Location = makeTruePoint.TruePoint;

            LineMake(data.RadioButtons[Id].Location);

            for (int i = 0; i < data.EdgesForDraw.Count(); i++)
            {
                if (Id == data.EdgesForDraw[i].a)
                    data.EdgesForDraw[i].point_a = TruePoint;
                else if (Id == data.EdgesForDraw[i].b)
                    data.EdgesForDraw[i].point_b = TruePoint;

            }
            Handed = false;
            
        }

    }
}
