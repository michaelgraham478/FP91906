
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
            this.pinecone = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.treeTimer = new System.Windows.Forms.Timer(this.components);
            this.treeTop2 = new System.Windows.Forms.PictureBox();
            this.treeBottom2 = new System.Windows.Forms.PictureBox();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Countdown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinecone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBottom2)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeTop
            // 
            this.treeTop.BackColor = System.Drawing.Color.Transparent;
            this.treeTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeTop.BackgroundImage")));
            this.treeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeTop.Location = new System.Drawing.Point(449, -236);
            this.treeTop.Name = "treeTop";
            this.treeTop.Size = new System.Drawing.Size(85, 462);
            this.treeTop.TabIndex = 0;
            this.treeTop.TabStop = false;
            // 
            // treeBottom
            // 
            this.treeBottom.BackColor = System.Drawing.Color.Transparent;
            this.treeBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeBottom.BackgroundImage")));
            this.treeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeBottom.Location = new System.Drawing.Point(449, 425);
            this.treeBottom.Name = "treeBottom";
            this.treeBottom.Size = new System.Drawing.Size(85, 501);
            this.treeBottom.TabIndex = 1;
            this.treeBottom.TabStop = false;
            // 
            // pinecone
            // 
            this.pinecone.BackColor = System.Drawing.Color.Transparent;
            this.pinecone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pinecone.BackgroundImage")));
            this.pinecone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pinecone.Location = new System.Drawing.Point(117, 305);
            this.pinecone.Name = "pinecone";
            this.pinecone.Size = new System.Drawing.Size(72, 80);
            this.pinecone.TabIndex = 3;
            this.pinecone.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 22;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // treeTimer
            // 
            this.treeTimer.Enabled = true;
            this.treeTimer.Interval = 15;
            this.treeTimer.Tick += new System.EventHandler(this.treeTimerEvent);
            // 
            // treeTop2
            // 
            this.treeTop2.BackColor = System.Drawing.Color.Transparent;
            this.treeTop2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeTop2.BackgroundImage")));
            this.treeTop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeTop2.Location = new System.Drawing.Point(926, -280);
            this.treeTop2.Name = "treeTop2";
            this.treeTop2.Size = new System.Drawing.Size(85, 462);
            this.treeTop2.TabIndex = 5;
            this.treeTop2.TabStop = false;
            // 
            // treeBottom2
            // 
            this.treeBottom2.BackColor = System.Drawing.Color.Transparent;
            this.treeBottom2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeBottom2.BackgroundImage")));
            this.treeBottom2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeBottom2.Location = new System.Drawing.Point(926, 381);
            this.treeBottom2.Name = "treeBottom2";
            this.treeBottom2.Size = new System.Drawing.Size(85, 501);
            this.treeBottom2.TabIndex = 6;
            this.treeBottom2.TabStop = false;
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(238)))), ((int)(((byte)(184)))));
            this.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestartBtn.Location = new System.Drawing.Point(284, 545);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(115, 40);
            this.RestartBtn.TabIndex = 7;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Visible = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(238)))), ((int)(((byte)(184)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(549, 545);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(115, 40);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Visible = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.scoreTxt);
            this.panel.Controls.Add(this.title);
            this.panel.Location = new System.Drawing.Point(218, 125);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(531, 493);
            this.panel.TabIndex = 9;
            this.panel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "80";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreTxt
            // 
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreTxt.Location = new System.Drawing.Point(66, 240);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(119, 37);
            this.scoreTxt.TabIndex = 1;
            this.scoreTxt.Text = "Score:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(39, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(450, 61);
            this.title.TabIndex = 0;
            this.title.Text = "Flappy Pinecone";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.Silver;
            this.panelShadow.Location = new System.Drawing.Point(211, 132);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(531, 493);
            this.panelShadow.TabIndex = 10;
            this.panelShadow.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "3";
            // 
            // Countdown
            // 
            this.Countdown.Interval = 1000;
            this.Countdown.Tick += new System.EventHandler(this.Countdown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 735);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.pinecone);
            this.Controls.Add(this.treeTop2);
            this.Controls.Add(this.treeBottom2);
            this.Controls.Add(this.treeTop);
            this.Controls.Add(this.treeBottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.treeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinecone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBottom2)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox treeTop;
        private System.Windows.Forms.PictureBox treeBottom;
        private System.Windows.Forms.PictureBox pinecone;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer treeTimer;
        private System.Windows.Forms.PictureBox treeTop2;
        private System.Windows.Forms.PictureBox treeBottom2;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Countdown;
    }
}

