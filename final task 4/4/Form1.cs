using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();
            Random r = new Random();
            int wr = r.Next(0, Width);
            Button circ = new Button();
            //Color c = new Color();
            //c = { "red", "blue", "green"};
            //circ.BackColor = ;
            circ.BackColor = Color.Red;
            circ.Size = new Size(20, 20);
            circ.Location = new Point(wr, 0);
            Controls.Add(circ);
            btn.Add(circ);
            int n = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (circ.BackColor == circ.BackColor)
                {
                    n += n + 100;
                    label2.Text = Convert.ToString(n);
                }
                if(n > 1000)
                {

                }
                if(circ.Location.Y > Height)
                {
                    n++;
                    if(n > 20)
                    {
                        Program.Stop();
                        ShowDialog("Game Over");                        
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
