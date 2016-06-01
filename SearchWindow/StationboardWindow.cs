using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SearchWindow
{
    public partial class StationboardWindow : Form
    {
        public StationboardWindow(string CMBText1, string StationID)
        {
            InitializeComponent();

            // Set the Title of the Stationboardwindow
            this.Text = "Statioboard: " + CMBText1;
            ITransport transport = new Transport();
            var Stationboard = transport.GetStationBoard(CMBText1, StationID);

            foreach (var stationboardentries in Stationboard.Entries)
            {
                // Add the Stationboard data to a Listview
                var item = new ListViewItem(stationboardentries.To);
                item.SubItems.Add(stationboardentries.Stop.Departure.ToShortTimeString());
                item.SubItems.Add(stationboardentries.Name);
                lvStationboard.Items.Add(item);
            }
        }
    }
}
