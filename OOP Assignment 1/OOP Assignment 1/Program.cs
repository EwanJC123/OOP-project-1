using System;

namespace OOP_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
          int userChoice = 0;
            Country[] europeCouncil = new Country[27];
            europeCouncil = generateEuCountries(europeCouncil);
            foreach(Country x in europeCouncil)
            {
                Console.WriteLine(x.CountryName);
            }

          while (true)
            {
              userChoice = Menu();
              if (userChoice==1)
              {

              }
              if (userChoice == 2)
              {

                }
              if (userChoice == 3)
              {

              }
              if (userChoice == 4)
              {
                    System.Environment.Exit(1);
              }
            }
            








        }




        static int Menu()
        {
            int userChoice = 0;
            Boolean x = true;
            while (x == true)
            {
                Console.WriteLine("Choose Option:");
                Console.WriteLine("1. Vote On Agenda");
                Console.WriteLine("2. Reset Votes");
                Console.WriteLine("3. Display Results");
                Console.WriteLine("4. Exit Program");
                Console.WriteLine("Choice:");
                userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice > 4 || userChoice < 1)
                {
                    Console.WriteLine("Please use a valid input");
                }
                else
                {
                    x = false;
                }

            }

            return userChoice;
        }


        static Country[] generateEuCountries(Country[] arr)
        {
            Country[] euCountries = new Country[27];
            euCountries[0] = new Country("Austria", (1.98f));
            euCountries[1] = new Country("Belgium", (2.56f));
            euCountries[2] = new Country("Bulgaria", (1.56f));
            euCountries[3] = new Country("Croatia", (0.91f));
            euCountries[4] = new Country("Cyprus", (0.20f));
            euCountries[5] = new Country("Czech Republic", (2.35f));
            euCountries[6] = new Country("Denmark", (1.30f));
            euCountries[7] = new Country("Estonia", (0.30f));
            euCountries[8] = new Country("Finland", (1.23f));
            euCountries[9] = new Country("France", (14.98f));
            euCountries[10] = new Country("Germany", (18.54f));
            euCountries[11] = new Country("Greece", (2.40f));
            euCountries[12] = new Country("Hungary", (2.18f));
            euCountries[13] = new Country("Ireland", (1.10f));
            euCountries[14] = new Country("Italy", (13.65f));
            euCountries[15] = new Country("Latvia", (0.43f));
            euCountries[16] = new Country("Lithuania", (0.62f));
            euCountries[17] = new Country("Luxembourg", (0.14f));
            euCountries[18] = new Country("Malta", (0.11f));
            euCountries[19] = new Country("Netherlands", (3.89f));
            euCountries[20] = new Country("Poland", (8.49f));
            euCountries[21] = new Country("Portugal", (2.30f));
            euCountries[22] = new Country("Romania", (4.34f));
            euCountries[23] = new Country("Slovakia", (1.22f));
            euCountries[24] = new Country("Slovenia", (0.47f));
            euCountries[25] = new Country("Spain", (10.49f));
            euCountries[26] = new Country("Sweden", (2.29f));
            return euCountries;
        }



}




    class Country
    {
        private string _CountryName;
        private float _CountryPop;
        private bool _participating;
        private int _CountryVote;
        

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
        public bool Participating
        {
            get { return _participating; }
            set { _participating = value; }
        }
        public int CountryVote
        {
            get { return _CountryVote; }
            set { _CountryVote = value; }
        }


        //country constructor
        public Country(string cName, float pop)
        {
            _CountryName = cName;
            _CountryPop = pop;
            _participating = true;
            _CountryVote = 0;
        }
        
    }


    class EUCouncil
    {
       // Country[] euCountries = new Country[27];
       // euCountries[0] = new Country("Austria", (1.98f));
       
    }

}

    