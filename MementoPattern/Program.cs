// See https://aka.ms/new-console-template for more information

// Memento Pattern: useful for defensive coding, and useful to return to an initial point from where the process started.

using MementoPattern;

var student = new Student();
Console.WriteLine($"Student initial status {student.Status}");

try
{
    student.StartAdmissionProcess();
    throw new Exception();
}
catch (Exception)
{
    student.Revert();
}

Console.WriteLine($"Student status after failure {student.Status}");
Console.ReadKey();
