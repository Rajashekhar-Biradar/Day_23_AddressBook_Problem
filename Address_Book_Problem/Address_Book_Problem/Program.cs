using Address_Book_Problem;

Console.WriteLine("---Welcome to your Address Book--");

//creating object person1 of AddressBook Class()
AddressBook1 person1 = new AddressBook1();
while (true)
{
    Console.WriteLine("Choose one operation to perform:\n 1-Add a Contact \n 2-Exit from the Addressbook\n 3-Edit details\n 4-Delete person");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            person1.AddPerson();
            Console.WriteLine("Enter any key to exit");
            break;
        case 2:
            person1.EditPersonDetails();
            Console.WriteLine("Enter any key to exit");
            break;
        case 3:
            person1.Delete_Person_UsingName();
            Console.WriteLine("Enter any key to exit");
            break;
        case 4:
            person1.Add_Multiple_Person();
            Console.WriteLine("Enter any key to exit");
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Please enter a valid input");
            break;
    }
    Console.ReadLine();
}