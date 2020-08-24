using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskrMat
{
    class DoTask
    {
        public List<int> Do(Data data)
        {
            if (data.RadioButtons.Count() == 0)
            {
                MessageBox.Show("Нет вершин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            FindArticPoints findPoints = new FindArticPoints();
            findPoints.Find_cutpoints(data.Edges);
            if (findPoints.Points.Count() != 0)
            {
                return findPoints.Points;
            }
            else
            {
                MessageBox.Show("Нет точек сочленения");
                return null;
            }
        }

    }
}
