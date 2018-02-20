namespace WordsGame
{
    partial class Result_Form
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScorePoints = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelPassedwords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(202, 104);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(127, 9);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 24);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Result";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(54, 43);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(38, 13);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "Score:";
            // 
            // labelScorePoints
            // 
            this.labelScorePoints.AutoSize = true;
            this.labelScorePoints.Location = new System.Drawing.Point(140, 43);
            this.labelScorePoints.Name = "labelScorePoints";
            this.labelScorePoints.Size = new System.Drawing.Size(10, 13);
            this.labelScorePoints.TabIndex = 4;
            this.labelScorePoints.Text = "-";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(54, 71);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(76, 13);
            this.labelPass.TabIndex = 5;
            this.labelPass.Text = "Passed words:";
            // 
            // labelPassedwords
            // 
            this.labelPassedwords.AutoSize = true;
            this.labelPassedwords.Location = new System.Drawing.Point(140, 71);
            this.labelPassedwords.Name = "labelPassedwords";
            this.labelPassedwords.Size = new System.Drawing.Size(10, 13);
            this.labelPassedwords.TabIndex = 6;
            this.labelPassedwords.Text = "-";
            // 
            // Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 151);
            this.Controls.Add(this.labelPassedwords);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelScorePoints);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonNewGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Result_Form";
            this.Text = "Result_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScorePoints;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelPassedwords;
    }
}