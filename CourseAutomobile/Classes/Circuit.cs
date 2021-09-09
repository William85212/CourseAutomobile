using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAutomobile.Classes
{
    public class Circuit
    {
        public double Kilometre { get; set; }
        public int NombreTour { get; set; }
        public Circuit(double kilometre, int nbtour)
        {
            Kilometre = kilometre;
            NombreTour = nbtour;
        }
    }
}
