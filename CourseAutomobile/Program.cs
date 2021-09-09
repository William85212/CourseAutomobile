using CourseAutomobile.Classes;
using System;

namespace CourseAutomobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Circuit circuit = new Circuit(16.666, 6);

            Voiture voiture1 = new Voiture("classe a", "mercedes");
            Voiture voiture2 = new Voiture("serie 1", "bmw");

            while(voiture1.TourParcourut <  circuit.NombreTour && voiture2.TourParcourut < circuit.NombreTour)
            {
                Console.WriteLine($"la voiture {voiture1.Marque} {voiture1.Model} vient de parcourit un tour en " +(voiture1.ParcourirUnTour(circuit.Kilometre)/100*60)+ " minutes");
                Console.WriteLine($"la voiture {voiture2.Marque} {voiture2.Model} vient de parcourit un tour en " +voiture2.ParcourirUnTour(circuit.Kilometre));
                
          
            }
            //temps total pour comparer les temps (ajouter une propriété)
            if (voiture1.TempsTotal < voiture2.TempsTotal)
            {
                Console.WriteLine($"voiture {voiture1.Marque} remporte la course !!");
            }
            else
            {
                Console.WriteLine($"voiture {voiture2.Marque} remporte la course !!");
            }
        }
    }
}
