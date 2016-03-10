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
                obstacles[i, 0].Left -= 5;
                obstacles[i, 1].Left -= 5;
                if (obstacles[i,0].Left < 0)
                {

                    obstacles[i, 0].Location = new System.Drawing.Point(800, 70 + rnd.Next(0, 200));
                    obstacles[i, 1].Location = new System.Drawing.Point(800, 70 + rnd.Next(0, 200));
                }
            }
        }

        private void CreateObstacles(int numberOfObstacles)
        {
            for(int i = 0; i < numberOfObstacles; i++)
            {

                var currentTopObstacle = new PictureBox();
                var currentBottomObstacle = new PictureBox();

                this.Controls.Add(currentBottomObstacle);
                this.Controls.Add(currentTopObstacle);

                currentBottomObstacle.BackColor = System.Drawing.Color.Transparent;
                currentBottomObstacle.BackgroundImage = global::FlappyCow.Properties.Resources.milkBottom;
                currentBottomObstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                currentBottomObstacle.Location = new System.Drawing.Point(i*300+400, 70 + rnd.Next(0,200));
                currentBottomObstacle.Size = new System.Drawing.Size(65, 200);
          
                obstacles[i,0] = currentBottomObstacle;
                obstacles[i,0].Visible = true;

                currentTopObstacle = currentBottomObstacle;
                currentTopObstacle.BackgroundImage = global::FlappyCow.Properties.Resources.milkTop;
                currentTopObstacle.Top += 70;
                obstacles[i, 1] = currentTopObstacle;
                
                obstacles[i, 1].Visible = true;
            }
        }
    }
}
