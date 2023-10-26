using Algar.Hours.Domain.Entities.Menu;
using Algar.Hours.Domain.Entities.Rol;


namespace Algar.Hours.Domain.Entities.RolMenu
{
    public class RoleMenuEntity
    {
        public Guid IdRoleMenu { get; set; }
        public Guid RoleId {  get; set; }   
        public virtual RoleEntity Role { get; set; }
        public Guid MenuEntityId { get; set; }
        public virtual MenuEntity MenuEntity { get; set; }  

    }
}
