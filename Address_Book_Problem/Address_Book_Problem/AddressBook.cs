
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Address_Book_Problem
{
    internal static class AddressBook1
    {
        public static void AddPerson()
        {
            List<Contacts> personDetails = new List<Contacts>();

            Contacts person = new Contacts();
            //
            Console.WriteLine("enter first name");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("enter last name");
            person.LastName = Console.ReadLine();
            Console.WriteLine("enter Address");
            person.Address = Console.ReadLine();
            Console.WriteLine("enter city name");
            person.City = Console.ReadLine();
            Console.WriteLine("enter state name");
            person.state = Console.ReadLine();
            Console.WriteLine("enter Zip Code");
            person.ZipCode = Console.ReadLine();
            Console.WriteLine("enter Phone number");
            person.PhNo = Console.ReadLine();
            Console.WriteLine("enter Email");
            person.Email = Console.ReadLine();
            personDetails.Add(person);


        }
    }
}