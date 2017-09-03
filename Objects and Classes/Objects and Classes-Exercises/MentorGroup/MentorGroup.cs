namespace MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class MentorGroup
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, Student> listOfStudents = new SortedDictionary<string, Student>();

            var firstToken = Console.ReadLine();

            while (firstToken != "end of dates")
            {
                char[] splitOption = new char[2] {' ', ','};
                var input = firstToken.Split(splitOption);

                var studentName = input[0];

                List<DateTime> dates = new List<DateTime>();
                Student currentStudent = new Student();

                currentStudent.Name = studentName;

                if (input.Length > 1)
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        DateTime date = DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dates.Add(date);
                    }
                }

                if (!listOfStudents.ContainsKey(studentName))
                {
                    listOfStudents.Add(studentName, currentStudent);
                    currentStudent.ReleaseDate = dates;
                }
                else
                {
                    listOfStudents[studentName].ReleaseDate.AddRange(dates);
                }

                firstToken = Console.ReadLine();
            }

            var secondToken = Console.ReadLine();

            while (secondToken != "end of comments")
            {
                var input = secondToken.Split('-');

                var studentName = input[0];

                List<string> comments = new List<string>();

                if (input.Length > 1)
                {
                    comments.Add(input[1]);
                }

                if (listOfStudents.ContainsKey(studentName))
                {
                    if (listOfStudents[studentName].Comments != null)
                    {
                        listOfStudents[studentName].Comments.AddRange(comments);
                    }
                    else
                    {
                        listOfStudents[studentName].Comments = comments;
                    }
                }

                secondToken = Console.ReadLine();
            }


            foreach (var student in listOfStudents)
            {
                Console.WriteLine("{0}", student.Key);
                Console.WriteLine("Comments:");

                if (student.Value.Comments != null)
                {
                    foreach (var comments in student.Value.Comments)
                    {

                        Console.WriteLine("- {0}", comments);
                    }
                }

                Console.WriteLine("Dates attended: ");

                foreach (var date in student.Value.ReleaseDate.OrderBy(x => x))
                {
                    Console.WriteLine("-- {0:dd/MM/yyyy}", date);
                }
            } 
        }
    }
}
