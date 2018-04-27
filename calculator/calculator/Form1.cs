using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        bool isOperationClicked = false;
        bool isResultClicked = false;
        double firstnumber = 0, secondnumber = 0, result = 0;
        string operation = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            // display.Text = Convert.ToString(result);
            if (display.Text == "0")
            {
                display.Text = display.Text.Remove(0);                
            }
           // display.Text += btn.Text;
            /*if(result != 0)
            {
                display.Text = display.Text.Remove(int.Parse(display.Text));
                display.Text = firstnumber.ToString();
            }*/
            display.Text += btn.Text;
            //display.Text += btn.Text;
            /*if (result != 0)
            {
                display.Text = btn.Text;

            }*/

            /*if (result > (-1))
            {
                display.Text = btn.Text;
            }*/

            //if(result = 0)

        }

        private void operation_Click(object sender, EventArgs e)
        {
            if (!isOperationClicked)
            {
                Button btn = sender as Button;
                firstnumber = double.Parse(display.Text);
                operation = btn.Text;
                display.Text = "";
                isOperationClicked = true;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (!isResultClicked)
            {
                Button btn = sender as Button;

                secondnumber = double.Parse(display.Text);
                if (secondnumber > 0 && secondnumber < 0 && secondnumber == 0)
                {
                    result = firstnumber;
                }
                switch (operation)
                {

                    case "x^y":
                        result = Math.Pow(firstnumber, secondnumber);
                        break;
                    case "+":
                        result = firstnumber + secondnumber;

                        break;
                    case "-":
                        result = firstnumber - secondnumber;
                        break;
                    case "*":
                        result = firstnumber * secondnumber;
                        break;
                    case "/":
                        result = firstnumber / secondnumber;
                        break;
                }
                display.Text = result.ToString();
                isResultClicked = true;
            }
        }

        private void clear_all_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            firstnumber = 0;
            secondnumber = 0;
            result = 0;
            operation = "";
            isResultClicked = false;
            isOperationClicked = false;
        }

        private void clear_last_Click(object sender, EventArgs e)
        {
            if (firstnumber != 0)
            {
                display.Text = "";
                secondnumber = 0;
            }
            if (firstnumber != 0 && secondnumber != 0)
            {
                display.Text = "";
                result = 0;
            }
            if (firstnumber != 0)
            {
                result = 0;
                display.Text = Convert.ToString(result);
            }
            /*if (secondnumber )
            {
                display.Text = "";
                firstnumber = 0;
            }*/
            isResultClicked = false;
            isOperationClicked = false;
        }

        private void num_db_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstnumber = double.Parse(display.Text);
            result = Math.Pow(firstnumber, 2);
            display.Text = result.ToString();
        }

        private void pi_Click(object sender, EventArgs e)
        {
            display.Text = Convert.ToString(3.14);
        }

        private void num_num_Click(object sender, EventArgs e)
        {
            
            //Button btn = sender as Button;
            //firstnumber = double.Parse(display.Text);
            secondnumber = double.Parse(display.Text);
            result = Math.Pow(firstnumber, secondnumber);
            display.Text = result.ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstnumber = double.Parse(display.Text);
            result = Math.Sqrt(firstnumber);
            display.Text = result.ToString();
        }

        private void plus_minus_Click(object sender, EventArgs e)
        {
            /*if(firstnumber > 0 || secondnumber > 0 || result > 0)
                display.Text = '-' + display.Text;
            if (firstnumber < 0 || secondnumber < 0 || result < 0)
                display.Text ="" + display.Text;*/
            result = double.Parse(display.Text) * (-1);

            display.Text = result.ToString();

        }
        
        private void e_Click(object sender, EventArgs e)
        {
            
             Button btn = sender as Button;
             firstnumber = double.Parse(display.Text);
             result = Math.Pow(2.71, firstnumber);
             display.Text = result.ToString();            
        }

        private void sin_Click(object sender, EventArgs e)
        {
            double angle = Math.PI * firstnumber / 180;
            firstnumber = double.Parse(display.Text);
            double res = Math.Sin(angle/ 57.2957818333258);
            result = res * 57.2958;
            display.Text = result.ToString();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            firstnumber = double.Parse(display.Text);
            result = Math.Cos(firstnumber);
            display.Text = result.ToString();

        }

        private void display_TextChanged(object sender, EventArgs e)
        {
            Button btn = new Button();
           // display.Text = Convert.ToString(0);
          
            
            display.TextAlign = HorizontalAlignment.Right;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            result = Math.Log10(double.Parse(display.Text));
            display.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\user\Desktop\PP-II\calculator\for.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(display.Text);
            sw.Close();
            fs.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\user\Desktop\PP-II\calculator\for.txt", string.Empty);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\user\Desktop\PP-II\calculator\for.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            result = double.Parse(s);
            display.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\user\Desktop\PP-II\calculator\for.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            result = double.Parse(s) + double.Parse(display.Text);
            display.Text = result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\user\Desktop\PP-II\calculator\for.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            result = double.Parse(s) - double.Parse(display.Text);
            display.Text = result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string s = display.Text.Remove(display.Text.Length - 1);
            
            
            if (display.Text.Length == 1)
            {
                result = 0;
                
                
            }
            
            else result = double.Parse(s);
            display.Text = result.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display.Text = result.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
            
        }

        private void tan_Click(object sender, EventArgs e)
        {
            firstnumber = double.Parse(display.Text);
            result = Math.Tan(firstnumber);
            display.Text = result.ToString();
        }

        private void binom_Click(object sender, EventArgs e)
        {
            int a = 1;
            firstnumber = double.Parse(display.Text);
            for (int i = 1; i <= firstnumber; i++)
            {
                a *= i;
            }
            result = a;
            
            if(display.Text == "0")
            {
                result = 0;
            }
            if(int.Parse(display.Text) < 0)
            {
                result = 0;
            }
            display.Text = result.ToString();
        }
    }
}
