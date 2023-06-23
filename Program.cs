using System;
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        PhoneBook newPhoneBook = new PhoneBook();
        newPhoneBook.menu();
    }

}
class PhoneBook
{
    public Hashtable phonebook ;
    public PhoneBook() {
        phonebook = new Hashtable();

    }
    public void addContact()
    {
        Console.WriteLine("Enter the name of the person");
        string personName=Console.ReadLine();
        Console.WriteLine("Enter the phonenumber of the person");
        int phonenumber = int.Parse(Console.ReadLine());
        phonebook.Add(personName, phonenumber);
        menu();
    }
    public void menu()
    {
        Console.WriteLine("WELCOME TO OUR PHONEBOOK");
        Console.WriteLine("Choose an operation to perform");
        Console.WriteLine("1:Add contacts");
        Console.WriteLine("2:View Contacts");
        Console.WriteLine("3:Search contacts");
        Console.WriteLine("4:Exit App");
        int menuInput = int.Parse(Console.ReadLine());
        switch (menuInput)
        {
            case 1:
                addContact(); 
                break;
            case 2:
                viewContacts();
                break;
            case 3:
                searchContact();
                break;
            case 4:
                exitApp();
                break;
            default:
                Console.WriteLine("Please try again");
                break;
        }
    }
    public void viewContacts()
    {
        foreach(string name  in phonebook.Keys)
        {
            Console.WriteLine($"{name} {phonebook[name]}");
        }
    }
    public void searchContact()
    {
        Console.WriteLine("Enter a name to search contacts");
        string searchTerm = Console.ReadLine();
        bool searchResults = phonebook.ContainsKey(searchTerm);
        if (searchResults)
        {
            Console.WriteLine($"{searchResults} phoneNumber:{phonebook[searchResults]}");
        }
        else
        {
            Console.WriteLine("Contact doesnt exist");
        }
    }
    public void exitApp()
    {
        Console.WriteLine("Enter any key to exit");
        Console.ReadKey();
    }
}