using System;

namespace paroplav
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//Reservoir res = new Reservoir(1050, 0, 100, 50000);
			Reservoir res = new Reservoir();
			Console.Write("введiть площу водоймища(м.кв.) ");
			res.Square = int.Parse(Console.ReadLine());
			Console.Write("введiть кiлькiсть впадаючих рiчок ");
			res.Number = int.Parse(Console.ReadLine());
			Console.Write("введiть найбiльшу глибину(м.) ");
			res.MaxDepth = double.Parse(Console.ReadLine());
			Console.Write("введiть масу води(кг.) ");
			res.WeightWater = double.Parse(Console.ReadLine());


			Console.WriteLine("");
			Console.WriteLine("середня глибина водоймища = " + res.AverageDepth() + "(м.)");
			if (res.WaterAnalise())
				Console.WriteLine("маса води бiльша нiж 1000(кг.)");
			else
				Console.WriteLine("маса води менша нiж 1000(кг.)");

			Console.WriteLine(res.NumberRivers());

			// Lake
			//Console.WriteLine("Клас Lake");
			//var lake = new Lake();
			//Console.Write("введiть кiлькiсть причалiв ");
			//lake.BerthsQty = int.Parse(Console.ReadLine());

			//Pond
			//var pond = new Pond();



			Console.ReadLine();
		}
	}
}
