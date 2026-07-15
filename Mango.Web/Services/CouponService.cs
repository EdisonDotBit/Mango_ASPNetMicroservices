using Mango.Web.Services.IService;
using Mango.Web.Models;

namespace Mango.Web.Services
{
    public class CouponService : BaseService, ICouponService
    {
        public CouponService(HttpClient httpClient) : base(httpClient)
        {
        }
   
        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetCouponByCodeAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
