using CourseAutomobile.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseAutomobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Circuit circuit = new Circuit(16.666, 6);

            

            Voiture voiture1 = new Voiture("classe a", "mercedes", circuit, "schumacher");
            Voiture voiture2 = new Voiture("serie 1", "bmw", circuit, "alonso");

            circuit.AjouterVoiture(voiture1);
            circuit.AjouterVoiture(voiture2);

            

            while (voiture1.TourParcourut <  circuit.NombreTour && voiture2.TourParcourut < circuit.NombreTour)
            {
                foreach (var item in circuit.Voitures)
                {
                    item.Value.ParcourirUnTour(item.Value.C.Kilometre);
                }
            }

            double tempsMin = double.MaxValue;
            foreach (var item in circuit.Voitures)
            {
                
                if (item.Value.TempsTotal < tempsMin)
                {
                    tempsMin = item.Value.TempsTotal;
                }
            }


            var gagnant = circuit.Voitures.FirstOrDefault(e => e.Value.TempsTotal == tempsMin);

            Console.WriteLine(gagnant.Value.Pilote + " gagne la course ");
           
        }
    }
}
