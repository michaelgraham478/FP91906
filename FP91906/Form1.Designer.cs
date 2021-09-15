
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
            this.logTop = new System.Windows.Forms.PictureBox();
            this.logBottom = new System.Windows.Forms.PictureBox();
            this.pinecone = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.TreeTimer = new System.Windows.Forms.Timer(this.components);
            this.logTop2 = new System.Windows.Forms.PictureBox();
            this.logBottom2 = new System.Windows.Forms.PictureBox();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.ExitBtn2 = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.CloudTimer = new System.Windows.Forms.Timer(this.components);
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinecone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBottom2)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            this.SuspendLayout();
            // 
            // logTop
            // 
            this.logTop.BackColor = System.Drawing.Color.Transparent;
            this.logTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logTop.BackgroundImage")));
            this.logTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logTop.Location = new System.Drawing.Point(449, -236);
            this.logTop.Name = "logTop";
            this.logTop.Size = new System.Drawing.Size(85, 462);
            this.logTop.TabIndex = 0;
            this.logTop.TabStop = false;
            // 
            // logBottom
            // 
            this.logBottom.BackColor = System.Drawing.Color.Transparent;
            this.logBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logBottom.BackgroundImage")));
            this.logBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logBottom.Location = new System.Drawing.Point(449, 425);
            this.logBottom.Name = "logBottom";
            this.logBottom.Size = new System.Drawing.Size(85, 501);
            this.logBottom.TabIndex = 1;
            this.logBottom.TabStop = false;
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
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 22;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // TreeTimer
            // 
            this.TreeTimer.Enabled = true;
            this.TreeTimer.Interval = 15;
            this.TreeTimer.Tick += new System.EventHandler(this.TreeTimerEvent);
            // 
            // Cloud
            // 
            this.CloudTimer.Enabled = true;
            this.CloudTimer.Interval = 15;
            this.CloudTimer.Tick += new System.EventHandler(this.CloudTimerEvent);
            // 
            // logTop2
            // 
            this.logTop2.BackColor = System.Drawing.Color.Transparent;
            this.logTop2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logTop2.BackgroundImage")));
            this.logTop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logTop2.Location = new System.Drawing.Point(926, -280);
            this.logTop2.Name = "logTop2";
            this.logTop2.Size = new System.Drawing.Size(85, 462);
            this.logTop2.TabIndex = 5;
            this.logTop2.TabStop = false;
            // 
            // logBottom2
            // 
            this.logBottom2.BackColor = System.Drawing.Color.Transparent;
            this.logBottom2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logBottom2.BackgroundImage")));
            this.logBottom2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logBottom2.Location = new System.Drawing.Point(926, 381);
            this.logBottom2.Name = "logBottom2";
            this.logBottom2.Size = new System.Drawing.Size(85, 501);
            this.logBottom2.TabIndex = 6;
            this.logBottom2.TabStop = false;
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
            this.panel.Controls.Add(this.ExitBtn2);
            this.panel.Controls.Add(this.StartBtn);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.scoreTxt);
            this.panel.Controls.Add(this.title);
            this.panel.Location = new System.Drawing.Point(218, 125);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(531, 493);
            this.panel.TabIndex = 9;
            this.panel.Visible = false;
            // 
            // ExitBtn2
            // 
            this.ExitBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(238)))), ((int)(((byte)(184)))));
            this.ExitBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn2.Location = new System.Drawing.Point(202, 355);
            this.ExitBtn2.Name = "ExitBtn2";
            this.ExitBtn2.Size = new System.Drawing.Size(115, 40);
            this.ExitBtn2.TabIndex = 13;
            this.ExitBtn2.Text = "Exit";
            this.ExitBtn2.UseVisualStyleBackColor = false;
            this.ExitBtn2.Visible = false;
            this.ExitBtn2.Click += new System.EventHandler(this.ExitBtn2_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(238)))), ((int)(((byte)(184)))));
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.Location = new System.Drawing.Point(202, 300);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(115, 40);
            this.StartBtn.TabIndex = 12;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Visible = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
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
            // cloud1
            // 
            this.cloud1.BackColor = System.Drawing.Color.Transparent;
            this.cloud1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cloud1.BackgroundImage")));
            this.cloud1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cloud1.Location = new System.Drawing.Point(78, 88);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(161, 94);
            this.cloud1.TabIndex = 11;
            this.cloud1.TabStop = false;
            // 
            // cloud2
            // 
            this.cloud2.BackColor = System.Drawing.Color.Transparent;
            this.cloud2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cloud2.BackgroundImage")));
            this.cloud2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cloud2.Location = new System.Drawing.Point(748, 269);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(130, 83);
            this.cloud2.TabIndex = 12;
            this.cloud2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 735);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.pinecone);
            this.Controls.Add(this.logTop2);
            this.Controls.Add(this.logBottom2);
            this.Controls.Add(this.logTop);
            this.Controls.Add(this.logBottom);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.cloud1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.logTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinecone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBottom2)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logTop;
        private System.Windows.Forms.PictureBox logBottom;
        private System.Windows.Forms.PictureBox pinecone;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer TreeTimer;
        private System.Windows.Forms.PictureBox logTop2;
        private System.Windows.Forms.PictureBox logBottom2;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer CloudTimer;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ExitBtn2;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud2;
    }
}

