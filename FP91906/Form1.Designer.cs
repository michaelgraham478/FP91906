
namespace FP91906
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeTop = new System.Windows.Forms.PictureBox();
            this.treeBottom = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pinecone = new System.Windows.Forms.PictureBox();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.treeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinecone)).BeginInit();
            this.SuspendLayout();
            // 
            // treeTop
            // 
            this.treeTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeTop.BackgroundImage")));
            this.treeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeTop.Location = new System.Drawing.Point(472, -2);
            this.treeTop.Name = "treeTop";
            this.treeTop.Size = new System.Drawing.Size(181, 246);
            this.treeTop.TabIndex = 0;
            this.treeTop.TabStop = false;
            // 
            // treeBottom
            // 
            this.treeBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeBottom.BackgroundImage")));
            this.treeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeBottom.Location = new System.Drawing.Point(472, 436);
            this.treeBottom.Name = "treeBottom";
            this.treeBottom.Size = new System.Drawing.Size(181, 246);
            this.treeBottom.TabIndex = 1;
            this.treeBottom.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 658);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(720, 200);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pinecone
            // 
            this.pinecone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pinecone.BackgroundImage")));
            this.pinecone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pinecone.Location = new System.Drawing.Point(118, 306);
            this.pinecone.Name = "pinecone";
            this.pinecone.Size = new System.Drawing.Size(72, 80);
            this.pinecone.TabIndex = 3;
            this.pinecone.TabStop = false;
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.BackColor = System.Drawing.Color.Transparent;
            this.textScore.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textScore.Location = new System.Drawing.Point(12, 257);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(46, 19);
            this.textScore.TabIndex = 4;
            this.textScore.Text = "Score:";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // treeTimer
            // 
            this.treeTimer.Enabled = true;
            this.treeTimer.Interval = 5;
            this.treeTimer.Tick += new System.EventHandler(this.treeTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(702, 752);
            this.Controls.Add(this.pinecone);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.treeTop);
            this.Controls.Add(this.treeBottom);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.treeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinecone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox treeTop;
        private System.Windows.Forms.PictureBox treeBottom;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pinecone;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer treeTimer;
    }
}

