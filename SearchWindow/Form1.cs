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
            Transport transport = new Transport();
            var CMBText1 = CMBSearch1.Text;
            var CMBText2 = CMBSearch2.Text;
            var Connectionsavailable = transport.GetConnections(CMBText1, CMBText2);
            var i = 0;
            TimeSpan ts = new TimeSpan();

            lblFrom.Visible = true;
            lblTo.Visible = true;
            lblFrom.Text = CMBText1;
            lblTo.Text = CMBText2;

            foreach (var Item in Connectionsavailable.ConnectionList)
            {
                ts = TimeSpan.Parse(Item.Duration);

                listResult.Items.Add((i + 1).ToString());
                listResult.Items[i].SubItems.Add("");
                listResult.Items[i].SubItems.Add("");
                listResult.Items[i].SubItems.Add(ts.ToString(@"hh\:mm"));
                i++;
            }
        }

        private void Helper(object sender, EventArgs e)
        {
            if (!(sender is ComboBox))
            {
                return;
            }

            return;

            var box = (ComboBox)sender;

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
    }
}