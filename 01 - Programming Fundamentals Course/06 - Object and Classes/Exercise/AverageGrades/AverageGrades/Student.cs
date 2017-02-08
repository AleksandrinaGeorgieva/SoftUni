using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Student
    {
        public string name { get; set; }
        public List<double> grades { get; set; }
        public double averageGrade { get; }

        public double GetAverage()
        {
            return grades.Average();
        }
    }
}
