using ADONETExample.Data;
using ADONETExample.Models;
using ADONETExample.Services;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace ADONETExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AdoNet intro
            // string connectionString = "server=MSI;database=ADONETBP217;trusted_connection=true;integrated security=true;";

            // SqlConnection connection = new SqlConnection(connectionString);
            // connection.Open();


            // SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Students", connection);

            // DataTable table=new DataTable();
            // dataAdapter.Fill(table);
            // connection.Close();


            //foreach(DataRow item in table.Rows)
            // {

            //     //Console.WriteLine(item[0]+" " + item[1]+" " + item[2]+" " + item[3]);
            //     Console.WriteLine(item["Id"]+" " + item["Name"]+" " + item["Surname"]+" " + item["Age"]);
            // }






            //SqlCommand command = new SqlCommand("INSERT INTO Students VALUES('Nicat','Ibrahimli',25)", connection);
            //int result=command.ExecuteNonQuery();

            //connection.Close();

            //if(result > 0)
            //{
            //    Console.WriteLine("Command successfully completed");

            //}
            //else
            //{
            //    Console.WriteLine("Error occured");
            //} 
            #endregion


            StudentService studentService = new StudentService();

            Student student=new Student { Name="Kubra",Surname="Ahmedova",Age=19};



            Student studen2t=new Student { Name="Kobra",Surname="Ahmedova",Age=19};

            studentService.Delete(5);
            //studentService.Add(student);

            List<Student> students = studentService.GetAll();

            foreach (var item in students)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Surname);
            }

        }
    }
}
