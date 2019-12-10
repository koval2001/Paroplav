using System;

namespace Water
{
    public class Reservoir:AboutBook
    {

        protected string name;
        protected int square;//площадь
        protected int number;//количество
        protected double maxDepth;//найбольшая глубина
        protected double weightWater;//масса воды


        public Reservoir()
        { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //конструктор класса
        public Reservoir(int square, int number, double maxDepth, double weightWater)
        {
            this.square = square;
            this.number = number;
            this.maxDepth = maxDepth;
            this.weightWater = weightWater;
        }

        //методы класса
        public virtual double AverageDepth()//вычисление средней глубины
        {
            return this.maxDepth / 2;
        }
        /// <summary>
        /// масса воды меньше 1000?
        /// </summary>
        /// <returns></returns>
        public bool WaterAnalise()
        {
            if (weightWater < 1000)
                return false;
            else
                return true;
        }

        /// <summary>
        /// количество речек, что впадают
        /// </summary>      
        public string NumberRivers()
        {
            if (number <= 0)
                return "у це водоймище рiчки не впадають";
            else
                return "кiлькiсть рiчок, що впадає у це водоймище = " + number.ToString();
        }

        //свойства класса
        public double MaxDepth
        {
            get { return this.maxDepth; }
            set { this.maxDepth = value; }
        }
        public int Square
        {
            get { return this.square; }
            set { this.square = value; }
        }
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public double WeightWater
        {
            get { return this.weightWater; }
            set { this.weightWater = value; }
        }

        public override float PartOfTheyearWhenThereIsNoIce()
        {
            return new TimeSpan(365, 0, 0, 0).Milliseconds / (float)IceingTime.Milliseconds;
        }

        public int compareByRiverNumber(Reservoir l1, Reservoir l2)
        {
            return l1.Number.CompareTo(l2.Number);
        }

        public int compareByName(Reservoir l1, Reservoir l2)
        {
            return l1.Name.CompareTo(l2.Name);
        }
        public int compareBySquare(Reservoir l1, Reservoir l2)
        {
            return l1.Square.CompareTo(l2.Square);
        }
    }
}