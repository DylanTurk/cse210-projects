using System;
using System.IO;
using System.Threading.Tasks.Dataflow;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        entry = 1;
        Entry entry = new Entry(); 
        entry._response = Console.ReadLine();

        entry._prompt = RandomPrompt();

        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();

        entry += 1;
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Entry.Display();
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");

        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(Entry.Display());
            }
        }
    }

    public void Load()
    {
        string filename = Console.WriteLine("What is the filename?");
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
    
}