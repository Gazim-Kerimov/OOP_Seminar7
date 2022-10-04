public class Finder{
    public void find(){
        Console.WriteLine("1 - поиск по имени и фамилии\n2 - поиск по ID\n3 - показать весь справочник");
        string userChoice = Console.ReadLine();
        if(userChoice.Equals("1")){
            Console.WriteLine("Введите имя и фамилию контакта через пробел:");
            string inputFullName = Console.ReadLine();
            CardList.getInstance().getInfoByName(inputFullName);
        }
        else if(userChoice.Equals("2")){
            Console.WriteLine("Введите ID контакта:");
            int inputID = int.Parse(Console.ReadLine());
            CardList.getInstance().getInfoById(inputID);
        }
        else if(userChoice.Equals("3")){
            CardList.getInstance().showAll();
        }
        else Console.WriteLine("Ошибка в запросе!");
    }
}