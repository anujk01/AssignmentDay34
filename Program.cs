using System;

namespace AssignmentDay34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO Employee PayRoll Services");
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.GetDataFromSql();
        }
    }
}