public class CardManager{
    CardCreator creator;
    Finder finder;
    FileManager fileManager;
    private static CardManager instance;
    private CardManager(){
        creator = new CardCreator();
        finder = new Finder();
        fileManager = new FileManager();
    }
    public static CardManager getInstance(){
        if(instance == null) instance = new CardManager();
        return instance;
    }
    public void start(){
        fileManager.importer.read();
        while(true){
            Console.WriteLine("1 - добавление нового контакта \n" +
                               "2 - поиск контакта в справочнике \n" +
                               "3 - экспорт справочника в файл \n" +
                               "4 - показать весь справочник \n" +
                               "5 - выход из программы");
            string userChoice = Console.ReadLine();
            if(userChoice.Equals("5")) break;
            switch(userChoice){
                case "1":
                    creator.createNewCard();
                    break;
                case "2":
                    finder.find();
                    break;
                case "3":
                    fileManager.manage();
                    break;
                case "4":
                    CardList.getInstance().showAll();
                    break;
                default:
                    Console.WriteLine("Введен некорректный запрос, попробуйте снова");
                    break;                
            }                   
        }
    }
}