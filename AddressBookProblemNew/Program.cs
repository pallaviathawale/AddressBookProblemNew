namespace AddressBookProblemNew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("...Welcome to Address Book...");
            AddressBooks Book = new AddressBooks();
            Book.CreateContact();
            Book.EditContact();
            Book.DisplayContact();
            Console.ReadLine();

        }
    }
}