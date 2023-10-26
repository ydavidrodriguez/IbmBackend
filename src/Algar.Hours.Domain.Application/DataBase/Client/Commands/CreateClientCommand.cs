using Algar.Hours.Domain.Entities.Client;
using AutoMapper;

namespace Algar.Hours.Application.DataBase.Client.Commands
{
    public class CreateClientCommand : ICreateClientCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateClientCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<CreateClientModel> Execute(CreateClientModel model)
        {
            var entity = _mapper.Map<ClientEntity>(model);
            await _dataBaseService.ClientEntity.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
