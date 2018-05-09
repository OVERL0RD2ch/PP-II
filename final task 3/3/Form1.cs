using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
	bool player1;
	bool player2;
        public Form1()
        {
            InitializeComponent();
	    player1= true;
	    player2 = false;
        }
        public void Is_over()
        {
            if(button1.Text = "X" && button2.Text = "X" && button3.Text = "X")
            {
		if (player1 == true) e.Message("Player 1 win");
		else e.Messaege("Player 2 win");            
	    }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Button.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();

        }
    }
}
