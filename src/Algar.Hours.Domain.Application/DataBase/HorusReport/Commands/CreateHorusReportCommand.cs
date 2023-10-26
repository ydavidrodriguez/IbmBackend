using Algar.Hours.Domain.Entities.HorusReport;
using Algar.Hours.Domain.Entities.Rol;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algar.Hours.Application.DataBase.HorusReport.Commands
{
    public class CreateHorusReportCommand : ICreateHorusReportCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateHorusReportCommand(IDataBaseService dataBaseService, IMapper mapper) 
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<CreateHorusReportModel> Execute(CreateHorusReportModel model)
        {
            var entity = _mapper.Map<HorusReportEntity>(model);
            await _dataBaseService.HorusReportEntity.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
