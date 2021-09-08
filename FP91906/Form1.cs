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

        int treeSpeed = 4;
        int score = 0;
        int gap = 200;

        public Form1()
        {
            InitializeComponent();
            RestartBtn.Visible = false;
            ExitBtn.Visible = false;
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

            //if () // decrease gap
            //{
            //-
            //}

            if (treeTop.Left <= -70)
            {
                treeTop.Left = 977;
                treeTop.Top = rnd.Next(-453, 23);
                score++;
            }
            if (treeTop2.Left <= -70)
            {
                treeTop2.Left = 977;
                treeTop2.Top = rnd2.Next(-453, 23);
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
            if (e.KeyCode == Keys.Space)
            {
                velocity = -12;
            }
            if (e.KeyCode == Keys.C)
            {
                velocity = 0;
                pinecone.Top = treeTop.Top + treeTop.Height + gap/2 - pinecone.Height/2;
                if (treeTop2.Left < treeTop.Left)
                {
                    pinecone.Top = treeTop2.Top + treeTop2.Height + gap / 2 - pinecone.Height / 2;
                }
            }
        }
        //private void gameKeyIsUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Space)
        //    {
        //        velocity = 10;
        //    }
        //    if (e.KeyCode == Keys.C)
        //    {
        //        velocity = 0;
        //    }
        //}
        private void EndGame()
        {
            gameTimer.Stop();
            treeTimer.Stop();
            pinecone.Visible = false;
            treeTop.Visible = false;
            treeTop2.Visible = false;
            treeBottom.Visible = false;
            treeBottom2.Visible = false;

            RestartBtn.Visible = true;
            ExitBtn.Visible = true;

            Menu();
        }
        public void Menu()
        { 
            //Back Panel
            Panel panel = new Panel
            {
                Size = new System.Drawing.Size(531, 493),
                BackColor = Color.White,
                Location = new Point(209, 120),
            };
            ;
            this.Controls.Add(panel);

            //Shadow Panel
            Panel Shadow = new Panel
            {
                Size = new System.Drawing.Size(531, 493),
                BackColor = Color.Gray,
                Location = new Point(204, 125),
            };
            ;
            this.Controls.Add(Shadow);
            Shadow.SendToBack();

            //Title Label
            Label Title = new Label
            {
                Size = new System.Drawing.Size(531, 100),
                BackColor = Color.White,
                Location = new Point(panel.Location.X, panel.Location.Y + 25),
                BorderStyle = BorderStyle.None,
                Text = "Flappy Pinecone",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT Bold", 40)
            };
            ;
            this.Controls.Add(Title);
            Title.BringToFront();

            //Score: Text
            Label ScoreTxt = new Label
            {
                Size = new System.Drawing.Size(115, 115),
                BackColor = Color.White,
                Location = new Point(284, 270),
                Text = "Score:",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 15)
            };
            this.Controls.Add(ScoreTxt);
            ScoreTxt.BringToFront();

            //Score Text
            Label ScoreNum = new Label
            {
                Size = new System.Drawing.Size(115, 115),
                BackColor = Color.White,
                Location = new Point(284, 350),
                Text = score.ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT Bold", 50)
            };
            ;      
            this.Controls.Add(ScoreNum);
            ScoreNum.BringToFront();      
        }

        public void RestartBtn_Click(object sender, EventArgs e)
        {
            pinecone.Top = ClientSize.Height / 2;
            gameTimer.Start();
            treeTimer.Start();
            pinecone.Visible = true;
            treeTop.Visible = true;
            treeTop.Left = 449;
            treeTop2.Visible = true;
            treeTop2.Left = 449;
            treeBottom.Visible = true;
            treeBottom.Left = 929;
            treeBottom2.Visible = true;
            treeBottom2.Left = 929;
 
            RestartBtn.Visible = false;
            //this.Controls.Remove(panel);

        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
