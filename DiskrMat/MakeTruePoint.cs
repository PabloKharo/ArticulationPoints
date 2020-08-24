using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskrMat
{
    class MakeTruePoint
    {
        public Point TruePoint { get; set; } 
        public Point FormLocation { get; set; }

        public void Vertex() 
        {
            Point cursorLoc = Cursor.Position;
            Point res = new Point
            {
                X = cursorLoc.X - FormLocation.X - 13,
                Y = cursorLoc.Y - FormLocation.Y - 38
            };
            this.TruePoint = res;
        }

        public void LineDelete()
        {
            Point cursorLoc = Cursor.Position;
            Point res = new Point
            {
                X = cursorLoc.X - FormLocation.X - 8,
                Y = cursorLoc.Y - FormLocation.Y - 33
            };
            this.TruePoint = res;
        }

        protected void LineMake(Point l)
        {
            Point res = new Point
            {
                X = l.X + 6,
                Y = l.Y + 7
            };
            this.TruePoint = res;
        }

    }
}
