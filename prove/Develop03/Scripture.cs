public class Scripture{

private string _scripture;
private List<string> _wordList = new List<string>();
Word Word1 = new Word();


public string GetScripture(){
    return _scripture;
}
public void SetScripture(string inputScripture){
    _scripture = inputScripture;
}

public int GetWordCount(){
    int wordCount = _wordList.Count();
    return wordCount;
}

public List<string> GetWordList(){
    return _wordList;
}
public void SetWordList(List<string> inputWordList){
    _wordList = inputWordList;
}

//TURNS A LIST OF STRINGS SPLIT BY SPACES BACK INTO A STRING
public string ListToStr(List<string> wordList){
    string words = "";
    foreach (string word in wordList){
        words = words + word + " ";
    }
    return words;
}

//SPLITS A STRING BY SPACES INTO A LIST
public List<string> StrToList(string words){
    return words.Split(" ").ToList<string>();
}

//CALLS THE FUNCTION TO HIDE WORDS IN THE Word CLASS BASED ON THE NUMBER OF HIDES THE USER CHOSE
public List<string> HideWords(int _numberOfHides){
    List<string> wordListWithBlanks = Word1.RandomizeBlanks(_wordList, _numberOfHides);
    return wordListWithBlanks;
}










}