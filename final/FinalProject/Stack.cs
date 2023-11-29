public class Stack{

List<Card> Cards = new List<Card>();


public List<Card> GetAll(){
    return Cards;
}

public Card GetTop(){
    return Cards.Last();
}

public void PlaceCard(Card card){
    Cards.Add(card);
}

public void ClearStack(){
    Cards.Clear();
}


}