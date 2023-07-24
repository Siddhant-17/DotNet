using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConnectToDb();

            Employee employee = new Employee
            {
                EmpNo = 23,
                Name = "a'admin",
                Basic = 18000,
                DeptNo = 20
            };
            //Insert(employee);
            //  InsertByParameter(employee);
            GetSingleValue();
            // InsertWithStoredProcedure(employee);
            // SelectWithSqlDataReader();
            //GetSingleRecordUsingSqlDataReder(2);
            //SqlDataReaderNextResult();
            // Mars();         //MultipleActiveResultSets
            //Transaction();
        }

        static void ConnectToDb()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True";
            try
            {
                cn.Open();
                Console.WriteLine("done");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
        }


        //if name ="a'admin"   then give error
        static void Insert(Employee emp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True";
            try
            {
                cn.Open();
                Console.WriteLine("done");
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;                  //konsa connection use karna hai
                cmdInsert.CommandType = System.Data.CommandType.Text;    //type
                //cmdInsert.CommandText = "insert into Employees values(2,'rutu',12000,20)";
                cmdInsert.CommandText = $"insert into Employees values({emp.EmpNo},'{emp.Name}',{emp.Basic},{emp.DeptNo})";
                //this $ will replace all {}  with original value
                //or write like String in println +


                cmdInsert.ExecuteNonQuery();           //actually run the command by calling   for command not returning value
                                                       //return int  no of record rows affected
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
        }

        //ExecuteNonQuery()
        static void InsertByParameter(Employee emp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True";
            try
            {
                cn.Open();
                Console.WriteLine("done");
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;                  //konsa connection use karna hai
                cmdInsert.CommandType = System.Data.CommandType.Text;    //type

                cmdInsert.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
                cmdInsert.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmdInsert.Parameters.AddWithValue("@Name", emp.Name);
                cmdInsert.Parameters.AddWithValue("@Basic", emp.Basic);
                cmdInsert.Parameters.AddWithValue("@DeptNo", emp.DeptNo);


                cmdInsert.ExecuteNonQuery();           //actually run the command by calling   for command not returning value
                                                       //return int  no of record rows affected
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
        }
        static void InsertWithStoredProcedure(Employee emp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True";
            try
            {
                cn.Open();
                Console.WriteLine("done");
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;                  //konsa connection use karna hai
                cmdInsert.CommandType = CommandType.StoredProcedure;    //type

                cmdInsert.CommandText = "InsertEmployees";
                cmdInsert.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmdInsert.Parameters.AddWithValue("@Name", emp.Name);
                cmdInsert.Parameters.AddWithValue("@Basic", emp.Basic);
                cmdInsert.Parameters.AddWithValue("@DeptNo", emp.DeptNo);


                cmdInsert.ExecuteNonQuery();           //actually run the command by calling   for command not returning value
                                                       //return int  no of record rows affected
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
        }

        //ExecuteScalar()
        static void GetSingleValue()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True";

            try
            {
                cn.Open();
                Console.WriteLine("done");
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;                  //konsa connection use karna hai
                cmdInsert.CommandType = CommandType.Text;    //type

                cmdInsert.CommandText = "Select count(*) from Employees";
                


               object retval= cmdInsert.ExecuteScalar();         //return only first row first column     return object            
                //why return Object because we dont know whar type return varchar /int
                
                Console.WriteLine(retval.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
        }

        //ExecuteReader()
        static void SelectWithSqlDataReader()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = cn;
                cmdSelect.CommandType = CommandType.Text;
                cmdSelect.CommandText = "Select * from Employees";
                SqlDataReader dr = cmdSelect.ExecuteReader();         //ExecuteScalar return only first row and first coloumn
                                                                      //ExecuteReader return  SqlDataReader  

                //now dr initially point to top of table  ref jdbc notes
                while (dr.Read())                          //.Read   return true if data exist else false
                {
                    //to access data   dr[0] first column   or dr["EmpNo"]  
                    Console.WriteLine(dr["EmpNo"]);

                }
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }

        }
        static void GetSingleRecordUsingSqlDataReder(int EmpNo)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = cn;
                cmdSelect.CommandType = CommandType.Text;
                cmdSelect.CommandText = "Select * from Employees where EmpNo=@EmpNo";
                cmdSelect.Parameters.AddWithValue("@EmpNo", EmpNo);
                SqlDataReader dr = cmdSelect.ExecuteReader();         //ExecuteScalar return only first row and first coloumn
                                                                      //ExecuteReader return  SqlDataReader  
                if (dr.Read())
                {
                    Console.WriteLine(dr["Name"]);
                }
                else
                {
                    Console.WriteLine("not found");

                }
                dr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }

        }
        static void SqlDataReaderNextResult()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = cn;
                cmdSelect.CommandType = CommandType.Text;
                cmdSelect.CommandText = "Select * from Employees;select * from Departments";     //return to tables
                SqlDataReader dr = cmdSelect.ExecuteReader();         //ExecuteScalar return only first row and first coloumn
                                                                      //ExecuteReader return  SqlDataReader  
                while(dr.Read()) 
                {
                    Console.WriteLine(dr["Name"]);  
                }

                //after this

                dr.NextResult();    //return true if next result set present
                while (dr.Read())        //now dr pointing to next table
                {
                    Console.WriteLine(dr["DeptName"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }

        }

        //one query inside another
        static void  Mars()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True;MultipleActiveResultSets=True";
            try
            {
                cn.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = cn;
                cmdSelect.CommandType = CommandType.Text;
                cmdSelect.CommandText = "Select * from Departments";     //return to tables
                SqlDataReader drDepts = cmdSelect.ExecuteReader();         //ExecuteScalar return only first row and first coloumn


                SqlCommand cmdemps = new SqlCommand();
                cmdemps.Connection = cn;
                cmdemps.CommandType = CommandType.Text;

                while (drDepts.Read())
                {
                    Console.WriteLine(" " +drDepts["DeptName"]);

                    cmdemps.CommandText = "select * from Employees where DeptNo= " + drDepts["DeptNo"];
                    SqlDataReader dremps = cmdemps.ExecuteReader();
                    while (dremps.Read())
                    {
                        Console.WriteLine(dremps["Name"]);
                    }



                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }

        }

        static void Transaction()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True";
            
                cn.Open();

            SqlTransaction t= cn.BeginTransaction();


                SqlCommand cmdInsert1 = new SqlCommand();
                cmdInsert1.Connection = cn;
            //must use transaction
            cmdInsert1.Transaction = t;     
                cmdInsert1.CommandType = System.Data.CommandType.Text;
                cmdInsert1.CommandText = "insert into  Employees values(10,'i',788,20)";                    
                SqlCommand cmdInsert2 = new SqlCommand();
                cmdInsert2.Connection = cn;
                //must use transaction
                cmdInsert2.Transaction = t;
                cmdInsert2.CommandType = System.Data.CommandType.Text;
            cmdInsert2.CommandText = "insert into  Employees values(30,'love',723348,20)";

            try {
                cmdInsert1.ExecuteNonQuery();
                cmdInsert2.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception e)
            {
                t.Rollback();
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }

        }
        public class Employee
        {
            public int EmpNo { get; set; }
            public String Name { get; set; }

            public float Basic { get; set; }

            public int DeptNo { get; set; }
        }

    }

}
