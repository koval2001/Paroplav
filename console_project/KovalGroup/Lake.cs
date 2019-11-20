using System;

namespace KovalGroup
{
    public class Lake : Reservoir, IMethods
    {
        protected int _berthsQty; // Кол-во пристаней
        protected int _boggingLevel; // Уровень заболочености
        protected int _saltFactor; // Коэфициент солености
        protected int _waterIntakeQty; // Кол-во водозаборов
        protected string _name; //Имя озера

        public Lake()
        {
        }

        /// <summary>
        /// конструктор класса
        /// </summary>
        /// <param name="berthsQty">Кол-во пристаней</param>
        /// <param name="boggingLevel">Уровень заболочености</param>
        /// <param name="saltFactor">Коэфициент солености</param>
        /// <param name="waterIntakeQty">Кол-во водозаборов</param>
        public Lake(string lakeName, int berthsQty, int boggingLevel, int saltFactor, int waterIntakeQty)
        {
            _berthsQty = berthsQty;
            _boggingLevel = boggingLevel;
            _saltFactor = saltFactor;
            _waterIntakeQty = waterIntakeQty;
            _name = lakeName;
        }

        public override string ToString()
        {
            return "Озеро " + Name + ". Кількість причалів на ньому = " + Convert.ToString(BerthsQty);
        }

        //свойства класса
        /// <summary>
        /// Соленое ли?
        /// </summary>
        public bool IsSalt { get { return _saltFactor > 0; } }

        /// <summary>
        /// Есть ли пристани?
        /// </summary>
        public bool HasBerts { get { return _berthsQty > 0; } }

        /// <summary>
        /// Кол-во пристаней
        /// </summary>
        public int BerthsQty
        {
            get { return _berthsQty; }
            set { _berthsQty = value; }
        }

        /// <summary>
        /// Уровень заболочености
        /// </summary>
        public int BoggingLevel
        {
            get { return _boggingLevel; }
            set { _boggingLevel = value; }
        }

        /// <summary>
        /// Коэфициент солености
        /// </summary>
        public int SaltFactor
        {
            get { return _saltFactor; }
            set { _saltFactor = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Кол-во водозаборов
        /// </summary>
        public int WaterIntakeQty
        {
            get { return _waterIntakeQty; }
            set { _waterIntakeQty = value; }
        }

        //методы класса
        /// <summary>
        /// Достигает ли численность рыб заданного значения?
        /// </summary>
        /// <param name="qty">Значение</param>
        /// <returns></returns>
        public bool IsFishQtyGreaterOrEqualsThan(int qty)
        {
            return qty > 0; // no data
        }

        /// <summary>
        /// Судоходное ли?
        /// </summary>
        /// <returns></returns>
        public bool IsNavigable()
        {
            throw new NotImplementedException("Interface must be fully implemented!!!");
        }

        /// <summary>
        /// Кол-во рейсов двух пароходов
        /// </summary>
        /// <returns></returns>
        public int VoyagesPerMonth()
        {
            return _berthsQty * 2 * 30;
        }

        /// <summary>
        /// Качество воды по уровню солености
        /// </summary>
        /// <returns></returns>
        public int WaterQuality()
        {
            return 100 - _saltFactor;
        }

        /// <summary>
        /// Сравнение качества воды в разных экземплярах класса Lake
        /// </summary>
        /// <param name="l1">Озеро 1</param>
        /// <param name="l2">Озеро 2</param>
        /// <returns>-1, если качество воды во втором озере лучше; 0, если качество воды одинаково; 1, если в первом озере качество воды лучше</returns>

        // how to use compareLakesBy... functions:
        // 1. create list of class Lake:
        //      List<Lake> lakesList;
        // ***some info about how does List<T> work: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8***
        // 2. when you have to sort it:
        //      lakesList.Sort(Lake.compareLakesBy...*variants are under*...)


        static public int compareLakesByWaterIntakeQuality(Lake l1, Lake l2)
        {
            return l1.WaterIntakeQty.CompareTo(l2.WaterIntakeQty);
        }

        static public int compareLakesByBerthsQuality(Lake l1, Lake l2)
        {
            return l1.BerthsQty.CompareTo(l2.BerthsQty);
        }

        static public int compareLakesByBoggingLevel(Lake l1, Lake l2)
        {
            return l1.BoggingLevel.CompareTo(l2.BoggingLevel);
        }

        static public int compareLakesBySaltFactor(Lake l1, Lake l2)
        {
            return l1.SaltFactor.CompareTo(l2.SaltFactor);
        }

        static public int compareLakesByName(Lake l1, Lake l2)
        {
            return String.Compare(l1.Name, l2.Name);//l1.Name.CompareTo(l2.Name);
        }

        /// <summary>
        /// Есть ли среди речек Синяя?
        /// </summary>
        /// <returns></returns>
        public bool HasBlueRiver()
        {
            return true; // no data
        }

        /// <summary>
        /// Исчесление средней глубины по сезонам
        /// </summary>
        /// <returns></returns>
        public override double AverageDepth()
        {
            return base.AverageDepth() + ((int)((DateTime.Today.AddMonths(-2).Month + 2) / 3) * .2);
        }


    }
}