using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.SchoolClasses
{
   public class StudentClass: School
    {
        public StudentClass()
        {
           
        }

        public StudentClass(string fName, string lNAme, int age, string nameOfSchool)
        {
            FirstName = fName;
            LastName = lNAme;
            Age = age;
            base.NameOfSchool = nameOfSchool;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentID { get; set; }
        public string StudentAddress { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public string Subjects { get; set; }
        public int mark { get; set; }

        public void GoToSchool()
        {
        }
        public void AttendClasses()
        {
        }
        public void WriteExams()
        {
        }
        public void GetResults()
        {
        }
        public void SkipClasses()
        {
        }
        public void PayFees()
        {
        }
        public void RegisterSubjects()
        {
        }
        protected int CalculateMark(int score)
        {
            score++;
            return score;
        }
    }
    
}
