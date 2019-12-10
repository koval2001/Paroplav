using System;

namespace Water
{
    public class Pond : Reservoir, IMethods, IPond
    {
        protected int _colvoplaces; // Кол-во пристаней
        protected int _drinkwater; // Уровень заболочености
        protected int stereotype; // Коэфициент солености
        protected int years; // Кол-во водозаборов
	
        public Pond()
        {
        }

        public Pond(int colvoplaces, int years, int drinkwater, int stereotype)
        {
            _colvoplaces = colvoplaces;
            _drinkwater = drinkwater;
            Stereotype = stereotype;
            Years = years;
        }

        public bool IsDrink { get { return Drinkwater > 0; } }

        public bool HasStereotype { get { return Stereotype > 0; } }

//        public string Name { get { return name; } set { name = value; } }

        public int Colvoplaces
        {
            get { return _colvoplaces; }
            set { _colvoplaces = value; }
        }

        public int Drinkwater
        {
            get { return _drinkwater; }
            set { _drinkwater = value; }
        }

        public int Years
        {
            get { return years; }
            set { years = value; }
        }

        public int Stereotype
        {
            get { return stereotype; }
            set { stereotype = value; }
        }

        public int squar(int sq)
        {
            return sq /2;
        }

        public double fishweight(double wwater)
        {
            return wwater/25;
        }

        public override float PartOfTheyearWhenThereIsNoIce()
        {
            return base.PartOfTheyearWhenThereIsNoIce();
        }

        bool IMethods.IsFishQtyGreaterOrEqualsThan(int qty)
        {
            return qty > 0;
            throw new NotImplementedException();
        }

        bool IMethods.IsNavigable()
        {
            throw new NotImplementedException();
        }
    }
}