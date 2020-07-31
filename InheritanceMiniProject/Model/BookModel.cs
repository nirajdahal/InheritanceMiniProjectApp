using System;

namespace InheritanceMiniProject
{
    public class BookModel : InventoryItemModel, IPurchaseable
    {
        public int NumberOfPages { get; set; }
        public int PurchasePrice { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("Thank you for buyiing this book");
        }
    }
}
