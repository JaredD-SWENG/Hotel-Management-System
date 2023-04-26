
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
    public partial class OrderConfirmationForm : Form
    {
        DecoratorReservation drif;
        User user;

        public OrderConfirmationForm(DecoratorReservation drif, User user)
        {
            this.drif = drif;
            InitializeComponent();
            this.user = user;

            //Set a temp to Decorator

            //Each "step", check if getServiceIF is null
            //If NOT null, Add the ServiceIF to a List for later
            //If Servif is null, you have arrived at your destination, please stay seated until the bus has come to a full stop and keep your arms and legs withion the confines of the seating. Please dont forget to wave goodbye to the bus driver, they do not recieve enough lvoe and credit for all the crap we put them through. Like geez.
            DecoratorReservation temp = drif;
            List<ServiceIF> servifs = new List<ServiceIF>();
            double totalCost = 0.0;

            while(temp.GetServiceIF() != null)
            {
                totalCost += ((temp.GetServiceIF()).isIncluded()) ? 0: (temp.GetServiceIF()).calculateCost(); //Sum up total Cost.
                servifs.Add(temp.GetServiceIF());//Adding service to list for display.
                temp = (DecoratorReservation)temp.GetReservationIF();//Unwrap a layer.
            }//When while loop terminates, we are at the last layer.
            ReservationIF rif = temp.GetReservationIF();
            totalCost = (!(rif.ToString()).Contains("Luxury")) ? totalCost + rif.calculateCost() : rif.calculateCost();

            
            
            string itemName = rif.ToString();
            string itemPrice =  string.Format("{0,10:C2}" , rif.calculateCost());
            string alignedItem = string.Format("{0,-21}{1,9}", itemName, itemPrice);
            listBox1.Items.Add(alignedItem);
            

            RoomAC rac = (rif.getRoom());
            

            foreach(ServiceIF sif in servifs)
            {
                
                itemName = sif.ToString();
                itemPrice = (!sif.isIncluded()) ? string.Format("{0,10:C2}", sif.calculateCost()) : "FREE";
                alignedItem = string.Format("{0,-21}{1,9}", itemName, itemPrice);
                listBox1.Items.Add(alignedItem);
               
            }

            HotelNameLabel.Text = rac.getName();
            drif.setStartDate(((ReservationAC)rif).getStartDate());
            CheckInLabel.Text =  ((ReservationAC)rif).getStartDate().ToString().Split(' ')[0];
            drif.setEndDate(((ReservationAC)rif).getEndDate());
            CheckOutLabel.Text = ((ReservationAC)rif).getEndDate().ToString().Split(' ')[0];
            TotalCostLabel.Text = string.Format("{0,10:C2}", totalCost);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            user.addReservation(drif);
            this.Close();
        }
    }
}
