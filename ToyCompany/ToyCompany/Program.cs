using System;
using ToyCompany.Models;

namespace ToyCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the portal");


            Program p = new Program();
            int choice;
            string Name, Password;
            using (var toyapp = new ToyContext())
            {
                do
                {
                    Console.WriteLine("Choose Option as \n\n 1. Compoany Admin \n 2. Customer\n 3. Exit ");
                    
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter  Name:");
                            Name = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            Password = Console.ReadLine();
                            if (Name == "admin" && Password == "admin")
                            {
                                p.Admin();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Cridentials");
                                break;
                            }

                        case 2:
                           p.Customer();
                            break;
                        case 3:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                } while (choice != 3);
            }

        }



        public void Admin()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Add Toy Category \n2. Add Toy\n3. Add Scheme \n4. Exit");
                Console.WriteLine("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCategory();
                        break;
                    case 2:
                       AddToy();
                        break;
                    
                    case 3:
                       AddScheme();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
            while (choice != 4);

        }

        public void Customer()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Signup \n2. Login \n3. Exit");
                Console.WriteLine("Enter Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice\n");
                        break;

                }
            }
            while (choice != 4);
        }


        public void AddCategory()
        {
            using (var toyapp = new ToyContext())
            {
                string CategoryName;
                Console.WriteLine("\nEnter CategoryName :-");

                CategoryName = Console.ReadLine();
                var category = new Category
                {
                    CategoryName = CategoryName,
                };
               toyapp.Categories.Add(category);
                toyapp.SaveChanges();

                Console.WriteLine("\nAdded Successfully\n");
            }

        }

        void AddToy()
        {
            using (var toyapp = new ToyContext())
            {
                Console.Write("\nEnter Toy Name : ");
                var toyName = Console.ReadLine();

                Console.WriteLine("\nWrite Description :-");
                var description = Console.ReadLine();

                Console.WriteLine("\nEnter Price :-");
                var price = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nEnter category id :-");
                var catId = Convert.ToInt32(Console.ReadLine());


                Toy toy = new Toy(toyName, description,price,catId);
                try
                {
                    toyapp.Toys.Add(toy);
                    toyapp.SaveChanges();
                    Console.WriteLine("\nAdded Successfully\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }






        void AddScheme()
        {
            using (var toyapp = new ToyContext())
            {
                Console.Write("\nEnter Scheme Name :- ");
                var schemeName = Console.ReadLine();

                Console.WriteLine("\nEnter Description :-");
                var description = Console.ReadLine();

                Console.WriteLine("\nEnter offeramount :- ");
                var offer = Convert.ToInt32(Console.ReadLine());

                Scheme scheme= new Scheme(schemeName, description, offer);
                try
                {
                    toyapp.Schemes.Add(scheme);
                    toyapp.SaveChanges();
                    Console.WriteLine("\nAdded Successfully\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }


        void Register()
        {
            using (var toyapp = new ToyContext())
            {
                Console.Write("\nCustomer Name :-");
                var name = Console.ReadLine();

                Console.WriteLine("\nEnter Email :-");
                var email = Console.ReadLine();

                Console.WriteLine("\nEnter Mobile Number.");
                var mobile = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter  Password.");
                var password = Console.ReadLine();

                Customer customer = new Customer(name, email,mobile ,password);
                try
                {
                    toyapp.Costomers.Add(customer);
                    toyapp.SaveChanges();
                    Console.WriteLine("\nAdded Successfully\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }


        /*
        void PlaceOrder()
        {
            using (var toyapp = new ToyContext())
            {
                Console.Write("\nEnter Toy Name : ");
                var toyName = Console.ReadLine();

                Console.WriteLine("\nWrite Description :-");
                var description = Console.ReadLine();

                Console.WriteLine("\nEnter Quantity :-");
                var qty = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nEnter category id :-");
                var catId = Convert.ToInt32(Console.ReadLine());


                Order order = new Order(toyName,, price, catId);
                try
                {
                    toyapp.Toys.Add(toy);
                    toyapp.SaveChanges();
                    Console.WriteLine("\nAdded Successfully\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        */

        void Login()
        {
            Console.WriteLine("\nEmail");
            string name = Console.ReadLine();

            Console.WriteLine("\nEmail Password ");
            string psssword = Console.ReadLine();

        }



    }
}
