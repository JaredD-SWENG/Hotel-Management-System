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
    /// HotelSelectionForm
    /// This is the form where users will select a room from a hotel to book now or later
    /// </summary>
    public partial class HotelSelectionForm : Form
    {

        HotelManager hmgr;
        User user;
        private bool isFormClosing;
        public HotelSelectionForm(User user)
        {
            
            InitializeComponent();
            isFormClosing = false;
            bookNowButton.Enabled = false;
            bookLaterButton.Enabled = false;
            hmgr = HotelManager.getInstance();
            List<Hotel> htls = hmgr.getHotels();
            foreach(Hotel htl in htls)
            {
                comboBox1.Items.Add(htl);
            }
            this.user = user;
            this.Text = user.getName() + " Hotel Selection Form";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HotelSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void bookNowButton_Click(object sender, EventArgs e)
        {
            //Proceeding to Form3 passing in selected Room.
            //Open Form3, Hide Form2, when Form3 closes (end of reservation is reached), close Form2 and show Form1 (main menu).
            HotelIF3 selectedRoom = (HotelIF3)listBox1.SelectedItem;
            if (!((RoomAC)selectedRoom).isReserved())
            {

                hmgr.reserveRoom(selectedRoom);
                int prevCount = (user.getReservations()).Count;
                isFormClosing = false;
                var rf = new ReservationForm(user, selectedRoom);
                rf.FormClosing += f2FormClosing;
                this.Hide();
                rf.Show();

                while (!isFormClosing)
                {
                    Application.DoEvents();
                    Thread.Sleep(10);
                }

                if(prevCount == (user.getReservations()).Count)
                {
                    hmgr.reserveRoom(selectedRoom);
                }

                this.Close();
            }
        }
        private void f2FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormClosing = true;
        }

        private void bookLaterButton_Click(object sender, EventArgs e)
        {
            //open dialog to ask user if they wish to be notified.
            isFormClosing = false;
            var blf = new BookLaterForm(user, ((RoomAC)listBox1.SelectedItem));
            blf.FormClosing += f2FormClosing;
            this.Hide();
            blf.Show();
            while (!isFormClosing)
            {
                Application.DoEvents();
                Thread.Sleep(10);
            }
            this.Close();

        }
        
        private void hotelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (listBox1.Items.Count > 0) listBox1.Items.Clear();
            Hotel temp = (Hotel)comboBox1.SelectedItem;
            List<HotelIF3> hifs = hmgr.getRooms(temp);
            foreach(HotelIF3 hf in hifs)
            {
                listBox1.Items.Add(hf);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((RoomAC)listBox1.SelectedItem).isReserved()) {
                bookNowButton.Enabled = false;
                bookLaterButton.Enabled = true;
            }
            else
            {
                bookNowButton.Enabled = true;
                bookLaterButton.Enabled = false;
            }
            
        }
    }
}
