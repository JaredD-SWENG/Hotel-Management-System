using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    /// <summary>
    /// ReservationForm
    /// This is the form where users will choose which type of reservation they want
    /// </summary>
    public partial class ReservationForm : Form
    {
        private User user;
        private RoomAC roomAC;
        private BuilderIF builder;
        private bool isFormClosing;

        public ReservationForm(User user, HotelIF3 selectedRoom)
        {
            //Add Room from Hotel Select Form

            builder = new StandardBuilder();
            builder.setRF(this);
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            nextButton.Enabled = false;
            roomAC = (RoomAC)selectedRoom;
            isFormClosing = false;
            this.user = user;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            //call "builder"'s build function, pass resulting object into next form.
            DecoratorReservation drif = builder.build();
            
            if((string)comboBox1.SelectedItem == "Luxury")
            {
                var ocf = new OrderConfirmationForm(drif, user);
                ocf.FormClosing += f2FormClosing;
                this.Hide();
                ocf.Show();
            }
            else
            {
                var bff = new BonusFeaturesForm(drif, this, user);
                bff.FormClosing += f2FormClosing;
                this.Hide();
                bff.Show();
            }
            while (!isFormClosing)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }

            this.Close();
        }
        private void f2FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormClosing = true;
        }

        public DateTime getStartDate()
        {
            return dateTimePicker1.Value;
        }

        public DateTime getEndDate()
        {
            return dateTimePicker2.Value;
        }

        
        public RoomAC getRoom()
        {
            return roomAC;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            builder = builder.provideBuilder((comboBox1.SelectedItem).ToString());

            //Dynamically fill "features" list with appropriate data. listBox1
            List<string> strs = builder.provideFeatures();
            listBox1.Items.Clear();
            foreach(string str in strs)
            {
                listBox1.Items.Add(str);
            }

            nextButton.Enabled = true;
        }
        public BuilderIF getBuilder()
        {
            return builder;
        }
    }
}
