namespace Supermarket.Model.Checkout
{
    public class VATLine
    {
        public int Rate { get; set; }
        public decimal Amount { get; set; }

        public override string ToString() => $"VAT {Rate/100:P0}: {Amount:C}";
    }
}