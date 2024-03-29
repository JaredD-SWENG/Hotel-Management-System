﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// ObserverMultiCaster
    /// This class handles all the observers for the observable
    /// </summary>
    class ObserverMultiCaster
    {
        List<ObserverIF> observers = new List<ObserverIF>();

        public void addObserver(ObserverIF obif)
        {
            observers.Add(obif);
        }

        public void removeObserver(ObserverIF obif)
        {
            observers.Remove(obif);
        }

        public void notifyObservers()
        {
            foreach (ObserverIF observer in observers)
            {
                observer.notify();
            }
            observers.Clear();
        }
    }
}
