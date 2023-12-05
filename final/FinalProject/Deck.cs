using System.Data;
using System.Runtime.InteropServices;

public class Deck{

//INITIALIZES THE DECK WITH EVERY CARD
List<Card> _deckList = new List<Card>{
new Ace("♠",1), new Fodder("♠",2), new Fodder("♠",3), new Fodder("♠",4), new Fodder("♠",5), new Fodder("♠",6), new Fodder("♠",7), new Fodder("♠",8), new Fodder("♠",9), new Fodder("♠",10), new Royal("♠",11,"jack",0), new Royal("♠",12,"queen",0), new Royal("♠",13,"king",0), 
new Ace("♣",1), new Fodder("♣",2), new Fodder("♣",3), new Fodder("♣",4), new Fodder("♣",5), new Fodder("♣",6), new Fodder("♣",7), new Fodder("♣",8), new Fodder("♣",9), new Fodder("♣",10), new Royal("♣",11,"jack",0), new Royal("♣",12,"queen",0), new Royal("♣",13,"king",0), 
new Ace("♦",1), new Fodder("♦",2), new Fodder("♦",3), new Fodder("♦",4), new Fodder("♦",5), new Fodder("♦",6), new Fodder("♦",7), new Fodder("♦",8), new Fodder("♦",9), new Fodder("♦",10), new Royal("♦",11,"jack",0), new Royal("♦",12,"queen",0), new Royal("♦",13,"king",0), 
new Ace("♥",1), new Fodder("♥",2), new Fodder("♥",3), new Fodder("♥",4), new Fodder("♥",5), new Fodder("♥",6), new Fodder("♥",7), new Fodder("♥",8), new Fodder("♥",9), new Fodder("♥",10), new Royal("♥",11,"jack",0), new Royal("♥",12,"queen",0), new Royal("♥",13,"king",0), 
};

List<Card> _drawnList = new List<Card>();
Random random = new Random();


//ADDS A LIST OF CARDS TO THE END OF THE DECK IN ORDER
public void AddCards(List<Card> cards){
    foreach (Card card in cards){
        _deckList.Add(card);
    }
}

//DRAWS THE CARD ON THE TOP OF THE DECK
public Card DrawCard(){
    Card draw = _deckList[0];
    _drawnList.Add(_deckList[0]);
    _deckList.Remove(_deckList[0]);
    return draw;
}

//SHUFFLES THE INDEX OF EVERY CARD IN THE DECK
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

//RETURNS A LIST OF ALL THE CARDS IN THE DECK
public List<Card> GetDeckList(){
    return _deckList;
}

//RETURNS A LIST OF ALL THE CARDS DRAWN FROM THE DECK
public List<Card> GetDrawnList(){
    return _drawnList;
}

}