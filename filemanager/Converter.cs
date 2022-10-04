
public class Converter{
    public Card convertToCard(string line){
        string[] list = line.Split("|");
        int id = int.Parse(list[0].Replace("ID: ", ""));
        string fullName = list[1].Replace("Name: ", "");
        string firstName = fullName.Split(" ")[0];
        string secondName = fullName.Split(" ")[1];
        int age = int.Parse(list[2].Replace("Age: ", ""));
        string phoneNumber = list[3].Replace("Phone: ", "");
        Person person = new Person(firstName, secondName, age, phoneNumber);
        Card card = new Card();
        card.setPerson(person);
        card.setId(id);
        return card;
    }
}