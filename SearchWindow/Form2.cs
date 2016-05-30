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
    public partial class Form2 : Form
    {
        public Form2(string CMBText1, string StationID)
        {
            InitializeComponent();

            this.Text = "Statioboard: " + CMBText1;
            Transport transport = new Transport();
            var Stationboard = transport.GetStationBoard(CMBText1, StationID);

            foreach (var stationboardentries in Stationboard.Entries)
            {
                var item = new ListViewItem(stationboardentries.To);
                item.SubItems.Add(stationboardentries.Stop.Departure.ToShortTimeString());
                item.SubItems.Add(stationboardentries.Name);
                lvStationboard.Items.Add(item);
            }
        }
    }
}
