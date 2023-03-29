using LeaveMagtSys.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace LeaveMagtSys.Domain
{
    public class LeaveAllocation
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
    public class LeaveRequest: BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string? RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public string RequestEmployeeId { get; set; } = string.Empty;

    }
}
