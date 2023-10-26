using Algar.Hours.Domain.Entities.Parameters;
using Algar.Hours.Domain.Entities.User;


namespace Algar.Hours.Domain.Entities.Country
{
    public class CountryEntity
    {
        public Guid IdCounty { get; set; }
        public string NameCountry { get; set; }
        public virtual UserEntity User { get; set; }

        public virtual ParametersEntity ParametersEntity { get; set; }  

    }
}
