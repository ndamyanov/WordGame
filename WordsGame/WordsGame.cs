using System;
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
            labelPassed.Text = Passed.ToString();
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
           // SystemSounds.Exclamation.Play();

            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = "soundFile.wav";
            //player.Play();
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            this.Passed++;
            labelPassed.Text = Passed.ToString();

            if (Passed >= ConstantsParams.AvailablePasses)
            {
                this.buttonPass.Enabled = false;  
            }
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
