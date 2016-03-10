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

        public int speed = 0;
        public int gravity = 2;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }

        private void Game_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                speed = -15;
                (new System.Media.SoundPlayer(global::FlappyCow.Properties.Resources.jump)).Play();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            speed += gravity;
            cow.Location = new Point(cow.Location.X, cow.Location.Y + speed);

        }
    }
}
