using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2employee

{
    class Program

    {
        static void Main(string[] args)
        {
            OperateCost someWarden = new Warden();
            OperateCost someLord = new Lord();
            OperateCost someSlave = new Slave();

            someSlave.position = "Slave";
            someLord.position = "Lord";
            someWarden.position = "Warden";

            Employee emp = new Employee("Petya", "Ivanov", "15.03.2002", someSlave);

            double grade = Employee.DiscoverGrade("15.03.2002");
            Console.WriteLine("Name: {0}, Surname: {1}, Date of Hire: {2}, Position: {3}", emp.name, emp.surname, Employee.dateOfHire, someSlave.position);

            someSlave.ApplyBonus(25000, grade);
            someSlave.ApplyTax();
            Console.WriteLine("Salary: {0}, Tax: {1}", emp.operationCost.salary, emp.operationCost.tax);

            Console.ReadKey();
        }
    }
}
