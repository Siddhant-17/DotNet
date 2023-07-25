using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet_Example_
{
    public partial class Form1 : Form
    {
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmdSelect;

                ds = new DataSet();
                da.Fill(ds, "Emps");

                cmdSelect.CommandText = "Select * from Departments";
                da.Fill(ds, "Dept");

                //primary key Constraint
                DataColumn[] arrCols = new DataColumn[1];
                arrCols[0] = ds.Tables["Emps"].Columns["EmpNo"];
                ds.Tables["Emps"].PrimaryKey = arrCols;                 //array of primary key because may composite primary key



                //add a foreign key constraint
                ds.Relations.Add(ds.Tables["Dept"].Columns["DeptNo"], ds.Tables["Emps"].Columns["DeptNo"]);
                //parents table ,child table


                //column level  constraint
                ds.Tables["Dept"].Columns["DeptNo"].Unique = true;


                // dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.DataSource = ds.Tables["Emps"];     //gride should read values from dataset table 0 set of DataTables
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YCPJuly2022;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = cn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = "update Employees set Name=@Name,Basic=@Basic where EmpNo=@EmpNo";  //we can use stored procedure
                
                //FOR MULTIPLE update
               /* SqlParameter p = new SqlParameter();
                p.ParameterName = "@Name";
                p.SourceColumn = "Name"; //column name from table
                p.SourceVersion = DataRowVersion.Current; //take current(changed) value not original
                cmdUpdate.Parameters.Add(p);*/
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName="@Name",SourceColumn="Name",SourceVersion=DataRowVersion.Current});
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });  //Original  because Empno is in where cluase so primary key did not change
                ///Original  because Empno is in where cluase so primary key did not change



                //simplar code for insert command  //DataRowVersion=current   ==new values
                //simplar code for Delete command  //DataRowVersion=original   ==becuse of where clause



                SqlDataAdapter da = new SqlDataAdapter();
                da.UpdateCommand = cmdUpdate;
                //da.InsertCommand = cmdInsert;
                //da.InsertCommand = cmdDelete;

                da.Update(ds, "Emps");  //same like da.Fill();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
