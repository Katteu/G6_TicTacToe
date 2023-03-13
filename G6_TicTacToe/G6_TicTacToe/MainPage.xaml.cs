using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TicTacTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        bool TurnState = false;
        bool Slot1_Clicked = false;
        bool Slot2_Clicked = false;
        bool Slot3_Clicked = false;
        bool Slot4_Clicked = false;
        bool Slot5_Clicked = false;
        bool Slot6_Clicked = false;
        bool Slot7_Clicked = false;
        bool Slot8_Clicked = false;
        bool Slot9_Clicked = false;

        private char CheckState()
        {
            return (TurnState==false)?'X':'O';
        }

        private void ChangeState()
        {
            TurnState = (TurnState==true)?false:true;
        }
        private bool CheckWinner()
        {
            if (EmptySlot1.Text == EmptySlot2.Text == EmptySlot3.Text || Slot7_Clicked == Slot8_Clicked)
            {

            }
            return true;
        }
        private void EmptySlot1_Clicked(object sender, EventArgs e)
        {
            if (Slot1_Clicked==false)
            {
                Slot1_Clicked = true;
                EmptySlot1.Text = Convert.ToString(CheckState());
                if(EmptySlot1.Text == "X")
                {
                    EmptySlot1.BackgroundColor = Color.LightGreen;
                }
                else
                {
                    EmptySlot1.BackgroundColor = Color.Red;
                }
                ChangeState();
            }
        }

        private void EmptySlot2_Clicked(object sender, EventArgs e)
        {
            if (Slot2_Clicked == false)
            {
                Slot2_Clicked = true;
                EmptySlot2.Text = Convert.ToString(CheckState());
                if (EmptySlot2.Text == "X")
                {
                    EmptySlot2.BackgroundColor = Color.LightGreen;
                }
                else
                {
                    EmptySlot2.BackgroundColor = Color.Red;
                }
                ChangeState();
            }
        }

        private void EmptySlot3_Clicked(object sender, EventArgs e)
        {
            if (Slot3_Clicked == false)
            {
                Slot3_Clicked = true;
                EmptySlot3.Text = Convert.ToString(CheckState());
                if (EmptySlot3.Text == "X")
                {
                    EmptySlot3.BackgroundColor = Color.LightGreen;
                }
                else
                {
                    EmptySlot3.BackgroundColor = Color.Red;
                }
                ChangeState();
            }
        }

        private void EmptySlot4_Clicked(object sender, EventArgs e)
        {
            if (Slot4_Clicked == false)
            {
                Slot4_Clicked = true;
                EmptySlot4.Text = Convert.ToString(CheckState());
                if (EmptySlot4.Text == "X")
                {
                    EmptySlot4.BackgroundColor = Color.LightGreen;
                }
                else
                {
                    EmptySlot4.BackgroundColor = Color.Red;
                }
                ChangeState();
            }
        }

        private void EmptySlot5_Clicked(object sender, EventArgs e)
        {
            if (Slot5_Clicked == false)
            {
                Slot5_Clicked = true;
                EmptySlot5.Text = Convert.ToString(CheckState());
                if (EmptySlot5.Text == "X")
                {
                    EmptySlot5.BackgroundColor = Color.LightGreen;
                }
                else
                {
                    EmptySlot5.BackgroundColor = Color.Red;
                }
                ChangeState();  
            }

        }

        private void EmptySlot6_Clicked(object sender, EventArgs e)
        {
            if (Slot6_Clicked == false)
            {
                Slot6_Clicked = true;
                EmptySlot6.Text = Convert.ToString(CheckState());
                if (EmptySlot6.Text == "X")
                {
                    EmptySlot6.BackgroundColor = Color.LightGreen;
                }
                else
                {
                    EmptySlot6.BackgroundColor = Color.Red;
                }
                ChangeState();
            }
        }

        private void EmptySlot7_Clicked(object sender, EventArgs e)
        {
            if (Slot7_Clicked == false)
            {
                Slot7_Clicked = true;
                EmptySlot7.Text = Convert.ToString(CheckState());
                if (EmptySlot7.Text == "X")
                {
                    EmptySlot7.BackgroundColor = Color.LightGreen;
                }
                else
                {
                    EmptySlot7.BackgroundColor = Color.Red;
                }
                ChangeState();
            }
        }

        private void EmptySlot8_Clicked(object sender, EventArgs e)
        {
            if (Slot8_Clicked == false)
            {
                Slot8_Clicked = true;
                EmptySlot8.Text = Convert.ToString(CheckState());
                if (EmptySlot8.Text == "X")
                {
                    EmptySlot8.BackgroundColor = Color.LightGreen;
                }
                else
                {
                    EmptySlot8.BackgroundColor = Color.Red;
                }
                ChangeState();
            }
        }

        private void EmptySlot9_Clicked(object sender, EventArgs e)
        {
            if (Slot9_Clicked == false)
            {
                Slot9_Clicked = true;
                EmptySlot9.Text = Convert.ToString(CheckState());
                if (EmptySlot9.Text == "X")
                {
                    EmptySlot9.BackgroundColor = Color.LightGreen;
                }
                else
                {
                    EmptySlot9.BackgroundColor = Color.Red;
                }
                ChangeState();
            }
        }
        private void Reset_Clicked(object sender, EventArgs e)
        {
            string empty = "-";
            Color background = Color.Gray;

            Slot1_Clicked = false;
            Slot2_Clicked = false;
            Slot3_Clicked = false;
            Slot4_Clicked = false;
            Slot4_Clicked = false;
            Slot5_Clicked = false;
            Slot6_Clicked = false;
            Slot7_Clicked = false;
            Slot8_Clicked = false;
            Slot9_Clicked = false;

            EmptySlot1.Text = empty;
            EmptySlot1.BackgroundColor = background;
            EmptySlot2.Text = empty;
            EmptySlot2.BackgroundColor = background;
            EmptySlot3.Text = empty;
            EmptySlot3.BackgroundColor = background;
            EmptySlot4.Text = empty;
            EmptySlot4.BackgroundColor = background;
            EmptySlot5.Text = empty;
            EmptySlot5.BackgroundColor = background;
            EmptySlot6.Text = empty;
            EmptySlot6.BackgroundColor = background;
            EmptySlot7.Text = empty;
            EmptySlot7.BackgroundColor = background;
            EmptySlot8.Text = empty;
            EmptySlot8.BackgroundColor = background;
            EmptySlot9.Text = empty;
            EmptySlot9.BackgroundColor = background;

        }
    }
}
