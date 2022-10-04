public class CardCreator{
    public void createNewCard(){
        Console.WriteLine("Введите имя нового контакта: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Введите фамилию нового контакта: ");
        string secondName = Console.ReadLine();
        Console.WriteLine("Введите возраст нового контакта: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите номер телефона: ");
        string phoneNumber = Console.ReadLine();
        Person person = new Person(firstName, secondName, age, phoneNumber);
        Card card = new Card();
        card.setPerson(person);
        card.setId(Id.getId());
        CardList.getInstance().addCard(card);
        Console.WriteLine("Добавлена новая запись:\n" + card.ToString());

        
    }
}