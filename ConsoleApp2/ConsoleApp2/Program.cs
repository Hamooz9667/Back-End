using System.ComponentModel;
using System.Text;

namespace ConsoleApp2
{
    enum StudentLevel { Freshman, Sophomore, Junior, Senior }

    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_STUDENTS = 3;
            List<string> studentNames = new List<string>();
            Dictionary<string, List<int>> studentGrades = new Dictionary<string, List<int>>();
            StringBuilder report = new StringBuilder();

            for (int i = 0; i < MAX_STUDENTS; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                studentNames.Add(name);

                List<int> grades = new List<int>();
                for (int g = 0; g < 3; g++)
                {
                    Console.Write("Enter grade " + (g + 1) + " for " + name + ": ");
                    int grade;
                    while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
                    {
                        Console.Write("Invalid. Enter 0-100: ");
                    }
                    grades.Add(grade);
                }
                studentGrades.Add(name, grades);
            }

            report.AppendLine("Name\tAverage\tLevel");

            foreach (string name in studentNames)
            {
                double average = studentGrades[name].Average();

                StudentLevel level;
                if (average < 20) level = StudentLevel.Freshman;
                else if (average < 40) level = StudentLevel.Sophomore;
                else if (average < 60) level = StudentLevel.Junior;
                else level = StudentLevel.Senior;

                report.AppendLine(name + "\t" + average.ToString("F2") + "\t" + level);
            }

            Console.WriteLine(report.ToString());
        }
    }
}