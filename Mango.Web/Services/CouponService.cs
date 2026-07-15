using Mango.Web.Services.IService;
using Mango.Web.Models;
using Mango.Web.Utility;

namespace Mango.Web.Services
{
    public class CouponService : BaseService, ICouponService
    {
        public CouponService(HttpClient httpClient) : base(httpClient)
        {
        }
   
        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = "/api/coupon",
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = $"/api/coupon/{id}",
            });
        }

        public async Task<ResponseDto?> GetCouponByCodeAsync(string code)
        {
            return await SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = $"/api/coupon/GetByCode/{code}",
            });
        }

        public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            return await SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.POST,
                Data = couponDto,
                Url = "/api/coupon",
            });
        }

        public async Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            return await SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.PUT,
                Data = couponDto,
                Url = "/api/coupon",
            });
        }

        public async Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            return await SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.DELETE,
                Url = $"/api/coupon/{id}",
            });
        }
    }
}
