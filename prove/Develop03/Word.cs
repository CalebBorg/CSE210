public class Word{

//THIS IS THE USER-INPUTTED NUMBER OF WORDS HIDDEN PER ROUND
private int _numberOfHides;
//THIS IS A LIST TO KEEP TRACK OF WHICH WORDS HAVE BEEN TURNED BLANK ALREADY
List<int> _blankIndexes = new List<int>();


public void Set_numberOfHides(int input_numberOfHides){
    _numberOfHides = input_numberOfHides;
}
public int Get_numberOfHides(){
    return _numberOfHides;
}

//THIS FINDS A RANDOM INDEX THAT HASN'T ALREADY BEEN HIDDEN AND HIDES IT, A NUMBER OF TIMES EQUAL TO _numberOfHides
public List<string> RandomizeBlanks(List<string> wordList, int _numberOfHides){
    int listSize = wordList.Count();
    Random randomGenerator = new Random();
    for (int i = 0; i<_numberOfHides; i++){
//IF THE WHOLE STRING IS BLANK, PASS
        if(_blankIndexes.Count() == wordList.Count()){
            return wordList;
        }
//FIND A RANDOM INDEX THAT'S NOT ALREADY BLANK
        else{
            int hiddenWordIndex = randomGenerator.Next(0,listSize);
            if (_blankIndexes.Contains(hiddenWordIndex)){
                i--;
            }
//CREATE A NEW WORD, AND FOR EACH REGULAR CHARACTER IN THE WORD WE WANT TO HIDE, ADD A BLANK TO THIS NEW WORD. DON'T MESS WITH THE PUNCTUATION
            else{
                string newWord = "";
                foreach(char letter in wordList[hiddenWordIndex]){
    
                    if (letter.ToString() != "." && letter.ToString() != "," && letter.ToString() != "-" && letter.ToString() != "'" && letter.ToString() != ";" && letter.ToString() != ":" && letter.ToString() != "" && letter.ToString() != "!" && letter.ToString() != "?" && letter.ToString() != "(" && letter.ToString() != ")" && letter.ToString() != "\""){
                        newWord = newWord + "_";
                    }
                    else{
                        newWord = newWord + letter;
                    }
                }
//SET THE WORD WE WANT TO HIDE TO THIS NEW WORD AND ADD THE INDEX OF THE NOW HIDDEN WORD TO THE LIST OF HIDDEN INDEXES
                wordList[hiddenWordIndex] = newWord;
                _blankIndexes.Add(hiddenWordIndex);
            }
        }
    }
    return wordList;
}



}