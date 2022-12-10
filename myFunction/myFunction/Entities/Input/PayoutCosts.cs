namespace myFunction.Entities.Input
{
    public class PayoutCosts
    {
        public int payout_fee_cents { get; set; }
        public int payout_fee_bps { get; set; }
        public int commission_cents { get; set; }
        public int commission_bps { get; set; }
    }
}
