using System;
 
class LitwareLib
{
    int EmpNo;
    string EmpName;
    double salary;
    double hra;
    double ta;
    double da;
    double pf;
    double tds;
    double NetSalary;
    double GrossSalary;

    public LitwareLib(int EmpNo, string EmpName, double salary)
    {
        this.EmpNo = EmpNo;
        this.EmpName = EmpName;
        this.salary = salary;
        calculate_GrossSalary(salary);
    }

    public void calculate_GrossSalary(double salary)
    {
        if (salary < 5000)
        {
            hra = 0.10*salary;
            ta = 0.05*salary;
            da = 0.15*salary;
        } 
        else if (salary < 10000)
        {
            hra = 0.15*salary;
            ta = 0.10*salary;
            da = 0.20*salary;
        }
        else if (salary < 15000)
        {
            hra = 0.20*salary;
            ta = 0.15*salary;
            da = 0.25*salary;
        }
        else if (salary < 20000)
        {
            hra = 0.25*salary;
            ta = 0.20*salary;
            da = 0.30*salary;
        }
        else if (salary >= 20000)
        {
            hra = 0.30*salary;
            ta = 0.25*salary;
            da = 0.35*salary;
        }

        GrossSalary = salary + hra + ta + da;
        CalculateSalary();
    }

    public void CalculateSalary()
    {
        pf = 0.10 * GrossSalary;
        tds = 0.18 * GrossSalary;
        NetSalary = GrossSalary - ( pf + tds);
        Display_Details();
    }

    public void Display_Details()
    {
        Console.WriteLine("Employee Details");

        Console.WriteLine("Employee Number : "+EmpNo);
        Console.WriteLine("Employee Name : "+EmpName);
        Console.WriteLine("Employee Salary : "+salary);
        Console.WriteLine("Employee HRA : "+hra);
        Console.WriteLine("Employee TA : "+ ta);
        Console.WriteLine("Employee DA : "+ da);
        Console.WriteLine("Employee PF : " + pf);
        Console.WriteLine("Employee TDS : "+tds);
        Console.WriteLine("Employee Net Salary : "+ NetSalary);
        Console.WriteLine("Employee Gross Salary : "+ GrossSalary);
    }

}

class program
{
    static void Main()
    {
        int eno;
        string ename;
        double esal;
        Console.WriteLine("Enter Employee Number : ");
        eno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name : ");
        ename = Console.ReadLine();
        Console.WriteLine("Enter Employee Salary : ");
        esal = Convert.ToDouble(Console.ReadLine());

        LitwareLib emp = new LitwareLib(eno, ename, esal);

    }
}
