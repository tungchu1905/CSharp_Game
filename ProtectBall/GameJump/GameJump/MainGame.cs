using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameJump
{
    public partial class MainGame : Form
    {
        private bool game = false;
        private bool right = false;
        private bool left = false;
        private float limit_Pad = 450;
        private float max_Rball = 560;
        private float max_Dball = 300;
        int speed_Top;
        int speed_Left;
        private int time = 0;
        Random r = new Random();

        int x = 10;
        public MainGame()
        {
            InitializeComponent();
            game = true;
            time = 100;
            timer2.Start();
            timer3.Start();
        }

        private void btnPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (game)
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    right = true;
                }
                else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    left = true;
                }
                timer1.Start();
            }
        }

        private void btnPlayer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = false;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = false;
            }
            timer1.Stop();
        }

        private void btnPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (left && btnPlayer.Location.X > 0)
            {
                btnPlayer.Left -= x;
            }
            else if (right && btnPlayer.Location.X < limit_Pad)
            {
                btnPlayer.Left += x;
            }
        }

        private void NewPoint(int n)
        {
            const int x = 317, y = 110;
            btnBall.Location = new Point(x, y);
            speed_Top = 0;
            speed_Left = n;
        }
        private void BallLeftField() // Slightly different from the project code:
        {

            if (btnBall.Location.X < 0)
            {
                NewPoint(5);
            }
            else if (btnBall.Location.X > this.ClientSize.Width)
            {
                NewPoint(-5);
            }
        }

        private void BallMoves()
        {

            btnBall.Top += speed_Top +x;
            btnBall.Left += speed_Left + x;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            lblTime.Text = time--.ToString();
            if (time == 0)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Win", "You Win", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void HitBorder()
        {
            if ( btnBall.Location.Y >= max_Dball)
            {
                //speed_Top -= 10;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Lose", "You Lose", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (btnBall.Location.X <= 10 )
            {
                speed_Left *= -1;
               
                //timer3.Stop();

            }
            else if (btnBall.Location.Y <= 10 )
            {
                speed_Top *= -1;
            } else if ( btnBall.Location.X >= max_Rball)
            {
                speed_Left -= 20;
            }

        }


        private bool Upper(Button Player)
        {
            return btnBall.Location.Y >= Player.Top - btnBall.Height && btnBall.Location.Y <= Player.Top + btnBall.Height;
        }
        private bool High(Button Player)
        {
            return btnBall.Location.Y > Player.Top + btnBall.Height && btnBall.Location.Y <= Player.Top + 2 * btnBall.Height;
        }
        private bool Middle(Button Player)
        {
            return btnBall.Location.Y > Player.Top + 2 * btnBall.Height && btnBall.Location.Y <= Player.Top + 3 * btnBall.Height;
        }
        private bool Low(Button Player)
        {
            return btnBall.Location.Y > Player.Top + 3 * btnBall.Height && btnBall.Location.Y <= Player.Top + 4 * btnBall.Height;
        }
        private bool Bot(Button Player)
        {
            return btnBall.Location.Y > Player.Top + 4 * btnBall.Height && btnBall.Location.Y <= Player.Bottom + btnBall.Height;
        }
        private int Negative(int i, int n)
        {
            int myval = r.Next(i, n) * -1;
            return myval;
        }
        private int AdjustCoordinates(int i, int n)
        {
            int res = 0;

            if (btnBall.Location.X < this.Height / 2)
            {
                res = r.Next(i, n);
            }
            else if (btnBall.Location.X > this.Height / 2)
            {
                res = Negative(i, n);
            }
            return res;
        }
        //private void Edge()
        //{
        //    if (btnBall.Location.X < this.Width / 2)
        //    {
        //        if (btnBall.Location.X < 0 + btnBall.Height / 3)
        //        {
        //            speed_Left *= -1;
        //        }
        //    }
        //}
        private void Collision(Button Paddle)
        {
           
            switch (true)
            {
                case true when Upper(Paddle):
                    speed_Top = Negative(4+x, 6+x);
                    speed_Left = AdjustCoordinates(10+x,12+x );
                    break;
                case true when High(Paddle):
                    speed_Top = Negative(2 + x, 3 + x);
                    speed_Left = AdjustCoordinates(12 + x, 14 + x);
                    break;
                case true when Middle(Paddle):
                    speed_Top = 0;
                    speed_Left = AdjustCoordinates(10 + x, 10 + x);
                    break;
                case true when Low(Paddle):
                    speed_Top = r.Next(2 + x, 3 + x);
                    speed_Left = AdjustCoordinates(12 + x, 14 + x);
                    break;
                case true when Bot(Paddle):
                    speed_Top = r.Next(4 + x, 6 + x);
                    speed_Left = AdjustCoordinates(10 + x, 12 + x);
                    break;
            }
            //Edge();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (btnBall.Bounds.IntersectsWith(btnPlayer.Bounds))
            {
                Collision(btnPlayer);
            }
            HitBorder();
            BallLeftField();
            BallMoves();
        }

        private void btnPlayer_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnPlayer_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnPlayer_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
