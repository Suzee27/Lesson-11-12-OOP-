using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1
{
    class Courses: Teachers
    {

        void CountOfClasses(int count)
        {
            count++;
        }

        void CountOfExercises()
        {

        }
        public string courseName { get; set; }
    }
}
