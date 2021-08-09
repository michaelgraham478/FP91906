﻿using System;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            pinecone.Top += gravity;
            if (pinecone.Bounds.IntersectsWith(treeBottom.Bounds) ||
                pinecone.Bounds.IntersectsWith(treeTop.Bounds) ||
                pinecone.Bounds.IntersectsWith(grass.Bounds) || pinecone.Top < -25)
            {
                endGame();
            }
        }
        private void treeTimerEvent(object sender, EventArgs e)
        {
            treeBottom.Left -= treeSpeed;
            treeTop.Left -= treeSpeed;


            textScore.Text = "Score: " + score;
            if (treeBottom.Left <= -182)
            {
                treeBottom.Left = 810;
            }
            if (treeTop.Left <= -182)
            {
                treeTop.Left = 810;
                score++;
            }
            if (score % 2 == 0 && !(score == 0))
            {
                treeSpeed = treeSpeed + 25/100;
            }
        }
        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }
        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
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
