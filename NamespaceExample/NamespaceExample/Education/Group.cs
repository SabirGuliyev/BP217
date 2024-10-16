using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceExample.Education
{
    internal class Group
    {
        public Student[] _students=new Student[0];

        public Student[] Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;  
            }
        }
        public string Name { get; set; }

        public Group(string name)
        {
            Name = name;
            
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, Students.Length + 1);
            Students[Students.Length-1]=student;
        }
        public void ShowStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i].GetInfo();
            }
        }
        public Student GetStudent(string name)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name == name)
                {
                    return Students[i];
                }
            }
            return null;
        }


        public void RemoveStudent(string name)
        {
            Student[] newArr= new Student[Students.Length-1];

            //0,1,2      0,1

            int j = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name != name)
                {
                    newArr[j]= Students[i];
                    j++;
                }
            }

            Students = newArr;

        }
    }
}
