using System;
// Inheritance design assignment.

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignmentMath = new MathAssignment("Roberto Rodriguez",
                                                           "Fractions", "3.7",
                                                           "8-19");
        WritingAssignment assignmentWrite = new WritingAssignment("Mary Waters",
                                                                  "European History",
                                                                  "The causes of World War II");

        // Math Display
        Console.WriteLine(assignmentMath.GetSummary());
        Console.WriteLine(assignmentMath.GetHomeworkList());
        Console.WriteLine();

        // Writing Display
        Console.WriteLine(assignmentWrite.GetSummary());
        Console.WriteLine(assignmentWrite.GetWritingInformation());

    }
}