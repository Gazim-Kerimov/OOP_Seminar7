public class Card{
    Person person;
    int id;
    public void setPerson(Person person){
        this.person = person;
    }
    public Person getPerson(){
        return person;
    }
    public void setId(int id){
        this.id = id;
    }
    public int getId(){
        return id;
    }
    
    override public string ToString(){
        string result = "ID: " + getId() + "|" + person.ToString();
        return result;
    }

}