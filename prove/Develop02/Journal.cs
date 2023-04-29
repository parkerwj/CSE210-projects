using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void DisplayJournalEntries()
    {
        foreach (Entry item in _entries)
        {
            item.DisplayEntry();
        }
    }
}