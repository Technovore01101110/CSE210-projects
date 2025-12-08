class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string titleP, string descriptionP, string dateP, 
                 string timeP, string addressP, string speakerP,
                 int capacityP): base(titleP, descriptionP, dateP, timeP,
                                      addressP)
    {
        _speakerName = speakerP;
        _capacity = capacityP;
    }

    public string GetLectureInfo()
    {    
        string lectureInfo = "";   
        lectureInfo += GetSplitter();
        lectureInfo += $"\n\"{GetTitle()}\"\n";
        lectureInfo += $"\nEvent Type: {this.GetType()}";
        lectureInfo += $"\nSpeaker: {_speakerName}";
        lectureInfo += $"\n{GetDescription()}";
        lectureInfo += $"\nCapacity: {_capacity}";
        lectureInfo += $"\n- {GetDateTime()}";
        lectureInfo += $"\nAddress: {GetAddress()}\n";
        lectureInfo += GetSplitter();

        return lectureInfo;
    }
}