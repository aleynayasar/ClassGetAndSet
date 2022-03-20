using System;

namespace ClassAndSetGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country();
            country.FirstName = "Semih";
            country.Capital = "Turkey";
            country.Population = 850000; 
            country.Currency = "TL";

            Console.WriteLine("First Name : "+ country.FirstName);
            Console.WriteLine("The Capital : " + country.Capital);
            Console.WriteLine("The Population : " + country.Population);
            Console.WriteLine("Currency  : " + country.Currency);


            Console.ReadKey();
           
        }
    }
}
