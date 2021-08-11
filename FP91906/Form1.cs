using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP91906
{
    public partial class Form1 : Form
    {
        int treeSpeed = 4;
        int gravity = 10;
        int score = 0;
        int gap = 200;

        public Form1()
        {
            InitializeComponent();
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            pinecone.Top += gravity;
            textScore.Text = score.ToString();

            if (pinecone.Bounds.IntersectsWith(treeBottom.Bounds) ||
                pinecone.Bounds.IntersectsWith(treeTop.Bounds) ||
                pinecone.Top < -25 ||
                pinecone.Top + pinecone.Height > ClientSize.Height + 20)
            {
                endGame();
            }
        }
        private void treeTimerEvent(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            treeBottom.Left -= treeSpeed;
            treeTop.Left -= treeSpeed;
            textScore.Text = "Score: " + score;
            if (treeTop.Left <= -182)
            {
                treeTop.Left = 810;
                treeTop.Top = rnd.Next(-453, -3);
                score++;
            }
            if (treeBottom.Left <= -182)
            {
                treeBottom.Left = 810;
                treeBottom.Top = treeTop.Top + treeTop.Height + gap;
            }
            //if (score % 2 == 0 && !(score == 0))
            //{
                //gap = gap - 10;
            //}
        }
        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
            if (e.KeyCode == Keys.C)
            {
                gravity = 0;
                pinecone.Top = treeTop.Top + treeTop.Height + 40;
            }
        }
        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
            if (e.KeyCode == Keys.C)
            {
                gravity = 10;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            treeTimer.Stop();
            textScore.Text += "\nGame over";
        }
    }
}
