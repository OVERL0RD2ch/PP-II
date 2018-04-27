using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics
{

    public partial class Form1 : Form
    {
        private Point[] points_ = new Point[6];
        Graphics g;
        List<Rectangle> rectangles;
        List<List<Point>> points;
        public Form1()
        {

            InitializeComponent();
            g = CreateGraphics();
            timer1.Start();
            rectangles = new List<Rectangle>()
            {
                new Rectangle(49, 81, 29, 29),
                new Rectangle(690, 400, 29, 29),
                new Rectangle(200, 40, 29, 29),
                new Rectangle(350, 99, 29, 29),
                new Rectangle(550, 170, 29, 29),
                new Rectangle(70, 400, 29, 29)
            };
            points = new List<List<Point>>()
            {
                // spaceship
                new List<Point> { new Point(348, 207), new Point(400, 185), new Point(451, 207), new Point(451, 251), new Point(400, 273) , new Point(348, 251) },
                //gun
                new List<Point> { new Point(392, 247), new Point(408, 247), new Point(408, 227), new Point(414, 227), new Point(400, 207), new Point(386, 227), new Point(392, 227) },
                // stars
                new List<Point> { new Point(166, 137), new Point(174, 147), new Point(188, 147), new Point(182, 159), new Point(188, 171), new Point(174, 171), new Point(166, 181), new Point(156, 171), new Point(142, 171), new Point(150, 159), new Point(142, 147), new Point(156, 147) },
                new List<Point> { new Point(166 + 450, 137), new Point(174 + 450, 147), new Point(188 + 450, 147), new Point(182 + 450, 159), new Point(188 + 450, 171), new Point(174 + 450, 171), new Point(166 + 450, 181), new Point(156 + 450, 171), new Point(142 + 450, 171), new Point(150 + 450, 159), new Point(142 + 450, 147), new Point(156 + 450, 147) },
                new List<Point> { new Point(166 + 47, 137 + 126), new Point(174 + 47, 147 + 126), new Point(188 + 47, 147 + 126), new Point(182 + 47, 159 + 126), new Point(188 + 47, 171 + 126), new Point(174 + 47, 171 + 126), new Point(166 + 47, 181 + 126), new Point(156 + 47, 171 + 126), new Point(142 + 47, 171 + 126), new Point(150 + 47, 159 + 126), new Point(142 + 47, 147 + 126), new Point(156 + 47, 147 + 126) },
                new List<Point> { new Point(166 + 346, 137 + 196), new Point(174 + 346, 147 + 196), new Point(188 + 346, 147 + 196), new Point(182 + 346, 159 + 196), new Point(188 + 346, 171 + 196), new Point(174 + 346, 171 + 196), new Point(166 + 346, 181 + 196), new Point(156 + 346, 171 + 196), new Point(142 + 346, 171 + 196), new Point(150 + 346, 159 + 196), new Point(142 + 346, 147 + 196), new Point(156 + 346, 147 + 196)},
        };


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // window
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(63, 72, 204)), 0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 15), 0, 0, Width - 17, Height - 40);

            var color = Color.Black;
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i].Count == 6)
                    color = Color.Yellow;
                else if (points[i].Count == 7)
                    color = Color.Green;
                else if (points[i].Count == 12)
                    color = Color.Red;
                e.Graphics.FillPolygon(new SolidBrush(color), points[i].ToArray());
            }
            // circles
            for (int i = 0; i < rectangles.Count; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.White), rectangles[i]);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < rectangles.Count; i++)
            {
                int dx = rnd.Next(-100, 100);
                int dy = rnd.Next(-100, 100);
                if (rectangles[i].X + dx + 15 >= 0 && rectangles[i].X + dx + 15 <= Width && rectangles[i].Y + dy + 15 >= 0 && rectangles[i].Y + dy + 15 <= Height)
                    rectangles[i] = new Rectangle(rectangles[i].X + dx, rectangles[i].Y + dy, rectangles[i].Width, rectangles[i].Height);
            }

            for (int i = 0; i < points.Count; i++)
            {
                int dx = rnd.Next(-1, 1);
                for (int j = 0; j < points[i].Count; j++)
                {
                    points[i][j] = new Point(points[i][j].X + dx, points[i][j].Y + dx);
                }
            }
            //    Invalidate();

        }


    }

}