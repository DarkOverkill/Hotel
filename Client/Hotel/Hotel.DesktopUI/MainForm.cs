using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Service.DTOs;

using System.Configuration;

namespace Hotel.DesktopUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            datePicker_arraive.MinDate = DateTime.Today;
            datePicker_departure.MinDate = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComboBoxGuest.Text == "")
            {
                MessageBox.Show("Please login");
                return;
            }
            var service = new HotelServiceClient();
            string data = "Arrival: " +datePicker_arraive.Value.ToShortDateString() + "\nDeparture: " +
                            datePicker_departure.Value.ToShortDateString() + "\nOn Name: " +
                            ComboBoxGuest.Text + "\nRoom #" +
                            Convert.ToInt32(listBox_AvailableRooms.Text);
            DialogResult d = MessageBox.Show(data, "Confirmed registration:", MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK)
            {
                service.RoomReservation(datePicker_arraive.Value, datePicker_departure.Value, ComboBoxGuest.Text, Convert.ToInt32(listBox_AvailableRooms.Text));
                this.MainForm_Load(sender, e);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var room = new HotelServiceClient();
            RoomDTO[] rooms = room.GetRooms();            
            dataGridView1.DataSource = rooms;
            dataGridView1.Columns[0].Visible = false;
            rooms = room.GetAvailableRooms();
            listBox_AvailableRooms.DataSource = rooms;

            var guest = new HotelServiceClient();
            GuestDTO[] guests = guest.GetGuests();
            foreach (var g in guests)
            {
                ComboBoxGuest.Items.Add(g.Name + " " + g.Surname);
            }
        }
    }
}
