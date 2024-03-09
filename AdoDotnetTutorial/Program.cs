using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AdoDotnetTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Connection
            Program.Connection();
            Console.ReadLine();
        }
       static  void Connection()
        {
            //string cs = "Data Source = LAPTOP-92R3ST6F\\SQLEXPRESS; Initial Catalog = StudentsDB; Integrated Security = true";
            //SqlConnection con = new SqlConnection(cs);


            //try {
            //    con.Open();
            //    if (con.State == ConnectionState.Open)
            //    {
            //        Console.WriteLine("Connection has been created SuccessFully");
            //    }
            //}
            //catch(SqlException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{

            //    con.Close();
            //}

            // string cs = "Data Source = LAPTOP-92R3ST6F\\SQLEXPRESS; Initial Catalog = StudentsDB; Integrated Security = true";
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
                try
            {
                using (con = new SqlConnection(cs))
                {
                    //con.Open();
                    //if (con.State == ConnectionState.Open)
                    //{
                    //    Console.WriteLine("Connection creatd successfully");
                    //}
                    //string query = "select * from Students";
                    //SqlCommand cmd = new SqlCommand(query,con);
                    //con.Open();
                    //SqlDataReader dr=cmd.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    Console.WriteLine("id=" + dr["id"]+ "Name=" + dr["Name"]+ "Gender=" + dr["Gender"] + "Age=" + dr["Age"]);


                    //}




                    //string query = "SpGetEmployee";
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.CommandText = query;
                    //cmd.Connection = con;
                    //con.Open();
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    Console.WriteLine("id=" + dr["id"] + "Name=" + dr["Name"] + "Gender=" + dr["Gender"] + "Age=" + dr["Age"]);


                    //}




                    //string query = "select * from Students";
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.CommandText = query;
                    //cmd.Connection = con;
                    //con.Open();
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    Console.WriteLine("id=" + dr["id"] + "Name=" + dr["Name"] + "Gender=" + dr["Gender"] + "Age=" + dr["Age"]);


                    //}





                    Console.WriteLine("Student ID : ");
                    string id = Console.ReadLine();
                    Console.WriteLine("Student Name : ");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Student Gender : ");
                    string Gender = Console.ReadLine();
                    Console.WriteLine("Studenf Age :");
                    string Age = Console.ReadLine();

                    // string query = "insert into Students values(@Name,@Gender,@Age)";
                    // SqlCommand cmd = new SqlCommand(query, con);
                    // //cmd.Parameters.AddWithValue("@id", id);
                    // cmd.Parameters.AddWithValue("@Name", Name);
                    // cmd.Parameters.AddWithValue("@Gender", Gender);
                    // cmd.Parameters.AddWithValue("@Age", Age);
                    // con.Open();
                    //int a= cmd.ExecuteNonQuery();
                    // if (a > 0)
                    // {
                    //     Console.WriteLine("Data Inserted");
                    // }
                    // else
                    // {
                    //     Console.WriteLine("DatamInsertion Failed");
                    // }



                    //string query = "select max(Age) from Students";
                    //SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.Parameters.AddWithValue("@Age", Age);
                    //con.Open();
                    //int a = (int)cmd.ExecuteScalar();

                    //if (a > 0)
                    //{
                    //    Console.WriteLine(a);
                    //}

                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }



        }

    }
}
