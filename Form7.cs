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
    /// BookLaterForm
    /// This form is where users can book a room for later
    /// </summary>
    public partial class BookLaterForm : Form
    {
        RoomAC room;
        User user;
        public BookLaterForm(User user, RoomAC room)
        {
            InitializeComponent();
            this.user = user;
            this.room = room;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //YES
            room.addObserver(user);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CANCEL
            this.Close();
        }
    }
}
