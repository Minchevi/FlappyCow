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

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            cow.BackColor = Color.Blue;
            if (e.KeyCode == Keys.Space)
            {
            speed -= 15;

            }
        }

        private void Game_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            cow.BackColor = Color.Blue;
            switch (e.KeyCode)
            {
                case Keys.Space:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            speed += gravity;
            //cow.Location = new Point(cow.Location.X, cow.Location.Y + speed);

            
        }
    }
}
