using Algar.Hours.Domain.Entities.Rol;
using Algar.Hours.Domain.Entities.User;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Algar.Hours.Persistence.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<UserEntity> entityBuilder) 
        {

            entityBuilder.HasKey(x => x.IdUser);
            entityBuilder.Property(x=> x.NameUser).IsRequired();
            entityBuilder.Property(x=> x.surnameUser).IsRequired();
            entityBuilder.Property(x=> x.Email).IsRequired();
            entityBuilder.Property(x=> x.EmployeeCode).IsRequired();

            entityBuilder.HasOne(x => x.RoleEntity)
                .WithOne(x => x.User)
                .HasForeignKey<UserEntity>(x => x.RoleEntityId);

            entityBuilder.HasOne(x=> x.CountryEntity)
                .WithOne(x=> x.User)
                .HasForeignKey<UserEntity>(x=> x.CountryEntityId);  
               
        
        
        }

    }
}
