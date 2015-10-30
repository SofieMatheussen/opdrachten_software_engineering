namespace YathzeeTeerling
{
    partial class ScoreBoardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scoreLabel = new System.Windows.Forms.Label();
            this.waardeScoreLabel = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.waardeHighScoreLabel = new System.Windows.Forms.Label();
            this.aantalWorpenLabel = new System.Windows.Forms.Label();
            this.waardeAantalWorpenLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waardeMaxAantalWorpenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(43, 37);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(49, 17);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score:";
            // 
            // waardeScoreLabel
            // 
            this.waardeScoreLabel.AutoSize = true;
            this.waardeScoreLabel.Location = new System.Drawing.Point(99, 37);
            this.waardeScoreLabel.Name = "waardeScoreLabel";
            this.waardeScoreLabel.Size = new System.Drawing.Size(16, 17);
            this.waardeScoreLabel.TabIndex = 1;
            this.waardeScoreLabel.Text = "0";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Location = new System.Drawing.Point(43, 67);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(76, 17);
            this.highScoreLabel.TabIndex = 2;
            this.highScoreLabel.Text = "Highscore:";
            // 
            // waardeHighScoreLabel
            // 
            this.waardeHighScoreLabel.AutoSize = true;
            this.waardeHighScoreLabel.Location = new System.Drawing.Point(126, 67);
            this.waardeHighScoreLabel.Name = "waardeHighScoreLabel";
            this.waardeHighScoreLabel.Size = new System.Drawing.Size(16, 17);
            this.waardeHighScoreLabel.TabIndex = 3;
            this.waardeHighScoreLabel.Text = "0";
            // 
            // aantalWorpenLabel
            // 
            this.aantalWorpenLabel.AutoSize = true;
            this.aantalWorpenLabel.Location = new System.Drawing.Point(46, 100);
            this.aantalWorpenLabel.Name = "aantalWorpenLabel";
            this.aantalWorpenLabel.Size = new System.Drawing.Size(102, 17);
            this.aantalWorpenLabel.TabIndex = 4;
            this.aantalWorpenLabel.Text = "Aantal worpen:";
            // 
            // waardeAantalWorpenLabel
            // 
            this.waardeAantalWorpenLabel.AutoSize = true;
            this.waardeAantalWorpenLabel.Location = new System.Drawing.Point(149, 100);
            this.waardeAantalWorpenLabel.Name = "waardeAantalWorpenLabel";
            this.waardeAantalWorpenLabel.Size = new System.Drawing.Size(16, 17);
            this.waardeAantalWorpenLabel.TabIndex = 5;
            this.waardeAantalWorpenLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "/";
            // 
            // waardeMaxAantalWorpenLabel
            // 
            this.waardeMaxAantalWorpenLabel.AutoSize = true;
            this.waardeMaxAantalWorpenLabel.Location = new System.Drawing.Point(195, 100);
            this.waardeMaxAantalWorpenLabel.Name = "waardeMaxAantalWorpenLabel";
            this.waardeMaxAantalWorpenLabel.Size = new System.Drawing.Size(16, 17);
            this.waardeMaxAantalWorpenLabel.TabIndex = 7;
            this.waardeMaxAantalWorpenLabel.Text = "0";
            this.waardeMaxAantalWorpenLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ScoreBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.waardeMaxAantalWorpenLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.waardeAantalWorpenLabel);
            this.Controls.Add(this.aantalWorpenLabel);
            this.Controls.Add(this.waardeHighScoreLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.waardeScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Name = "ScoreBoardView";
            this.Size = new System.Drawing.Size(666, 204);
            this.Load += new System.EventHandler(this.ScoreBoardView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label waardeScoreLabel;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label waardeHighScoreLabel;
        private System.Windows.Forms.Label aantalWorpenLabel;
        private System.Windows.Forms.Label waardeAantalWorpenLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label waardeMaxAantalWorpenLabel;
    }
}
