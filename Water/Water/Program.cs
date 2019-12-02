using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Water
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
            var classCreator = chooseClass();
            var obj = classCreator.reservoir();
            //var tps = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(ReservoirCreator))).ToList();//DefinedTypes.Where(t => t.);
            //Console.WriteLine(obj.GetType().ToString() == "KovalGroup.Lake");
            List<Reservoir> reservoirList = new List<Reservoir>();

            Console.Write("Кількість резервуарів даного типу, яку хочете створити:");
            int reservoirCount = int.Parse(Console.ReadLine());
            if (obj.GetType().ToString() == "Water.Lake")
            {
                for (int i = 0; i < reservoirCount; i++)
                {
                    Lake lake = new Lake();
                    Console.Write("Введіть назву водойми: ");
                    lake.Name = Console.ReadLine();
                    Console.Write("введiть кiлькiсть причалiв ");
                    lake.BerthsQty = int.Parse(Console.ReadLine());
                    Console.Write("введiть рiвень заболоченостi ");
                    lake.BoggingLevel = int.Parse(Console.ReadLine());
                    Console.Write("введiть коефiнiєнт солоностi ");
                    lake.SaltFactor = int.Parse(Console.ReadLine());
                    Console.Write("введiть кiлькiсть водозаборiв ");
                    lake.WaterIntakeQty = int.Parse(Console.ReadLine());
                    reservoirList.Add(lake);
                }
                //(reservoirList as List<Lake>).Sort(Lake.compareLakesByName);
                //reservoirList.Sort(Lake.compareLakesByBerthsQuality);
                
                for (int j = 0; j < reservoirCount - 1; j++)
                {
                    for (int i = 0; i < reservoirCount - j - 1; i++)
                        if ((new Lake()).compareLakesByBerthsQuality(reservoirList[i] as Lake, reservoirList[i + 1] as Lake) == 1)
                        {
                            Reservoir temp = reservoirList[i];
                            reservoirList[i] = reservoirList[i + 1];
                            reservoirList[i + 1] = temp;
                        }
                }
                for (int j = 0; j < reservoirCount-1; j++) {
                    for(int i = 0; i<reservoirCount - j - 1; i++)
                        if ((new Lake()).compareLakesByName(reservoirList[i] as Lake, reservoirList[i+1] as Lake) == 1)
                        {
                            Reservoir temp = reservoirList[i];
                            reservoirList[i] = reservoirList[i + 1];
                            reservoirList[i + 1] = temp;
                        }
                }
            }
            else if (obj.GetType().ToString() == "Water.Pond")
            {
                for (int i = 0; i < reservoirCount; i++)
                {
                    Console.Write("Введіть назву водойми: ");
                    obj.Name = Console.ReadLine();
                    Console.Write("введiть кiлькiсть мiсць на пляжi ");
                    (obj as IPond).Colvoplaces = int.Parse(Console.ReadLine());
                    Console.Write("введiть рiвень забрудненостi води ");
                    (obj as IPond).Drinkwater = int.Parse(Console.ReadLine());
                    Console.Write("введiть кiлькiсть стереотипних видань ");
                    (obj as IPond).Stereotype = int.Parse(Console.ReadLine());
                    Console.Write("введiть кiлькiсть рокiв видання ");
                    (obj as IPond).Years = int.Parse(Console.ReadLine());
                }
            }

            Console.ReadLine();
            //Console.Wri
            //List<Lake> lakesList = new List<Lake>();
            //// Lake
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Клас Lake");
            //    var lake = new Lake();
            //    Console.Write("введiть назву озера ");
            //    lake.Name = Console.ReadLine();
            //    Console.Write("введiть кiлькiсть причалiв ");
            //    //ILake lake1 = lake as ILake;
            //    //if (lake1 != null)
            //    //{
            //        lake.BerthsQty = int.Parse(Console.ReadLine());
            //        lakesList.Add(lake);
            //    //}
            //}
            //lakesList.Sort(Lake.compareLakesByName);
            //lakesList.Sort(Lake.compareLakesByBerthsQuality);
            for (int i = 0; i < reservoirList.Count; i++)
            {
                Console.WriteLine(reservoirList[i]);
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

        //private void sortReservoirs(int reservoirCount, List<Reservoir> reservoirList, newLake compareLake)
        //{
        //    for (int j = 0; j < reservoirCount - 1; j++)
        //    {
        //        for (int i = 0; i < reservoirCount - j - 1; i++)
        //            if (compareLake.(reservoirList[i] as Lake, reservoirList[i + 1] as Lake) == 1)
        //            {
        //                Reservoir temp = reservoirList[i];
        //                reservoirList[i] = reservoirList[i + 1];
        //                reservoirList[i + 1] = temp;
        //            }
        //    }
        //}
        private static ReservoirCreator chooseClass()
        {
            var tps = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(ReservoirCreator))).ToList();//DefinedTypes.Where(t => t.);
            //
            Console.WriteLine("Classes:");
            for (int i = 0; i < tps.Count(); i++)
            {
                Console.WriteLine($"\t{i+1}. {tps[i].FullName.Split('.')[1].Replace("Creator","")}");
            }
            Console.Write("Choose class:");
            //int classNum = 0;
            if (int.TryParse(Console.ReadLine(), out int classNum) && classNum>0 && classNum <=tps.Count)
            {
                var instance = (ReservoirCreator)Activator.CreateInstance(tps[classNum - 1]);
                Console.WriteLine(instance.ReservoirType);
                return instance;
            }
            Console.WriteLine("\nДані некоректні, введіть знов.");
            return chooseClass();
        }
    }
}