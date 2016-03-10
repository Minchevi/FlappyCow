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

        private int speed = 0;
        private int gravity = 2;
        private PictureBox[,] obstacles = new PictureBox[3,2];
        Random rnd = new Random();

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            CreateObstacles(3);
        }

        private void Game_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                speed = -15;
                (new System.Media.SoundPlayer(global::FlappyCow.Properties.Resources.jump)).Play();
            }
            if(e.KeyCode == Keys.H)
            {

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            speed += gravity;
            cow.Location = new Point(cow.Location.X, cow.Location.Y + speed);
            for(int i = 0; i <= 2; i++)
            {
                obstacles[i, 0].Left -= 4;
                obstacles[i, 1].Left -= 4;
                if (obstacles[i,0].Left < 0)
                {
                    var positionY = rnd.Next(0, 200);
                    obstacles[i, 0].Location = new System.Drawing.Point(800, positionY + 70);
                    obstacles[i, 1].Location = new System.Drawing.Point(800, positionY - 200);
                }
            }
        }

        private void CreateObstacles(int numberOfObstacles)
        {
            for(int i = 0; i < numberOfObstacles; i++)
            {

                var topObstacle = new PictureBox();
                var bottomObstacle = new PictureBox();
                var positionY = rnd.Next(0, 200);

                this.Controls.Add(bottomObstacle);
                this.Controls.Add(topObstacle);

                bottomObstacle.BackColor = System.Drawing.Color.Transparent;
                bottomObstacle.BackgroundImage = global::FlappyCow.Properties.Resources.milkBottom;
                bottomObstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                bottomObstacle.Location = new System.Drawing.Point(i*300+400, positionY+70);
                bottomObstacle.Size = new System.Drawing.Size(60, 200);
          
                obstacles[i,0] = bottomObstacle;
                obstacles[i,0].Visible = true;

                topObstacle.BackColor = System.Drawing.Color.Transparent;
                topObstacle.BackgroundImage = global::FlappyCow.Properties.Resources.milkTop;
                topObstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                topObstacle.Location = new System.Drawing.Point(i * 300 + 400, positionY - 200);
                topObstacle.Size = new System.Drawing.Size(60, 200);

                obstacles[i, 1] = topObstacle;
                obstacles[i, 1].Visible = true;
            }
        }

        private void points_Click(object sender, EventArgs e)
        {

        }
    }
}
