using AutoMapper;

namespace Algar.Hours.Application.DataBase.AssignmentReport.Commands
{
    public class CreateAssignmentReportCommand : ICreateAssigmentReportCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateAssignmentReportCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<CreateAssignmentReportModel> Execute(CreateAssignmentReportModel model)
        {
            var entity = _mapper.Map<Domain.Entities.AssignmentReport.AssignmentReport>(model);
            await _dataBaseService.assignmentReports.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
