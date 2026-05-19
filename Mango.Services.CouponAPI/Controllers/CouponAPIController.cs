using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;

        public CouponAPIController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> couponList = _db.Coupons.ToList();
                return couponList;
            }
            catch (Exception ex)
            {

            }
            return null;
        }


        [HttpGet]
        [Route("{id:int}")]
        public object Get(int id)
        {
            try
            {
                Coupon coupon = _db.Coupons.First(x => x.CouponId == id);
                return coupon;
            }
            catch (Exception ex) 
            {

            }
            return null;
        }
    }
}
