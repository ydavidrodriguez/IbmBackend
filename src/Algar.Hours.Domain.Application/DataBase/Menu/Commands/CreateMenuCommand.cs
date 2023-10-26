using Algar.Hours.Domain.Entities.Menu;
using AutoMapper;

namespace Algar.Hours.Application.DataBase.Menu.Commands
{
    public class CreateMenuCommand : ICreateMenuCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateMenuCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<CreateMenuModel> Execute(CreateMenuModel model)
        {
            var entity = _mapper.Map<MenuEntity>(model);
            await _dataBaseService.MenuEntity.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
