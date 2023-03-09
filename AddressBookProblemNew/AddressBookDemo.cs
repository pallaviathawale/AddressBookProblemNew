using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblemNew
{
    internal class AddressBooks
    {
        List<Contact> addressBookList = new List<Contact>();

        public void CreateContact()
        {
            Contact contacts = new Contact();

            Console.WriteLine("Enter First Name : ");
            contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            contacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");           
            contacts.PhoneNo = Console.ReadLine();
            Console.WriteLine("Enter the Address : ");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter Zip code");
            contacts.ZipCode = Console.ReadLine();
            Console.WriteLine("Enter Email Address");
            contacts.Email = Console.ReadLine();
            Console.WriteLine("Contact created.....");
        }

        public void EditContact()
        {
            Console.WriteLine("Enter the First Name to Check : ");
            string firstName = Console.ReadLine();
            foreach (Contact data in addressBookList)
            {
                if (data.FirstName == firstName)
                {
                    Console.WriteLine("Edit Contact details");
                    Console.WriteLine("\n1.First Name \n2.Last Name \n3.Address \n4.zip Code \n5.Phone Number \n6.Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name : ");
                            data.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Last Name");
                            data.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter Address");
                            data.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter Zip Code");
                            data.ZipCode = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter Phone Number");
                            data.PhoneNo = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter Email");
                            data.Email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Select Correct number");
                            break;
                    }
                    Console.WriteLine("Contact Edited Successfully");
                }
                else
                {
                    Console.WriteLine("No Contact Exists with this First Name : " + firstName);
                }
            }
        }
            public void DisplayContact()
            {
                Console.WriteLine("Contact Details");
                foreach (Contact display in addressBookList)
                {
                    Console.WriteLine(display.FirstName);
                    Console.WriteLine(display.LastName);
                    Console.WriteLine(display.Email);
                    Console.WriteLine(display.PhoneNo);
                    Console.WriteLine(display.Address);
                    Console.WriteLine(display.ZipCode);
                }
            }
        
    }
    }



    
 