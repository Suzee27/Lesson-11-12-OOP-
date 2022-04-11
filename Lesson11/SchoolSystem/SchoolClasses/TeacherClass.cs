using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.SchoolClasses
{
   public class TeacherClass: School
    {
        public TeacherClass()
        {
            
        }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public string TeacherAddress { get; set; }
        public int Salary { get; set; }
        public int RankOfTeacher { get; set; }
        public bool MaleTeacher { get; set; }

        public void GetSalary()
        {
        }
        public void TeachAClass()
        {
        }
        public void MarkScripts()
        {
        }
        public void GiveAssignment()
        {
        }
    }
}
