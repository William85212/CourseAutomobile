using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAutomobile.Classes
{
    public class Voiture
    {
        public event Action<Voiture, Circuit, double> tourFiniEvent = null;

        public Voiture(string model, string marque, Circuit c, string pilote)
        {
            Pilote = pilote;
            C = c;
            Marque = marque;
            Model = model;
            _minVitesse = VitesseRandomMin();
            _maxVitesse = VitesseRandomMax();
            tourFiniEvent += TourParcourutEn;
  
        }
        public string Pilote { get; private set; }
        public Circuit C { get; set; }
        private int _minVitesse;
        private int _maxVitesse;
        public string Marque { get; private set; }
        public string Model { get; private set; }
        private int _tourParcourut;
        private double _tempsTotal;

        public double TempsTotal
        {
            get { return _tempsTotal; }
            private set { _tempsTotal = value; }//tourFiniEvent?.Invoke(this, this.C, tempsTour)
        }


        public int TourParcourut
        {
            get { return _tourParcourut; }
            private set { _tourParcourut = value; }
        }



        public int MinVitesse
        {
            get { return _minVitesse; }
            private set { _minVitesse = value; }
        }
        public int MaxVitesse
        {
            get { return _maxVitesse; }
            private set { _maxVitesse = value; }
        }
        Random rdm = new Random();
        public int VitesseRandomMin()
        {
            return rdm.Next(60, 80);
        }
        public int VitesseRandomMax()
        {
            return rdm.Next(140, 160);
        }


        
        public double ParcourirUnTour(double distance)
        {
            double vitesse = rdm.Next(this.MinVitesse, this.MaxVitesse);

            int ancienNbt = TourParcourut;
            double tempsTour = distance / vitesse;
            TourParcourut++;
            TempsTotal += tempsTour;
            if(ancienNbt < TourParcourut)
                tourFiniEvent?.Invoke(this, this.C, tempsTour);
      
            return tempsTour;
        }
        
        public void TourParcourutEn(Voiture v, Circuit c, double temps)
        {
            Console.WriteLine($"la voiture {v.Marque} {v.Model} vient de finir un tour en {temps} " );
            
        }
    }
}
