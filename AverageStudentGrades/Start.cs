using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Start
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> data = new Dictionary<string, List<double>>();

            while (num>0)
            {
                string[] info = Console.ReadLine().Split();
                var studentName = info[0];
                var grade = double.Parse(info[1]);

                if (!data.ContainsKey(studentName))
                {
                    data.Add(studentName, new List<double>());
                }
                data[studentName].Add(grade);
                num--;
            }

            foreach (var student in data)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x => x.ToString("F2")))} (avg: {student.Value.Average().ToString("F2")})");
            }


        }
    }
}
