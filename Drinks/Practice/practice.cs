using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Practice
{
    internal class practice
    {
        public record Person
            (
       string FirstName,
       string LastName,
       int Age,
       ImmutableList<string> Friends
            );
        public static ImmutableList<Person> Friends = [
            new ("Enosh", "Tsur", 34, ["Igal", "Tom", "Shay", "Smbat"]),
       new ("Shay", "Peleg", 34, ["Igal", "Enosh", "Denis", "Guy"]),
       new ("Igal", "Groisman", 28, ["Enosh", "Shay", "Denis", "Anton"]),
       new ("Lior", "Orshter", 30, ["Matan", "Noa", "Igal", "Ran"]),
       new ("Ran", "Edri", 36, ["Enosh", "Lior", "Dorin", "Anna"])
        ];

        public static string GetFullName(string firstName) =>
             Friends.Where(fr => fr.FirstName == firstName)
                .Select(fr => $"{fr.FirstName} {fr.LastName}").FirstOrDefault() ?? "notfound";
        //Person pe = Friends.FirstOrDefault(fr => fr.FirstName == firstName);
        //return $"{pe.FirstName} {pe.LastName}";

        public static Person GetOldest() =>
            Friends.OrderByDescending(fr => fr.Age).FirstOrDefault();

        public static ImmutableList<(string fullName,int count)> numList() =>
               Friends.Select(fr => myTupl(fr)).ToImmutableList();
             
        public static (string fullName, int count) myTupl(Person fr) =>
            (fullName: $"{fr.FirstName} {fr.LastName}", count: fr.Age);



        //public static ImmutableList<Person> unicNames() =>
            //Friends.Aggregate(ImmutableList<Person> (res,p) => 
            //List.FirstOrDefault(per => per.FirstName == p.FirstName) == null ?res.Add(p) : res)
            //.ToImmutableList();
        //Friends.Select(p => p.FirstName)
        //.Distinct()
        //.ToImmutableList();


        //public static Dictionary<int, ImmutableList<Person>> dictAge() =>







    }
}
