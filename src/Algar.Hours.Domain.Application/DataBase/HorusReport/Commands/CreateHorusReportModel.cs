using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algar.Hours.Application.DataBase.HorusReport.Commands
{
    public class CreateHorusReportModel
    {
        public Guid IdHorusReport { get; set; }
        public Guid UserEntityId { get; set; }
        public DateTime StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public Guid ClientEntityId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int TipoReporte { get; set; }
        public DateTime DateApprovalSystem { get; set; }

    }
}
