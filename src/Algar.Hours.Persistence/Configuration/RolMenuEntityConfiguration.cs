using Algar.Hours.Domain.Entities.RolMenu;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Algar.Hours.Persistence.Configuration
{
    public class RolMenuEntityConfiguration
    {
        public RolMenuEntityConfiguration(EntityTypeBuilder<RoleMenuEntity> entityTypeBuilder) 
        { 
            entityTypeBuilder.HasKey(x => x.IdRoleMenu);
            entityTypeBuilder.Property(x => x.MenuEntityId).IsRequired();
            entityTypeBuilder.Property(x => x.RoleId).IsRequired();

            entityTypeBuilder.HasOne(x => x.Role)
                .WithOne(x => x.RolMenuEntity)
                .HasForeignKey<RoleMenuEntity>(x => x.RoleId);

            entityTypeBuilder.HasOne(x => x.MenuEntity)
                .WithOne(x => x.RolMenuEntity)
                .HasForeignKey<RoleMenuEntity>(x => x.MenuEntityId);
        
        }

    }
}
