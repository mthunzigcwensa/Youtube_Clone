using YouTubeClone.Web.Models;
using YouTubeClone.Web.Service.IService;
using YouTubeClone.Web.Utility;

namespace YouTubeClone.Web.Service
{
    public class AuthService : IAuthService
    {
        private readonly IBaseService _baseService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthService(IBaseService baseService, IHttpContextAccessor httpContextAccessor)
        {
            _baseService = baseService;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = registrationRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/AssignRole"
            });
        }

        public async Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = loginRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/login"
            }, withBearer: false);
        }



        public async Task<ResponseDto?> RegisterAsync(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = registrationRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/register",
                ContentType = SD.ContentType.MultipartFormData
            }, withBearer: false);
        }
    }
}
