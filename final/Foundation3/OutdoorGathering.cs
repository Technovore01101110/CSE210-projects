class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string titleP, string descriptionP, string dateP, 
                 string timeP, string addressP, string weatherP): base(titleP, 
                                                                 descriptionP,
                                                                 dateP, 
                                                                 timeP,
                                                                 addressP)
    {
        _weather = weatherP;
    }

    public string GetOutdoorGatheringInfo()
    {   
        string outdoorGatheringInfo = "";    
        outdoorGatheringInfo += GetSplitter();
        outdoorGatheringInfo += $"\n\"{GetTitle()}\"\n";
        outdoorGatheringInfo += $"\nEvent Type: {this.GetType()}";
        outdoorGatheringInfo += $"\n{GetDescription()}";
        outdoorGatheringInfo += $"\n- {GetDateTime()}";
        outdoorGatheringInfo += $"\nWeather: {_weather}";
        outdoorGatheringInfo += $"\nAddress: {GetAddress()}\n";
        outdoorGatheringInfo += GetSplitter();

        return outdoorGatheringInfo;
    }

}