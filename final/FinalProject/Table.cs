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
List<Card> _killList = new List<Card>();


public Card GetFodder(int location){
    return _boardState[location];
}

public Card GetRoyal(int location){
    return _royalCourt[location];
}

public List<Card> GetBoardState(){
    return _boardState;
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

public List<int> FindTarget(List<Card> boardState, List<Card> royalCourt, List<Card> fodder, List<Card> royals){
    List<int> hits = new List<int>();
    if (royals[0].GetValue() != 0){
        if (fodder[0].GetValue() + fodder[1].GetValue() >= royals[0].GetValue() + royals[0].GetArmor()){
            switch(royals[0].GetFace()){
                case "king":
                    if(fodder[0].GetSuit() == royals[0].GetSuit() && fodder[1].GetSuit() == royals[0].GetSuit()){
                        hits.Add(0);
                    }
                    break;
                case "queen":
                    if(fodder[0].GetColor() == royals[0].GetColor() && fodder[1].GetColor() == royals[0].GetColor()){
                        hits.Add(0);
                    }
                    break;
                default:
                    hits.Add(0);
                    break;
            }
        }
    }
    if (royals[1].GetValue() != 0){
        if (fodder[2].GetValue() + fodder[3].GetValue() >= royals[1].GetValue() + royals[1].GetArmor()){
            switch(royals[1].GetFace()){
                case "king":
                    if(fodder[2].GetSuit() == royals[1].GetSuit() && fodder[3].GetSuit() == royals[1].GetSuit()){
                        hits.Add(1);
                    }
                    break;
                case "queen":
                    if(fodder[2].GetColor() == royals[1].GetColor() && fodder[3].GetColor() == royals[1].GetColor()){
                        hits.Add(1);
                    }
                    break;
                default:
                    hits.Add(1);
                    break;
            }
        }
                
    }
    return hits;
}


public void CannonFire(int location, List<Card> boardState, List<Card> royalCourt){
    switch(location){
        case 0:
            List<Card> fodder0 = new List<Card>{boardState[1],boardState[2],boardState[3],boardState[6]};
            List<Card> royals0 = new List<Card>{royalCourt[4],royalCourt[9]};
            List<int> hits0 = FindTarget(boardState, royalCourt, fodder0, royals0);
            if (hits0.Count() > 0){
                Console.WriteLine($"Cannon Fire!");
                Thread.Sleep(1000);
            }
            if (hits0.Contains(0)){
                Console.WriteLine($"The {royalCourt[4].GetFace()} of {royalCourt[4].GetSuit()} is Dead!");
                _killList.Add(royalCourt[4]);
                Thread.Sleep(1000);
                royalCourt[4] = new Card("placeholder",0);
            }
            if (hits0.Contains(1)){
                Console.WriteLine($"The {royalCourt[9].GetFace()} of {royalCourt[9].GetSuit()} is Dead!");
                _killList.Add(royalCourt[9]);
                Thread.Sleep(1000);
                royalCourt[9] = new Card("placeholder",0);
            }
            break;
        case 1:
            List<Card> fodder1 = new List<Card>{boardState[4], boardState[7]};
            List<Card> royals1 = new List<Card>{royalCourt[10], new Card("placeholder",0)};
            List<int> hits1 = FindTarget(boardState, royalCourt, fodder1, royals1);
            if (hits1.Count() > 0){
                Console.WriteLine($"Cannon Fire!");
                Thread.Sleep(1000);
            }
            if (hits1.Contains(0)){
                Console.WriteLine($"The {royalCourt[10].GetFace()} of {royalCourt[10].GetSuit()} is Dead!");
                _killList.Add(royalCourt[10]);
                Thread.Sleep(1000);
                royalCourt[10] = new Card("placeholder",0);
            }
            break;
        case 2:
            List<Card> fodder2 = new List<Card>{boardState[0],boardState[1],boardState[5],boardState[8]};
            List<Card> royals2 = new List<Card>{royalCourt[3],royalCourt[11]};
            List<int> hits2 = FindTarget(boardState, royalCourt, fodder2, royals2);
            if (hits2.Count() > 0){
                Console.WriteLine($"Cannon Fire!");
                Thread.Sleep(1000);
            }
            if (hits2.Contains(0)){
                Console.WriteLine($"The {royalCourt[3].GetFace()} of {royalCourt[3].GetSuit()} is Dead!");
                _killList.Add(royalCourt[3]);
                Thread.Sleep(1000);
                royalCourt[3] = new Card("placeholder",0);
            }
            if (hits2.Contains(1)){
                Console.WriteLine($"The {royalCourt[11].GetFace()} of {royalCourt[11].GetSuit()} is Dead!");
                _killList.Add(royalCourt[11]);
                Thread.Sleep(1000);
                royalCourt[11] = new Card("placeholder",0);
            }
            break;
        case 3:
            List<Card> fodder3 = new List<Card>{boardState[4],boardState[5]};
            List<Card> royals3 = new List<Card>{royalCourt[6], new Card("placeholder", 0)};
            List<int> hits3 = FindTarget(boardState, royalCourt, fodder3, royals3);
            if (hits3.Count() > 0){
                Console.WriteLine($"Cannon Fire!");
                Thread.Sleep(1000);
            }
            if (hits3.Contains(0)){
                Console.WriteLine($"The {royalCourt[6].GetFace()} of {royalCourt[6].GetSuit()} is Dead!");
                _killList.Add(royalCourt[6]);
                Thread.Sleep(1000);
                royalCourt[6] = new Card("placeholder",0);
            }
            break;
        case 4:
            break;
        case 5:
            List<Card> fodder5 = new List<Card>{boardState[3],boardState[4]};
            List<Card> royals5 = new List<Card>{royalCourt[5],new Card("placeholder",0)};
            List<int> hits5 = FindTarget(boardState, royalCourt, fodder5, royals5);
            if (hits5.Count() > 0){
                Console.WriteLine($"Cannon Fire!");
                Thread.Sleep(1000);
            }
            if (hits5.Contains(0)){
                Console.WriteLine($"The {royalCourt[5].GetFace()} of {royalCourt[5].GetSuit()} is Dead!");
                _killList.Add(royalCourt[5]);
                Thread.Sleep(1000);
                royalCourt[5] = new Card("placeholder",0);
            }
            break;
        case 6:
            List<Card> fodder6 = new List<Card>{boardState[3],boardState[0],boardState[7],boardState[8]};
            List<Card> royals6 = new List<Card>{royalCourt[0],royalCourt[8]};
            List<int> hits6 = FindTarget(boardState, royalCourt, fodder6, royals6);
            if (hits6.Count() > 0){
                Console.WriteLine($"Cannon Fire!");
                Thread.Sleep(1000);
            }
            if (hits6.Contains(0)){
                Console.WriteLine($"The {royalCourt[0].GetFace()} of {royalCourt[0].GetSuit()} is Dead!");
                _killList.Add(royalCourt[0]);
                Thread.Sleep(1000);
                royalCourt[0] = new Card("placeholder",0);
            }
            if (hits6.Contains(1)){
                Console.WriteLine($"The {royalCourt[8].GetFace()} of {royalCourt[8].GetSuit()} is Dead!");
                _killList.Add(royalCourt[8]);
                Thread.Sleep(1000);
                royalCourt[8] = new Card("placeholder",0);
            }
            break;
        case 7:
            List<Card> fodder7 = new List<Card>{boardState[1],boardState[4]};
            List<Card> royals7 = new List<Card>{royalCourt[1], new Card("placeholder",0)};
            List<int> armor7 = new List<int>{royalCourt[1].GetArmor(),0};
            List<string> face7 = new List<string>{royalCourt[1].GetFace()};
            List<int> hits7 = FindTarget(boardState, royalCourt, fodder7, royals7);
            if (hits7.Count() > 0){
                Console.WriteLine($"Cannon Fire!");
                Thread.Sleep(1000);
            }
            if (hits7.Contains(0)){
                Console.WriteLine($"The {royalCourt[1].GetFace()} of {royalCourt[1].GetSuit()} is Dead!");
                _killList.Add(royalCourt[1]);
                Thread.Sleep(1000);
                royalCourt[1] = new Card("placeholder",0);
            }
            break;
        case 8:
            List<Card> fodder8 = new List<Card>{boardState[2],boardState[5],boardState[6],boardState[7]};
            List<Card> royals8 = new List<Card>{royalCourt[2],royalCourt[7]};
            List<int> armor8 = new List<int>{royalCourt[2].GetArmor(),royalCourt[7].GetArmor()};
            List<string> face8 = new List<string>{royalCourt[2].GetFace(),royalCourt[7].GetFace()};
            List<int> hits8 = FindTarget(boardState, royalCourt, fodder8, royals8);
            if (hits8.Count() > 0){
                Console.WriteLine($"Cannon Fire!");
                Thread.Sleep(1000);
            }
            if (hits8.Contains(0)){
                Console.WriteLine($"The {royalCourt[2].GetFace()} of {royalCourt[2].GetSuit()} is Dead!");
                _killList.Add(royalCourt[2]);
                Thread.Sleep(1000);
                royalCourt[2] = new Card("placeholder",0);
            }
            if (hits8.Contains(1)){
                Console.WriteLine($"The {royalCourt[7].GetFace()} of {royalCourt[7].GetSuit()} is Dead!");
                _killList.Add(royalCourt[7]);
                Thread.Sleep(1000);
                royalCourt[7] = new Card("placeholder",0);
            }
            break;
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
            if(spaces.Count() == 0){
                spaces.Add(12);
            }
            break;
        case 1:
            if (_royalCourt[1].GetValue() == 0){
                spaces.Add(1);
            }
            if(spaces.Count() == 0){
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
            if(spaces.Count() == 0){
                spaces.Add(12);
            }
            break;
        case 3:
            if (_royalCourt[5].GetValue() == 0){
                spaces.Add(5);
            }
            if(spaces.Count() == 0){
                spaces.Add(12);
            }
            break;
        case 5:
            if (_royalCourt[6].GetValue() == 0){
                spaces.Add(6);
            }
            if(spaces.Count() == 0){
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
            if(spaces.Count() == 0){
                spaces.Add(12);
            }
            break;
        case 7:
            if (_royalCourt[10].GetValue() == 0){
                spaces.Add(10);
            }
            if(spaces.Count() == 0){
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
            if(spaces.Count() == 0){
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

public List<Card> GetKillList(){
    return _killList;
}

}