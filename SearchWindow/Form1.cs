using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SearchWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Transport transport = new Transport();
                var CMBText1 = CMBSearch1.Text;
                var CMBText2 = CMBSearch2.Text;
                int isArrivaltime = 0;
                if (rbArrival.Checked) 
                {
                    isArrivaltime = 1;
                }
                var Connectionsavailable = transport.GetConnections(CMBText1, CMBText2, dateTimePicker.Value.ToString(@"yyyy\-MM\-dd"), TimePicker.Value.ToString(@"HH\:mm"), isArrivaltime);
                var i = 0;

                #region Showlabels
                lblFrom.Visible = true;
                lblTo.Visible = true;
                lblDate.Visible = true;
                lblTime.Visible = true;
                lblFrom.Text = CMBText1;
                lblTo.Text = CMBText2;
                lblDate.Text = dateTimePicker.Value.ToString(@"yyyy\-MM\-dd");
                lblTime.Text = TimePicker.Value.ToString(@"HH\:mm");

                #endregion

                listResult.Items.Clear();

                #region ListView
                foreach (var connection in Connectionsavailable.ConnectionList)
                {
                    TimeSpan ts;
                    var item = new ListViewItem((i + 1).ToString());
                    item.SubItems.Add(connection.From.Station.Name);
                    item.SubItems.Add(DateTime.Parse(connection.From.Departure).ToString("HH:mm"));
                    item.SubItems.Add(connection.From.Platform);
                    item.SubItems.Add(connection.To.Station.Name);
                    item.SubItems.Add(DateTime.Parse(connection.To.Arrival).ToString("HH:mm"));
                    item.SubItems.Add(connection.To.Platform);
                    ts = TimeSpan.ParseExact(connection.Duration, @"dd\dhh\:mm\:ss", null);
                    item.SubItems.Add(ts.ToString(@"hh\:mm"));
                    listResult.Items.Add(item);
                    i++;

                }
                #endregion

                Cursor.Current = Cursors.Default;
           }
           catch(Exception q)
           {
                MessageBox.Show("Your input is invalid!\n\n" + q.Message,
                                "Important Note",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            CMBSearch1.Text = "";
            CMBSearch1.Items.Clear();
            CMBSearch2.Text = "";
            CMBSearch2.Items.Clear();
            listResult.Items.Clear();
            lblDate.Visible = false;
            lblFrom.Visible = false;
            lblTime.Visible = false;
            lblTo.Visible = false;
        }

        private void Helper(object sender, KeyEventArgs e)
        {
            if (!(sender is ComboBox))
            {
                return;
            }

            var box = (ComboBox)sender;

            // Exit the Code when a Arrowkey is pressed (for Selection) or Control --> Shift key
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Control || e.KeyCode == Keys.Shift)
            {
                return;
            }

            var selectionStart = box.SelectionStart;
            var selectionLength = box.SelectedText.Length;
            // Clear the ComboBoxList
            box.Items.Clear();

            // Set the Cursor to the correct spot
            box.Select(selectionStart, selectionLength);

            // Opens the Dropdown Menu of the Combobox (to see the possible stations)
            box.DroppedDown = true;
            Transport transport = new Transport();
            var SearchText = box.Text;
            var StationNames = transport.GetStations(SearchText);
            //CMBSearch1.Items.AddRange(StationNames.StationList.ToArray());
            foreach (var Item in StationNames.StationList)
            {
                box.Items.Add(Item.Name);
            }
        }

        private void cmdstatonboard_Click(object sender, EventArgs e)
        {
            var CMBText1 = CMBSearch1.Text;
            var CMBText2 = CMBSearch2.Text;
            Transport transport = new Transport();
            var Station = transport.GetStations(CMBText1);
            var StationID = Station.StationList[0].Id;

            Form2 stationboard = new Form2(CMBText1, StationID);
            stationboard.Show();
        }

        private void cmdMap_Click(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            Station station = new Station();
            var CMBText1 = CMBSearch1.Text;
            var CMBText2 = CMBSearch2.Text;

            if (!(sender is Button))
            {
                return;
            }

            var button = (Button)sender;
            string MapSearch = "";

            if (button == cmdMap1)
            {
                MapSearch = CMBText1;
            }
            else if (button == cmdMap2)
            {
                MapSearch = CMBText2;
            }

            var StationName = transport.GetStations(MapSearch);
            var StationXCoord = StationName.StationList[0].Coordinate.XCoordinate;
            var StationYCoord = StationName.StationList[0].Coordinate.YCoordinate;

            //Process.Start("https://www.google.ch/maps/place/" + MapSearch + "/,13z");
            Process.Start("https://www.google.ch/maps/@" + StationXCoord + "," + StationYCoord + "/,13z");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.ch/maps/@");
        }
    }
}