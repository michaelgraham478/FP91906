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

        int timerVal = 3;
        int logSpeed = 4;
        int score = 0;
        readonly int gap = 200;

        public Form1()
        {
            InitializeComponent();
            ShowStartMenu();

            GameTimer.Stop();
        }    
        private void GameTimerEvent(object sender, EventArgs e)
        {
            pinecone.Top += velocity;
            velocity += acceleration;

            if (pinecone.Bounds.IntersectsWith(logBottom.Bounds) ||
                pinecone.Bounds.IntersectsWith(logTop.Bounds) ||
                pinecone.Bounds.IntersectsWith(logBottom2.Bounds) ||
                pinecone.Bounds.IntersectsWith(logTop2.Bounds) ||
                pinecone.Top < 0 ||
                pinecone.Top + pinecone.Height > ClientSize.Height)
            {
                EndGame();
            }
        }
        private void TreeTimerEvent(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();

            logBottom.Left -= logSpeed;
            logTop.Left -= logSpeed;

            logBottom2.Left -= logSpeed;
            logTop2.Left -= logSpeed;

            if (logTop.Left <= -70)
            {
                logTop.Left = 977;
                logTop.Top = rnd.Next(-400, 0);
                score++;
            }
            if (logTop2.Left <= -70)
            {
                logTop2.Left = 977;
                logTop2.Top = rnd2.Next(-400, 0);
                score++;
            }
            if (logBottom.Left <= -70)
            {
                logBottom.Left = 977;
                logBottom.Top = logTop.Top + logTop.Height + gap;
            }
            if (logBottom2.Left <= -70)
            {
                logBottom2.Left = 977;
                logBottom2.Top = logTop2.Top + logTop2.Height + gap;
            }
        }
        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (pinecone.Top > 0 || pinecone.Top + pinecone.Height == ClientSize.Height)
            {
                if (e.KeyCode == Keys.Space)
                {
                    velocity = -12;
                }
            }           
        }
        public void ShowRestartMenu()
        {
            pinecone.Visible = false;
            logTop.Visible = false;
            logTop2.Visible = false;
            logBottom.Visible = false;
            logBottom2.Visible = false;

            title.Visible = true;
            panel.Visible = true;
            panelShadow.Visible = true;
            scoreTxt.Visible = true;
            RestartBtn.Visible = true;
            RestartBtn.BringToFront();
            ExitBtn.Visible = true;
            ExitBtn.BringToFront();
            StartBtn.Visible = false;
            ExitBtn2.Visible = false;
            label1.Visible = true;

            label1.Text = score.ToString();
        }
        public void HideRestartMenu()
        {
            pinecone.Visible = true;
            pinecone.BackColor = Color.Transparent;
            pinecone.Location = new Point(117, ClientSize.Height / 2);
            logTop.Visible = true;
            logTop2.Visible = true;
            logBottom.Visible = true;
            logBottom2.Visible = true;

            logTop.Left = logBottom.Left = 449;
            logTop2.Left = logBottom2.Left = 949;
            logTop.Top = -236;
            logTop2.Top = -280;
            logBottom.Top = logTop.Top + logTop.Height + gap;
            logBottom2.Top = logTop2.Top + logTop2.Height + gap;

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
            GameTimer.Start();
            TreeTimer.Start();
        }
        public void ShowStartMenu()
        {
            pinecone.Visible = true;
            pinecone.BringToFront();
            pinecone.BackColor = Color.White;
            pinecone.Location = new Point((ClientSize.Width/2) - (pinecone.Width/2), ((ClientSize.Height / 2) - (pinecone.Height / 2)) - 40);
            logTop.Visible = false;
            logTop2.Visible = false;
            logBottom.Visible = false;
            logBottom2.Visible = false;

            title.Visible = true;
            panel.Visible = true;
            panelShadow.Visible = true;
            label1.Visible = false;
            scoreTxt.Visible = false;
            StartBtn.Visible = true;
            ExitBtn2.Visible = true;

        }
        public void HideStartMenu()
        {
            GameTimer.Start();

            pinecone.Visible = true;
            pinecone.BackColor = Color.Transparent;
            pinecone.Location = new Point(117, ClientSize.Height / 2);
            logTop.Visible = true;
            logTop2.Visible = true;
            logBottom.Visible = true;
            logBottom2.Visible = true;

            logTop.Left = logBottom.Left = 449;
            logTop2.Left = logBottom2.Left = 949;
            logTop.Top = -236;
            logTop2.Top = -280;
            logBottom.Top = logTop.Top + logTop.Height + gap;
            logBottom2.Top = logTop2.Top + logTop2.Height + gap;

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
            GameTimer.Start();
            TreeTimer.Start();
        }
        private void EndGame()
        {
            GameTimer.Stop();
            TreeTimer.Stop();
            
            velocity = 0;
            acceleration = 0;

            ShowRestartMenu();
        }
        public void RestartBtn_Click(object sender, System.EventArgs e)
        {
            score = 0;
            HideRestartMenu();
        }
        public void StartBtn_Click(object sender, System.EventArgs e)
        {
            HideStartMenu();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            HideRestartMenu();
            ShowStartMenu();
            GameTimer.Stop();
        }
        private void ExitBtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
    }
}
