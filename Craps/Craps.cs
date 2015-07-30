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
                double dblCurBank = double.Parse(txtBank.Text);

                if (dblBet > dblCurBank || dblBet <= 0)
                    throw new Exception("Bad Bet");

                txtCurrentBet.Text = dblBet.ToString("C");
                lblCurrentBet.Text = dblBet.ToString();

            }
            catch
            {
                MessageBox.Show("Please enter a valid bet between $1 and " + double.Parse(txtBank.Text).ToString("C"),
                                "Invalid Bet");
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
                double dblResult = 0;
                double dblBet = double.Parse(lblCurrentBet.Text);
                double dblBank = double.Parse(txtBank.Text);

                Random rnd = new Random();

                intDieOne = rnd.Next(1, 6);
                intDieTwo = rnd.Next(1, 6);

                lblDieOne.Text = intDieOne.ToString();
                lblDieTwo.Text = intDieTwo.ToString();

                if (lblPhase.Text == "Come Out")
                {
                    if (intDieOne + intDieTwo == 7 || intDieOne + intDieTwo == 11)
                        dblResult += dblBet;
                    else if (intDieOne + intDieTwo == 2 || intDieOne + intDieTwo == 3 || intDieOne + intDieTwo == 12)
                        dblResult -= dblBet;
                    else
                    {
                        lblPhase.Text = "Point";
                        lblPoint.Text = (intDieOne + intDieTwo).ToString();
                    }
                }
                else
                {
                    intCurPoint = int.Parse(lblPoint.Text);

                    if (intDieOne + intDieTwo == 7)
                        dblResult -= dblBet;
                    else if (intDieOne + intDieTwo == intCurPoint)
                        dblResult += dblBet;
                    else
                        dblResult = 0;

                    if (dblResult != 0)
                    {
                        lblPhase.Text = "Come Out";
                        lblPoint.Text = "";
                    }
                }
                if (dblResult != 0)
                {
                    txtRecentResult.Text = dblResult.ToString("C");
                    txtBank.Text = (dblBank + dblResult).ToString();

                    txtCurrentBet.Text = 0.ToString("C");
                    lblCurrentBet.Text = 0.ToString();

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
            txtBank.Text = "5000";
        }
    }
}
