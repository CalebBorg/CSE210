public class NewEntry{

//DEFINE VARIABLES
public static string _newEntry;
public static List<string> _writingPrompts = new List<string>{
    "Who was the most interesting person you talked to today? What did they say?",
    "What was the most interesting thing that happened to you today?", 
    "Did you create something new or experience something new today? What was it?", 
    "What was the hardest thing you did today?", 
    "Did you feel any strong emotions today? What were they and what caused them?", 
    "What are you grateful for today?", 
    "Write a short poem about something interesting that happened or that you saw today", 
    "Knowing what happened today, how will you live differently or the same tomorrow?", 
    "What was your environment like today? Did you go outside? Did you stay in all day? How's the weather?", 
    "What made you feel very afraid or very brave today?"};
public static string _currentPrompt;
public static Random _randomNumber = new Random();


//ADD THE NEW ENTRY TO THE LIST OF JOURNAL ENTRIES
public static List<string> StoreEntry(string _newEntry, List<string> _journalEntries){

    Journal._journalEntries.Add(_newEntry);
    return Journal._journalEntries;
}


//GENERATE A WRITING PROMPT AND DISPLAY IT
public static void DisplayPrompt(Random _randomNumber, List<string> _writingPrompts){

    int _randomPromptIndex = _randomNumber.Next(10);
    _currentPrompt = _writingPrompts[_randomPromptIndex];
    Console.WriteLine(_currentPrompt);
}
}