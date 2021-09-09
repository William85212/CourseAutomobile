using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAutomobile.Classes
{
    class Voiture
    {
        public Voiture(string model, string marque)
        {
            Marque = marque;
            Model = model;
            _minVitesse = VitesseRandomMin();
            _maxVitesse = VitesseRandomMax();
        }
        private int _minVitesse;
        private int _maxVitesse;
        public string Marque { get; private set; }
        public string Model { get; private set; }
        private int _tourParcourut;
        private double _tempsTotal;

        public double TempsTotal
        {
            get { return _tempsTotal; }
            set { _tempsTotal = value; }
        }


        public int TourParcourut
        {
            get { return _tourParcourut; }
            private set { _tourParcourut = value; }
        }



        public int MinVitesse
        {
            get { return _minVitesse; }
            set { _minVitesse = value; }
        }
        public int MaxVitesse
        {
            get { return _maxVitesse; }
            set { _maxVitesse = value; }
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
            
            
            double tempsTour = distance / vitesse;
            TourParcourut++;
            TempsTotal += tempsTour;
            return tempsTour;
        }
    }
}
