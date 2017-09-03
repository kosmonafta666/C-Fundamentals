namespace Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AverageGrades
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Student> listOFStudents = new List<Student>();

            for (int i = 1; i <= n; i++)
            {
                var token = Console.ReadLine().Split(' ').ToArray();
                double[] grades = TakeGrades(token);

                Student student = new Student() { Name = token[0], Grades = grades};

                listOFStudents.Add(student);
            }

            var highStudents = listOFStudents
                .Where(x => x.AverageGrade >= 5.00)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade)
                .ToList();

            foreach (var item in highStudents)
            {
                Console.WriteLine("{0} -> {1:F2}", item.Name, item.AverageGrade);
            }
        }

        public static double[] TakeGrades(string[] token)
        {
            double[] listOfGrades = new double[token.Length - 1];

            for (int i = 0; i < (token.Length - 1); i++)
            {
                listOfGrades[i] = double.Parse(token[i + 1]);
            }

            return listOfGrades;
        }


    }
}
