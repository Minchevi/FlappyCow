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
        public int gravity = 1;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }

        private void Game_KeyDown(object sender, KeyPressEventArgs e)
        {
            speed -= 15;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            speed += gravity;
            //cow.Location.Y += speed;

        }
    }
}
