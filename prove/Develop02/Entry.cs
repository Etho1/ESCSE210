public class Entry
{
    public string _prompt;
    private string _entry = "";
    private string _date;
    public Entry(string entry, string prompt) {
        DateTime d = DateTime.Now;
        _date = d.ToShortDateString();
        _prompt = prompt;
        _entry = entry;
    }
    public string GetEntry(){
        return ($"Date: {_date} \n {_prompt} \n --> {_entry} \n --------------------------------------------");
    }

    // public void CreateFromList(){
    //     _dateText = items[0];
    //     _prompt = items[1];
    //     _entry = items[2];
    // }

}