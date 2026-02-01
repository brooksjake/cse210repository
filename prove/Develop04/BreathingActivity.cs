public class BreathingActivity : Activity
{
    private int _inhaleDuration;
    private int _exhaleDuration;
    
    public BreathingActivity()
    {
        setName("Relax by Deliberate Breathing");
        setDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        _inhaleDuration = 4;
        _exhaleDuration = 6;
    }
    
    public void RunActivity()
    {
        
    }
}