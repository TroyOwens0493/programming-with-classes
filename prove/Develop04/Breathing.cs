public class Breathing : Activity
{

    //Attributes
    private int _numOfBreaths;

    //Methods
    private int CalcNumOfBreaths()
    {
        var breathDuration = 12;
        return _duration / breathDuration;
    }
    private void DispInhale()
    {
        Console.Write("Breath in through your nose. ");
        DisplayAnimation(4);
    }
    private void DispExhale()
    {
        Console.Write("Breathe out through your mouth. ");
        DisplayAnimation(8);
    }
    public void BreathingLoop()
    {
        StartActivity();
        DisplayAnimation(5);
        Console.Clear();
        GetDuration();
        GetReady();

        var breaths = CalcNumOfBreaths();
        var count = 0;
        do
        {
            DispInhale();
            Console.Clear();
            DispExhale();
            Console.Clear();
            count ++;
        } while (count < breaths);
    }
}
