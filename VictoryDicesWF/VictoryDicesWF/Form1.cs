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

        private void explbtn_Click(object sender, EventArgs e)
        {
            string s = string.Format("You need a 100 points to win this game, the program will play until it reaches 100 points.\n");
            s += string.Format("\nPer round the game will roll 8 dices. The total of the dice determines where you end up on the board. The board is depicted below this textbox.\n");
            s += string.Format("\nEnding up on a red number adds points to your total needed to win. " +
                "Ending up on a green tile will add another prize to win. Ending up on a black numbers does nothing.\n");
            s += string.Format("\nIf the total of the dice is 29 the price per round will double, this effect is cummulative. Base price for one round of play is $1.\n");
            s += string.Format("\nThe program will output how many rounds were needed to reach 100 points, how many prices were won and the total cost to win\n");
            label2.Text = s;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void gameboardimg_Click(object sender, EventArgs e)
        {

        }
    }
}
