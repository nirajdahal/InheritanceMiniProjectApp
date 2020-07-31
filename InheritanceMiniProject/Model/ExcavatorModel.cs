using System;

namespace InheritanceMiniProject
{
    public class ExcavatorModel: InventoryItemModel, IRentable
    {
        public int RentPrice { get; set; }
        public void Dig()
        {
            Console.WriteLine("I am digging");
        }

        public void Rent()
        {
            if (QuantityInStock == 0)
            {
                Console.WriteLine("Sorry There is No other Excavator left for rental");
            }
            else
            {
                QuantityInStock -= 1;
                Console.WriteLine("This excavator has been rented");
            }
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("The excavator has been returned");
        }
    }
}
