using Algar.Hours.Application.DataBase;
using Algar.Hours.Domain.Entities.AssignmentReport;
using Algar.Hours.Domain.Entities.Client;
using Algar.Hours.Domain.Entities.Country;
using Algar.Hours.Domain.Entities.HorusReport;
using Algar.Hours.Domain.Entities.Menu;
using Algar.Hours.Domain.Entities.Parameters;
using Algar.Hours.Domain.Entities.Rol;
using Algar.Hours.Domain.Entities.RolMenu;
using Algar.Hours.Domain.Entities.User;
using Algar.Hours.Domain.Entities.UsersExceptions;
using Algar.Hours.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;


namespace Algar.Hours.Persistence.DataBase
{
    public class DatabaseService : DbContext, IDataBaseService
    {
        public DatabaseService(DbContextOptions options) : base(options)
        {



        }

        public DbSet<AssignmentReport> assignmentReports { get; set; }
        public DbSet<ClientEntity> ClientEntity { get; set; }
        public DbSet<CountryEntity> CountryEntity { get; set; }
        public DbSet<HorusReportEntity> HorusReportEntity { get; set; }
        public DbSet<MenuEntity> MenuEntity { get; set; }
        public DbSet<ParametersEntity> ParametersEntity { get; set; }
        public DbSet<RoleEntity> RoleEntity { get; set; }
        public DbSet<RoleMenuEntity> RoleMenuEntity { get; set; }
        public DbSet<UserEntity> UserEntity { get; set; }
        public DbSet<UsersExceptions> UsersExceptions { get; set; }

        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfuguration(modelBuilder);
        }
        private void EntityConfuguration(ModelBuilder modelBuilder)
        {
            new AssignmentReportConfiguration(modelBuilder.Entity<AssignmentReport>());
            new ClientConfiguration(modelBuilder.Entity<ClientEntity>());
            new CountryConfiguration(modelBuilder.Entity<CountryEntity>());
            new HorusReportEntityConfiguration(modelBuilder.Entity<HorusReportEntity>());
            new MenuEntiryConfiguration(modelBuilder.Entity<MenuEntity>());
            new ParametersEntityConfiguration(modelBuilder.Entity<ParametersEntity>());
            new RolEntityConfiguration(modelBuilder.Entity<RoleEntity>());
            new RolMenuEntityConfiguration(modelBuilder.Entity<RoleMenuEntity>());
            new UserConfiguration(modelBuilder.Entity<UserEntity>());
            new UserExceptionsConfiguration(modelBuilder.Entity<UsersExceptions>());


        }


    }
}
