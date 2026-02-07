abstract class Goal
{
    protected string _goalText;
    protected int _basePointValue;
    protected bool _completed;
    
    // constructor
    protected Goal(string text, int baseValue)
    {
        _goalText = text;
        _basePointValue = baseValue;
        _completed = false;
    }
    
    virtual public void Complete()
    {
        _completed = true;
    }
    
    public string GetText()
    {
        return _goalText;
    }
    
    virtual public int GetValue()
    {
        if (_completed)
        {
            return _basePointValue;
        } else
        {
            return 0;
        }
    }
    
    virtual public string GetCompleted()
    {
        if (_completed)
        {
            return "true";
        } else
        {
            return "false";
        }
    }
    
    virtual public string GetStringRepresentation()
    {
        string representation = _goalText;
        representation += ":";
        representation += _basePointValue.ToString();
        representation += ":";
        representation += _completed.ToString();
        return representation;
    }
}