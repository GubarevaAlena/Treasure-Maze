using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treasure
{
    public partial class Form1 : Form
    {
        bool goUp, goDown, goRight, goLeft, gameOver;
        int score = 0;
        int speed = 3;
        int points1 = 10; int points2 = 50;
        Random random = new Random();

        public Form1()
        {

            InitializeComponent();
            Init();
            MainTimer.Start();
        }

        public void Init()
        {
            this.Width = 500;
            this.Height = 500;
            
        }


        int timeleft = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft -= 1;
                Timer.Text = timeleft + " seconds";
            }
            else
            {
                gameOver = true;
            }

            score += points1;
            if (goLeft == true && mc.Left > 0)
            {
                mc.Left -= speed;
            }
            if (goRight == true && mc.Left + mc.Width < this.ClientSize.Width)
            {
                mc.Left += speed;
            }
            if (goUp == true && mc.Top > 0)
            {
                mc.Top -= speed;
            }
            if (goDown == true && mc.Top + mc.Height < this.ClientSize.Height)
            {
                mc.Top += speed;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Points.Text = score.ToString();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void NotPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
        }

        private void OnPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
        }

       

        private void SpawndChest()
        {

        }

        private void RestartGame()
        {

        }
    }
}
