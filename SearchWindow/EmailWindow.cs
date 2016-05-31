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
            lblSendFromTo.Text = From + " - " + To;
            Connections = connections;
        }

        private Connections Connections { get; set; }

        private void cmdSend_Click(object sender, EventArgs e)
        {
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

            var text = rtbText.Text.Replace("\r\n", "<br>").Replace("\n", "<br>") + "<br>--------------------------------------------<br>" + values;


            MailMessage mail = new MailMessage
            (
                txtFrom.Text,
                txtTo.Text,
                txtSubject.Text,
                text
            )
            {
                IsBodyHtml = true
            };


            mail.BodyEncoding = UTF8Encoding.UTF8;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mail);
            MessageBox.Show("Email is successfully send.");
            Close();
        }

        private string createValues()
        {
            var text = "<table style='width: 100%'>";

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
                TimeSpan ts;
                var FromName = connection.From.Station.Name;
                var Departure = DateTime.Parse(connection.From.Departure).ToString("HH:mm");
                var FromPlatform = connection.From.Platform;
                var ToName = connection.To.Station.Name;
                var Arrival = DateTime.Parse(connection.To.Arrival).ToString("HH:mm");
                var ToPlatform = connection.To.Platform;
                ts = TimeSpan.ParseExact(connection.Duration, @"dd\dhh\:mm\:ss", null);
                var Duaration = (ts.ToString(@"hh\:mm"));

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
            text += "</table>";
            return text;
        }
    }
}

