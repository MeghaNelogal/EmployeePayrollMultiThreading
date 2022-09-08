using EmployeePayrollMultiThreading;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_EmpDetails_Data()
        {
            List<EmployeeModel> employeeDetails = new List<EmployeeModel>();
            employeeDetails.Add(new EmployeeModel(employeeId: 1, employeeName: "megha", phoneNumber: "9008088657", address: "banglore", departMent: "cse"));
            employeeDetails.Add(new EmployeeModel(employeeId: 2, employeeName: "savita", phoneNumber: "9008088657", address: "hubli", departMent: "me"));
            employeeDetails.Add(new EmployeeModel(employeeId: 3, employeeName: "shalu", phoneNumber: "9008088657", address: "hangl", departMent: "civil"));
            employeeDetails.Add(new EmployeeModel(employeeId: 4, employeeName: "chaitra", phoneNumber: "9008088657", address: "haveri", departMent: "physics"));
            employeeDetails.Add(new EmployeeModel(employeeId: 5, employeeName: "rahul", phoneNumber: "9008088657", address: "hubli", departMent: "EEE"));
        

        Operations emppayroll = new Operations();
            DateTime StartDateTime = DateTime.Now;
            emppayroll.AddEmployee(employeeDetails);
            DateTime StopDateTimes = DateTime.Now;

            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));

            DateTime StartDateTimeThread = DateTime.Now;
            emppayroll.AddEmployeePayrollThread(employeeDetails);
            DateTime StopDateTimeThread = DateTime.Now;

            Console.WriteLine("Duration with threads: " + (StopDateTimeThread - StartDateTimeThread));
        }
    }
}
    




    