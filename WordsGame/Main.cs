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
    public partial class Main : Form
    {
        public int Score { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            WordsGame wordsGame = new WordsGame();
            //this.Hide();
            wordsGame.ShowDialog();
            wordsGame.BringToFront();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Form_Options optionsForm = new Form_Options();
            optionsForm.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History_Form historyForm = new History_Form();
            historyForm.ShowDialog();

        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            NewWord_Form newWordForm = new NewWord_Form();
            newWordForm.ShowDialog();
        }
    }
}
