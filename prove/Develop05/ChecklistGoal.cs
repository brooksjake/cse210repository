class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _desiredTimes;
    private int _bonusValue;
    public ChecklistGoal(string text, int value, int desiredTimes, int bonus) : base(text, value)
    {
        if (desiredTimes != 0)
        {
            _desiredTimes = desiredTimes;
        } else
        {
            _desiredTimes = 1;
        }
        _bonusValue = bonus;
    }

    override public string GetCompleted()
    {
        return _completed + ", " + _timesCompleted.ToString() + " times / " + _desiredTimes.ToString() + " goal";
    }

    override public void Complete()
    {
        _timesCompleted++;
        if (_timesCompleted % _desiredTimes == 0)
        {
            _completed = true;
        }
    }
    
    override public int GetValue()
    {
        int total = _basePointValue * _timesCompleted;
        int completions = _timesCompleted / _desiredTimes;
        total += completions * _bonusValue;
        return total;
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
        representation += ":";
        representation += _desiredTimes.ToString();
        representation += ":";
        representation += _bonusValue.ToString();
        return representation;
    }
    
    
}