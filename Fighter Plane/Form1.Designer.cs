namespace Fighter_Plane
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.Pillar2 = new System.Windows.Forms.PictureBox();
            this.Pillar1 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.textScore = new System.Windows.Forms.Label();
            this.Pillar3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar3)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = global::Fighter_Plane.Properties.Resources.Helicopter_final1;
            this.Player.Location = new System.Drawing.Point(101, 101);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 54);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 5;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // ufo
            // 
            this.ufo.Image = global::Fighter_Plane.Properties.Resources.download__1___1___1_1;
            this.ufo.Location = new System.Drawing.Point(790, 271);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(71, 72);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 4;
            this.ufo.TabStop = false;
            this.ufo.Click += new System.EventHandler(this.ufo_Click);
            // 
            // Pillar2
            // 
            this.Pillar2.Image = global::Fighter_Plane.Properties.Resources.Piller_final;
            this.Pillar2.Location = new System.Drawing.Point(314, 257);
            this.Pillar2.Name = "Pillar2";
            this.Pillar2.Size = new System.Drawing.Size(63, 561);
            this.Pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pillar2.TabIndex = 1;
            this.Pillar2.TabStop = false;
            this.Pillar2.Tag = "Pillar";
            // 
            // Pillar1
            // 
            this.Pillar1.Image = global::Fighter_Plane.Properties.Resources.Piller_final;
            this.Pillar1.Location = new System.Drawing.Point(514, -83);
            this.Pillar1.Name = "Pillar1";
            this.Pillar1.Size = new System.Drawing.Size(63, 201);
            this.Pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pillar1.TabIndex = 0;
            this.Pillar1.TabStop = false;
            this.Pillar1.Tag = "Pillar";
            this.Pillar1.Click += new System.EventHandler(this.Pillar1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.ForeColor = System.Drawing.Color.White;
            this.textScore.Location = new System.Drawing.Point(0, 0);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(82, 24);
            this.textScore.TabIndex = 6;
            this.textScore.Text = "Score:0";
            this.textScore.Click += new System.EventHandler(this.textScore_Click);
            // 
            // Pillar3
            // 
            this.Pillar3.Image = global::Fighter_Plane.Properties.Resources.Piller_final;
            this.Pillar3.Location = new System.Drawing.Point(878, 164);
            this.Pillar3.Name = "Pillar3";
            this.Pillar3.Size = new System.Drawing.Size(57, 799);
            this.Pillar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pillar3.TabIndex = 7;
            this.Pillar3.TabStop = false;
            this.Pillar3.Tag = "Pillar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1064, 749);
            this.Controls.Add(this.Pillar3);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.Pillar2);
            this.Controls.Add(this.Pillar1);
            this.Name = "Form1";
            this.Text = "Fighter Plan Shooting ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pillar1;
        private System.Windows.Forms.PictureBox Pillar2;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.PictureBox Pillar3;
    }
}

