using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fighter_Plane
{
    public partial class Form1 : Form
    {
        bool goUp, goDown, shot, gameOver;
        int score = 0;
        int speed = 8;
        int UFOspeed = 10;

        Random rand = new Random();

        int playerSpeed = 7;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            textScore.Text = "Score :" + score;

            if (goUp == true && Player.Top > 0)
            {
                Player.Top -= playerSpeed;
            }

            if (goDown == true && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += playerSpeed;
            }
            ufo.Left -= UFOspeed;

            if (ufo.Left + ufo.Width < 0)
            {
                ChangeUFO();
            }

            foreach (Control x in this.Controls)

                {
                if (x is PictureBox && (string)x.Tag == "Pillar")

                {
                    x.Left -= speed;
                    if(x.Left < -200)
                    {
                        x.Left = 1000;
                    }

                    if(Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver();
                    }

                }

                if(x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;
                    if(x.Left > 900)
                    {
                        RemoveBullet(((PictureBox)x));
                    }

                    if(ufo.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveBullet(((PictureBox)x));
                        score += 1;
                        ChangeUFO();
                    }
                }
            }
            if (Player.Bounds.IntersectsWith(ufo.Bounds))
            {
                GameOver();
            }
            if(score > 10)
            {
                speed = 12;
                UFOspeed = 18;
            }
                
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Space && shot == false)
            {
                MakeBullet();
                shot = true;
            }

        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (shot == true)
            {
                shot = false;
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
        private void RestartGame()
        {
            goUp = false;
            goDown = false;
            shot = false;
            gameOver = false;
            score = 0;
            speed = 0;
            UFOspeed = 11;


            textScore.Text = "Score :" + score;

            ChangeUFO();

            Player.Top = 101;
            Pillar1.Left = 790;
            Pillar2.Left = 302;
            Pillar3.Left = 1100;

            GameTimer.Start();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameOver()
        {
            GameTimer.Stop();
            textScore.Text = "score :     " + score + "Ohh Game Over! Press Enter to Ready Again";
            gameOver = true;
        }

        private void ufo_Click(object sender, EventArgs e)
        {

        }

        private void textScore_Click(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void Pillar1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();

        }


        private void MakeBullet()
        {
            {
                PictureBox bullet = new PictureBox();
                bullet.BackColor = System.Drawing.Color.DarkOrange;
                bullet.Height = 5;
                bullet.Width = 10;

                bullet.Left = Player.Left + Player.Width;
                bullet.Top = Player.Top + Player.Height / 2;

                bullet.Tag = "bullet";

                this.Controls.Add(bullet);

            }
        }         
          private void ChangeUFO()
            {
                if (index > 3)
                {
                    index = 1;
                }

                switch (index)
                {
                    case 1:
                        ufo.Image = Properties.Resources.alien_1;
                        break;

                    case 2:
                        ufo.Image = Properties.Resources.alien_2;
                        break;

                    case 3:
                        ufo.Image = Properties.Resources.alien_3;
                        break;
                   


            }
                ufo.Left = 1000;

                ufo.Top = rand.Next(20, this.ClientSize.Height - ufo.Height);
          }      
        


       
    }
}

