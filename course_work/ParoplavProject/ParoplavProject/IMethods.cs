namespace Water
{
    public interface IMethods
    {
        string Name { get; set; }
        bool IsFishQtyGreaterOrEqualsThan(int qty);
        bool IsNavigable();
    }
}