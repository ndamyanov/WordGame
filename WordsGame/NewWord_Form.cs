using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsGame
{
    public partial class NewWord_Form : Form
    {
        public NewWord_Form()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string word = textBoxNewWord.Text;
            string file = ConstantsParams.FilePath;

            using(var writer = new StreamWriter(file, true))
            {
                writer.WriteLine(word);
            }
            textBoxNewWord.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
