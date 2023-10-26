using Algar.Hours.Domain.Entities.Client;
using Algar.Hours.Domain.Entities.Country;
using Algar.Hours.Domain.Entities.HorusReport;
using Algar.Hours.Domain.Entities.Menu;
using Algar.Hours.Domain.Entities.Parameters;
using Algar.Hours.Domain.Entities.Rol;
using Algar.Hours.Domain.Entities.RolMenu;
using Algar.Hours.Domain.Entities.User;
using Algar.Hours.Domain.Entities.UsersExceptions;
using Microsoft.EntityFrameworkCore;


namespace Algar.Hours.Application.DataBase
{
    public interface IDataBaseService
    {
        DbSet<Domain.Entities.AssignmentReport.AssignmentReport> assignmentReports { get; set; }
        DbSet<ClientEntity> ClientEntity { get; set; }
        DbSet<CountryEntity> CountryEntity { get; set; }
        DbSet<HorusReportEntity> HorusReportEntity { get; set; }
        DbSet<MenuEntity> MenuEntity { get; set; }
        DbSet<ParametersEntity> ParametersEntity { get; set; }
        DbSet<RoleEntity> RoleEntity { get; set; }
        DbSet<RoleMenuEntity> RoleMenuEntity { get; set; }
        DbSet<UserEntity> UserEntity { get; set; }
        DbSet<UsersExceptions> UsersExceptions { get; set; }

        Task<bool> SaveAsync();
    }
}
