using CourseManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.Services
{
    internal class CourseService
    {
        public static List<Group> Groups;
        public void CreateGroup() {

            Groups.Add(new Group());
        
        }
        public void CreateStudent() { 

            foreach (var group in Groups)
            {
               
            }
            
            
        Student student = new Student();


        }
        public void ShowAllStudents() { }
        public void ShowAllGroups() { }
        public void ShowGroup() { }
        public void EditGroup() { }
    }
}
