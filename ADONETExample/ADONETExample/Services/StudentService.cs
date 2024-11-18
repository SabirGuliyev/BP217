using ADONETExample.Data;
using ADONETExample.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETExample.Services
{
    internal class StudentService
    {
        private static Sql _sql;

        public StudentService()
        {
            _sql= new Sql();
            
        }


        public void Add(Student student)
        {
           int result= _sql.ExecuteCommand($"INSERT INTO Students VALUES('{student.Name}','{student.Surname}',{student.Age})");

            if (result > 0)
            {
                Console.WriteLine("Completed");
            }
            else
            {
                Console.WriteLine("Error occured");
            }
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
           DataTable table= _sql.ExecuteQuery("SELECT * FROM Students");

            foreach (DataRow item in table.Rows) 
            {
                Student student=new Student {
                    Id = (int)item["Id"],
                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    Age = Convert.ToInt32( item["Age"])

                };
                students.Add(student);
            }

            return students;


        }

        public void Delete(int id)
        {
            _sql.ExecuteCommand($"DELETE FROM Students WHERE Id={id}");
        }


    }
}

