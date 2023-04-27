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
    /// MainMenuForm
    /// This is the main menu where users can create or view reservations
    /// </summary>
    public partial class MainMenuForm : Form
    {
        User user;
        private bool isFormClosing;
        public MainMenuForm(User user)
        {
            InitializeComponent();
            this.user = user;
            user.setMMF(this);
            this.Text = user.getName() + " Main Menu Form";
            isFormClosing = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            isFormClosing = false;
            var f2 = new HotelSelectionForm(user);
            f2.FormClosing += f2FormClosing;
            f2.Show();

            while (!isFormClosing)
            {
                Application.DoEvents();
                Thread.Sleep(10);
            }
            
            this.Show();
            
        }
        private void f2FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormClosing = true;
        }

        private void viewReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            isFormClosing = false;
            var vrf = new ViewReservationForm(user);
            vrf.FormClosing += f2FormClosing;
            vrf.Show();
            while (!isFormClosing)
            {
                Application.DoEvents();
                Thread.Sleep(10);
            }
            this.Show();
        }
    }
}
