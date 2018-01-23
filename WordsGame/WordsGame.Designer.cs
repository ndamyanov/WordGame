namespace WordsGame
{
    partial class WordsGame
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
            this.labelWord = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelRemainingTime = new System.Windows.Forms.Label();
            this.buttonPass = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.labelForScore = new System.Windows.Forms.Label();
            this.labelSCore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(74, 51);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(110, 28);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "labelWord";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(247, 20);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(25, 13);
            this.labelTimer.TabIndex = 1;
            this.labelTimer.Text = "120";
            // 
            // labelRemainingTime
            // 
            this.labelRemainingTime.AutoSize = true;
            this.labelRemainingTime.Location = new System.Drawing.Point(159, 20);
            this.labelRemainingTime.Name = "labelRemainingTime";
            this.labelRemainingTime.Size = new System.Drawing.Size(82, 13);
            this.labelRemainingTime.TabIndex = 2;
            this.labelRemainingTime.Text = "Remaining time:";
            // 
            // buttonPass
            // 
            this.buttonPass.Location = new System.Drawing.Point(28, 137);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(82, 29);
            this.buttonPass.TabIndex = 3;
            this.buttonPass.Text = "Pass";
            this.buttonPass.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonPass.UseVisualStyleBackColor = true;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(197, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(162, 137);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(82, 29);
            this.btnCorrect.TabIndex = 6;
            this.btnCorrect.Text = "Correct";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // labelForScore
            // 
            this.labelForScore.AutoSize = true;
            this.labelForScore.Location = new System.Drawing.Point(25, 226);
            this.labelForScore.Name = "labelForScore";
            this.labelForScore.Size = new System.Drawing.Size(38, 13);
            this.labelForScore.TabIndex = 7;
            this.labelForScore.Text = "Score:";
            // 
            // labelSCore
            // 
            this.labelSCore.AutoSize = true;
            this.labelSCore.Location = new System.Drawing.Point(70, 226);
            this.labelSCore.Name = "labelSCore";
            this.labelSCore.Size = new System.Drawing.Size(10, 13);
            this.labelSCore.TabIndex = 8;
            this.labelSCore.Text = "-";
            // 
            // WordsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelSCore);
            this.Controls.Add(this.labelForScore);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonPass);
            this.Controls.Add(this.labelRemainingTime);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelWord);
            this.Name = "WordsGame";
            this.Text = "WordsGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelRemainingTime;
        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Label labelForScore;
        private System.Windows.Forms.Label labelSCore;
    }
}