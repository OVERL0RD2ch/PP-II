using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        Pen pen;
        Point prev, cur;
        bool clicked;
        public enum Tool
        {
            Rectangle,
            Ellipse,
            Pen,
            Circle,
            Triangle,
            Erase
        }
        Tool tool;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            pen = new Pen(Color.Black, 2);
            tool = Tool.Pen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = Math.Min(prev.X, cur.X);
            int y = Math.Min(prev.Y, cur.Y);
            int w = Math.Abs(prev.X - cur.X);
            int h = Math.Abs(prev.Y - cur.Y);
            if (tool == Tool.Rectangle)
            {
                g.DrawRectangle(pen, x, y, w, h);
            }
            else if (tool == Tool.Circle)
            {
                g.DrawEllipse(pen, x, y, w, h);
            }
            clicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if (tool == Tool.Pen && clicked)
            {
                g.DrawLine(pen, prev, cur);
                prev = cur;
            }
            else if (tool == Tool.Erase && clicked)
            {
                Pen pen = new Pen(Color.White, 2);
                g.DrawLine(pen, prev, cur);
                prev = cur;
            }
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = Tool.Rectangle;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = Tool.Pen;            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tool = Tool.Circle;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tool = Tool.Triangle;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pen.Color = colorDialog1.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tool = Tool.Erase;
        }

        private void i(object sender, System.EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x = Math.Min(prev.X, cur.X);
            int y = Math.Min(prev.Y, cur.Y);
            int w = Math.Abs(prev.X - cur.X);
            int h = Math.Abs(prev.Y - cur.Y);
            if (clicked)
            {
                if (tool == Tool.Rectangle)
                {
                    e.Graphics.DrawRectangle(pen, x, y, w, h);
                }
                else if (tool == Tool.Circle)
                {
                    e.Graphics.DrawEllipse(pen, x, y, w, h);
                }                
            }
        }
    }
}