using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AFP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> Users = new List<Person>();
            Users.Add(new Person { Id = 1, Name = "Amirhossein Hashemi", Age = 22 });
            Users.Add(new Person { Id = 2, Name = "Mohammdreza Zargarzade", Age = 20 });
            Users.Add(new Person { Id = 3, Name = "Mohammadjavad Abasipor", Age = 21 });
            Users.Add(new Person { Id = 4, Name = "Hossein Naderi", Age = 20 });
            Users.Add(new Person { Id = 5, Name = "Fatemeh Mohammadhasani", Age = 20 });
            Users.Add(new Person { Id = 6, Name = "Mahsaa Zia", Age = 21 });
            Users.Add(new Person { Id = 7, Name = "Nasim Kiani", Age = 20 });
            Users.Add(new Person { Id = 8, Name = "Zahra Salamipor", Age = 21 });
            Users.Add(new Person { Id = 9, Name = "Fatemeh Rahnama", Age = 20 });

            while (true)
            {


                Console.WriteLine("Please enter the code assigned to your preferred action.");
                Console.WriteLine("To show all current users ( Code 1 )");
                Console.WriteLine("To add a new user ( Code 2 )");
                Console.WriteLine("To change a user data ( Code 3 )");
                Console.WriteLine("To delete a user ( Code 4 )");
                Console.WriteLine("To exit the program completely ( Code 5 )");
                string MaineResponse = Console.ReadLine();

                switch (MaineResponse)
                {
                    case "1":
                        if (Users.Count == 0)
                        {
                            Console.WriteLine("There are no seres to show");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Users are:");
                            foreach (var person in Users)
                            {
                                Console.WriteLine($"UserId: {person.Id} , UserName: {person.Name} , UserAge: {person.Age}");
                            }
                            Console.WriteLine();



                        }

                        break;
                    case "2":
                        Console.WriteLine("To add a new user please ");
                        Console.WriteLine("Enter the user Id:");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the user Name");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter The User Age");
                        int Age = Convert.ToInt32(Console.ReadLine());
                        Person NewUsers = new Person
                        {
                            Id = Id,
                            Name = Name,
                            Age = Age

                        };
                        Users.Add(NewUsers);
                        Console.WriteLine("User was added successfully");


                        break;

                    case "3":
                        Console.WriteLine("To change the user data please enter it's Id:");
                        int UserId = Convert.ToInt32(Console.ReadLine());
                        var UserIdFounded = Users.Find(x => x.Id == UserId);
                        Console.WriteLine($"Id : {UserIdFounded.Id} \nName : {UserIdFounded.Name} \nAge : {UserIdFounded.Age}");
                        Console.WriteLine("Which of the following data do you want to change the Name ( Code 1 ) or the Age ( Code 2 )");
                        string Response = Console.ReadLine();
                        switch (Response)
                        {
                            case "1":
                                Console.WriteLine("New name :");
                                string NewName = Console.ReadLine();
                                UserIdFounded.Name = NewName;
                                Console.WriteLine($"Id : {UserIdFounded.Id} \nName : {UserIdFounded.Name} \nAge : {UserIdFounded.Age}");

                                break;

                            case "2":

                                Console.WriteLine("New age :");
                                int NewAge = Convert.ToInt32(Console.ReadLine());
                                UserIdFounded.Age = NewAge;
                                Console.WriteLine($"Id : {UserIdFounded.Id} \nName : {UserIdFounded.Name} \nAge : {UserIdFounded.Age}");

                                break;

                        }
                        break;

                    case "4":

                        Console.WriteLine("Please enter the user Id that you want to be deleted");
                        int UserToBeRemoved = Convert.ToInt32(Console.ReadLine());
                        Person UserRemoved = Users.Find(x => x.Id == UserToBeRemoved);
                        if (UserRemoved != null)
                        {
                            Console.WriteLine($"Are you sure you want to delet this user?");
                            Console.WriteLine($"\nId: { UserRemoved.Id} \nName: { UserRemoved.Name} \nAge: { UserRemoved.Age}");
                            Console.WriteLine();
                            Console.WriteLine("For YES please enter ( 1 ) and for NO please enter ( 2 )");
                            string Redponse = Console.ReadLine();
                            switch (Redponse) {
                                case "1":
                                    Users.Remove(UserRemoved);
                                    Console.WriteLine($"User with the following data was was successfully removed \nId : {UserRemoved.Id} \nName : {UserRemoved.Name} \nAge : {UserRemoved.Age}");
                                    Console.WriteLine();

                                    break;
                            
                            
                                    case "2":

                                    Console.WriteLine("You will be redirected to the home page.");
                                    Console.WriteLine();    
                                    
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("There is no user with such Id");

                        }
                        break;

                    
                    
                    case "5":


                        Environment.Exit(0);
                        break;

                }
                
                Console.ReadKey();

            }

        }
    }
}
