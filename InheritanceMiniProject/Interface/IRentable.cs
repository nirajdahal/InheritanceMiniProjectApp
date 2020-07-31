namespace InheritanceMiniProject
{
    public interface IRentable
    {
        int RentPrice { get; set; }
        void Rent();
        void ReturnRental();
    }
}
