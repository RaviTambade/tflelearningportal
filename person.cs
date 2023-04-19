namespace Hr;
public class Person{
    private string firstname;
    private string lastname;
    public void SetFirstName(string fname){
        this.firstname=fname;
    }

    public string GetFirstName(){
        return this.firstname;
    }

    public Person(){}
    public Person(string f, string l){
        this.firstname=f;
        this.lastname=l;

    }

    public override string ToString()
    {
        return this.firstname + " "+ this.lastname;
    }
}