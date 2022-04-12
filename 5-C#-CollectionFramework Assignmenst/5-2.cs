using System;
using System.Collections;
class Employee
{
    int empId;
    string empName;
    string empdept;
    public Employee(int id, string name, string dept)
    {
        empId = id;
        empName = name;
        empdept = dept;
    }
    public int EmplId()
    {
        return empId;
    }
    public string EmplName()
    {
        return empName;
    }
    public string EmpDept()
    {
        return empdept;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArrayList empList = new ArrayList();
        while (true)
        {
            Console.WriteLine("1.ENTER EMPLOYEE DETAILS \n2. DISPLAY EMPLOYEE DETAILS \n3. EXIT");
            Console.WriteLine("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter Employee Id : ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Employee Dept : ");
                string dept = Console.ReadLine();
                empList.Add(new Employee(id, name, dept));

            }
            else if (choice == 2)
            {
                foreach (Employee emp in empList)
                {
                    Console.WriteLine("Employee ID : {0}, Employee Name : {1}, Employee Dept : {2}", emp.EmplId(), emp.EmplName(), emp.EmpDept());
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
}
