using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class Operations
    {
        public List<EmployeeModel> employeeDatalist = new List<EmployeeModel>();
        public void AddEmployee(List<EmployeeModel> employeeDatalist)
        {
            employeeDatalist.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                this.AddEmployeePayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.EmployeeName);
            }
            );
            Console.WriteLine(this.employeeDatalist.ToString());
        }
        public void AddEmployeePayrollThread(List<EmployeeModel> employeeDatalist)
        {
            employeeDatalist.ForEach(employeeData =>

            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                    this.AddEmployeePayrollThread(employeeData);
                    Console.WriteLine("Employee added: " + employeeData.EmployeeName);

                });
                thread.Start();
            });
            Console.WriteLine(this.employeeDatalist.Count);
        }
        public void AddEmployeePayroll(EmployeeModel emp)
        {
            employeeDatalist.Add(emp);
        }
        public void AddEmployeePayrollThread(EmployeeModel emp)
        {
            employeeDatalist.Add(emp);
        }
    }

}

