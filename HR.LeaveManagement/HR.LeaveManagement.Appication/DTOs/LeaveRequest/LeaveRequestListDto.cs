using HR.LeaveManagement.Appication.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Appication.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public LeaveTypeDto DateRequested { get; set; }
        public bool? Approved { get; set;  }
    }

}
