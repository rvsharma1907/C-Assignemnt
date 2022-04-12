using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class manager
{
    public delegate void manager_name(string name);
    public delegate void manager_id_dept(int id, string dept);
    public void print_name(string name)
    {
        Console.WriteLine("Manager NAME : " + name);
    }

    public void print_id_dept(int id, string dept)
    {
        Console.WriteLine("Manager ID : {0} , Manager DEPT : {1}", id, dept);
    }





    static void Main(string[] args)
    {
        manager mng = new manager();
        manager_name obj1 = new manager_name(mng.print_name);
        manager_id_dept obj2 = new manager_id_dept(mng.print_id_dept);
        manager_name obj3 = new manager_name(mng.print_name);
        manager_id_dept obj4 = new manager_id_dept(mng.print_id_dept);

        obj1("Rio");
        obj2(24, "HR");
        obj3("Inaya");
        obj4(35, "IT");

        Console.ReadKey();
    }
}
