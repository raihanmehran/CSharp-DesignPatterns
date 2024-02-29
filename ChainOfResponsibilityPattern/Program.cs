// See https://aka.ms/new-console-template for more information

using ChainOfResponsibilityPattern;

var requirement = new Requirement();

// recruit the team
ProgramManager christine = new ProgramManager();
Architect todd = new Architect();
SoftwareEngineer janet = new SoftwareEngineer();
QAEngineer alex = new QAEngineer();
DevOpsEngineer mike = new DevOpsEngineer();

// introduce the team to each other
christine.HandOverWhenDone(todd);
todd.HandOverWhenDone(janet);
janet.HandOverWhenDone(alex);
alex.HandOverWhenDone(mike);

// meet the client/program manager
christine.Handle(requirement);

// test
foreach(var operation in requirement.OperationsDone)
{
    Console.WriteLine($"{operation} -> Done");
}