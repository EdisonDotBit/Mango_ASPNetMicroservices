namespace Mango.Services.CouponAPI.Models.Dto
{
    public class CouponDto
    {
        public int CoouponId { get; set; }
        public string CouponCode { get; set; }
        public int DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
