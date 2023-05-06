public class Job
{
    private string _company;
    private int _startYear;
    private int _endyear;
    private string _jobTitle;

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endyear = endYear;
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endyear}");
    }

    
}