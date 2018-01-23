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
        public WordsGame()
        {
            InitializeComponent();
            labelWord.Text = RandomWordGenerator.NewWord();
            labelTimer.Text = ConstantsParams.SecondsForWord.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelTimer.Text == 0.ToString())
            {
                this.buttonNextWord_Click(sender, e);
            }
            else
            {
                labelTimer.Text = (int.Parse(labelTimer.Text) - 1).ToString();
            }
        }

        private void buttonNextWord_Click(object sender, EventArgs e)
        {
            labelTimer.Text = ConstantsParams.SecondsForWord.ToString();
            labelWord.Text = RandomWordGenerator.NewWord();
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
