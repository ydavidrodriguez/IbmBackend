using Algar.Hours.Domain.Entities.HorusReport;
using Algar.Hours.Domain.Entities.User;


namespace Algar.Hours.Domain.Entities.AssignmentReport
{
    public class AssignmentReport
    {
        public Guid IdAssignmentReport { get; set; }
        public Guid UserId { get; set; }
        public virtual UserEntity UserEntity { get; set; }
        public Guid HorusReportId { get; set; }
        public virtual HorusReportEntity HorusReportEntity { get; set; }
        public int State { get; set; }
        public string Description { get; set; }
        public DateTime DateApprovalCancellation { get; set; }
    }
}
