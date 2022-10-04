public class Id{
    private static int id;
    public static int getId(){
        if(CardList.getInstance().getList().Count == 0){
             id = 0;
        }
        else{
            int lastIndex = CardList.getInstance().getList().Count - 1;
            id = CardList.getInstance().getList()[lastIndex].getId() + 1;     
            }
        return id;    
    }
}