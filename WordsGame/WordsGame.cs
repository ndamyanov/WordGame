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
    public partial class WordsGame : Form
    {

        public int Score { get; set; }

        public int Passed { get; set; }

        public WordsGame()
        {
            InitializeComponent();
            labelWord.Text = RandomWordGenerator.NewWord();
            labelTimer.Text = ConstantsParams.TimeForGame.ToString();
            labelSCore.Text = Score.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelTimer.Text == 0.ToString())
            {
                timer1.Stop();
                this.Hide();
                Result_Form resultForm = new Result_Form(Score, Passed);
                resultForm.ShowDialog();
                
            }
            else
            {
                labelTimer.Text = (int.Parse(labelTimer.Text) - 1).ToString();
            }
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            this.Passed++;
            labelWord.Text = RandomWordGenerator.NewWord();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            this.Score++;
            labelSCore.Text = Score.ToString();
            labelWord.Text = RandomWordGenerator.NewWord();
        }
    }
}
