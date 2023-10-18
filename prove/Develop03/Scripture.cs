public class Scripture{

private string scripture;
private List<string> wordList = new List<string>();
Word Word1 = new Word();


public string GetScripture(){
    return scripture;
}
public void SetScripture(string inputScripture){
    scripture = inputScripture;
}

public int GetWordCount(){
    int wordCount = wordList.Count();
    return wordCount;
}

public List<string> GetWordList(){
    return wordList;
}
public void SetWordList(List<string> inputWordList){
    wordList = inputWordList;
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
public List<string> HideWords(int numberOfHides){
    List<string> wordListWithBlanks = Word1.RandomizeBlanks(wordList, numberOfHides);
    return wordListWithBlanks;
}










}