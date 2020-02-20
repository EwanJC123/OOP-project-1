using System;

namespace OOP_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Country Austria = new Country("Austria", (1.98f));
            Console.WriteLine(Austria.CountryName);
            Console.WriteLine(Austria.CountryPop);


        }
    }



    class Country
    {
        private string _CountryName;
        private float _CountryPop;

        public string CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }

        public float CountryPop
        {
            get { return _CountryPop; }
            set { _CountryPop = value; }

        }


        //country constructor
        public Country(string cName, float pop)
        {
            _CountryName = cName;
            _CountryPop = pop;
        }
        
    }


}

    