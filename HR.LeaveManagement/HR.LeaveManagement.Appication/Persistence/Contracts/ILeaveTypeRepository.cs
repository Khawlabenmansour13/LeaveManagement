using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Appication.Persistence.Contracts
{
    public interface ILeaveTypeRepository :  IGenericRepository<LeaveType>
    {
    }
}
