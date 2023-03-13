using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace G6_TicTacToe
{
    public partial class MainPage : ContentPage
    {
        int turn=1,count=0;
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("G6_TicTacToe.Images.tictactoelogo.png");
        }

        private void btnClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (turn == 1)
            {
                btn.Text = "X";
                btn.BackgroundColor = Color.FromHex("#FFFF8F");
                turn = 0;
                LabelO.Text = "O Player's turn";
                LabelX.Text = "X Player waits";
            }
            else
            {
                btn.Text = "O";
                turn = 1;
                btn.BackgroundColor = Color.FromHex("#87CEEB");
                LabelX.Text = "X Player's turn";
                LabelO.Text = "O Player waits";
            }
            btn.IsEnabled = false;
            validate(btn.Text);
        }

        private void validate(string btnContent)
        {
            if ((buttonOne.Text == btnContent && buttonTwo.Text == btnContent && buttonThree.Text == btnContent) ||
                (buttonOne.Text == btnContent && buttonFive.Text == btnContent && buttonNine.Text==btnContent)||
                (buttonOne.Text == btnContent && buttonFour.Text ==btnContent && buttonSeven.Text==btnContent)||
                (buttonTwo.Text == btnContent && buttonFive.Text ==btnContent && buttonEight.Text ==btnContent)||
                (buttonThree.Text==btnContent && buttonSix.Text ==btnContent && buttonNine.Text ==btnContent)||
                (buttonThree.Text==btnContent && buttonFive.Text==btnContent && buttonSeven.Text==btnContent)||
                (buttonFour.Text==btnContent && buttonFive.Text == btnContent && buttonSix.Text==btnContent)||
                (buttonSeven.Text==btnContent && buttonEight.Text == btnContent && buttonNine.Text==btnContent))
            {
                switch (btnContent)
                {
                    case "O":
                        LabelO.Text = "O Player won!";
                        LabelX.Text = "X Player lost :(";
                        break;
                    case "X":
                        LabelO.Text = "O Player lost :(";
                        LabelX.Text = "X Player won!";
                        break;
                    default:
                        break;
                }
                disableBtn();
            }
            else
            {
                count = 0;
                foreach (Button btn in parentElem1.Children)
                {
                    if (btn.IsEnabled == false) { count++; }
                }
                foreach (Button btn in parentElem2.Children)
                {
                    if (btn.IsEnabled == false) { count++; }
                }
                foreach (Button btn in parentElem3.Children)
                {
                    if (btn.IsEnabled == false) { count++; }
                }

                if (count >= 9)
                {
                    LabelX.Text = "It is a tie!";
                    LabelO.Text = "No one wins!";
                }
            }
        }

        private void disableBtn()
        {
            foreach (Button btn in parentElem1.Children)
            {
                btn.IsEnabled = false;
            }
            foreach (Button btn in parentElem2.Children)
            {
                btn.IsEnabled = false;
            }
            foreach (Button btn in parentElem3.Children)
            {
                btn.IsEnabled = false;
            }
            resetBtn.IsEnabled = true;
        }

        private void resetClicked(object sender, EventArgs e)
        {
            foreach(Button btn in parentElem1.Children)
            {
                btn.Text = "";
                btn.BackgroundColor = Color.Gray;
                btn.IsEnabled = true;
                LabelX.Text = "X Player's turn";
                LabelO.Text = "O Player waits";
                turn = 1;
            }
            foreach (Button btn in parentElem2.Children)
            {
                btn.Text = "";
                btn.BackgroundColor = Color.Gray;
                btn.IsEnabled = true;
                LabelX.Text = "X Player's turn";
                LabelO.Text = "O Player waits";
                turn = 1;
            }
            foreach (Button btn in parentElem3.Children)
            {
                btn.Text = "";
                btn.BackgroundColor = Color.Gray;
                btn.IsEnabled = true;
                LabelX.Text = "X Player's turn";
                LabelO.Text = "O Player waits";
                turn = 1;
            }
        }
    }
}
