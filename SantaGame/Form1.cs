using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaGame
{
    public partial class Form1 : Form
    {

        int gravity = 10;
        int objSpeed = 6;
        double score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            santaClaus.Top += gravity;
            pineTree1.Left -= objSpeed;
            pineTree2.Left -= objSpeed;
            snowFlake1.Left -= objSpeed;
            snowFlake2.Left -= objSpeed;
            santaHut.Left -= objSpeed;
            score += 0.25;
            if ((score % 1) == 0)
            {
                scoreLabel.Text = $"score: {score}";
            }
            //scoreLabel.Text = $"score: {score}";

            if (pineTree1.Left < -100)
            {
                pineTree1.Left = 900;
            }
            if(pineTree2.Left < -100)
            {
                pineTree2.Left = 945;
            }
            if(snowFlake1.Left < -100)
            {
                snowFlake1.Left = 910;
            }
            if (snowFlake2.Left < -100)
            {
                snowFlake2.Left = 965;
            }

            if(santaClaus.Top < -25)
            {
                gameOver();
            }

            if (santaClaus.Bounds.IntersectsWith(pineTree1.Bounds) || santaClaus.Bounds.IntersectsWith(pineTree2.Bounds) || santaClaus.Bounds.IntersectsWith(snowFlake1.Bounds) || santaClaus.Bounds.IntersectsWith(snowFlake2.Bounds) || santaClaus.Bounds.IntersectsWith(snowyGround.Bounds))
            {
                gameOver();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -6;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void santaClaus_Click(object sender, EventArgs e)
        {

        }

        private void santaHut_Click(object sender, EventArgs e)
        {

        }

        private void pineTree1_Click(object sender, EventArgs e)
        {

        }

        private void pineTree2_Click(object sender, EventArgs e)
        {

        }

        private void snowFlake1_Click(object sender, EventArgs e)
        {

        }

        private void snowFlake2_Click(object sender, EventArgs e)
        {

        }

        private void skyMoon_Click(object sender, EventArgs e)
        {

        }

        private void gameOver()
        {
            timer1.Stop();
            scoreLabel.Text = $"Game over!";
            buttonRestart.Visible = true;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
