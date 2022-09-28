using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1Exercise4Snakesandladdersss
{
    public partial class Form1 : Form
    {
        bool green = false;
        int x=24, y=471, dicevalue,p=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources.snakesandladders;
            pictureBox1.Image = Properties.Resources.g11;
            pictureBox4.Image = Properties.Resources.g;
            pictureBox4.Visible = false;
            pictureBox3.Image = Properties.Resources.roll1; 
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dicevalue = rolldice(pictureBox3);
            label2.Text = dicevalue.ToString();
            if (green == true)
            {
                p=move(ref x,ref y, pictureBox4, dicevalue, p, label9);
                label7.Text = p.ToString();
            }
            if (label2.Text == "6" && green == false)
            {
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                green = true;
                pictureBox4.Location = new Point(x, y);
                label3.Text = x.ToString();
                label5.Text = y.ToString();
                label7.Text = p.ToString();
                p++;
              
            }
            if(p==100)
            {
                MessageBox.Show("win");
                button1.Enabled = false;
            }
            p = snake(ref x, ref y, p, pictureBox4);

        }
        public static int rolldice(PictureBox px)
        {
            int dice = 0;
            Random r = new Random();
            dice = r.Next(1, 7);
            switch (dice)
            {

                case 1:
                    px.Image = Properties.Resources._1;
                    break;
                case 2:
                    px.Image = Properties.Resources._2;
                    break;
                case 3:
                    px.Image = Properties.Resources._3;
                    break;
                case 4:
                    px.Image = Properties.Resources._4;
                    break;
                case 5:
                    px.Image = Properties.Resources._5;
                    break;
                case 6:
                    px.Image = Properties.Resources._6;
                    break;
            }
            px.SizeMode = PictureBoxSizeMode.StretchImage;
            return dice;
        }
        public static int move(ref int x, ref int y, PictureBox px, int dice, int p, Label l)
        {
            if (dice + p > 100)
            {
                l.Text = "Can't move!";
                l.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                for (int i = 0; i < dice; i++)
                {

                    if (p == 10)
                    {
                        x = 26;
                        y = 420;
                        p++;
                    }
                    else if (p == 30)
                    {
                        x = 24;
                        y = 318;
                        p++;
                    }
                    else if (p == 40)
                    {
                        x = 27;
                        y = 268;
                        p++;
                    }
                    else if (p == 50)
                    {
                        x = 23;
                        y = 217;
                        p++;
                    }
                    else if (p == 60)
                    {
                        x = 22;
                        y = 165;
                        p++;
                    }
                    else if (p == 70)
                    {
                        x = 21;
                        y = 115;
                        p++;
                    }
                    else if (p == 80)
                    {
                        x = 23;
                        y = 68;
                        p++;
                    }
                    else if (p == 90)
                    {
                        x = 24;
                        y = 11;
                        p++;
                    }
                    else if (p == 3)
                    {
                        x = 24;
                        y = 218;
                        p = 51;
                    }
                    else if (p == 6)
                    {
                        x = 515;
                        y = 371;
                        p = 27;
                    }
                    else if (p == 20)
                    {
                        x = 762;
                        y = 165;
                        p = 70;
                    }
                    else if (p == 36)
                    {
                        x = 352;
                        y = 216;
                        p = 55;
                    }
                    else if (p == 63)
                    {
                        x = 351;
                        y = 11;
                        p = 95;
                    }
                    else if (p == 68)
                    {
                        x = 36;
                        y = 31;
                        p = 98;
                    }
                    else
                    {
                        x += 79;

                    }

                    px.Location = new Point(x, y);
                    p++;
                }

            }
            return p;
        }
        public static int snake(ref int x, ref int y, int p, PictureBox px)
        {
            if (p == 25)
            {
                x = 350;
                y = 471;
                p = 5;
                px.Location = new Point(x, y);
            }
            else if (p == 34)
            {
                x = 24;
                y = 471;
                p = 1;
                px.Location = new Point(x, y);
            }
            else if (p == 47)
            {
                x = 674;
                y = 427;
                p = 19;
                px.Location = new Point(x, y);
            }
            else if (p == 65)
            {
                x = 104;
                y = 216;
                p = 52;
                px.Location = new Point(x, y);
            }
            else if (p == 87)
            {
                x = 515;
                y = 217;
                p = 57;
                px.Location = new Point(x, y);
            }
            else if (p == 91)
            {
                x = 23;
                y = 165;
                p = 61;
                px.Location = new Point(x, y);
            }
            else if (p == 99)
            {
                x = 675;
                y = 165;
                p = 69;
                px.Location = new Point(x, y);
            }
            return p;
        }

    }
}
