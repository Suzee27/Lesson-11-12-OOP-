using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    class Student: Human
    {
        public Student(): this(0)
        {
            Mark = mark;
        }

        public Student(int imark)
        {
            Mark = mark;
        }
        private int mark;

        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }

    }
}
