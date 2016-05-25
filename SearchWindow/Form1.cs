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
            Cursor.Current = Cursors.WaitCursor;

            Transport transport = new Transport();
            var CMBText1 = CMBSearch1.Text;
            var CMBText2 = CMBSearch2.Text;
            var Connectionsavailable = transport.GetConnections(CMBText1, CMBText2);
            var i = 0;

            #region From-To label
            lblFrom.Visible = true;
            lblTo.Visible = true;
            lblFrom.Text = Connectionsavailable.ConnectionList[0].From.Station.Name;
            lblTo.Text = Connectionsavailable.ConnectionList[0].To.Station.Name;
            #endregion

            #region ListView
            foreach (var connection in Connectionsavailable.ConnectionList)
            {
                TimeSpan ts;
                var item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(DateTime.Parse(connection.From.Departure).ToString("hh:mm"));
                item.SubItems.Add(DateTime.Parse(connection.To.Arrival).ToString("hh:mm"));
                ts = TimeSpan.ParseExact(connection.Duration, @"dd\dhh\:mm\:ss", null);
                item.SubItems.Add(ts.ToString(@"hh\:mm"));
                listResult.Items.Add(item);
                i++;

            }
            #endregion

            Cursor.Current = Cursors.Default;
        }

        private void Helper(object sender, EventArgs e)
        {
            return;


            if (!(sender is ComboBox))
            {
                return;
            }

            var box = (ComboBox)sender;

            if (box.Text.Length < 3)
            {
                return;
            }
            // Clear the ComboBoxList
            box.Items.Clear();
            // Set the Cursor to the correct spotz
            box.Select(box.Text.Length, box.Text.Length);
            Transport transport = new Transport();
            var SearchText = box.Text;
            var StationNames = transport.GetStations(SearchText);
            //CMBSearch1.Items.AddRange(StationNames.StationList.ToArray());
            foreach (var Item in StationNames.StationList)
            {
                box.Items.Add(Item.Name); 
            }
            box.DroppedDown = true;
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            CMBSearch1.Text = "";
            CMBSearch1.Items.Clear();
            CMBSearch2.Text = "";
            CMBSearch2.Items.Clear();
            listResult.Items.Clear();
        }
    }
}