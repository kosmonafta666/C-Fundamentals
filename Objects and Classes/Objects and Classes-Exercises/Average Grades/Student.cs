namespace Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }

        public double AverageGrade
        {
            get { return Grades.Average(); }
        }
    }
}
