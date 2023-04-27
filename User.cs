using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// User
    /// This class represents the user who can make reservations and be notified if the room their wanted to book later opens up
    /// </summary>
    public class User : ObserverIF
    {
        private string name;
        MainMenuForm mmf;
        private List<DecoratorReservation> reservations;

        public User(string name)
        {
            this.name = name;
            reservations = new List<DecoratorReservation>();
        }
        public void addReservation(DecoratorReservation drif)
        {
            reservations.Add(drif);
        }
        public void setMMF(MainMenuForm mmf)
        {
            this.mmf = mmf;
        }

        public string getName()
        {
            return name;
        }

        public List<DecoratorReservation> getReservations()
        {
            return reservations;
        }

        public void notify()
        {
            
            var ntfy = new NotifyUserForm(this);
            ntfy.Show();
        }
    }
}
