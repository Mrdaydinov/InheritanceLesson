using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    internal class Student
    {


        private int[] grades;

        public int[] Grades
        {
            get { return grades; }
            set
            {
                int count = 0;
                foreach (var grade in value)
                {
                    if (grade % 2  == 0)
                        count++;
                }
                grades = new int[count];
                int index = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] % 2 == 0)
                    {
                        grades[index] = value[i];
                        index++;
                    }
                }
            }
        }

    }
}
