using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// Portions that I understand have been taken from ChatGPT with some of them having been modified a bit to fit the code
namespace TicTacToeProject
{
    //Week 1 Finialization Begin ------------------------------------------------------------
    public partial class MainWindow : Window
    {

        #region Private Fields and MainWindow

        private bool player1Turn = true;
        private int turnCount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        #endregion

        #region on a Button_Click

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (player1Turn)
            {
                button.Content = "☢";
            }
            else
            {
                button.Content = "☣";
            }

            //Week 1 Finialization End ------------------------------------------------------------

            //Week 2 Finialization Begin ------------------------------------------------------------

            button.IsEnabled = false;
            turnCount++;

            if (CheckForWinner())
            {
                DisableAllButtons();
                if (player1Turn)
                {
                    //throw new Exception("Testing");
                    // Player 1 wins
                    MessageBox.Show("<Player ☢ Wins?>");
                }
                else
                {
                    //throw new Exception("Testing");
                    // Player 2 wins
                    MessageBox.Show("<Player ☣ Wins?>");
                }

                #region not required code, it's just for my own intertainment

                if (turnCount == 8)
                {
                    //This is just a easter egg
                    MessageBox.Show("Big Brother Is Watching you (•_•) (•ˋ _ ˊ•)");
                }
                if (turnCount == 5)
                {
                    //Just some more easter eggs
                    MessageBox.Show("┗|｀O′|┛");
                }
                if (turnCount < 3)
                {
                    //throw new Exeption("testing"();
                    MessageBox.Show("(⊙_⊙)？");
                }
                if (turnCount == 1)
                {
                    //throw new Exeption("testing"();
                    MessageBox.Show("Oh my God, he's pulling his hacks out");
                }

                #endregion

                //Week 2 Finialization End ------------------------------------------------------------

                //Week 3 Finalization Begin ------------------------------------------------------------
            }
            else if (turnCount == 9)
            {
                //throw new Exeption("testing");
                // No one wins
                MessageBox.Show("<The Game is a a tie?>");
            }
            // The thing below was taken from ChatGPT
            else
            {
                //turn switches to next player
                player1Turn = !player1Turn;
            }
        }

        #endregion

        #region CheckForWinner

        // The CheckForWinner is also from ChatGPT but I am looking to
        // remove it and replace it with my own code if I think of a way
        // to code this portion, though I might just leave it
        // Update: As of 3/29/2023 I have decided that I will leave the CheckForWinner as it currently is

        public bool CheckForWinner()
        {
            // Check the rows for a win
            if (CheckLine(btn1, btn2, btn3) || CheckLine(btn4, btn5, btn6) || CheckLine(btn7, btn8, btn9))
            {
                return true;
            }

            // Check the columns for a win
            if (CheckLine(btn1, btn4, btn7) || CheckLine(btn2, btn5, btn8) || CheckLine(btn3, btn6, btn9))
            {
                return true;
            }

            // Check the diagonals for a win
            if (CheckLine(btn1, btn5, btn9) || CheckLine(btn3, btn5, btn7))
            {
                return true;
            }

            else
            {
                return false;
            }
            
        }

        #endregion

        // Week 3 Finalization End ------------------------------------------------------------

        // Week 4 Finalization Begin ------------------------------------------------------------

        #region CheckLine Method

        public bool CheckLine(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.IsEnabled == false && btn2.IsEnabled == false && btn3.IsEnabled == false &&
                btn1.Content == btn2.Content && btn2.Content == btn3.Content)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        #endregion

        #region DisableAllButtons

        private void DisableAllButtons()
        {
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
        }

        #endregion

        // Week 4 Finalization End ------------------------------------------------------------

    }
}
