class EternalGoal : Goal
{
    private int _timesCompleted;
    public EternalGoal(string text, int value) : base(text, value)
    {
        _timesCompleted = 0;
        _completed = false;
    }

    override public string GetCompleted()
    {
        return _timesCompleted.ToString() + " times (never really finished)";
    }

    public override void Complete()
    {
        _completed = false;
        _timesCompleted++;
    }

    public override int GetValue()
    {
        return _basePointValue*_timesCompleted;
    }

    public override string GetStringRepresentation()
    {
        string representation = _goalText;
        representation += ":";
        representation += _basePointValue.ToString();
        representation += ":";
        representation += _completed.ToString();
        representation += ":";
        representation += _timesCompleted.ToString();
        return representation;
    }
}