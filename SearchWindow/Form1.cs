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

            //MessageBox.Show(transport.ToString());

            //listResult.Text = Searchbox1.Text;
        }

        private void Helper(object sender, EventArgs e)
        {
            if (!(sender is ComboBox))
            {
                return;
            }

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