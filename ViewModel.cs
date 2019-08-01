using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Data;
using Syncfusion.SfDataGrid.XForms;

namespace App2
{
    class ViewModel
    {
        public ObservableCollection<Player> PlayerScoreInfo { get; set; }

        public DataTable dataTable { get; set; }
        public ViewModel()
        {
            this.PlayerScoreInfo = new ObservableCollection<Player>();
            this.GenerateScore();
        }


        public void GenerateScore()
        {
            //PlayerScoreInfo.Add(PropertyCollection.P1);
            //PlayerScoreInfo.Add(PropertyCollection.P2);
            dataTable = new DataTable();
            dataTable.Columns.Add("Players");
            dataTable.Columns.Add("Set Score");
            dataTable.Columns.Add("Game score");

            dataTable.Rows.Add("Player 1", PropertyCollection.P1.setScore, PropertyCollection.P1.gameScore);
            dataTable.Rows.Add("Player 2", PropertyCollection.P2.setScore, PropertyCollection.P2.gameScore);
        }
    }


    
}
