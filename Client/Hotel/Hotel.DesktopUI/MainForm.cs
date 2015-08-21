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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new HotelServiceClient();
            string message = service.Registered();
            MessageBox.Show(message);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
             var room = new HotelServiceClient();
             RoomDTO[] rooms = room.GetRooms();
             dataGridView1.DataSource = rooms;
             listBox1.DataSource = rooms;
        }

    }
}
