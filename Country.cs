using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndSetGet
{
    class Country
    {
        private string firstName;
        private string capital;
        private int population;
        private string currency;

        public string FirstName 
        {
            get {return firstName;}  set { firstName = value.ToUpper(); }
        }
        public string Capital
        {
            get { return capital; } set { capital = value.ToUpper(); }
        }
        public int Population
        {
            get { return population; } set { population = value; }
        }
        public string Currency
        {
            get { return currency; }  set { currency = value; }
        }
    }
}
