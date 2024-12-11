using AutoMapper;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;

namespace OnlineMuhasebeServer.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<CreateCompanyRequest, Company>().ReverseMap(); 
        }
    }
}
