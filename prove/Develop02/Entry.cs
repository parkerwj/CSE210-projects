using System;
public class Entry
{
    public string _prompt = "";
    public string _response = "";
    public string _date  = DateTime.Now.ToString("MM/dd/yyyy");

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt} \n{_response}\n");
    }
}