using System;
using System.Collections.Generic;
using System.Globalization;

namespace InheritanceMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {


            List<IRentable> rentable = new List<IRentable>();
            List<IPurchaseable> purchaseable = new List<IPurchaseable>();
            VehicleModel vehicle = new VehicleModel { DealerFee = 25, ProductName = "KIA optima", QuantityInStock = 5, PurchasePrice=5000, RentPrice = 250};
            BookModel book = new BookModel { NumberOfPages = 200, ProductName = "The Power of Now", PurchasePrice=10 };
            ExcavatorModel excavator = new ExcavatorModel { ProductName = "Bull Dozer", QuantityInStock = 15, RentPrice=700};

            rentable.Add(excavator);
            rentable.Add(vehicle);

           purchaseable.Add(vehicle);
            purchaseable.Add(book);

            UserProcess(purchaseable, rentable,  book,excavator, vehicle);

           
        }


        private static void UserProcess(List<IPurchaseable> purchaseable, List<IRentable> rentable, BookModel book, ExcavatorModel excavator, VehicleModel vehicle)
        {
            
            string userChoice = UserInput("Enter 1 to Purchase and 2 to Rent/Return");


            if (userChoice == "1")
            {
                foreach (IPurchaseable purchase in purchaseable)
                {
                    if (purchase is VehicleModel vehicles)
                    {
                        Console.WriteLine($"Product Type = Vehicle \n Product Name : {vehicles.ProductName} \n Dealer Fee :  ${vehicles.DealerFee} \n Price: {vehicles.PurchasePrice} \n QuantityInStock: {vehicles.QuantityInStock}");
                    }
                    if (purchase is BookModel books)
                    {
                        Console.WriteLine($"Product Type = Book \n Product Name : {books.ProductName} \n Dealer Fee :  ${books.NumberOfPages} \n Purchase Price: {books.PurchasePrice} \n QuantityInStock: {books.QuantityInStock}");
                    }
                }
               
                
                string userPurchaseChoice = UserInput("Press 1 To Purchase Book and 2 to Purchase Vehicle ");
                if (userPurchaseChoice == "1")
                {
                    book.Purchase();
                }

                else if (userPurchaseChoice == "2")
                {
                    vehicle.Purchase();
                }
                else
                {
                    Console.WriteLine("Sorry you didnot provided clear information");
                    Console.Clear();
                }
            }

            else if (userChoice == "2")
            {
                foreach (IRentable rent in rentable)
                {
                    if (rent is VehicleModel vehicles)
                    {
                        Console.WriteLine($"Product Type = Vehicle \n Product Name : {vehicles.ProductName} \n Dealer Fee :  ${vehicles.DealerFee}  Price: {vehicles.RentPrice} \n QuantityInStock: {vehicles.QuantityInStock}");
                    }
                    if (rent is ExcavatorModel excavators)
                    {
                        Console.WriteLine($"Product Type = Book \n Product Name : {excavators.ProductName} \n Dealer Fee :  \n Purchase Price: {excavators.RentPrice}  \n QuantityInStock: {excavators.QuantityInStock}");
                    }
                }
               

                string userRentChoice = UserInput("Press 1 To Rent / Return Excavator and 2 to Rent / Return Vehicle ");
                if (userRentChoice == "1")
                {

                    ExcavatorRentReturn(excavator);

                }

                else if (userRentChoice == "2")
                {
                    VehicleRentReturn(vehicle);
                }
                else
                {
                    Console.WriteLine("Sorry you didnot provided clear information");
                    Console.Clear();
                }
            }

            else
            {
                Console.WriteLine("Sorry Please type 1 or 2");
            }
        }


        private static string UserInput(string message)
        {
            Console.WriteLine(message);
            string userChoice = Console.ReadLine();

            return userChoice;
        }

        private static void VehicleRentReturn(VehicleModel vehicle)
        {
            string userVehicleRent = UserInput("Enter 1 to Rent 2 to Return Vehicle");
            if (userVehicleRent == "1")
            {
                vehicle.Rent();
            }
            else if (userVehicleRent == "2")
            {
                vehicle.ReturnRental();
            }
            else
            {
                Console.WriteLine("Sorry u cannot perform this operation");
            }
        }

        private static void ExcavatorRentReturn(ExcavatorModel excavator)
        {
            string userExcavatorRent = UserInput("Enter 1 to Rent 2 to Return Excavator");
            if (userExcavatorRent == "1")
            {
                excavator.Rent();
            }
            else if (userExcavatorRent == "2")
            {
                excavator.ReturnRental();
            }
            else
            {
                Console.WriteLine("Sorry u cannot perform this operation");
            }
        }
    }
}
