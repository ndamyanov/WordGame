using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsGame
{
    public partial class Result_Form : Form
    {
        private int _score;

        private int _passed;

        public Result_Form(int score, int passed)
        {
            InitializeComponent();
            this._score = score;
            this._passed = passed;

            labelScorePoints.Text = _score.ToString();
            labelPassedwords.Text = _passed.ToString();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            WordsGame wordsGame = new WordsGame();
            this.Close();
            wordsGame.ShowDialog();
            wordsGame.BringToFront();
        }
    }
}
