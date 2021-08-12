using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PongGame
{
    /*
     *  Full code idea from https://www.codeproject.com/Articles/5250284/Small-WinForm-Pong-Game-Csharp 
     *  this is the code that change a few things to make it run
     *  
     *  
     *  
     *  
     *  
     *  
     *  
     */
    public partial class Form1 : Form
    {
        int speed = 10;
        const int limit_Pad = 255;
        const int limit_Ball = 347;

        int computer_won = 0;
        int player_won = 0;

        int speed_Top;
        int speed_Left;

        bool up = false;
        bool down = false;
        bool game = false;
        Timer timer1 = new Timer();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPlayer.Focus();
        }

        private void btnPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (game)
            {
                if(e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    up = true;
                }
                else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    down = true;
                }
                timer1.Start();
            }
        }

        private void btnPlayer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                up = false;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                down = false;
            }
            timer1.Stop();
        }

        private void btnPlayer_Move(object sender, EventArgs e)
        {
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartValues();
            game = true;
            btnStart.Visible = false;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            btnStart.Enabled = false;
        }
        private void StartValues()
        {
            speed_Top = 0;
            speed_Left = -5;
        }
        private void BallMoves()
        {
            btnBall.Top += speed_Top+ speed;
            btnBall.Left += speed_Left+ speed;
        }
        private void HitBorder()
        {
            if ( btnBall.Location.Y >= limit_Ball)
            {
                speed_Top += -speed;
            }
           else if (btnBall.Location.Y <= 0 )
            {
                speed_Top *= -1;
            }
        }
        private void NewPoint(int n)
        {
            const int x = 227, y = 120;
            btnBall.Location = new Point(x, y);
            speed_Top = 0;
            speed_Left = n;
        }
        private void btnPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (up && btnPlayer.Location.Y > 0)
            {
                btnPlayer.Top -= speed;
            }
            else if (down && btnPlayer.Location.Y < limit_Pad)
            {
                btnPlayer.Top += speed;
            }
        }

        private bool Upper(Button Pad)
        {
            return btnBall.Location.Y >= Pad.Top - btnBall.Height && btnBall.Location.Y <= Pad.Top + btnBall.Height;
        }
        private bool High(Button Pad)
        {
            return btnBall.Location.Y > Pad.Top + btnBall.Height && btnBall.Location.Y <= Pad.Top + 2 * btnBall.Height;
        }
        private bool Middle(Button Pad)
        {
            return btnBall.Location.Y > Pad.Top + 2 * btnBall.Height && btnBall.Location.Y <= Pad.Top + 3 * btnBall.Height;
        }
        private bool Low(Button Pad)
        {
            return btnBall.Location.Y > Pad.Top + 3 * btnBall.Height && btnBall.Location.Y <= Pad.Top + 4 * btnBall.Height;
        }
        private bool Bot(Button Pad)
        {
            return btnBall.Location.Y > Pad.Top + 4 * btnBall.Height && btnBall.Location.Y <= Pad.Bottom + btnBall.Height;
        }
        private int Negative(int i, int n)
        {
            int myval = r.Next(i, n) * -1;
            return myval;
        }

        private int AdjustCoordinates(int i, int n)
        {
            int res = 0;

            if (btnBall.Location.X < this.Width / 2)
            {
                res = r.Next(i, n);
            }
            else if (btnBall.Location.X > this.Width / 2)
            {
                res = Negative(i, n);
            }
            return res;
        }
        private void Edge()
        {
            if (btnBall.Location.X < this.Width / 2)
            {
                if (btnBall.Location.X < 0 + btnBall.Height / 3)
                {
                    speed_Left *= -1;
                }
            }
            else if (btnBall.Location.X > this.Width / 2)
            {
                if (btnBall.Location.X > btnComputer.Location.X + (btnBall.Width / 3))
                {
                    speed_Left *= -1;
                }
            }
        }
        private void Collision(Button Paddle)
        {
            switch (true)
            {
                case true when Upper(Paddle):
                    speed_Top = Negative(4+ speed, 6 + speed);
                    speed_Left = AdjustCoordinates(5 + speed, 6 + speed);
                    break;
                case true when High(Paddle):
                    speed_Top = Negative(2 + speed, 3 + speed);
                    speed_Left = AdjustCoordinates(6 + speed, 7 + speed);
                    break;
                case true when Middle(Paddle):
                    speed_Top = 0;
                    speed_Left = AdjustCoordinates(5 + speed, 5 + speed);
                    break;
                case true when Low(Paddle):
                    speed_Top = r.Next(2 + speed, 3 + speed);
                    speed_Left = AdjustCoordinates(6 + speed, 7 + speed);
                    break;
                case true when Bot(Paddle):
                    speed_Top = r.Next(4 + speed, 6 + speed);
                    speed_Left = AdjustCoordinates(5 + speed, 6 + speed);
                    break;
            }
            Edge();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (btnComputer.Location.Y <= 0)
            {
                btnComputer.Location = new Point(btnComputer.Location.X, 0);
            }
            else if (btnComputer.Location.Y >= limit_Pad)
            {
                btnComputer.Location = new Point(btnComputer.Location.X, limit_Pad);
            }

            if (btnBall.Location.Y < btnComputer.Top + (btnComputer.Height / 2))
            {
                btnComputer.Top -= speed;
            }
            else if (btnBall.Location.Y > btnComputer.Top + (btnComputer.Height / 2))
            {
                btnComputer.Top +=speed;
            }
        }
        private void PlayerWon()
        {
            player_won++;
            label1.Text = player_won.ToString();
        }
        private void ComputerWon()
        {
            computer_won++;
            label3.Text = computer_won.ToString();
        }

        private void EndGame()
        {
            btnPlayer.Location = new Point(0, 75);
            btnComputer.Location = new Point(454, 75);
            player_won = 0;
            computer_won = 0;
            label1.Text = player_won.ToString();
            label3.Text = computer_won.ToString();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            btnStart.Visible = true;
            game = false;
        }
        private void BallLeftField() // Slightly different from the project code:
        {
            if (player_won == 10 || computer_won == 10)
            {

                EndGame();
            }

            if (btnBall.Location.X < 0)
            {
                NewPoint(5);
                ComputerWon();
            }
            else if (btnBall.Location.X > this.ClientSize.Width)
            {
                NewPoint(-5);
                PlayerWon();
            }
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            if (btnBall.Bounds.IntersectsWith(btnPlayer.Bounds))
            {
                Collision(btnPlayer);
            }
            else if (btnBall.Bounds.IntersectsWith(btnComputer.Bounds))
            {
                Collision(btnComputer);
            }
         
            HitBorder();
            BallLeftField();
            BallMoves();
        }
        int click = 7;
        private void timer4_Tick(object sender, EventArgs e)
        {
            click--;
            if(click == 0)
            {
                label4.Text = "";
            }
        }
    }
}
