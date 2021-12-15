namespace SantaGame
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
            this.snowyGround = new System.Windows.Forms.PictureBox();
            this.skyMoon = new System.Windows.Forms.PictureBox();
            this.santaHut = new System.Windows.Forms.PictureBox();
            this.santaClaus = new System.Windows.Forms.PictureBox();
            this.snowFlake2 = new System.Windows.Forms.PictureBox();
            this.pineTree1 = new System.Windows.Forms.PictureBox();
            this.snowFlake1 = new System.Windows.Forms.PictureBox();
            this.pineTree2 = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.snowyGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santaHut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santaClaus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree2)).BeginInit();
            this.SuspendLayout();
            // 
            // snowyGround
            // 
            this.snowyGround.Image = ((System.Drawing.Image)(resources.GetObject("snowyGround.Image")));
            this.snowyGround.Location = new System.Drawing.Point(0, 482);
            this.snowyGround.Name = "snowyGround";
            this.snowyGround.Size = new System.Drawing.Size(805, 80);
            this.snowyGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowyGround.TabIndex = 2;
            this.snowyGround.TabStop = false;
            // 
            // skyMoon
            // 
            this.skyMoon.Image = ((System.Drawing.Image)(resources.GetObject("skyMoon.Image")));
            this.skyMoon.Location = new System.Drawing.Point(0, 1);
            this.skyMoon.Name = "skyMoon";
            this.skyMoon.Size = new System.Drawing.Size(134, 130);
            this.skyMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skyMoon.TabIndex = 3;
            this.skyMoon.TabStop = false;
            this.skyMoon.Click += new System.EventHandler(this.skyMoon_Click);
            // 
            // santaHut
            // 
            this.santaHut.Image = ((System.Drawing.Image)(resources.GetObject("santaHut.Image")));
            this.santaHut.Location = new System.Drawing.Point(37, 392);
            this.santaHut.Name = "santaHut";
            this.santaHut.Size = new System.Drawing.Size(131, 128);
            this.santaHut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santaHut.TabIndex = 4;
            this.santaHut.TabStop = false;
            this.santaHut.Click += new System.EventHandler(this.santaHut_Click);
            // 
            // santaClaus
            // 
            this.santaClaus.Image = ((System.Drawing.Image)(resources.GetObject("santaClaus.Image")));
            this.santaClaus.Location = new System.Drawing.Point(0, 137);
            this.santaClaus.Name = "santaClaus";
            this.santaClaus.Size = new System.Drawing.Size(224, 96);
            this.santaClaus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santaClaus.TabIndex = 5;
            this.santaClaus.TabStop = false;
            this.santaClaus.Click += new System.EventHandler(this.santaClaus_Click);
            // 
            // snowFlake2
            // 
            this.snowFlake2.Image = ((System.Drawing.Image)(resources.GetObject("snowFlake2.Image")));
            this.snowFlake2.Location = new System.Drawing.Point(720, 1);
            this.snowFlake2.Name = "snowFlake2";
            this.snowFlake2.Size = new System.Drawing.Size(56, 57);
            this.snowFlake2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowFlake2.TabIndex = 6;
            this.snowFlake2.TabStop = false;
            this.snowFlake2.Click += new System.EventHandler(this.snowFlake2_Click);
            // 
            // pineTree1
            // 
            this.pineTree1.Image = ((System.Drawing.Image)(resources.GetObject("pineTree1.Image")));
            this.pineTree1.Location = new System.Drawing.Point(258, 334);
            this.pineTree1.Name = "pineTree1";
            this.pineTree1.Size = new System.Drawing.Size(117, 186);
            this.pineTree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pineTree1.TabIndex = 7;
            this.pineTree1.TabStop = false;
            this.pineTree1.Click += new System.EventHandler(this.pineTree1_Click);
            // 
            // snowFlake1
            // 
            this.snowFlake1.Image = ((System.Drawing.Image)(resources.GetObject("snowFlake1.Image")));
            this.snowFlake1.Location = new System.Drawing.Point(441, 75);
            this.snowFlake1.Name = "snowFlake1";
            this.snowFlake1.Size = new System.Drawing.Size(47, 42);
            this.snowFlake1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowFlake1.TabIndex = 6;
            this.snowFlake1.TabStop = false;
            this.snowFlake1.Click += new System.EventHandler(this.snowFlake1_Click);
            // 
            // pineTree2
            // 
            this.pineTree2.Image = ((System.Drawing.Image)(resources.GetObject("pineTree2.Image")));
            this.pineTree2.Location = new System.Drawing.Point(679, 286);
            this.pineTree2.Name = "pineTree2";
            this.pineTree2.Size = new System.Drawing.Size(126, 234);
            this.pineTree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pineTree2.TabIndex = 7;
            this.pineTree2.TabStop = false;
            this.pineTree2.Click += new System.EventHandler(this.pineTree2_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(0, 565);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(147, 50);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRestart.Location = new System.Drawing.Point(281, 188);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(298, 140);
            this.buttonRestart.TabIndex = 9;
            this.buttonRestart.Text = "play again";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(804, 612);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pineTree2);
            this.Controls.Add(this.snowFlake1);
            this.Controls.Add(this.pineTree1);
            this.Controls.Add(this.snowFlake2);
            this.Controls.Add(this.santaClaus);
            this.Controls.Add(this.santaHut);
            this.Controls.Add(this.skyMoon);
            this.Controls.Add(this.snowyGround);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.snowyGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santaHut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santaClaus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snowyGround;
        private System.Windows.Forms.PictureBox skyMoon;
        private System.Windows.Forms.PictureBox santaHut;
        private System.Windows.Forms.PictureBox santaClaus;
        private System.Windows.Forms.PictureBox snowFlake2;
        private System.Windows.Forms.PictureBox pineTree1;
        private System.Windows.Forms.PictureBox snowFlake1;
        private System.Windows.Forms.PictureBox pineTree2;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonRestart;
    }
}

