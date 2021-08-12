using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameEatCoin
{
    public partial class Form1 : Form
    {
        bool isLeft, isRight, GameOver, Jump;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;
        int ho2 = 5;
        int enemySpeed = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void MaingameTime(object sender, EventArgs e)
        {
            Player.Top += jumpSpeed;
           if(isLeft == true)
            {
                Player.Left -= playerSpeed;

            }
           if(isRight == true)
            {
                Player.Left += playerSpeed;
            }
           if(Jump == true && force < 0)
            {
                Jump = false;
            }
            if (Jump == true)
            {
                jumpSpeed = -15;
                force -= 1;
            }
            else
            {
                jumpSpeed = 20;
            }
            foreach (Control control in this.Controls)
            {
                if(control is PictureBox)
                {
                    if ((string)control.Tag == "platForm") 
                    {
                        if (Player.Bounds.IntersectsWith(control.Bounds))
                        {
                            force = 15;
                            Player.Top = control.Top - Player.Height;
                        }
                        control.BringToFront();
                    }
                    if ((string)control.Tag == "coin")
                    {
                        if (Player.Bounds.IntersectsWith(control.Bounds))
                        {
                            control.Visible = false;
                        }
                    }
                    if ((string)control.Tag == "EndGame")
                    {
                        if (Player.Bounds.IntersectsWith(control.Bounds))
                        {
                            GameOver = true;
                            ReStart();
                        }
                    }
                    if ((string)control.Tag == "enemy")
                    {
                        if (Player.Bounds.IntersectsWith(control.Bounds))
                        {
                            GameOver = true;
                            ReStart();
                        }
                    }
                }
            }

            pictureBoxMove6.Top += verticalSpeed;
            if (pictureBoxMove6.Top < 60 || pictureBoxMove6.Top + pictureBoxMove6.Height > 362)
            {
                verticalSpeed = -verticalSpeed;
            }



            pictureBox11.Left -= horizontalSpeed;
            pictureBox12.Left -= horizontalSpeed;
            pictureBox13.Left -= horizontalSpeed;
            pictureBox14.Left -= horizontalSpeed;
            pictureBoxMove7.Left -= horizontalSpeed;
            if(pictureBoxMove7.Left< 80 || pictureBoxMove7.Left + pictureBoxMove7.Width > this.ClientSize.Width)
            {
                horizontalSpeed = - horizontalSpeed;
            }


           
            pictureBox7.Left -= ho2;
            pictureBox9.Left -= ho2;
            pictureBox10.Left -= ho2;
            pictureBoxMove2.Left -= ho2;
            //240 - 348
            if (pictureBoxMove2.Left < 240 || pictureBoxMove2.Left + pictureBoxMove2.Width > this.ClientSize.Width)
            {
                ho2 = -ho2;
            }


            EnemyTwo.Left += enemySpeed;
            if (EnemyTwo.Left < 131 || EnemyTwo.Left > 284)
            {
                enemySpeed = -enemySpeed;
            }
            // txtScore
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                isLeft = true;
            }
            if(e.KeyCode == Keys.D)
            {
                isRight = true;
            }
            if(e.KeyCode == Keys.Space && Jump == false)
            {
                Jump = true;
            }
        }
     

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                isLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                isRight = false;
            }
            if (Jump == true)
            {
                Jump = false;
            }
            if (e.KeyCode == Keys.Enter && GameOver == true)
            {
                ReStart();
            }
        } 
        private void ReStart()
        {
            //Jump = false;
            //isLeft = false;
            //isRight = false;
            //GameOver = false;
            //score = 0;

            //// 

            //foreach (Control control in this.Controls)
            //{
            //    if(control is PictureBox && control.Visible == false)
            //    {
            //        control.Visible = true;
            //    }
            //}

            //Player.Left = 67;
            //Player.Top = 433;

            //EnemyTwo.Left = 131;
            //EnemyTwo.Top = 204;
            Application.Restart();
            timer1.Start();
        }
    }
}
