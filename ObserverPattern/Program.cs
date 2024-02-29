// See https://aka.ms/new-console-template for more information


using ObserverPattern;

Company company = new Company();

company.AddCandidates(new Candidate{
   Name = "Hassan"
});

company.AddCandidates(new Candidate
{
    Name = "Nick"
});

company.AddOpportunity(new Opportunity
{
    Name = "DevOps Enginner"
});

company.AddOpportunity(new Opportunity
{
    Name = "Tech Lead"
});

