using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VictoryEngine;

namespace VictoryDicesWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            var game = new VictoryGame();

            game.PlayGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var game = new VictoryGame();

            VictoryResult r = game.PlayGame2();
            string s = string.Format("You needed {0} rounds to win the game", r.TotalRounds);
            s += string.Format("\nTotal cost for this victory was " + r.TotalCost.ToString("C0", CultureInfo.CurrentUICulture));
            s += string.Format("\nYou won {0} prizes", r.TotalPrize);
            label2.Text = s;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
