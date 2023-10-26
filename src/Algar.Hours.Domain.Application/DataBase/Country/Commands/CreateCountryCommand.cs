using Algar.Hours.Domain.Entities.Country;
using Algar.Hours.Domain.Entities.Rol;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algar.Hours.Application.DataBase.Country.Commands
{
    public class CreateCountryCommand : ICreateCountryCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateCountryCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<CreateCountryModel> Execute(CreateCountryModel model)
        {
            var entity = _mapper.Map<CountryEntity>(model);
            await _dataBaseService.CountryEntity.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
