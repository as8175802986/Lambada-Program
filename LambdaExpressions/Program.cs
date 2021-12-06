using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("list person in the city ");
            // UC 1
            List<Persons> listPersonInCity = new List<Persons>();
            AddRecords(listPersonInCity);
            //RetrivingTopTwoRecords_ForAgeIs_LessThanSixty(listPersonInCity);
            //CheckingForTeenage(listPersonInCity);
        }
        //UC 1
        private static void AddRecords(List<Persons> listPersonInCity)
        {
            listPersonInCity.Add(new Persons("8184654413", "Aman", "sector 62, Noida" ,23));
            listPersonInCity.Add(new Persons("5237946125", "Shivam", "Sector 22,Noida", 25));
            listPersonInCity.Add(new Persons("1329567329", "Anirudh", "Pari Chowk , G.Noida" ,24));
            listPersonInCity.Add(new Persons("1963584625", "Shiv", "xyz,lucknow",28));
            listPersonInCity.Add(new Persons("3265795431", "Anshu", "sector 52,noida",26));
            listPersonInCity.Add(new Persons("8184654413", "vikas", "sector 122, Noida", 65));
            listPersonInCity.Add(new Persons("5237946125", "Ashi", "Sector 22,Noida", 55));
            listPersonInCity.Add(new Persons("1329567329", "Devesh", "Pari Chowk , G.Noida", 15));
            listPersonInCity.Add(new Persons("1963584625", "Parth", "xyz,lucknow", 38));
            listPersonInCity.Add(new Persons("3265795431", "Rakesh", "sector 52,noida", 46));
        }
       
    }
}
