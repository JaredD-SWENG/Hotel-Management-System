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
    /// NotifyUserForm
    /// This form will pop up to notify users if the room the are looking to reserve later has opened up
    /// </summary>
    public partial class NotifyUserForm : Form
    {
        public NotifyUserForm(User user)
        {
            InitializeComponent();
            label1.Text = user.getName() + ", A room you want is now available!";
            button1.Text = "Notified. Thanks!";
        }
        private void notifiedButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
