using BusinessLogic.DTOs.User;
using BusinessLogic.VeiwModels.User;
using DataAccess.Identity;


namespace BusinessLogic.Mapping
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterViewModel, RegisterDTO>().ReverseMap();
            CreateMap<LoginViewModel, LoginDTO>().ReverseMap();
            CreateMap<ProfileViewModel, ProfileDTO>().ReverseMap();
            CreateMap<ApplicationUser, ProfileDTO>().ReverseMap();
        }
    }
}
