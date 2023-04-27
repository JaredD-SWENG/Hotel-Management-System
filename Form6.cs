using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    /// <summary>
    /// ViewReservationForm
    /// This form gives the user the option to view their reservations
    /// </summary>
    public partial class ViewReservationForm : Form
    {
        User user;
        public ViewReservationForm(User user)
        {
            InitializeComponent();
            this.user = user;
            
            foreach (DecoratorReservation reservation in user.getReservations())
            {
                comboBox1.Items.Add(reservation);
            }
        }

        private void ViewReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (listBox1.Items.Count > 0) listBox1.Items.Clear();
            DecoratorReservation temp = (DecoratorReservation)comboBox1.SelectedItem;
            List<ServiceIF> servifs = new List<ServiceIF>();
            double totalCost = 0.0;

            while (temp.GetServiceIF() != null)
            {
                totalCost += ((temp.GetServiceIF()).isIncluded()) ? 0 : (temp.GetServiceIF()).calculateCost(); //Sum up total Cost.
                servifs.Add(temp.GetServiceIF());//Adding service to list for display.
                temp = (DecoratorReservation)temp.GetReservationIF();//Unwrap a layer.
            }//When while loop terminates, we are at the last layer.
            ReservationIF rif = temp.GetReservationIF();
            totalCost = (!(rif.ToString()).Contains("Luxury")) ? totalCost + rif.calculateCost() : rif.calculateCost();



            string itemName = rif.ToString();
            string itemPrice = string.Format("{0,10:C2}", rif.calculateCost());
            string alignedItem = string.Format("{0,-21}{1,9}", itemName, itemPrice);
            listBox1.Items.Add(alignedItem);


            RoomAC rac = (rif.getRoom());


            foreach (ServiceIF sif in servifs)
            {

                itemName = sif.ToString();
                itemPrice = (!sif.isIncluded()) ? string.Format("{0,10:C2}", sif.calculateCost()) : "FREE";
                alignedItem = string.Format("{0,-21}{1,9}", itemName, itemPrice);
                listBox1.Items.Add(alignedItem);

            }

            HotelNameLabel.Text = rac.getName();
            CheckInLabel.Text = ((ReservationAC)rif).getStartDate().ToString().Split(' ')[0];
            CheckOutLabel.Text = ((ReservationAC)rif).getEndDate().ToString().Split(' ')[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
