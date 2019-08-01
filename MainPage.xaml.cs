using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            PropertyCollection.P1 = new Player();
            PropertyCollection.P2 = new Player();
            PropertyCollection.gameInference = "";
            PropertyCollection.tie = false;
            PropertyCollection.gameAdvantage = null;
            PropertyCollection.endGame = false;
            PropertyCollection.deuce = false;
           
        }

        private void P1_Clicked(object sender, EventArgs e)
        {
            ScoreActions.addGameScore(PropertyCollection.P1);
            if (PropertyCollection.endGame)
            {
                DisplayAlert("GAME OVER", PropertyCollection.gameInference, "New Game");
                PropertyCollection.resetGame();
                
            }
        }

        private void P2_Clicked(object sender, EventArgs e)

        {
            ScoreActions.addGameScore(PropertyCollection.P2);
            if (PropertyCollection.endGame)
            {
                DisplayAlert("GAME OVER", PropertyCollection.gameInference, "New Game");
                PropertyCollection.resetGame();
            }
        }

        private async void DisplayScore_Clicked(object sender, EventArgs e)
        {
            ScoreActions.setGameInference();
            await Navigation.PushModalAsync(new DisplayScore());

        }
      
    }


}
