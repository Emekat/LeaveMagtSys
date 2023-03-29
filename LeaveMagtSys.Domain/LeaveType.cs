using LeaveMagtSys.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LeaveMagtSys.Domain
{
    public class LeaveType: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
    }
}
