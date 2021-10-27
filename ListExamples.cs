using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Arrays
{
    internal class ListExamples
    {
        

        //vi skal lave en metode, før vi kan manipulere med objektet
        public void AddData()
        {
            AnimalModel animalModel1 = new AnimalModel(); //objekt + nyt instans af objekt
            AnimalModel animalModel2 = new AnimalModel();
            AnimalModel animalModel3 = new AnimalModel();
            AnimalModel animalModel4 = new AnimalModel();
            AnimalModel animalModel5 = new AnimalModel();
            AnimalModel animalModel6 = new AnimalModel();
            AnimalModel animalModel7 = new AnimalModel();

            List<AnimalModel> animalModels = new List<AnimalModel>();

            animalModel1.Id = 001;
            animalModel1.Name = "Koko";
            animalModel1.Type = "Gorilla";
            animalModel2.Id = 002;
            animalModel2.Name = "Hansi";
            animalModel2.Type = "Kapivar";
            animalModel3.Id = 003;
            animalModel3.Name = "Poppedreng";
            animalModel3.Type = "Paradisfugl";
            animalModel4.Id = 004;
            animalModel4.Name = "Greyfriar's Bobby";
            animalModel4.Type = "Skye Terrier";
            animalModel5.Id = 005;
            animalModel5.Name = "Tandgnost";
            animalModel5.Type = "Ged";
            animalModel6.Id = 006;
            animalModel6.Name = "Tandgrisna";
            animalModel6.Type = "Ged";
            animalModel7.Id = 007;
            animalModel7.Name = "Sølvryg";
            animalModel7.Type = "Gorilla";


            animalModels.Add(animalModel1);
            animalModels.Add(animalModel2);
            animalModels.Add(animalModel3);
            animalModels.Add(animalModel4);
            animalModels.Add(animalModel5);
            animalModels.Add(animalModel6);
            animalModels.Add(animalModel7);

            ShowAnimals(animalModels);

            //parts.Contains(new Part { PartId =1734, PartName = "" });

            bool b = animalModels.Contains(new AnimalModel { Name = "Koko" });
            if (b) Console.WriteLine("O nome de gorilla e Koko"); //if boolean = true, så udskrives string
        }

        private static void ShowAnimals(List<AnimalModel> animalModels)
        {
            var i = animalModels.Count();
            Console.WriteLine($"Min zoo består af {i} antal dyr. \n ");

            foreach (AnimalModel animal in animalModels)
            {
                Console.WriteLine($"Name: {animal.Name}, Type: {animal.Type} ");
            }
        }
           
    }

    public class AnimalModel
    //variabler skal helst være private (internt i vores klasse)
    //hvorimod properties skal være public
    {
        public int MyProperty { get; set; } //dette er en property af typen int. navnet er property og så har vi en get; set;
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    }
    

    
}
