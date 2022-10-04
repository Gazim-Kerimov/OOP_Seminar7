public class Person{
    private string firstName;
    private string secondName;
    private int age;
    private string phoneNumber;
    private Person(){}

    public Person(string firstName, string secondName, int age, string phoneNumber){
        this.firstName = firstName;
        this.secondName = secondName;
        this.age = age;
        this.phoneNumber = phoneNumber;
    }
    public string getName(){
        string fullName = firstName + " " + secondName;
        return fullName;
    }
    public int getAge(){
        return age;
    }
    public String getPhoneNumber(){
        return phoneNumber;
    }
    override public string ToString(){
        string result = "Name: " + getName() + "|Age: " + getAge() + "|Phone: " + getPhoneNumber();
        return result;
    }
}