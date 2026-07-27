using Microsoft.AspNetCore.Mvc;
using Mango.Web.Services.IService;
using Mango.Web.Models;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;

        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()    
        {
            List<CouponDto> couponList = new List<CouponDto>();
            
            ResponseDto? responseDto = await _couponService.GetAllCouponsAsync();
            
            if (responseDto != null && responseDto.IsSuccess)
            {
                couponList = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(responseDto.Result));
            }

            return View(couponList);
        }
    }
}
