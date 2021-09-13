using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP91906
{
    public partial class Form1 : Form
    {
        int velocity = 0;
        int acceleration = 1;

        int timer = 3;
        readonly int treeSpeed = 4;
        int score = 0;
        readonly int gap = 200;

        public Form1()
        {
            InitializeComponent();     
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            pinecone.Top += velocity;
            velocity += acceleration;

            if (pinecone.Bounds.IntersectsWith(treeBottom.Bounds) ||
                pinecone.Bounds.IntersectsWith(treeTop.Bounds) ||
                pinecone.Bounds.IntersectsWith(treeBottom2.Bounds) ||
                pinecone.Bounds.IntersectsWith(treeTop2.Bounds) ||
                pinecone.Top < 0 ||
                pinecone.Top + pinecone.Height > ClientSize.Height)
            {
                EndGame();
            }
        }
        private void treeTimerEvent(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();

            treeBottom.Left -= treeSpeed;
            treeTop.Left -= treeSpeed;

            treeBottom2.Left -= treeSpeed;
            treeTop2.Left -= treeSpeed;

            if (treeTop.Left <= -70)
            {
                treeTop.Left = 977;
                treeTop.Top = rnd.Next(-400, 0);
                score++;
            }
            if (treeTop2.Left <= -70)
            {
                treeTop2.Left = 977;
                treeTop2.Top = rnd2.Next(-400, 0);
                score++;
            }
            if (treeBottom.Left <= -70)
            {
                treeBottom.Left = 977;
                treeBottom.Top = treeTop.Top + treeTop.Height + gap;
            }
            if (treeBottom2.Left <= -70)
            {
                treeBottom2.Left = 977;
                treeBottom2.Top = treeTop2.Top + treeTop2.Height + gap;
            }
        }
        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (pinecone.Top > 0 || pinecone.Top + pinecone.Height == ClientSize.Height)
            {
                if (e.KeyCode == Keys.Space)
                {
                    velocity = -12;
                }
            }           
        }
        public void ShowMenu()
        {
            pinecone.Visible = false;
            treeTop.Visible = false;
            treeTop2.Visible = false;
            treeBottom.Visible = false;
            treeBottom2.Visible = false;

            title.Visible = true;
            panel.Visible = true;
            panelShadow.Visible = true;
            scoreTxt.Visible = true;
            RestartBtn.Visible = true;
            RestartBtn.BringToFront();
            ExitBtn.Visible = true;
            ExitBtn.BringToFront();

            label1.Text = score.ToString();
        }
        public void HideMenu()
        {
            pinecone.Visible = true;
            treeTop.Visible = true;
            treeTop2.Visible = true;
            treeBottom.Visible = true;
            treeBottom2.Visible = true;

            treeTop.Left = treeBottom.Left = 449;
            treeTop2.Left = treeBottom2.Left = 949;
            treeTop.Top = -236;
            treeTop2.Top = -280;
            treeBottom.Top = treeTop.Top + treeTop.Height + gap;
            treeBottom2.Top = treeTop2.Top + treeTop2.Height + gap;

            title.Visible = false;
            panel.Visible = false;
            panelShadow.Visible = false;
            scoreTxt.Visible = false;
            RestartBtn.Visible = false;
            ExitBtn.Visible = false;

            

            velocity = 0;
            acceleration = 1;
       
            pinecone.Top = ClientSize.Height / 2;


            this.Focus();
            gameTimer.Start();
            treeTimer.Start();
        }
        private void EndGame()
        {
            gameTimer.Stop();
            treeTimer.Stop();
            
            velocity = 0;
            acceleration = 0;
      
            ShowMenu();
        }
        public void RestartBtn_Click(object sender, System.EventArgs e)
        {
            HideMenu();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Countdown_Tick(object sender, EventArgs e)
        {
            timer--;
            label2.Text = timer.ToString();
        }
    }
}
