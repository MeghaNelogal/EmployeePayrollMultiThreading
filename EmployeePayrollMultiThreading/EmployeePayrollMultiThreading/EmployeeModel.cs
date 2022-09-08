using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string DepartMent { get; set; }

        public EmployeeModel(int employeeId, string employeeName, string phoneNumber, string address, string departMent)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.DepartMent = departMent;
        }
    }
}
   
