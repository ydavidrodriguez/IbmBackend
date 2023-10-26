namespace Algar.Hours.Application.DataBase.Client.Commands
{
    public interface ICreateClientCommand
    {
        Task<CreateClientModel> Execute(CreateClientModel model);
    }
}
