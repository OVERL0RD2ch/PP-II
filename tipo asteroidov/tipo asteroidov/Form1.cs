using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipo_asteroidov
{
    public partial class Form1 : Form
    {
        
        List<Button> btn = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /*label3.Text = Convert.ToString(0);
            if(button1.Location.X == label1.Location.X && button1.Location.Y == label1.Location.Y)
            {
                label3.Text += 100;
            }*/

        }
        private void button1_KeyPress(object sender, KeyEventArgs e)
        {
            Point px = button1.Location;
            
            switch (e.KeyCode)
            {
                case Keys.A:
                    button1.Location = new Point(button1.Location.X - 15, button1.Location.Y);
                    break;
                case Keys.D:
                    button1.Location = new Point(button1.Location.X + 15, button1.Location.Y);
                    break;
                case Keys.R:
                    Application.Restart();
                    break;
            }
            if (button1.Location.X > Width)
                px.X = 0;
            if (button1.Location.X < Width)
                px.X = Width;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int wr = r.Next(0, Width);
            Button ast = new Button();
            ast.BackColor = Color.Yellow;
            ast.Size = new Size(20, 20);
            ast.Location = new Point(wr, 0);
            Controls.Add(ast); btn.Add(ast);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*switch (e.KeyCode)
            {
                case Keys.R:
                    Application.Restart();
                    break;
            }*/
            label1.Visible = false;
            label2.Visible = false;
            for (int i = 0; i < btn.Count; i++)
            {
                
                int x = btn[i].Location.X;
                int y = btn[i].Location.Y;
                btn[i].Location = new Point(x, y + 5);
                if (Math.Abs(btn[i].Location.X - button1.Location.X) <= btn[i].Width && Math.Abs(btn[i].Location.Y - button1.Location.Y) <= btn[i].Height)
                {
                    button1.Visible = false;
                    timer2.Enabled = false;
                    timer1.Enabled = false;
                    label1.Visible = true;
                    label2.Visible = true;
                    for (int j = 0; j < btn.Count; j++)
                    {
                        btn[j].Visible = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.R:
                    Application.Restart();
                    break;
            }
        }
    }
}
