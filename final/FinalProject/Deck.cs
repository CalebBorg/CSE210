using System.Data;
using System.Runtime.InteropServices;

public class Deck{

List<Card> _deckList = new List<Card>{
new Ace("♠",1), new Fodder("♠",2), new Fodder("♠",3), new Fodder("♠",4), new Fodder("♠",5), new Fodder("♠",6), new Fodder("♠",7), new Fodder("♠",8), new Fodder("♠",9), new Fodder("♠",10), new Royal("♠",11,"jack",0), new Royal("♠",12,"queen",0), new Royal("♠",13,"king",0), 
new Ace("♣",1), new Fodder("♣",2), new Fodder("♣",3), new Fodder("♣",4), new Fodder("♣",5), new Fodder("♣",6), new Fodder("♣",7), new Fodder("♣",8), new Fodder("♣",9), new Fodder("♣",10), new Royal("♣",11,"jack",0), new Royal("♣",12,"queen",0), new Royal("♣",13,"king",0), 
new Ace("◆",1), new Fodder("◆",2), new Fodder("◆",3), new Fodder("◆",4), new Fodder("◆",5), new Fodder("◆",6), new Fodder("◆",7), new Fodder("◆",8), new Fodder("◆",9), new Fodder("◆",10), new Royal("◆",11,"jack",0), new Royal("◆",12,"queen",0), new Royal("◆",13,"king",0), 
new Ace("♥",1), new Fodder("♥",2), new Fodder("♥",3), new Fodder("♥",4), new Fodder("♥",5), new Fodder("♥",6), new Fodder("♥",7), new Fodder("♥",8), new Fodder("♥",9), new Fodder("♥",10), new Royal("♥",11,"jack",0), new Royal("♥",12,"queen",0), new Royal("♥",13,"king",0), 
};
List<Card> _drawnList = new List<Card>();
Card _currentDraw;
Random random = new Random();




public Card DrawCard(){
    int randInt = random.Next(0,_deckList.Count());
    if (_deckList.Count() < 5){
        Console.WriteLine($"{_deckList.Count()} draws remaining");
    }
    Card draw = _deckList[randInt];
    _deckList.Remove(_deckList[randInt]);
    _drawnList.Add(draw);
    return draw;
}


}