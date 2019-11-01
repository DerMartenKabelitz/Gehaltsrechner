using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gehaltsrechner
{
    public class StundenlohnUpdatedEventArgs : EventArgs
    {
        public double Stundenlon { get; set; }

        public StundenlohnUpdatedEventArgs(double stundenlohn)
        {
            Stundenlon = stundenlohn;
        }
    }
}
