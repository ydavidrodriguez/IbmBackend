using Algar.Hours.Domain.Entities.Rol;
using AutoMapper;

namespace Algar.Hours.Application.DataBase.Rol.Commands
{
    public class CreateRolCommand : ICreateRolCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateRolCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<CreateRolModel> Execute(CreateRolModel model)
        {
            var entity = _mapper.Map<RoleEntity>(model);
            await _dataBaseService.RoleEntity.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;

        }
    }
}
