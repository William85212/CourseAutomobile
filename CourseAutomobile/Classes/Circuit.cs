using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAutomobile.Classes
{
    public class Circuit
    {
        public Dictionary<string, Voiture> Voitures = new Dictionary<string, Voiture>();
        public double Kilometre { get; set; }
        public int NombreTour { get; set; }
        public Circuit(double kilometre, int nbtour)
        {
            Kilometre = kilometre;
            NombreTour = nbtour;
        }

        public Voiture this[string pilote]
        {
            get
            {
                Voiture v;
                Voitures.TryGetValue(pilote, out v);
                return v;
            }
            set
            {
                Voitures[pilote] = value;
            }
        }
        //public Voiture this[double tempsTt]
        //{
        //    get
        //    {
        //        Voiture v;
        //        Voitures.TryGetValue(tempsTt, out v);
        //        return v;
        //    }
        //    set
        //    {
        //        Voitures[tempsTt] = value;
        //    }
        //}

        public void AjouterVoiture(Voiture v)
        {
            Voitures.Add(v.Pilote, v);
        }
        public void SupprimerVoiture(string tt)
        {
            Voitures.Remove(tt);
        }
    }
}
