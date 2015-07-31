using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public partial class Craps : Form
    {
        public Craps()
        {
            InitializeComponent();
        }

        private void btnConfirmBet_Click(object sender, EventArgs e)
        {
            try
            {

                double dblBet = double.Parse(txtBet.Text);
                double dblOdds = 0;

                double dblCurBet = double.Parse(lblCurrentBet.Text);
                double dblCurBank = double.Parse(txtBank.Text);

                if (lblPhase.Text == "Come Out")
                {
                    if (dblBet > dblCurBank || dblBet <= 0)
                        throw new Exception("Bad Bet");
                }
                else
                {
                    dblOdds = double.Parse(txtOddsBet.Text);
                    if (dblOdds + dblCurBet > dblCurBank || dblOdds <= 0)
                        throw new Exception ("Bad Odds");
                }
                if (lblPhase.Text == "Come Out")
                {
                    txtCurrentBet.Text = dblBet.ToString("C");
                    lblCurrentBet.Text = dblBet.ToString();
                }
                else
                {
                    txtCurOddsBet.Text = dblOdds.ToString("C");
                    lblCurOddsBet.Text = dblBet.ToString();
                }
               
            }
            catch(Exception ex)
            {
                if (ex.Message == "Bad Bet")
                    MessageBox.Show("Please enter a valid bet between $1 and " + double.Parse(txtBank.Text).ToString("C"),
                                    "Invalid Bet");
                else if (ex.Message == "Bad Odds")
                    MessageBox.Show("Please enter a valid bet between $1 and " + (double.Parse(txtBank.Text) - double.Parse(lblCurrentBet.Text)).ToString("C"),
                                    "Invalid Bet");
                else
                    MessageBox.Show("DON'T JUST TYPE RANDOM CRAP");
            }

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCurrentBet.Text == "$0.00")
                    throw new Exception("No Bet");

                int intDieOne = 0;
                int intDieTwo = 0;
                int intCurPoint = 0;
                int intDieSum = 0;
                double dblResult = 0;
                double dblCurOddsBet = 0;
                double dblOddsMult = 0.0;
                double dblBet = double.Parse(lblCurrentBet.Text);
                double dblBank = double.Parse(txtBank.Text);

                Random rnd = new Random();

                intDieOne = rnd.Next(1, 6);
                intDieTwo = rnd.Next(1, 6);

                intDieSum = intDieOne + intDieTwo;

                lblDieOne.Text = intDieOne.ToString();
                lblDieTwo.Text = intDieTwo.ToString();

                if (lblPhase.Text == "Come Out")
                {
                    if (intDieSum == 7 || intDieSum == 11)
                        dblResult += dblBet;
                    else if (intDieSum == 2 || intDieSum == 3 || intDieSum == 12)
                        dblResult -= dblBet;
                    else
                    {
                        lblPhase.Text = "Point";
                        lblPoint.Text = (intDieOne + intDieTwo).ToString();
                        txtBet.Enabled = false;
                        txtOddsBet.Enabled = true;
                        txtOddsBet.Visible = true;
                        lblOdds.Visible = true;
                        btnConfirmBet.Text = "Confirm Odds Bet";
                        lblOdds.Text = "Odds Bet\nCurrent payout is: ";
                        if (intDieSum == 4 || intDieSum == 10)
                            lblOdds.Text += "2:1 :";
                        else if (intDieSum == 5 || intDieSum == 9)
                            lblOdds.Text += "3:2 :";
                        else
                            lblOdds.Text += "6:5 :";
                    }
                }
                else
                {
                    intCurPoint = int.Parse(lblPoint.Text);
                    dblCurOddsBet = double.Parse(lblCurOddsBet.Text);
                    if (intDieSum == 4 || intDieSum == 10)
                        dblOddsMult = 2;
                    else if (intDieSum == 5 || intDieSum == 9)
                        dblOddsMult = (3.0/2.0);
                    else
                        dblOddsMult = (6.0/5.0);


                    if (intDieSum == 7)
                        dblResult -= (dblBet + dblCurOddsBet);
                    else if (intDieSum == intCurPoint)
                        dblResult = dblBet + (dblCurOddsBet * dblOddsMult);
                    else
                        dblResult = 0;

                    //MessageBox.Show("Odds Mult = " + dblOddsMult.ToString() + "\nCurOdds * Odds Mult = " + (dblCurOddsBet * dblOddsMult).ToString());

                    if (dblResult != 0)
                    {
                        lblPhase.Text = "Come Out";
                        lblPoint.Text = "";
                        txtBet.Enabled = true;
                    }
                }
                if (dblResult != 0)
                {
                    txtRecentResult.Text = dblResult.ToString("C");
                    txtBank.Text = (dblBank + dblResult).ToString();

                    txtCurrentBet.Text = 0.ToString("C");
                    lblCurrentBet.Text = 0.ToString();
                    txtBet.Enabled = true;

                    btnConfirmBet.Text = "Confirm Bet";

                    txtCurOddsBet.Text = 0.ToString("C");
                    lblCurOddsBet.Text = 0.ToString();
                    txtOddsBet.Text = "";
                    txtOddsBet.Enabled = false;
                    lblOdds.Visible = false;
                    txtOddsBet.Visible = false;

                    if (dblResult > 0)
                    {
                        txtRecentResult.BackColor = Color.Green;
                        MessageBox.Show("WINNER WINNER CHICKEN DINNER!");
                    }
                    else
                    {
                        txtRecentResult.BackColor = Color.Red;
                        MessageBox.Show("TOO BAD SO SAD!");
                    }
                }
                if (double.Parse(txtBank.Text) <= 0)
                {
                    MessageBox.Show("Game over, man!", "Game Over");
                    this.Close();
                }
            }

            catch
            {
                MessageBox.Show("Place a bet first!", "No Bet");
            }
        }

        private void Craps_Load(object sender, EventArgs e)
        {
            txtCurrentBet.Text = 0.ToString("C");
            lblCurrentBet.Text = 0.ToString();
            txtCurOddsBet.Text = 0.ToString("C");
            lblCurOddsBet.Text = 0.ToString();
            txtBank.Text = "5000";
        }

        private void btnWalkAway_Click(object sender, EventArgs e)
        {
            int intFinalBank = int.Parse(txtBank.Text);

            if (intFinalBank == 5000)
                MessageBox.Show("You broke even. Kind of boring, but whatevs.", "Broke Even");
            else if (intFinalBank > 5000)
                MessageBox.Show("Woohoo! You're up " + (intFinalBank - 5000).ToString("C") + "!", "Big Winner");
            else
                MessageBox.Show("You lost " + (5000 - intFinalBank).ToString("C") + ".  Hope you don't have any hungry kids waiting for you at home ...", "Loser");

            this.Close();

        }
    }
}
