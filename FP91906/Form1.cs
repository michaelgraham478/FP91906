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

            if (pinecone.Bounds.IntersectsWith(treeBottom.Bounds) ||
                pinecone.Bounds.IntersectsWith(treeTop.Bounds) ||
                pinecone.Top < 0 ||
                pinecone.Top + pinecone.Height > ClientSize.Height)
            {
                EndGame();
            }
            textScore.Text = "" + score;
            textScore.Left = pinecone.Left + 25;
            textScore.Top = pinecone.Top - 34;           
        }
        private void treeTimerEvent(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            treeBottom.Left -= treeSpeed;
            treeTop.Left -= treeSpeed;

            //if () // decrease gap
            //{
                //-
            //}
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
                pinecone.Top = treeTop.Top + treeTop.Height + gap/2 - pinecone.Height/2;
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
                gravity = 0;
            }
        }
        private void EndGame()
        {
            gameTimer.Stop();
            treeTimer.Stop();
            pinecone.Visible = false;
            textScore.Visible = false;
            treeBottom.Visible = false;
            treeTop.Visible = false;
            textScore.Text += "\nGame over";

            Menu();
        }
        private void Menu()
        { 
            //Back Panel
            Panel panel = new Panel
            {
                Size = new System.Drawing.Size(531, 493),
                BackColor = Color.White,
                Location = new Point(89, 120),
            };
            ;
            this.Controls.Add(panel);

            //Shadow Panel
            Panel shadow = new Panel
            {
                Size = new System.Drawing.Size(531, 493),
                BackColor = Color.Gray,
                Location = new Point(84, 125),
            };
            ;
            this.Controls.Add(shadow);
            shadow.SendToBack();

            //Restart Button
            Button restartBtn = new Button 
            {
                Size = new System.Drawing.Size(115, 40),
                BackColor = Color.FromArgb(113,238,184),
                Location = new Point(panel.Location.X + 75, panel.Location.Y + 425),
                FlatStyle = FlatStyle.Flat,              
                Text = "Restart",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT Bold", 16)
            };
            ;
            restartBtn.FlatAppearance.BorderSize = 0;
            this.Controls.Add(restartBtn);
            restartBtn.BringToFront();

            //Exit Button
            Button exitBtn = new Button
            {
                Size = new System.Drawing.Size(115, 40),
                BackColor = Color.FromArgb(113, 238, 184),
                Location = new Point(panel.Location.X + 340, panel.Location.Y + 425),
                FlatStyle = FlatStyle.Flat,
                Text = "Exit",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT Bold", 16)
            };
            ;
            exitBtn.FlatAppearance.BorderSize = 0;
            this.Controls.Add(exitBtn);
            exitBtn.BringToFront();

            //Title Label
            Label title = new Label
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
            this.Controls.Add(title);
            title.BringToFront();

            //Score: Text
            Label scoreTxt = new Label
            {
                Size = new System.Drawing.Size(restartBtn.Size.Width, restartBtn.Size.Width),
                BackColor = Color.White,
                Location = new Point(restartBtn.Location.X, 270),
                Text = "Score:",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 15)
            };
            this.Controls.Add(scoreTxt);
            scoreTxt.BringToFront();

            //Score Text
            Label scoreNum = new Label
            {
                Size = new System.Drawing.Size(restartBtn.Size.Width, restartBtn.Size.Width),
                BackColor = Color.White,
                Location = new Point(restartBtn.Location.X, 350),
                Text = score.ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT Bold", 50)
            };
            ;      
            this.Controls.Add(scoreNum);
            scoreNum.BringToFront();
        }
        private void Restart()
        {

        }
    }
}
