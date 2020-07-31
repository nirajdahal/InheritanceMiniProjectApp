using System;

namespace InheritanceMiniProject
{
    public class VehicleModel : InventoryItemModel, IRentable, IPurchaseable
    {
        public decimal DealerFee { get; set; }
        public int RentPrice { get; set; }
        public int PurchasePrice { get; set; }

        public void Purchase()
        {
            if (QuantityInStock == 0)
            {
                Console.WriteLine("Sorry There is No Vehicle Left for Purchase");
            }
            else
            {
                QuantityInStock -= 1;
                Console.WriteLine("You have Purchased the vehicle");

            }
        }

        public void Rent()
        {
            if (QuantityInStock == 0)
            {
                Console.WriteLine("Sorry There is No Vehicle Left for Rent");
            }
            else
            {
                QuantityInStock -= 1;
                Console.WriteLine("You have Rented the vehicle");

            }
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("You have Returned the vehicle");
        }
    }
}
