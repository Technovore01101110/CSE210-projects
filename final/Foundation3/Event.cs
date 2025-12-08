using System.Dynamic;

class Event
{
    private string _splitter = "-------------------------------";
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string titleP, string descriptionP, string dateP, 
                 string timeP, string addressP)
    {
        _title = titleP;
        _description = descriptionP;
        _date = dateP;
        _time = timeP;
        _address = addressP;
    }

    public string GetStandardInfo()
    {
        string standardInfo = "";

        standardInfo += _splitter;
        standardInfo += $"\n\"{_title}\"\n";
        standardInfo += $"\n{_description}";
        standardInfo += $"\n- {_date} {_time}";
        standardInfo += $"\nAddress: {_address}\n";
        standardInfo += _splitter;

        return standardInfo;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDateTime()
    {
        return _date + " " + _time;
    }

    public string GetAddress()
    {
        return _address;
    }

    public string GetSplitter()
    {
        return _splitter;
    }

    public string GetShortInfo()
    {
        string shortInfo = "";
        shortInfo += _splitter;
        shortInfo += $"\n\"{_title}\"\n";
        shortInfo += $"\nEvent Type: {this.GetType()}";
        shortInfo += $"\n- {_date}\n";
        shortInfo += _splitter;

        return shortInfo;
    }
}