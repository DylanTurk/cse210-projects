using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public void AddEntry()
    {
        Entry entry = new Entry();
        PromptGenerator generator = new PromptGenerator();

        entry._prompt = generator.RandomPrompt();
        Console.WriteLine(entry._prompt);
        
        entry._response = Console.ReadLine();


        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();

        entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");

        string filename;
        filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {

                outputFile.WriteLine(entries);
        }
    }

    public void Load()
    {
        
        Console.WriteLine("What is the filename?");

        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);
    }
    
}