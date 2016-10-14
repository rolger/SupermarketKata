namespace Supermarket.Model.Core
{
    public class Product
    {
        public EAN Number { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int VATRate { get; set; }
        public Discount Discount { get; set; }

        public override string ToString() => $"{Name} {UnitPrice:C}";
    }
}