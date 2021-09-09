using CourseAutomobile.Classes;
using System;

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

            circuit["alonso"]

            while (voiture1.TourParcourut <  circuit.NombreTour && voiture2.TourParcourut < circuit.NombreTour)
            {
                voiture1.ParcourirUnTour(circuit.Kilometre);
                voiture2.ParcourirUnTour(circuit.Kilometre);

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
