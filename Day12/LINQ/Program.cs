using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static List<Employee> elist = new List<Employee>();
        static List<Department> dlist = new List<Department>();


        public static void Entry()
        {
            elist.Add(new Employee { Id = 1, Name = "sid", DeptNo = 10, Sal = 1232 });
            elist.Add(new Employee { Id = 2, Name = "anuja", DeptNo = 20, Sal = 100 });
            elist.Add(new Employee { Id = 5, Name = "boss", DeptNo = 20, Sal = 103312 });
            elist.Add(new Employee { Id = 3, Name = "rutu", DeptNo = 30, Sal = 130 });
            elist.Add(new Employee { Id = 4, Name = "sidhu", DeptNo = 40, Sal = 12000 });
            elist.Add(new Employee { Id = 5, Name = "sarkar", DeptNo = 40, Sal = 12030 });

            dlist.Add(new Department { DeptName = "manager", DeptNo = 10 });
            dlist.Add(new Department { DeptName = "worker", DeptNo = 20 });
            dlist.Add(new Department { DeptName = "cashier", DeptNo = 30 });
            dlist.Add(new Department { DeptName = "teacher", DeptNo = 40 });
        }
        static void Main1(string[] args)
        {
            Entry();

            //from Single_Object in collection select somthing
            var emps = from emp in elist select emp;
            //IEnumerable<Employee> emps=from emp in elist select emp;

            foreach (var item in emps)
            {
                Console.WriteLine(item.Name);
            }


        }

        static void Main2(string[] args)
        {
            Entry();

            var emps = from emp in elist select emp.Name;
            //IEnumerable<String> emps

            foreach (var item in emps)
            {
                Console.WriteLine(item);           //item.  all string class method
            }

        }
        static void Main3(string[] args)
        {
            Entry();

            var emps = from emp in elist select emp.Id;
            //IEnumerable<int>

            //var emps1 = from emp in elist select emp.Id,emp.Name;    LINQ  C#
            var emps1 = from emp in elist select new { emp.Id, emp.Name };   //anonymous class
            //IEnumerable<'a>   //anonymous class   

            // var o=new { emp.Id, emp.Name };//anonymous class



            foreach (var item in emps1)      //now here item is anonymous class object having property int id and String name
            {
                Console.WriteLine(item.Id);
            }

        }

        static void Main4(string[] args)
        {
            Entry();
                       //from (Employee Emp) in elist (List)  select something (data type)
            var emps = from emp in elist
                       where emp.Sal > 1300
                       select emp;
            //var emps  //IEnumerable<Employee>

            // var emps1 = from emp in elist
            //           where emp.Sal>1000 AND emp.sal < 10000;   //error

            var emps1 = from emp in elist
                        where emp.Sal > 100 && emp.Sal < 1001
                        select emp;


            foreach (var item in emps1)
            {
                Console.WriteLine(item.Name);
            }
        
        }

        static void Main5(string[] args)
        {
            Entry();

            var emps = from emp in elist
                       orderby emp.Sal
                       select emp;

            var emps1 = from empl in elist
                        orderby empl.Sal descending
                        select empl;



            foreach (var item in emps1)
            {
                Console.WriteLine(item);
            }
        }

        static void Main6(string[] args)
        {
            Entry();
            //here var is   IEnumerable of anoymous type having parameter String and String
            var emps = from emp in elist
                       join dept in dlist
                       on emp.DeptNo equals dept.DeptNo
                       select new { dept.DeptName, emp.Name };


            //here var is   IEnumerable of anoymous type having parameter Department and Employee
            var emps1 = from emp in elist
                       join dept in dlist
                       on emp.DeptNo equals dept.DeptNo
                       select new { dept, emp };

            foreach (var item in emps1)
            {
                Console.WriteLine(item.emp.Name);
            }

            foreach (var item in emps1)
            {
                Console.WriteLine(item.dept.DeptName);
            }
        }

        static void Main7(string[] args)
        {
            Entry();

            //var     = IEnumerable<IGrouping<int,Employee>>
            var emps = from emp in elist
                       group emp by emp.DeptNo;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Key);  //dept NO
                
                foreach(var e in emp)        //e is an Employee,emp is a grouping Employee
                {
                    Console.WriteLine(e);

                }


            }

        }

        static void Main(string[] args)
        {
            Entry();
            var emps = from emp in elist
                       group emp by emp.DeptNo into group1
                       select new { group1, Cout = group1.Count(), Max = group1.Max(x => x.Sal), Min = group1.Min(x => x.Sal) };

            foreach (var e in emps)
            { 
                Console.WriteLine(e.Min);
                Console.WriteLine(e.Min);
                Console.WriteLine(e.Cout);
                Console.WriteLine(e.group1.Key);

                foreach(var emp in e.group1 )
                {
                    Console.WriteLine(emp.Name);
                }


            }
        }
        public class Department
        {
            public int DeptNo { get; set; }

            public String DeptName { get; set; }
        }




        public class Employee
        {
            public int Id { get; set; }

            public String Name { get; set; }

            public float Sal { get; set; }

            public int DeptNo { get; set; }

            public override string ToString()
            {
                return "[name="+Name+" "+"id= "+Id+"]";
            }
        }
    }

}