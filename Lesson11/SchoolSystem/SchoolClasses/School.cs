using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.SchoolClasses
{
   public class School
    {
        public School()
        {
            this.NameOfSchool = NameOfSchool;
        }

        public School(string nameOfSchool, string location)
        {
            this.NameOfSchool = nameOfSchool;
            this.SchoolLocation = location;
        }
        public string NameOfSchool { get; set; }
        public string SchoolLocation { get; set; }
        public string TypeOfSchool { get; set; }

        public void GetToTalNoOfStudents()
        {
        }

        public void RegisterSchool()
        {
        }

        public void AdmitStudents()
        {
        }

        public void PayEmployees()
        {
        }
        public void PaintSchool()
        {
        }
    }
}
