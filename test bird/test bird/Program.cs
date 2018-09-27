using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_bird
{
    class Bird
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }
        public decimal Weight { get; set; }
        public decimal BandNo { get; set; }


        public Bird(string NameUnknowen, string SpeciesUnknowen, string SexUnknowen, decimal WeightUnknowen, decimal BandNumberUnknowen)
        {
            Console.WriteLine("Bird odject created and default data loaded......\n");
            Name = NameUnknowen;
            Species = SpeciesUnknowen;
            Sex = SexUnknowen;
            Weight = WeightUnknowen;
            BandNo = BandNumberUnknowen;
            
        }
        public string BirdDetails()
        {

            return $"Bird name: {Name} \nSpecies is : {Species} \nSex is : {Sex} \nWeight is : {Weight} \nBand Number is : {BandNo}";

        }

        class Program
        {
            static void Main(string[] args)
            {
                
                Console.WriteLine("PLEASE UPDATE BIRD DATA\n");
                Console.WriteLine("Please enter the birds Name: ");
                string NameUnknowen = Console.ReadLine();
                Console.WriteLine("please enter the birds Species: ");
                string SpeciesUnknowen = Console.ReadLine();
                Console.WriteLine("please enter the birds Sex: ");
                string SexUnknowen = Console.ReadLine();
                Console.WriteLine("please enter the birds weight: ");
                decimal WeightUnknowen = decimal.Parse(Console.ReadLine());
                Console.WriteLine("please enter the birds band number:");
                decimal BandNumberUnkownen = decimal.Parse(Console.ReadLine());
                Console.WriteLine("******************************************\n");

                Bird B1 = new Bird(NameUnknowen, SexUnknowen, SpeciesUnknowen, WeightUnknowen, BandNumberUnkownen);
                Console.WriteLine("******************************************\n");
                Console.WriteLine("BIRDS OF PREY DATA OUTPUT\n");

                Console.WriteLine(B1.BirdDetails());









            }
        }
    }
}
