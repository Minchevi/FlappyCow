using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyCow
{
    public partial class Game : Form
    {

        private int fallingSpeed;
        private int gravity;
        private int points;
        private int bestPoints;
        private double obstaclesSpeed;
        private PictureBox[,] obstacles = new PictureBox[3,2];
        private bool isAlive;
        Random rnd = new Random();

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            bestPoints = 0;
            bestResult.Text = "Best: 0";
            CreateObstacles(3);
            GameStart();
        }

        private void Game_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && isAlive)
            {
                e.SuppressKeyPress = true;
                fallingSpeed = -12;
                (new System.Media.SoundPlayer(global::FlappyCow.Properties.Resources.jump)).Play();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (cow.Location.Y < 0 || cow.Location.Y > this.Height)
                GameOver();
            fallingSpeed += gravity;
            cow.Location = new Point(cow.Location.X, cow.Location.Y + fallingSpeed);
            for (int i = 0; i < 3; i++)
            {
                if (cow.Bounds.IntersectsWith(obstacles[i, 0].Bounds)
                    || cow.Bounds.IntersectsWith(obstacles[i, 1].Bounds))
                    GameOver();
                 obstacles[i, 0].Left -= (int)obstaclesSpeed;
                obstacles[i, 1].Left -= (int)obstaclesSpeed;
                if (obstacles[i,0].Left < 0)
                {
                    (new System.Media.SoundPlayer(global::FlappyCow.Properties.Resources.point)).Play();
                    points++;
                    result.Text = "Points: " + points.ToString();
                    if (points > bestPoints)
                    {
                        bestPoints = points;
                        bestResult.Text = "Best: " + bestPoints.ToString();
                    }
                    obstaclesSpeed += 0.25;
                    var positionY = rnd.Next(0, 200);
                    obstacles[i, 0].Location = new System.Drawing.Point(800, positionY + 90);
                    obstacles[i, 1].Location = new System.Drawing.Point(800, positionY - 200);
                }
            }
        }

        private void GameOver()
        {
            isAlive = false;
            retryButton.Visible = true;
            retryButton.Enabled = true;
            timer.Stop();
            (new System.Media.SoundPlayer(global::FlappyCow.Properties.Resources.gameOver)).Play();
        }

        private void GameStart()
        {
            points = 0;
            result.Text = "Points: 0";
            cow.Location = new Point(50, 90);
            isAlive = true;
            fallingSpeed = 0;
            gravity = 2;
            obstaclesSpeed = 3.5;
            for(int i = 0; i < 3; i++)
            {
                var positionY = rnd.Next(0, 200);
                obstacles[i,0].Location = new System.Drawing.Point(i * 300 + 400, positionY + 90);
                obstacles[i,1].Location = new System.Drawing.Point(i * 300 + 400, positionY - 200);

            }
            timer.Start();
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            retryButton.TabStop = false;
            retryButton.Visible = false;
            retryButton.Enabled = false;
            GameStart();

        }

        private void CreateObstacles(int numberOfObstacles)
        {

            this.cow.Location = new Point(cow.Location.X + 50, cow.Location.Y);
            for (int i = 0; i < numberOfObstacles; i++)
            {

                var topObstacle = new PictureBox();
                var bottomObstacle = new PictureBox();
                
                this.Controls.Add(bottomObstacle);
                this.Controls.Add(topObstacle);

                bottomObstacle.BackColor = System.Drawing.Color.Transparent;
                bottomObstacle.BackgroundImage = global::FlappyCow.Properties.Resources.milkBottom;
                bottomObstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                bottomObstacle.Size = new System.Drawing.Size(60, 200);
          
                obstacles[i,0] = bottomObstacle;
                obstacles[i,0].Visible = true;
                topObstacle.BackColor = System.Drawing.Color.Transparent;
                topObstacle.BackgroundImage = global::FlappyCow.Properties.Resources.milkTop;
                topObstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                topObstacle.Size = new System.Drawing.Size(60, 200);

                obstacles[i, 1] = topObstacle;
                obstacles[i, 1].Visible = true;
            }
        }
        
    }
}
