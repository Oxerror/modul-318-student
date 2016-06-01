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
using System.Net.Mail;

namespace SearchWindow
{
    public partial class MainWindow : Form
    {
        private Connections Connections = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            // Check if both Comboboxes are not empty
            if (CMBSearch1.Text == "" || CMBSearch2.Text == "")
            {
                MessageBox.Show("At least one Stationfield is empty");
                cmdSendMail.Enabled = false;
                return;
            }
    
            // Set the Current Cursor the the Waitcursor
            Cursor.Current = Cursors.WaitCursor;
    
            ITransport transport = new Transport();
            var CMBText1 = CMBSearch1.Text;
            var CMBText2 = CMBSearch2.Text;
            int isArrivaltime = 0;
            // if the time is the Arrival time change "isArrivaltime" to 1
            if (rbArrival.Checked) 
            {
                isArrivaltime = 1;
            }
            // Get the connections (Station1, Station2, date(yyyy-MM-dd), time(HH:mm), isArrivaltime)
            var Connectionsavailable = transport.GetConnections(CMBText1, CMBText2, dateTimePicker.Value.ToString(@"yyyy\-MM\-dd"), TimePicker.Value.ToString(@"HH\:mm"), isArrivaltime);
            var i = 0;

            // Set Connections
            Connections = Connectionsavailable;
    
            // Show the labels with the Current Infos
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
    
            // Clear the ListView before adding new datas
            listResult.Items.Clear();
            // Check if a connection is available
            if (Connectionsavailable.ConnectionList.Count == 0)
            {
                MessageBox.Show("There is no connection available");
                cmdSendMail.Enabled = false;
                return;
            }
    
            // adding data to the ListView
            #region ListView
                foreach (var connection in Connectionsavailable.ConnectionList)
                {
                    TimeSpan ts;
                    // index
                    var item = new ListViewItem((i + 1).ToString());
                    // Start Name
                    item.SubItems.Add(connection.From.Station.Name);
                    // Departure time
                    item.SubItems.Add(DateTime.Parse(connection.From.Departure).ToString("HH:mm"));
                    // Departure Platform if available
                    item.SubItems.Add(connection.From.Platform);
                    // Destination Name
                    item.SubItems.Add(connection.To.Station.Name);
                    // Arrival time
                    item.SubItems.Add(DateTime.Parse(connection.To.Arrival).ToString("HH:mm"));
                    // Arrival Platform
                    item.SubItems.Add(connection.To.Platform);
                    ts = TimeSpan.ParseExact(connection.Duration, @"dd\dhh\:mm\:ss", null);
                    // Duration
                    item.SubItems.Add(ts.ToString(@"hh\:mm"));
                    listResult.Items.Add(item);
                    // ++ index
                    i++;

                }
                #endregion
    
            // Set again the Default Cursos instead of the Waitcursor
            Cursor.Current = Cursors.Default;
            // Enable the send Email button
            cmdSendMail.Enabled = true;
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            // Set all the Values back to default (not the time and date)
            CMBSearch1.Text = "";
            CMBSearch1.Items.Clear();
            CMBSearch2.Text = "";
            CMBSearch2.Items.Clear();
            listResult.Items.Clear();
            lblDate.Visible = false;
            lblFrom.Visible = false;
            lblTime.Visible = false;
            lblTo.Visible = false;
            cmdSendMail.Enabled = false;
            cmdstationboard.Enabled = false;
        }

        private async void Helper(object sender, KeyEventArgs e)
        {
            // Check if sender is a Combox
            if (!(sender is ComboBox))
            {
                return;
            }

            var box = (ComboBox)sender;

            // if the senderbox is the Departsearchbox and if the senderbox isn't empty enable the Stationboard
            if (!(box.Text == "") && box ==CMBSearch1)
            {
                cmdstationboard.Enabled = true;
            }
            // if the senderbox is empty and is the Departsearchbox disable the Stationboard and 
            else if (box.Text == "" && box == CMBSearch1)
            {
                cmdstationboard.Enabled = false;
            }
            // if the senderbox is empty return (return needed cause else a error appears)
            if (box.Text == "")
            {
                return;
            }

            // Exit the Code when a Arrowkey or the Enterkey is pressed (for Selection), same for Control and Shift key (for commands)
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Control || e.KeyCode == Keys.Shift || e.KeyCode == Keys.Enter)
            {
                return;
            }

            var selectionStart = box.SelectionStart;
            var selectionLength = box.SelectedText.Length;
            // Clear the ComboBoxList
            box.Items.Clear();

            // Set the Cursor to the last spot of the box
            box.Select(selectionStart, selectionLength);

            // Opens the Dropdown Menu of the Combobox (to see the possible stations)
            box.DroppedDown = true;
            ITransport transport = new Transport();
            var SearchText = box.Text;
            var StationNames = await transport.GetStations(SearchText);
            // add Stationnames to Combobox
            foreach (var Item in StationNames.StationList)
            {
                box.Items.Add(Item.Name);
            }
        }

        private async void cmdstatonboard_Click(object sender, EventArgs e)
        {
            // Change the Cursor to the WaitCursor
            Cursor.Current = Cursors.WaitCursor;

            var CMBText1 = CMBSearch1.Text;
            var CMBText2 = CMBSearch2.Text;
            ITransport transport = new Transport();
            var Station = await transport.GetStations(CMBText1);

            // if there are no Station data return
            if (Station.StationList.Count == 0)
            {
                MessageBox.Show("Invalid Station");
                return;
            }

            // get ID of the selected Station
            var StationID = Station.StationList[0].Id;

            // Show th eStationboardWindow
            StationboardWindow stationboard = new StationboardWindow(CMBText1, StationID);
            stationboard.Show();

            // Change the Cursor to the Default Cursor
            Cursor.Current = Cursors.Default;
        }

        private async void cmdMap_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();
            Station station = new Station();
            var CMBText1 = CMBSearch1.Text;
            var CMBText2 = CMBSearch2.Text;

            // if sender isn't a button return
            if (!(sender is Button))
            {
                return;
            }

            var button = (Button)sender;
            string MapSearch = "";

            // checks which button is the sender
            if (button == cmdMap1)
            {
                if (CMBText1 == "")
                {
                    MessageBox.Show("The Departfield is empty");
                    return;
                }
                MapSearch = CMBText1;
            }
            else if (button == cmdMap2)
            {
                if (CMBText2 == "")
                {
                    MessageBox.Show("The Arrivalfield is empty");
                    return;
                }
                MapSearch = CMBText2;
            }
            // if it isnt one of the buttons above return
            else
            {
                return;
            }

            //Get Stations with the entered name
            var StationName = await transport.GetStations(MapSearch);
            // Get the X and Y coordiantes (if the mapsearch is with coordinates)
            // var StationXCoord = StationName.StationList[0].Coordinate.XCoordinate;
            // var StationYCoord = StationName.StationList[0].Coordinate.YCoordinate;

            // Google Maps search with the Stationname
            Process.Start("https://www.google.ch/maps/place/" + MapSearch + "/,13z");
            // Mapsearch with coordiantes (not used here cause the search with the name finds everything, not even the Stations on the List)
            // Process.Start("https://www.google.ch/maps/@" + StationXCoord + "," + StationYCoord + "/,13z");
        }

        private void cmdSendMail_Click(object sender, EventArgs e)
        {
            // Show the EmailWindow
            EmailWindow emailwindow = new EmailWindow(CMBSearch1.Text, CMBSearch2.Text, Connections);
            emailwindow.Show();
        }
    }
}