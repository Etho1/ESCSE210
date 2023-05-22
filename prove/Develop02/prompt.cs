public class Prompt
{

    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("How was your day?");
        _prompts.Add("What was todays highlight?");
        _prompts.Add("When was a moment today where you felt at peace?");
        _prompts.Add("How do you feel about todays events?");
        _prompts.Add("What was the most interesting thing I saw or heard today?");
        _prompts.Add("What am I grateful for today?");
        _prompts.Add("What did I do today that I am proud of?");
        _prompts.Add("What did I learn today?");
        _prompts.Add("What was the worst thing that happened today?");
        _prompts.Add("What was the best thing that happened today?");
    }
    // public usedPrompt(_prompts)
    // {


    // }
    public string returnRandomPrompt()
    {
        var rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return (_prompts[index]);
    }


}