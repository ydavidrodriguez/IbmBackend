using Algar.Hours.Domain.Entities.Country;
using Algar.Hours.Domain.Entities.HorusReport;
using Algar.Hours.Domain.Entities.Rol;


namespace Algar.Hours.Domain.Entities.User
{
    public class UserEntity
    {
        public Guid IdUser { get; set; }
        public string NameUser { get; set; }
        public string surnameUser { get; set; }
        public string Email { get; set; }
        public string EmployeeCode { get; set; }
        public Guid RoleEntityId { get; set; }  
        public virtual  RoleEntity RoleEntity { get; set; }
        public Guid CountryEntityId { get; set; }
        public virtual CountryEntity CountryEntity { get; set; }
        public virtual AssignmentReport.AssignmentReport AssignmentReport { get; set; }
        public virtual HorusReportEntity HorusReportEntity { get; set; }

        public virtual UsersExceptions.UsersExceptions usersExceptions { get; set; }    

    }
}
    