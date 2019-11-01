using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gehaltsrechner
{
    public class Einstellungen
    {
        public Einstellungen(double stundenlohn)
        {
            StundenLohn = stundenlohn;
            SekundenLohn = StundenlohnZuSekundenLohn(stundenlohn);
        }

        public event EventHandler<StundenlohnUpdatedEventArgs> OnStundenlohnUpdated;

        public double StundenLohn { get; set; }
        public double SekundenLohn { get; set; }

        public void UpdateStundenlohn(double neuerStundenlohn)
        {
            OnStundenlohnUpdated?.Invoke(this, new StundenlohnUpdatedEventArgs(neuerStundenlohn));
        }

        public void a_OnStundenLohnUpdated(object sender, StundenlohnUpdatedEventArgs e)
        {
            StundenLohn = e.Stundenlon;
            SekundenLohn = StundenlohnZuSekundenLohn(e.Stundenlon);
        }

        private double StundenlohnZuSekundenLohn(double stundenlohn)
        {
            return (stundenlohn / 60) / 60;
        }
    }
}
