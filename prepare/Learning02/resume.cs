public class Resume
{
    private string _name;
    private List<Job>_jobs;

    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }
}
