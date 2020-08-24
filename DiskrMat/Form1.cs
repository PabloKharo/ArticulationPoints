using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DiskrMat
{
    public partial class Form1 : Form
    {

        // Инициализация элементов
        private string buttonSelected;
        private bool caged;
        private bool doted;
        private int cageSize;
        private string colorSelected;
        private List<Point> listOfAnsPoints;
        private Color lineColor;
        private Bitmap bitmap;
        private Bitmap bitmapCage;
        private Bitmap bitmapFrame;
        private Bitmap bitmapDot;
        private Bitmap bitmapAns;
        private Data data = new Data();
        private Hand hand = new Hand();
        private Vertex vertex = new Vertex();
        private Line line = new Line();
        private Delete delete = new Delete();
        private DoTask doTask = new DoTask();
        System.Windows.Forms.ToolStripMenuItem whiteFonToolStripMenuItem;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Программу написал Харьков П.А студент группы М80-106Б-19";
            caged = true;
            CageToolStripMenuItem.Checked = true;
            doted = false;
            cageSize = 30;
            numbCageSizeToolStripMenuItem.Text = cageSize.ToString();
            numbCageSizeToolStripMenuItem.MaxLength = 2;
            numbCageSizeToolStripMenuItem.AutoSize = false;
            numbCageSizeToolStripMenuItem.Width = 30;
            listOfAnsPoints = new List<Point>();

            lineColor = Color.Black;
            colorSelected = "Black";
            blackToolStripMenuItem.Checked = true;

            hand.Handed = false;
            line.Lineded = false;

            data.NumbVertexes = 0;
            data.Edges = new List<List<int>>();
            data.EdgesForDraw = new List<Edge>();
            data.RadioButtons = new List<RadioButton>();

            InitializeBitmapFrame();
            InitializeBitmap();
            InitializeBitmapCage();
            InitializeBitmapDot();
            InitializeBitmapAns();

            whiteFonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuStripField.Items.Insert(1, whiteFonToolStripMenuItem);
            whiteFonToolStripMenuItem.Name = "whiteFonToolStripMenuItem";
            whiteFonToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            whiteFonToolStripMenuItem.Text = "Белый фон";
            whiteFonToolStripMenuItem.Click += new System.EventHandler(whiteFonToolStripMenuItem_Click);

            MessageBox.Show("Выполнил Харьков П.А.,\nстудент группы М80-106Б-19\nзадание №13", "Информация");

        }

        private void InitializeBitmap()
        {
            if (this.Width > 21 && this.Height > 103)
            {
                bitmap = new Bitmap(this.Width - 21, this.Height - 103);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    for (int i = 0; i < data.EdgesForDraw.Count(); i++)
                    {
                        Pen pen = new Pen(data.EdgesForDraw[i].color);
                        graphics.DrawLine(pen,
                            data.EdgesForDraw[i].point_a,
                            data.EdgesForDraw[i].point_b);
                    }
                }
            }
        }
        
        private void InitializeBitmapCage()
        {
            if (this.Width > 21 && this.Height > 103)
            {
                bitmapCage = new Bitmap(this.Width, this.Height);

                using (Graphics g = Graphics.FromImage(bitmapCage))
                {
                    for (int i = cageSize; i < this.Height - 8; i += cageSize)
                    {
                        g.DrawLine(Pens.Gainsboro, 0 + 5, i, this.Width - 21, i);
                    }
                    for (int i = cageSize; i < this.Width - 8; i += cageSize)
                    {
                        g.DrawLine(Pens.Gainsboro, i, 0 + 5, i, this.Height - 103);
                    }
                }
            }
        }

        private void InitializeBitmapDot()
        {
            if (this.Width > 21 && this.Height > 103)
            {
                bitmapDot = new Bitmap(this.Width, this.Height);

                using (Graphics g = Graphics.FromImage(bitmapDot))
                {
                    Brush brush = (Brush)Brushes.Gainsboro;
                    for (int i = cageSize; i < this.Width - 14; i += cageSize)
                    {
                        for (int j = cageSize; j < this.Height - 103; j += cageSize)
                        {
                            g.FillEllipse(brush, i-1, j-1, 3, 3);
                        }
                    }
                }
            }
        }

        private void InitializeBitmapFrame()
        {
            if (this.Width > 21 && this.Height > 103)
            {
                bitmapFrame = new Bitmap(this.Width, this.Height);

                using (Graphics g = Graphics.FromImage(bitmapFrame))
                {
                    g.DrawRectangle(
                        new Pen(Color.SteelBlue, 8),
                        0, 0, this.Width - 16, this.Height - 98);
                }
            }
        }
        
        private void InitializeBitmapAns()
        {
            if (this.Width > 21 && this.Height > 103)
            {
                bitmapAns = new Bitmap(this.Width - 21, this.Height - 103);
                using (Graphics graphics = Graphics.FromImage(bitmapAns))
                {
                    for (int i = 0; i < listOfAnsPoints.Count(); i++)
                    {
                        Pen pen = new Pen(Color.Cyan, 4);
                        graphics.DrawEllipse(pen, listOfAnsPoints[i].X - 9, listOfAnsPoints[i].Y - 7, 30, 30);
                    }
                }
                listOfAnsPoints.Clear();
            }
        }


        // Управление кнопками
        private void ButtonHand_Click(object sender, EventArgs e)
        {
            EnableLastButton();
            buttonSelected = "Hand";
            buttonHand.Enabled = false;
            InitializeBitmapAns();
            this.Invalidate();
        }

        private void ButtonVertex_Click(object sender, EventArgs e)
        {
            EnableLastButton();
            buttonSelected = "Vertex";
            buttonVertex.Enabled = false;
            InitializeBitmapAns();
            this.Invalidate();
        }

        private void ButtonLine_Click(object sender, EventArgs e)
        {
            EnableLastButton();
            buttonSelected = "Line";
            buttonLine.Enabled = false;
            InitializeBitmapAns();
            this.Invalidate();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            EnableLastButton();
            buttonSelected = "Delete";
            buttonDelete.Enabled = false;
            InitializeBitmapAns();
            this.Invalidate();
        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            EnableLastButton();

            for (int i = 0; i < data.RadioButtons.Count(); i++)
            {
                this.Controls.Remove(data.RadioButtons[i]);
            }
            data.ClearAllData();
            InitializeBitmapAns();
            InitializeBitmap();
            this.Invalidate();

        }

        private void ButtonDo_Click(object sender, EventArgs e)
        {
            EnableLastButton();
            List<int> list = doTask.Do(data);
            if (list != null)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    listOfAnsPoints.Add(data.RadioButtons[list[i] - 1].Location);
                }
            }
            InitializeBitmapAns();
            this.Invalidate();
        }

        private void EnableLastButton()
        {
            switch (buttonSelected)
            {
                case "Hand":
                    buttonHand.Enabled = true;
                    hand.Handed = false;
                    break;
                case "Vertex":
                    buttonVertex.Enabled = true;
                    break;
                case "Line":
                    buttonLine.Enabled = true;
                    line.Lineded = false;
                    break;
                case "Delete":
                    buttonDelete.Enabled = true;
                    break;
            }
        }


        // Управление полем
        private void RdButtton_Click(object sender, MouseEventArgs e)
        {
            if (buttonSelected == "Hand" && hand.Handed == false)
            {
                hand.RdButtonClicked(sender);
            }
            else if (buttonSelected == "Line")
            {
                line.RdButtonClicked(data, sender, lineColor);
                if (!line.Lineded)
                    DrawLine();

            }
            else if (buttonSelected == "Delete")
            {
                this.Controls.Remove((sender as RadioButton));
                int id = Convert.ToInt32((sender as RadioButton).Name);

                delete.RdButtonClicked(data, id);
                InitializeBitmap();
                this.Invalidate();
            }
        }

        private void DrawLine()
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                int n = data.EdgesForDraw.Count() - 1;
                if (n >= 0)
                {
                    Pen pen = new Pen(data.EdgesForDraw[n].color);
                    graphics.DrawLine(pen,
                        data.EdgesForDraw[n].point_a,
                        data.EdgesForDraw[n].point_b);
                }
            }

            this.Invalidate();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MakeTruePoint makeTruePoint = new MakeTruePoint();
            makeTruePoint.FormLocation = Location;

            if (buttonSelected == "Hand" && hand.Handed == true)
            {
                makeTruePoint.Vertex();
                this.Controls.Remove(data.RadioButtons[hand.Id]);

                hand.PanelClicked(data, line, makeTruePoint, caged, doted, cageSize);

                this.Controls.Add(data.RadioButtons[hand.Id]);
                InitializeBitmap();
                this.Invalidate();
            }
            else if (buttonSelected == "Vertex")
            {
                makeTruePoint.Vertex();
                if (!vertex.IsVertex(data, makeTruePoint, caged, doted, cageSize))
                {
                    vertex.CreateVertex(data, makeTruePoint, caged, doted, cageSize);

                    data.RadioButtons[data.NumbVertexes - 1].MouseClick += new MouseEventHandler(RdButtton_Click);
                    this.Controls.Add(data.RadioButtons[data.NumbVertexes - 1]);
                }
            }
            else if (buttonSelected == "Delete")
            {
                makeTruePoint.LineDelete();
                delete.PanelClicked(data, makeTruePoint);
                if (delete.IsEdge == true)
                {
                    InitializeBitmap();
                    this.Invalidate();
                }

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmapFrame, new Point(0, 0));
            if (doted == true)
                e.Graphics.DrawImage(bitmapDot, new Point(0, 0));
            else if (caged == true)
                e.Graphics.DrawImage(bitmapCage, new Point(0, 0));
            e.Graphics.DrawImage(bitmapAns, new Point(0, 0));
            e.Graphics.DrawImage(bitmap, new Point(0, 0));
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            InitializeBitmapFrame();
            InitializeBitmapCage();
            InitializeBitmapDot();
            InitializeBitmap();
        }


        // Управление ToolStripMenu
        private void сageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whiteFonToolStripMenuItem.Checked = false;
            if (doted == true)
            {
                doted = false;
                dotToolStripMenuItem.Checked = false;
            }
            if (caged == true)
            {
                caged = false;
                whiteFonToolStripMenuItem.Checked = true;
            }
            else
            {
                caged = true;
                whiteFonToolStripMenuItem.Checked = false;
            }
            CageToolStripMenuItem.Checked = caged;
            this.Invalidate();
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whiteFonToolStripMenuItem.Checked = false;
            if (caged == true)
            {
                caged = false;
                CageToolStripMenuItem.Checked = false;
            }
            if (doted == true)
            {
                doted = false;
                whiteFonToolStripMenuItem.Checked = true;
            }
            else
            {
                doted = true;
                whiteFonToolStripMenuItem.Checked = false;
            }
            dotToolStripMenuItem.Checked = doted;
            this.Invalidate();
        }

        private void whiteFonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (caged == true)
            {
                caged = false;
                CageToolStripMenuItem.Checked = false;
            }
            if (doted == true)
            {
                doted = false;
                dotToolStripMenuItem.Checked = false;
            }
            whiteFonToolStripMenuItem.Checked = true;
            this.Invalidate();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAllColorsToolStrip();
            colorSelected = "Black";
            lineColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAllColorsToolStrip();
            colorSelected = "Red";
            lineColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAllColorsToolStrip();
            colorSelected = "Green";
            lineColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAllColorsToolStrip();
            colorSelected = "Blue";
            lineColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    EnableAllColorsToolStrip();
                    colorSelected = "Other";
                    lineColor = cd.Color;
                    otherToolStripMenuItem.Checked = true;
                }
            }
        }

        private void numbCageSizeToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(numbCageSizeToolStripMenuItem.Text, out int n);
            if (isNumeric == true)
            {
                if (n != 0)
                {
                    numbCageSizeToolStripMenuItem.Text = n.ToString();
                    cageSize = n;
                }
                else
                    MessageBox.Show("Нельзя ввести 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (numbCageSizeToolStripMenuItem.Text.Length != 0)
                    MessageBox.Show("Введите число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitializeBitmapCage();
            InitializeBitmapDot();
            this.Invalidate();
        }

        private void EnableAllColorsToolStrip()
        {
            switch (colorSelected)
            {
                case "Black":
                    blackToolStripMenuItem.Checked = false;
                    break;
                case "Red":
                    redToolStripMenuItem.Checked = false;
                    break;
                case "Green":
                    greenToolStripMenuItem.Checked = false;
                    break;
                case "Blue":
                    blueToolStripMenuItem.Checked = false;
                    break;
                case "Other":
                    otherToolStripMenuItem.Checked = true;
                    break;
            }
        }

        private void numbCageSizeToolStripMenuItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                contextMenuStripField.Close();
        }

    }
}
