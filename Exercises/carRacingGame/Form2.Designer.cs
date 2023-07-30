namespace carRacingGame
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picRoadTrack1 = new System.Windows.Forms.PictureBox();
            this.picRoadTrack2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labDiscription = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoadTrack2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picRoadTrack2);
            this.panel1.Controls.Add(this.picRoadTrack1);
            this.panel1.Location = new System.Drawing.Point(8, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 519);
            this.panel1.TabIndex = 0;
            // 
            // picRoadTrack1
            // 
            this.picRoadTrack1.Image = global::carRacingGame.Properties.Resources.roadTrack;
            this.picRoadTrack1.Location = new System.Drawing.Point(0, -519);
            this.picRoadTrack1.Name = "picRoadTrack1";
            this.picRoadTrack1.Size = new System.Drawing.Size(476, 519);
            this.picRoadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoadTrack1.TabIndex = 0;
            this.picRoadTrack1.TabStop = false;
            // 
            // picRoadTrack2
            // 
            this.picRoadTrack2.Image = global::carRacingGame.Properties.Resources.roadTrack;
            this.picRoadTrack2.Location = new System.Drawing.Point(0, 0);
            this.picRoadTrack2.Name = "picRoadTrack2";
            this.picRoadTrack2.Size = new System.Drawing.Size(476, 519);
            this.picRoadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoadTrack2.TabIndex = 1;
            this.picRoadTrack2.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // labDiscription
            // 
            this.labDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDiscription.Location = new System.Drawing.Point(23, 641);
            this.labDiscription.Name = "labDiscription";
            this.labDiscription.Size = new System.Drawing.Size(446, 114);
            this.labDiscription.TabIndex = 6;
            this.labDiscription.Text = "Press and right to move the car\r\n\r\nDon\'t hit any other cars in the gamae and try " +
    "to survive as  long as you can";
            this.labDiscription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labScore
            // 
            this.labScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.Location = new System.Drawing.Point(23, 559);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(446, 28);
            this.labScore.TabIndex = 5;
            this.labScore.Text = "Score: 0";
            this.labScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(192, 593);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 36);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 764);
            this.Controls.Add(this.labDiscription);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRoadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoadTrack2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picRoadTrack1;
        private System.Windows.Forms.PictureBox picRoadTrack2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label labDiscription;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Button btnStart;
    }
}