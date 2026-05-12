namespace Mango.Services.CouponAPI.Models
{
    public class Coupon
    {
        public int CoouponId { get; set; }
        public string CouponCode { get; set; }
        public int DiscountAmount { get; set; }
        public int MinAmount { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
