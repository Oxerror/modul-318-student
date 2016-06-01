using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using SwissTransport;

namespace SearchWindow
{
    public partial class EmailWindow : Form
    {
        public EmailWindow(string From, string To, Connections connections)
        {
            InitializeComponent();
            // Change Labeltext to Station1 - Station2
            lblSendFromTo.Text = From + " - " + To;
            // set Connections
            Connections = connections;
        }

        private Connections Connections { get; set; }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            // Just works with gmail
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(txtFrom.Text, txtPassword.Text);

            var Connect = Connections;
            var values = createValues();

            // Replace the breaks with html breaks 
            var text = rtbText.Text.Replace("\r\n", "<br>").Replace("\n", "<br>") + "<br>--------------------------------------------<br>" + values;

            MailMessage mail;

            // try to fill in the data, if the Email address is not in the correct format show Errormessage and stop the code
            try
            {
                mail = new MailMessage
                (
                    txtFrom.Text,
                    txtTo.Text,
                    txtSubject.Text,
                    text
                )
                {
                    //Mail is in Body html Code
                    IsBodyHtml = true
                };
            }
            catch (FormatException error)
            {
                MessageBox.Show("Check the Email address\n" + error.Message);
                return;
            }

            mail.BodyEncoding = UTF8Encoding.UTF8;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            // try to send the Email, if the Credentails are wrong show Errormessage and stop the code
            try
            {
                client.Send(mail);
            }
            catch (SmtpException error)
            {
                MessageBox.Show("Check your Email and password\n" + error.Message);
                return;
            }
            MessageBox.Show("Email is successfully send.");
            Close();
        }

        private string createValues()
        {
            // create in html code a table
            var text = "<table style='width: 100%'>";

            // add titles to the table
            text += "<tr>"
                 + "<td>" + "<h4>From</h4>" + "</td>"
                 + "<td>" + "<h4>Departure</h4>" + "</td>"
                 + "<td>" + "<h4>Platform</h4>" + "</td>"
                 + "<td>" + "<h4>To</h4>" + "</td>"
                 + "<td>" + "<h4>Arrival</h4>" + "</td>"
                 + "<td>" + "<h4>Platform</h4>" + "</td>"
                 + "<td>" + "<h4>Duratioin</h4>" + "</td>"
                 + "</tr>";

            foreach (var connection in Connections.ConnectionList)
            {
                // get the Connection datas
                TimeSpan ts;
                var FromName = connection.From.Station.Name;
                var Departure = DateTime.Parse(connection.From.Departure).ToString("HH:mm");
                var FromPlatform = connection.From.Platform;
                var ToName = connection.To.Station.Name;
                var Arrival = DateTime.Parse(connection.To.Arrival).ToString("HH:mm");
                var ToPlatform = connection.To.Platform;
                ts = TimeSpan.ParseExact(connection.Duration, @"dd\dhh\:mm\:ss", null);
                var Duaration = (ts.ToString(@"hh\:mm"));

                // foreach Connetion create a new row and insert the data
                text += "<tr>"
                + "<td>" + FromName + "</td>"
                + "<td>" + Departure + "</td>"
                + "<td>" + FromPlatform + "</td>"
                + "<td>" + ToName + "</td>"
                + "<td>" + Arrival + "</td>"
                + "<td>" + ToPlatform + "</td>"
                + "<td>" + Duaration + "</td>"
                + "</tr>";
            }
            // close the table
            text += "</table>";
            return text;
        }
    }
}

