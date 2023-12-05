using System.Data;
using System.Runtime.InteropServices;

public class Deck{

List<Card> _deckList = new List<Card>{
new Ace("♠",1), new Fodder("♠",2), new Fodder("♠",3), new Fodder("♠",4), new Fodder("♠",5), new Fodder("♠",6), new Fodder("♠",7), new Fodder("♠",8), new Fodder("♠",9), new Fodder("♠",10), new Royal("♠",11,"jack",0), new Royal("♠",12,"queen",0), new Royal("♠",13,"king",0), 
new Ace("♣",1), new Fodder("♣",2), new Fodder("♣",3), new Fodder("♣",4), new Fodder("♣",5), new Fodder("♣",6), new Fodder("♣",7), new Fodder("♣",8), new Fodder("♣",9), new Fodder("♣",10), new Royal("♣",11,"jack",0), new Royal("♣",12,"queen",0), new Royal("♣",13,"king",0), 
new Ace("♦",1), new Fodder("♦",2), new Fodder("♦",3), new Fodder("♦",4), new Fodder("♦",5), new Fodder("♦",6), new Fodder("♦",7), new Fodder("♦",8), new Fodder("♦",9), new Fodder("♦",10), new Royal("♦",11,"jack",0), new Royal("♦",12,"queen",0), new Royal("♦",13,"king",0), 
new Ace("♥",1), new Fodder("♥",2), new Fodder("♥",3), new Fodder("♥",4), new Fodder("♥",5), new Fodder("♥",6), new Fodder("♥",7), new Fodder("♥",8), new Fodder("♥",9), new Fodder("♥",10), new Royal("♥",11,"jack",0), new Royal("♥",12,"queen",0), new Royal("♥",13,"king",0), 
};

List<Card> _drawnList = new List<Card>();
Card _currentDraw;
Random random = new Random();



public void AddCards(List<Card> cards){
    foreach (Card card in cards){
        _deckList.Add(card);
    }
}


public Card DrawCard(){
    Card draw = _deckList[0];
    _drawnList.Add(_deckList[0]);
    _deckList.Remove(_deckList[0]);
    return draw;
}

public void Shuffle(int deckLength){
    List<int> indexDeck =  new List<int>();
    List<Card> emptyDeck = new List<Card>();
    int counter = 0;
    for (int i = 0; i < deckLength; i++){
        indexDeck.Add(i);
    }
    for (int i = 0; i < deckLength; i++){
        emptyDeck.Add(new Card("♠",0));
    }

    for (int i = 0; i < deckLength; i++){
        int randomIndex = random.Next(0,indexDeck.Count());
        emptyDeck[indexDeck[randomIndex]] = _deckList[counter];
        indexDeck.Remove(indexDeck[randomIndex]);
        counter++;
    }
    _deckList = emptyDeck;
}

public List<Card> GetDeckList(){
    return _deckList;
}

public List<Card> GetDrawnList(){
    return _drawnList;
}

}