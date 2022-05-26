using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentGradesDict = new Dictionary<string, List<decimal>>();
            int gradesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < gradesCount; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                string names = line[0];
                decimal grades = decimal.Parse(line[1]);
                if (!studentGradesDict.ContainsKey(names))               
                    studentGradesDict.Add(names, new List<decimal>());               
                studentGradesDict[names].Add(grades);                                             
            }
            foreach (var name in studentGradesDict.Keys)
            {
                List<decimal> grades = studentGradesDict[name];
                string gradesStr = string.Join(" ", grades.Select(g => g.ToString("f2")));
                decimal avg = grades.Average();
                Console.WriteLine($"{name} -> {gradesStr} (avg: {avg:f2})");
            }

        }
    }
}
