using System;
using System.Windows.Forms;

namespace Platform_Game
{
    public partial class Form1 : Form
    {
        bool goLeft, goRigth, jump, isGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
      
        int playerSpeed = 6;

        int horizontSpeed = 3;
        int verticalSpeed = 3;

        int enemyOneSpeed = 2;
        int enemyTwoSpeed = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Colecte all the coins!\n" + "Score: "  + score;
            
            Player.Top += jumpSpeed;

            if(goLeft == true)
            {
                Player.Left -= playerSpeed;
            }
            if(goRigth == true)
            {
                Player.Left += playerSpeed;
            }

            if(jump == true && force < 0)
            {
                jump = false;
            }
            if(jump == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "Platform")
                    {
                        if(Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            Player.Top = x.Top - Player.Height;

                            if ((string)x.Name == "HorizontalPlatform1" && goLeft == false
                                || (string)x.Name == "HorizontalPlatform1" && goRigth == false)
                            {
                                Player.Left -= horizontSpeed;
                            }

                            if ((string)x.Name == "HorizontalPlatform2" && goLeft == false
                                || (string)x.Name == "HorizontalPlatform2" && goRigth == false)
                            {
                                Player.Left += horizontSpeed;
                            }


                        }

                        x.BringToFront();
                    }

                    if((string)x.Tag == "coin")
                    {
                        if(Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }
                    if((string)x.Tag == "enemy")
                    {
                        if(Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameTimer.Stop();
                            isGameOver = true;
                            txtScore2.Text = Environment.NewLine
                    + "Game Over !\n"
                    + "You were kiled !";
                        }
                    }

                }
                
            }

            if(Player.Top + Player.Height > this.ClientSize.Height + 50)
            {
                GameTimer.Stop();
                isGameOver = true;
                txtScore2.Text = Environment.NewLine 
                    + "Game Over !\n"
                    + "You fell and died !";
                
            }

            if(Player.Bounds.IntersectsWith(Door.Bounds) && score == 39)
            {
                GameTimer.Stop();
                isGameOver = true;
                
            }
            
            HorizontalPlatform1.Left -= horizontSpeed;
            if(HorizontalPlatform1.Left < 32 || HorizontalPlatform1.Left > 400)
            {
                horizontSpeed = -horizontSpeed;
            }

            HorizontalPlatform2.Left += horizontSpeed;
            if (HorizontalPlatform1.Left < 42 || HorizontalPlatform2.Left > 400)
            {
                horizontSpeed = -horizontSpeed;
            }

            VerticalPlatform.Top += verticalSpeed;
            if(VerticalPlatform.Top > 400 || VerticalPlatform.Top < 180)
            {
                verticalSpeed = - verticalSpeed;
            }

            Enemy1.Left += enemyOneSpeed;
            if(Enemy1.Left < pictureBox2.Left || Enemy1.Left + Enemy1.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            Enemy2.Left -= enemyTwoSpeed;
            if (Enemy2.Left < pictureBox4.Left || Enemy2.Left + Enemy2.Width > pictureBox4.Left + pictureBox4.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            Enemy3.Left += enemyOneSpeed;
            if (Enemy3.Left < pictureBox5.Left || Enemy3.Left + Enemy3.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            Enemy4.Left -= enemyTwoSpeed;
            if (Enemy4.Left < pictureBox6.Left || Enemy4.Left + Enemy4.Width > pictureBox6.Left + pictureBox6.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            

        }

          private void KeyIsDown(object sender, KeyEventArgs e)
          {
                if(e.KeyCode == Keys.Left)
                {
                    goLeft = true;
                }
                if(e.KeyCode == Keys.Right)
                {
                    goRigth = true;
                }
                if(e.KeyCode == Keys.Space && jump == false)
                {
                    jump = true;
                }
                
          }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRigth = false;
            }
            if(jump == true)
            {
                jump = false;
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                
                RestartGame();
                
            }

        }
        

        private void RestartGame()
        {
           
            jump = false;
            goLeft = false;
            goRigth = false;
            isGameOver = false;
            score = 0;

            txtScore.Text = "Score: " + score;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;

                }
            }

            /*reset pozition of platforms and enemys*/
            Player.Left = 44;
            Player.Top = 628;

            Enemy1.Left = 498;
            Enemy1.Top = 547;

            Enemy2.Left = 135;
            Enemy2.Top = 390;

            Enemy3.Left = 565;
            Enemy3.Top = 310;

            Enemy4.Left = 1011;
            Enemy4.Top = 184;

            HorizontalPlatform1.Left = 260;
            HorizontalPlatform1.Top = 512;

            HorizontalPlatform2.Left = 545;
            HorizontalPlatform2.Top = 167;

            VerticalPlatform.Left = 757;
            VerticalPlatform.Top = 485;

            
            GameTimer.Start();

        }
    }
}
