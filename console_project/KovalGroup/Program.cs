using System;
using System.Collections.Generic;
using System.Text;

namespace KovalGroup
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Reservoir res = new Reservoir(1050, 0, 100, 50000);
            ////Reservoir res = new Reservoir();
            //Console.Write("введiть площу водоймища(м.кв.) ");
            //res.Square = int.Parse(Console.ReadLine());
            //Console.Write("введiть кiлькiсть впадаючих рiчок ");
            //res.Number = int.Parse(Console.ReadLine());
            //Console.Write("введiть найбiльшу глибину(м.) ");
            //res.MaxDepth = double.Parse(Console.ReadLine());
            //Console.Write("введiть масу води(кг.) ");
            //res.WeightWater = double.Parse(Console.ReadLine());


            //Console.WriteLine("");
            //Console.WriteLine("середня глибина водоймища = " + res.AverageDepth() + "(м.)");
            //if (res.WaterAnalise())
            //    Console.WriteLine("маса води бiльша нiж 1000(кг.)");
            //else
            //    Console.WriteLine("маса води менша нiж 1000(кг.)");

            //Console.WriteLine(res.NumberRivers());


            var lake = new Lake();
            List<Lake> lakesList = new List<Lake>();
            // Lake
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Клас Lake");
                lake = new Lake();
                Console.Write("введiть назву озера ");
                lake.Name = Console.ReadLine();
                Console.Write("введiть кiлькiсть причалiв ");
                lake.BerthsQty = int.Parse(Console.ReadLine());
                lakesList.Add(lake);
            }
            lakesList.Sort(Lake.compareLakesByName);
            lakesList.Sort(Lake.compareLakesByBerthsQuality);
            for (int i = 0; i < lakesList.Count; i++)
            {
                Console.WriteLine(lakesList[i]);
            }
                //Console.WriteLine("Клас Lake");
                //var lake = new Lake();
                //Console.Write("введiть кiлькiсть причалiв ");
                //lake.BerthsQty = int.Parse(Console.ReadLine());
                //Console.Write("введiть рiвень заболоченостi ");
                //lake.BoggingLevel = int.Parse(Console.ReadLine());
                //Console.Write("введiть коефiнiєнт солоностi ");
                //lake.SaltFactor = int.Parse(Console.ReadLine());
                //Console.Write("введiть кiлькiсть водозаборiв ");
                //lake.WaterIntakeQty = int.Parse(Console.ReadLine());

   //             Console.WriteLine();
   //         Console.WriteLine($"Кiлькiсть рейсiв {lake.VoyagesPerMonth()}");
   //         Console.WriteLine($"Якiсть води {lake.WaterQuality()}");
   //         Console.WriteLine($"Середня глибина у поточному мiсяцi {lake.VoyagesPerMonth()}");

			////Pond
			//var pond = new Pond();
			//Console.Write("введiть кiлькiсть мiсць на пляжi ");
			//pond.Colvoplaces = int.Parse(Console.ReadLine());
			//Console.Write("введiть рiвень забрудненостi води ");
			//pond.Drinkwater = int.Parse(Console.ReadLine());
			//Console.Write("введiть кiлькiсть стереотипних видань ");
			//pond.Stereotype = int.Parse(Console.ReadLine());
			//Console.Write("введiть кiлькiсть рокiв видання ");
			//pond.Years = int.Parse(Console.ReadLine());
			

			//Console.WriteLine();
		 //   Console.WriteLine($"Середня площа на пляж (м.кв.) {pond.squar(res.Square)}");
			//Console.WriteLine($"Маса води на одну рибу (кг.) {pond.fishweight(res.WeightWater)}");

            Console.ReadLine();
        }
    }
}