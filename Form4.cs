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
    /// BonusFeaturesForm
    /// This form allows users to select additional services if they want
    /// </summary>
    public partial class BonusFeaturesForm : Form
    {
        DecoratorReservation drif;
        User user;
        private bool isFormClosing;
        public BonusFeaturesForm(DecoratorReservation drif, ReservationForm rf, User user)
        {
            this.drif = drif;
            this.user = user;
            List<string> includedFeatures = new List<string>();
            List<string> bonusFeatures = new List<string>();
            includedFeatures.AddRange(rf.getBuilder().provideFeatures());
            InitializeComponent();
            //Continental Breakfast, Exclusive Parking, Gym Pass, Pool Pass, SPA, WiFi
            bonusFeatures.Add(string.Format("{0,-21}{1,13}","Continental Breakfast_","FREE"));
            bonusFeatures.Add(string.Format("{0,-21}{1,13}","Exclusive Parking_","$8.00"));
            bonusFeatures.Add(string.Format("{0,-21}{1,13}", "Room Service_", "$5.00"));
            bonusFeatures.Add(string.Format("{0,-21}{1,13}", "Gym Pass_", "$6.00"));
            bonusFeatures.Add(string.Format("{0,-21}{1,13}", "Pool Pass_", "$4.00"));
            bonusFeatures.Add(string.Format("{0,-21}{1,13}", "Spa_", "$15.00"));
            bonusFeatures.Add(string.Format("{0,-21}{1,13}", "WiFi_", "$1.00"));
            bonusFeatures.Add(string.Format("{0,-21}{1,13}", "Premium TV_", "$2.00"));
            isFormClosing = false;
            bool flag;

            foreach(string s in bonusFeatures)
            {
                flag = true;
                foreach(string k in includedFeatures)
                {
                    if  (k.Contains((s.Split('_')).ElementAt(0))) flag = false;
                }
                if  (flag == true) checkedListBox1.Items.Add(s.Replace('_', ' '));
            }

            //Unpack what is stored in decorator, populate what is missing in list to be selected and added.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            List<ServiceIF> toAddServices;
            toAddServices = getToAddServices(checkedListBox1.CheckedItems);

            foreach (ServiceIF service in toAddServices)
            {
                drif = new DecoratorReservation(service, drif);
                Console.WriteLine((drif.GetServiceIF()).ToString());
            }

            isFormClosing = false;
            var ocf = new OrderConfirmationForm(drif, user);
            ocf.FormClosing += f2FormClosing;
            this.Hide();
            ocf.Show();
            while (!isFormClosing)
            {
                Application.DoEvents();
                Thread.Sleep(10);
            }
            this.Close();
        }
        private void f2FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormClosing = true;
        }

        private List<ServiceIF> getToAddServices(CheckedListBox.CheckedItemCollection features)
        {
            List<ServiceIF> servicesTemp = new List<ServiceIF>(); 
           
            foreach (Object f in features)
            {
                string temp = f.ToString();

                if(temp.Contains("Room"))
                {
                    servicesTemp.Add(new RoomService(false));
                }
                else if (temp.Contains("Exclusive"))
                {
                    servicesTemp.Add(new ExclusiveParking(false));
                }
                else if (temp.Contains("Gym"))
                {
                    servicesTemp.Add(new GymPass(false));
                }
                else if (temp.Contains("Pool"))
                {
                    servicesTemp.Add(new PoolPass(false));
                }
                else if (temp.Contains("Spa"))
                {
                    servicesTemp.Add(new Spa(false));
                }
                else if (temp.Contains("WiFi"))
                {
                    servicesTemp.Add(new WiFi(false));
                }
                else if (temp.Contains("Premium"))
                {
                    servicesTemp.Add(new PremiumTV(false));
                }
            }

            return servicesTemp;
           
        }

        private void skipButton_Click(object sender, EventArgs e)
        {

            isFormClosing = false;
            var ocf = new OrderConfirmationForm(drif, user);
            ocf.FormClosing += f2FormClosing;
            this.Hide();
            ocf.Show();
            while (!isFormClosing)
            {
                Application.DoEvents();
                Thread.Sleep(10);
            }
            this.Close();
        }
    }
}
