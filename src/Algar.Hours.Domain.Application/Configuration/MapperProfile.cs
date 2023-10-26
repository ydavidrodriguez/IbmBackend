using Algar.Hours.Application.DataBase.AssignmentReport.Commands;
using Algar.Hours.Application.DataBase.Client.Commands;
using Algar.Hours.Application.DataBase.Country.Commands;
using Algar.Hours.Application.DataBase.HorusReport.Commands;
using Algar.Hours.Application.DataBase.Menu.Commands;
using Algar.Hours.Application.DataBase.Parameters.Commands.CreateParameters;
using Algar.Hours.Application.DataBase.Rol.Commands;
using Algar.Hours.Application.DataBase.RolMenu.Commands.CreateRolMenu;
using Algar.Hours.Application.DataBase.User.Commands.CreateUser;
using Algar.Hours.Domain.Entities.Client;
using Algar.Hours.Domain.Entities.Country;
using Algar.Hours.Domain.Entities.HorusReport;
using Algar.Hours.Domain.Entities.Menu;
using Algar.Hours.Domain.Entities.Parameters;
using Algar.Hours.Domain.Entities.Rol;
using Algar.Hours.Domain.Entities.RolMenu;
using Algar.Hours.Domain.Entities.User;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algar.Hours.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<UserEntity, CreateUserModel>().ReverseMap();
            CreateMap<RoleEntity, CreateRolModel>().ReverseMap();
            CreateMap<Domain.Entities.AssignmentReport.AssignmentReport,CreateAssignmentReportModel>().ReverseMap();
            CreateMap<ClientEntity,CreateClientModel>().ReverseMap();
            CreateMap<CountryEntity,CreateCountryModel>().ReverseMap();
            CreateMap<HorusReportEntity,CreateHorusReportModel>().ReverseMap();
            CreateMap<HorusReportEntity,CreateHorusReportModel>().ReverseMap();
            CreateMap<MenuEntity,CreateMenuModel>().ReverseMap();
            CreateMap<ParametersEntity,CreateParametersModel>().ReverseMap();
            CreateMap<RoleEntity,CreateRolModel>().ReverseMap();
            CreateMap<RoleMenuEntity,CreateRolMenuModel>().ReverseMap();
            CreateMap<UserEntity,CreateUserModel>().ReverseMap();
        }  

    }
}
