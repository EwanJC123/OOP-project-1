using System;

namespace OOP_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;
            int vote = 0;
            Boolean partic = true;
            Country[] europeCouncil = new Country[27];
            europeCouncil = generateEuCountries(europeCouncil);

           while (true)
            {
                userChoice = Menu();
                if (userChoice == 1)
                {
                    foreach (Country x in europeCouncil)
                    {
                        if (x.Participating == true)
                        {
                            Console.WriteLine("How will {0} be voting? 0 for abstain, 1 for yes, 2 for no", x.CountryName);
                            vote = Convert.ToInt32(Console.ReadLine());
                            x.CountryVote = vote;

                        }
                        else
                            Console.WriteLine("{0} is not participating", x.CountryName);

                    }
                }
                else if (userChoice == 2)
                {
                    foreach (Country x in europeCouncil)
                    {
                        Console.WriteLine("Will {0} be participating?", x.CountryName);
                        partic = Convert.ToBoolean(Console.ReadLine());
                        x.Participating = partic;
                    }
                   
                }
                else if (userChoice == 3)
                {
                    europeCouncil = generateEuCountries(europeCouncil);
                    Console.WriteLine("Council has been reset");
                }
                else if (userChoice == 4)
                {
                    //this will currently only work with an all states voting policy as the manipulation of population size and member state reduction has not been implemented
                    float sumTotalPercentage = 0;
                    int sumTotalMemberStates = 0;


                    foreach(Country x in europeCouncil)
                    {
                        if (x.Participating == true)
                        {
                            if (x.CountryVote == 1)
                            {
                                sumTotalMemberStates += 1;
                                sumTotalPercentage += x.CountryPop;

                            }
                           
                        }
                    }
                    if (sumTotalMemberStates>=15 || sumTotalPercentage>=65)
                    {
                        Console.WriteLine("This vote has passed");
                    }
                    else
                    {
                        Console.WriteLine("This vote has failed");
                    }
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine("Thank you for using the program!");
                    System.Environment.Exit(0);
                 
                }
                 
            }
          
            








        }




        static int Menu()
        {
            int userChoice = 0;
            Boolean x = true;
            while (x == true)
            {
                Console.WriteLine("Welcome To The European Council!");
                Console.WriteLine("Choose Option:");
                Console.WriteLine("1. Vote On Agenda");
                Console.WriteLine("2. Change Participants");
                Console.WriteLine("3. Reset Votes");
                Console.WriteLine("4. Display Results");
                Console.WriteLine("5. Exit Program");
                Console.WriteLine("Choice:");
                userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice > 5 || userChoice < 1)
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
            set {

                if (value == true || value == false)
                {
                    _participating = value;
                }
                else
                    Console.WriteLine("Participating can only be true or false");
                }
        }
        public int CountryVote
        {
            get { return _CountryVote; }
            set {

                if (value >= 0 && value <= 2)
                {
                    _CountryVote = value;
                }
                else
                    Console.WriteLine("Country Vote can only be equal to 0,1 or 2");
            }
                
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


  
}

    