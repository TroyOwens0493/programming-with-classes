public class InAndOut
{
    //Attributes
    private DateTime _day = DateTime.Now.Date;
    private int _listsInSession = 0;
    private int _reflectionsInSession = 0;
    private int _breathingsInSession = 0;
    private string _path = "data.txt";

    //Methods
    public void incrementActivityCouter(string activity)
    {
        if (activity == "list")
        {
            _listsInSession++;
        }
        else if (activity == "reflect")
        {
            _reflectionsInSession++;
        }
        else if (activity == "breathe")
        {
            _breathingsInSession++;
        }
    }

    public List<string> GetFromDateRange(string dateRange)
    {
        DateTime startDate = DateTime.Now;
        if (dateRange == "month")
        {
            startDate = startDate.AddMonths(-1);
        }
        else if (dateRange == "year")
        {
            startDate = startDate.AddYears(-1);
        }

        List<string> data = new() { "0", "0", "0" };
        using (StreamReader reader = new StreamReader(_path))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                // Check if the line is a date and within range
                if (DateTime.TryParse(line, out DateTime parsedDate) && parsedDate > startDate)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if ((line = reader.ReadLine()) != null && int.TryParse(line, out int activityCount))
                        {
                            data[i] = (int.Parse(data[i]) + activityCount).ToString();
                        }
                    }
                }
            }
        }
        return data;
    }

    public void WriteSessionData(List<string> data)
    {
        data.Insert(0, _day.ToString());
        File.AppendAllLines(_path, data);
    }
}
