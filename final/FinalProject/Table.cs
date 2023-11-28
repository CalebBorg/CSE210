using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Diagnostics;

public class Table{

List<bool> _isFodderCardPlaced = new List<bool>{false,false,false,false,false,false,false,false,false};
List<bool> _isRoyalCardPlaced = new List<bool>{false,false,false,false,false,false,false,false,false,false,false,false};
List<Stack> _cardStacks = new List<Stack>();
List<Card> _boardState = new List<Card>();
List<Card> _royalCourt = new List<Card>{new Card("placeholder",0), new Card("placeholder",0), new Card("placeholder",0), new Card("placeholder",0), new Card("placeholder",0), new Card("placeholder",0), new Card("placeholder",0), new Card("placeholder",0), new Card("placeholder",0), new Card("placeholder",0), new Card("placeholder",0), new Card("placeholder",0)};
List<Card> _dicardPile = new List<Card>();


public Card GetFodder(int location){
    return _boardState[location];
}

public Card GetRoyal(int location){
    return _royalCourt[location];
}

public void InitializeCardStacks(List<Stack> stacks){
    foreach(Stack stack in stacks){
        _cardStacks.Add(stack);
    }
}

public void UpdateIndividualCardStacks(Stack stack, int coordinate){
    _cardStacks[coordinate] = stack;
}

public void UpdateBoardState(){
    _boardState.Clear();
    for (int i = 0 ; i<9 ; i++){
        _boardState.Add(_cardStacks[i].GetTop());
    }
}

public void UpdateRoyalCourt(int location, Card royal){
    _royalCourt[location] = royal;
}

public void InitializeRoyalCourt(){
    for (int i = 0; i < 13; i++){
        _royalCourt[i] = new Card("placeholder",0);
    }
}

public Stack GetStack(int location){
    return _cardStacks[location];
}

public List<Stack> GetStacks(){
    return _cardStacks;
}

public void PlaceCard(Card draw, int location){
_cardStacks[location].GetAll().Add(draw);
}

public void CannonFire(int location){
    if (location ==1){
//add cards 2 and 3
//add cards 4 and 7
//check for royals
//check if royal dies
//remove royal
    }
    else if (location == 3){
//add cards 1 and 2
//add cards 6 and 9
//check for royals
//check if royal dies
//remove royal
    }
    else if (location == 7){
//add cards 8 and 9
//add cards 1 and 4
//check for royals
//check if royal dies
//remove royal
    }
    else if (location == 9){
//add cards 7 and 8
//add cards 3 and 5
//check for royals
//check if royal dies
//remove royal
    }
}

public void PlaceRoyal(Card royal){
    bool suitMatch = false;
    bool colorMatch = false;
    int index = 0;
    int counter = 0;
    Card highCard = new Card("placeholder",0);
    List<Card> suitMatchList = new List<Card>();
    List<Card> colorMatchList = new List<Card>();
    List<Card> noMatchList = new List<Card>();

    foreach (Card fodder in _boardState){
        counter++;
        if (counter == 5){
            
        }
        else if (fodder.GetSuit() == royal.GetSuit()){
            suitMatchList.Add(fodder);
            suitMatch = true;
        }
    }

    counter = 0;
    foreach (Card nonSuitMatchFodder in _boardState){
        counter ++;
        if (counter == 5){

        }
        else if (nonSuitMatchFodder.GetColor() == royal.GetColor()){
            colorMatchList.Add(nonSuitMatchFodder);
            colorMatch = true;
        }
    }

    counter = 0;
    foreach(Card nonColorMatchFodder in _boardState){
        counter ++;
        if (counter == 5){

        }
        else{
            noMatchList.Add(nonColorMatchFodder);
        }
        
    }

    foreach (Card fodderSuitMatch in suitMatchList){
        if (fodderSuitMatch.GetValue() > highCard.GetValue()){
            index = _boardState.IndexOf(fodderSuitMatch);
            if (GetOpenCourtPositions(index)[0] != 12){
                highCard = fodderSuitMatch;
            }

        }
    }
    if (highCard.GetValue() == 0){
        foreach (Card fodderColorMatch in colorMatchList){
            if (fodderColorMatch.GetValue() > highCard.GetValue()){
                index = _boardState.IndexOf(fodderColorMatch);
                if (GetOpenCourtPositions(index)[0] != 12){
                    highCard = fodderColorMatch;
                }

            }
        }
    }

    if (highCard.GetValue() == 0){
        foreach (Card fodderNoMatch in noMatchList){
            if (fodderNoMatch.GetValue() > highCard.GetValue()){
                index = _boardState.IndexOf(fodderNoMatch);
                if (GetOpenCourtPositions(index)[0] != 12){
                    highCard = fodderNoMatch;
                }

            }
        }
    }

    foreach (Card fodder in _boardState){
        if (highCard == fodder){
            index = _boardState.IndexOf(fodder);
        }
    }
    
    if (index == 0){
        List<int> spaces = GetOpenCourtPositions(index);
        if (spaces.Count() > 1){
            Console.WriteLine($"Do you want to put your royal 'above' or to the 'left' of the {_boardState[index].GetValue()} of {_boardState[index].GetSuit()}?");
            while(true){
                string input = Console.ReadLine().ToLower();
                if (input == "above"){
                    _royalCourt[0] = royal;
                    break;
                }
                if (input == "left"){
                    _royalCourt[3] = royal;
                    break;
                }
                else{
                    Console.WriteLine("Invalid input");
                }
            }
        }
        else{
            _royalCourt[spaces[0]] = royal;
        }
    }
    if (index == 2){
        List<int> spaces = GetOpenCourtPositions(index);
        if (spaces.Count() > 1){
            Console.WriteLine($"Do you want to put your royal 'above' or to the 'right' of the {_boardState[index].GetValue()} of {_boardState[index].GetSuit()}?");
            while(true){
                string input = Console.ReadLine().ToLower();
                if (input == "above"){
                    _royalCourt[2] = royal;
                    break;
                }
                if (input == "right"){
                    _royalCourt[4] = royal;
                    break;
                }
                else{
                    Console.WriteLine("Invalid input");
                }
            }
        }
        else{
            _royalCourt[spaces[0]] = royal;
        }
    }
    if (index == 6){
        List<int> spaces = GetOpenCourtPositions(index);
        if (spaces.Count() > 1){
            Console.WriteLine($"Do you want to put your royal 'below' or to the 'left' of the {_boardState[index].GetValue()} of {_boardState[index].GetSuit()}?");
            while(true){
                string input = Console.ReadLine().ToLower();
                if (input == "below"){
                    _royalCourt[9] = royal;
                    break;
                }
                if (input == "left"){
                    _royalCourt[7] = royal;
                    break;
                }
                else{
                    Console.WriteLine("Invalid input");
                }
            }
        }
        else{
            _royalCourt[spaces[0]] = royal;
        }
        
    }
    if (index == 8){
        List<int> spaces = GetOpenCourtPositions(index);
        if (spaces.Count() > 1){
            Console.WriteLine($"Do you want to put your royal 'below' or to the 'right' of the {_boardState[index].GetValue()} of {_boardState[index].GetSuit()}?");
            while(true){
                string input = Console.ReadLine().ToLower();
                if (input == "below"){
                    _royalCourt[11] = royal;
                    break;
                }
                if (input == "right"){
                    _royalCourt[8] = royal;
                    break;
                }
                else{
                    Console.WriteLine("Invalid input");
                }
            }
        }
        else{
            _royalCourt[spaces[0]] = royal;
        }
    }



    if (index == 1){
        _royalCourt[1] = royal;
    }
    if (index == 3){
        _royalCourt[5] = royal;
    }
    if (index == 5){
        _royalCourt[6] = royal;
    }
    if (index == 7){
        _royalCourt[10] = royal;
    }
}

public List<int> GetOpenCourtPositions(int index){
    List<int> spaces = new List<int>();
    switch(index){
        case 0: 
            if (_royalCourt[0].GetValue() == 0){
                spaces.Add(0);
            }
            if (_royalCourt[3].GetValue() == 0){
                spaces.Add(3);
            }
            else{
                spaces.Add(12);
            }
            break;
        case 1:
            if (_royalCourt[1].GetValue() == 0){
                spaces.Add(1);
            }
            else{
                spaces.Add(12);
            }
            break;
        case 2: 
            if (_royalCourt[2].GetValue() == 0){
                spaces.Add(2);
            }
            if (_royalCourt[4].GetValue() == 0){
                spaces.Add(4);
            }
            else{
                spaces.Add(12);
            }
            break;
        case 3:
            if (_royalCourt[5].GetValue() == 0){
                spaces.Add(5);
            }
            else{
                spaces.Add(12);
            }
            break;
        case 5:
            if (_royalCourt[6].GetValue() == 0){
                spaces.Add(6);
            }
            else{
                spaces.Add(12);
            }
            break;
        case 6: 
            if (_royalCourt[7].GetValue() == 0){
                spaces.Add(7);
            }
            if (_royalCourt[9].GetValue() == 0){
                spaces.Add(9);
            }
            else{
                spaces.Add(12);
            }
            break;
        case 7:
            if (_royalCourt[10].GetValue() == 0){
                spaces.Add(10);
            }
            else{
                spaces.Add(12);
            }
            break;
        case 8: 
            if (_royalCourt[8].GetValue() == 0){
                spaces.Add(8);
            }
            if (_royalCourt[11].GetValue() == 0){
                spaces.Add(11);
            }
            else{
                spaces.Add(12);
            }
            break;
    }
    return spaces;
}

public List<Card> GetRoyalCourt(){
    return _royalCourt;
}

public void ArmorRoyal(int index, Card armor){
    _royalCourt[index-1].SetArmor(armor.GetValue());
}


}