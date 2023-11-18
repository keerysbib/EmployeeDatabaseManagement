using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EmployeeDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connstr = @"Data Source=.;Initial Catalog=Employee;Integrated Security=SSPI";
            try
            {
                sqlConnection = new SqlConnection(connstr);
                sqlConnection.Open();
                Console.WriteLine("Connection established successfully");

                

               

                Console.WriteLine("Choice 1: Insertion");
                Console.WriteLine("Choice 2: Updation");
                Console.WriteLine("Choice 3: Selection");
                Console.WriteLine("Choice 4: Deletion");
                Console.WriteLine("Choice 5: Exit");

                Console.WriteLine("Enter the choice:");

                int ch = Convert.ToInt32(Console.ReadLine());
                while (!(ch > 5))
                {
                    switch (ch)
                    {
                        case 1:

                            Console.WriteLine("Data Insertion!......");
                            Console.WriteLine("Enter Employee Name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Employee Age:");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee DateofBirth");
                            string dob = Console.ReadLine();
                            Console.WriteLine("Enter Employee salary:");
                            double sal = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Employee department:");
                            string dept = Console.ReadLine();

                            string insertquery = "Insert into Emp(name,age,dob,salary,dept) values ('" + name + "'," + age + ",'" + dob + "'," + sal + ",'" + dept + "')";
                            SqlCommand sqlCommand = new SqlCommand(insertquery, sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            Console.WriteLine("Data is inserted successfully");
                            break;

                        case 2:
                            Console.WriteLine("Data Updation:");
                            Console.WriteLine("What column is needed to update:");
                            string col = Console.ReadLine();
                            Console.WriteLine("What value is needed to update");
                            string v = Console.ReadLine();
                            string updatequery = "Update Emp set " + col + "=" + v;
                            SqlCommand sqlCommand1 = new SqlCommand(updatequery, sqlConnection);
                            sqlCommand1.ExecuteNonQuery();
                            Console.WriteLine("Data is updated successfully");
                            break;

                        case 3:
                            Console.WriteLine("Data selection:");


                            string sel = "select * from Emp";
                            SqlCommand sqlCommand2 = new SqlCommand(sel, sqlConnection);
                            SqlDataReader reader = sqlCommand2.ExecuteReader();

                            while (reader.Read())
                            {
                                Console.WriteLine("User " + reader.GetValue(1).ToString());
                                Console.WriteLine("Age " + reader.GetValue(2).ToString());
                                Console.WriteLine("DOB " + reader.GetValue(3).ToString());
                                Console.WriteLine("Salary " + reader.GetValue(4).ToString());
                                Console.WriteLine("Department " + reader.GetValue(5).ToString());
                                Console.WriteLine("......................");

                            }
                            Console.ReadKey();
                            reader.Close();

                            Console.WriteLine("Data is selected");
                            break;

                        case 4:
                            Console.WriteLine("Data Deletion");
                            string del = "delete Emp";
                            SqlCommand sqlCommand3 = new SqlCommand(del, sqlConnection);
                            sqlCommand3.ExecuteNonQuery();
                            Console.WriteLine("Data is deleted successfully");
                            break;

                        case 5:
                            Console.WriteLine("Exit");
                            return;



                    }

                }
                sqlConnection.Close();
              
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
