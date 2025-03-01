namespace ClassLibrary2;

public class Student
{
    public string Name { get; set; }
    public string Gender { get; set; }

    public int Age { get; set; }
    public string Id { get; set; }


    public Student(string name, string gender, int age, string id)
    {
        Name = name;
        Gender = gender;
        Age = age;
        Id = id;


    }

    public override string ToString()
    {
        return $" Name: {Name},Gender: {Gender}, Age: {Age} ,Id: {Id}";
    }
}