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
    public partial class History_Form : Form
    {
        public History_Form()
        {
            InitializeComponent();
            FillTheHistory();
        }

        public void FillTheHistory()
        {
            var lines = File.ReadAllLines(ConstantsParams.HistoryFile).Count();
            var text = "";
            using(var reader = new StreamReader(ConstantsParams.HistoryFile))
            {
                for (int i = 0; i < lines; i++)
                {
                    text += $" {i+1}  ->  " + reader.ReadLine() + Environment.NewLine; 
                }
            }
            richTextBoxHistory.Text = text;
        }
    }
}
