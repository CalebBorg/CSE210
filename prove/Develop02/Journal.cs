using System.IO.Enumeration;
using Microsoft.Win32.SafeHandles;

public class Journal{


public static List<string> _journalEntries = new List<string>();
public static string _fileName;



public static List<string> InitializeJournal(string _fileName, List<string> _journalEntries){

    StreamReader _textFile = new StreamReader($"C:/Users/Caleb/OneDrive/Documents/1Sophomore Year/CSE210/prove/Develop02/{_fileName}");
    string line = _textFile.ReadLine();
    while(line!=null){
        _journalEntries.Add(line);
        line = _textFile.ReadLine();
    }
    _textFile.Close();
    return _journalEntries;
}


public static void RefreshFile(string _fileName, List<string> _journalEntries){

    string _fileText = File.ReadAllText($@"C:/Users/Caleb/OneDrive/Documents/1Sophomore Year/CSE210/prove/Develop02/{_fileName}");
    string _entryText = string.Join(Environment.NewLine, _journalEntries.ToArray());

    _fileText = _fileText.Replace($"{_fileText}",$"{_entryText}");
    File.WriteAllText($@"C:/Users/Caleb/OneDrive/Documents/1Sophomore Year/CSE210/prove/Develop02/{_fileName}", _fileText);
}



}