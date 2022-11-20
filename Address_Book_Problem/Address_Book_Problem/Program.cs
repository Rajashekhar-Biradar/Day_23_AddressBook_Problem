
using Address_Book_Problem;

Console.WriteLine("---Welcome to your Address Book--");

//creating object person1 of AddressBook Class()

while (true)
{
    Console.WriteLine("Choose one operation to perform:\n 1-Add a Contact \n 2-Exit from the Addressbook");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            AddressBook1.AddPerson();
            Console.WriteLine("Enter any key to exit");
            break;
        case 2:
            return;
        default:
            Console.WriteLine("Please enter a valid input");
            break;
    }
    Console.ReadLine();
}