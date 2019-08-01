using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfDataGrid;
using Syncfusion.SfDataGrid.XForms;
using Xamarin.Forms;
using System.Data;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayScore : ContentPage
    {
        public DisplayScore()
        {
            InitializeComponent();
            populateScore();
            Inference.Text = PropertyCollection.gameInference;
        }

        public void populateScore()
        {
            GameScoreP1.Text = Convert.ToString(PropertyCollection.P1.gameScore);
            GameScoreP2.Text = Convert.ToString(PropertyCollection.P2.gameScore);
            SetScoreP1.Text = Convert.ToString(PropertyCollection.P1.setScore);
            SetScoreP2.Text = Convert.ToString(PropertyCollection.P2.setScore);
        }


        
      
    }
}