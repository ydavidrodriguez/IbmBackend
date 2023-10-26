using Algar.Hours.Domain.Entities.AssignmentReport;
using Algar.Hours.Domain.Entities.User;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algar.Hours.Persistence.Configuration
{
    public class AssignmentReportConfiguration
    {

        public AssignmentReportConfiguration(EntityTypeBuilder<AssignmentReport> entityBuilder) 
        {

            entityBuilder.HasKey(x => x.IdAssignmentReport);
            entityBuilder.Property(x => x.State).IsRequired();
            entityBuilder.Property(x=> x.DateApprovalCancellation).IsRequired();
            entityBuilder.Property(x => x.UserId).IsRequired(); 
            entityBuilder.Property(x => x.HorusReportId).IsRequired();


            entityBuilder.HasOne(x => x.UserEntity)
                .WithOne(x => x.AssignmentReport)
                .HasForeignKey<AssignmentReport>(x => x.UserId);

            entityBuilder.HasOne(x => x.HorusReportEntity)
                .WithOne(x => x.assignmentReport)
                .HasForeignKey<AssignmentReport>(x => x.HorusReportId);

        }
    }
}
