namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string InventoryName { get; set; } = string.Empty; // we never want this to be null so we initialize with empty string
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
