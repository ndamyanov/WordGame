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
    public partial class Form_Options : Form
    {
        public Form_Options()
        {
            InitializeComponent();
            trackBarTime.Value = ConstantsParams.SecondsForWord / 30;
        }

        private void AdjustTimeForResponse(object sender, EventArgs e)
        {
            int time = trackBarTime.Value * 30;
            ConstantsParams.SecondsForWord = time;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
