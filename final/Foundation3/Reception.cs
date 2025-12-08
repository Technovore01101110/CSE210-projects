class Reception : Event
{
    private string _contactEmail;

    public Reception(string titleP, string descriptionP, string dateP, 
                 string timeP, string addressP, string contactEmailP): 
                    base(titleP, descriptionP, dateP, timeP, addressP)
    {
        _contactEmail = contactEmailP;
    }

    public string GetReceptionInfo()
    {
        string receptionInfo = ""; 
        receptionInfo += GetSplitter();
        receptionInfo += $"\n\"{GetTitle()}\"\n";
        receptionInfo += $"\nEvent Type: {this.GetType()}";
        receptionInfo += $"\n{GetDescription()}";
        receptionInfo += $"\n- {GetDateTime()}";
        receptionInfo += $"\nRSVP: {_contactEmail}";
        receptionInfo += $"\nAddress: {GetAddress()}\n";
        receptionInfo += GetSplitter();

        return receptionInfo;
    }

}