namespace Algar.Hours.Application.DataBase.Country.Commands
{
    public interface ICreateCountryCommand
    {
        Task<CreateCountryModel> Execute(CreateCountryModel model);
    }
}
