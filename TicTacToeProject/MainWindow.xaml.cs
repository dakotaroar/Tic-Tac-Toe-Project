﻿using System;
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

// Portions that I understand have been taken from ChatGPT with some of them having been modified a bit to fit into the code
namespace TicTacToeProject
{
    //------------------------------------------------------------ Week 1 Finialization Begin ------------------------------------------------------------
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

        /*
         On each click of the button it does the following: make the button 
         content change depending on which player's turn it is when the button is 
         clicked, checks for winner and displays who wins based on the player turn.
        */
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

            //------------------------------------------------------------ Week 1 Finialization End ------------------------------------------------------------

            //------------------------------------------------------------ Week 2 Finialization Begin ------------------------------------------------------------

            // Disables the button when clicked
            button.IsEnabled = false;
            turnCount++;

            /*
              When CheckForWinner returns true, it checks if whether or not its player 1's turn, if so then it
              says they one, if not then it says that player 2 wins. 
            */
            if (CheckForWinner())
            {
                DisableAllButtons();
                if (player1Turn)
                {
                    //throw new Exception("Testing");
                    // displays that player 1 wins
                    MessageBox.Show("<Player ☢ Wins?>");
                }
                else
                {
                    //throw new Exception("Testing");
                    // displays that player 2 wins
                    MessageBox.Show("<Player ☣ Wins?>");
                }

                #region not required code, it's just for my own intertainment
                // Just a bunch of code that I added for fun and to add personality

                /*
                 These "easter egg" codes work by when CheckForWinner is true, it checks not just for which player's turn it
                 is like it normally does, it also checks for if it matches the requirments for one of the "easter egg" code.
                */ 
                if (turnCount == 8)
                {
                    //throw new Exception("Testing");
                    //This is just a easter egg
                    MessageBox.Show("Big Brother Is Watching you (•_•) (•ˋ _ ˊ•)");
                }
                if (turnCount == 5)
                {
                    //throw new Exception("Testing");
                    //Just some more easter eggs
                    MessageBox.Show("┗|｀O′|┛");
                }
                if (turnCount < 3)
                {
                    MessageBox.Show("(⊙_⊙)？");
                }
                if (turnCount == 1)
                {
                    MessageBox.Show("Oh my God, he's pulling his hacks out!");
                }

                #endregion

                //------------------------------------------------------------ Week 2 Finialization End ------------------------------------------------------------

                //------------------------------------------------------------ Week 3 Finalization Begin ------------------------------------------------------------
            }

            // If turn count reaches 9, when all buttons have been clicked, it displays that the game was a tie.
            else if (turnCount == 9)
            {
                //throw new Exception("Testing");
                // No one wins
                MessageBox.Show("<The Game is a a tie?>");
            }
            else
            {
                //turn switches to next player
                player1Turn = !player1Turn;
            }
        }

        #endregion

        #region CheckForWinner

        /* 
         CheckForWinner is a boolian which every turn checks if a player matches one of the conditions
         needed to win it returns true. When CheckForWinner is run when no player meets the requirements it returns false.
        */

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

        //------------------------------------------------------------ Week 3 Finalization End ------------------------------------------------------------

        //------------------------------------------------------------ Week 4 Finalization Begin ------------------------------------------------------------

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

        //------------------------------------------------------------ Week 4 Finalization End ------------------------------------------------------------

    }
}