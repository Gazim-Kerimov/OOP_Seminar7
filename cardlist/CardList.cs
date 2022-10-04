using System.Collections;
public class CardList{
    List<Card> cardlist;
    private static CardList instance;
    private CardList(){
        cardlist = new List<Card>();
    }
    public static CardList getInstance(){
        if(instance == null){
            instance = new CardList();
        }
        return instance;
    }
    public void addCard(Card card){
        cardlist.Add(card);
    }
    public void getInfoByName(string name){
        int tempId = -1;
        for(int i = 0; i < cardlist.Count; i++){
            string tempCard = cardlist[i].ToString();
            if(tempCard.Contains("Name: " + name)){
                tempId = i;
            }
        }
        if(tempId == -1){
            Console.WriteLine("Данного пользователя нет в списке контактов");
        }
        else Console.WriteLine(cardlist[tempId]);
    }
    public void getInfoById(int id){
        int tempId = -1;
        for(int i = 0; i < cardlist.Count; i++){
            string tempCard = cardlist[i].ToString();
            if(tempCard.Contains("ID: " + id)){
                tempId = i;
            }    
        }
        if(tempId == -1) Console.WriteLine("Данного пользователя нет в списке контактов");
        else Console.WriteLine(cardlist[tempId]);
    }
    public void showAll(){
        if(cardlist.Count == 0) Console.WriteLine("Список пуст");
        else{
            for(int i = 0; i < cardlist.Count; i++){
                Console.WriteLine(cardlist[i]);
            }
        }
    }
    public List<Card> getList(){
        return cardlist;
    }
}