using AutoMapper;
using QLSL2018.Application.ViewModels.System;
using QLSL2018.Data.Entities;

namespace QLSL2018.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {

            CreateMap<Function, FunctionViewModel>();
            CreateMap<AppUser, AppUserViewModel>();
            CreateMap<AppRole, AppRoleViewModel>();


        }
    }
}
