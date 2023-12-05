public class Stack{

List<Card> Cards = new List<Card>();

//RETURNS ALL THE CARDS IN A STACK
public List<Card> GetAll(){
    return Cards;
}

//RETURNS THE TOP CARD OF THE STACK
public Card GetTop(){
    return Cards.Last();
}

//ADDS A CARD TO THE TOP OF THE STACK
public void PlaceCard(Card card){
    Cards.Add(card);
}

//EMPTIES A STACK
public void ClearStack(){
    Cards.Clear();
}


}