namespace ClassLibrary2;

public class StudentManager
{
    private List<Student> students = new List<Student>();
    private string filepath = "students.txt";

    public void addStudent(Student student)
    {
        students.Add(student);
        SaveStudents();
        Console.WriteLine("学生添加成功");
    }

    public void RemoveStudent(string studentID)
    {
        Student student = students.Find(s => s.Id==studentID);
        if (student != null)
        {
            students.Remove(student);
            SaveStudents();
            Console.WriteLine("删除学生成功");
        }
        else
        {
            Console.WriteLine("未找到该学生信息");
        }
    }

    public void ModifyStudent(string studentID, string newName, string gerder, int age)
    {
        Student student = students.Find(s => s.Id==studentID);
        if (student != null)
        {
            student.Name = newName;
            student.Age = age;
            student.Gender = gerder;
            student.Id = studentID;
            SaveStudents();
            Console.WriteLine("学生修改信息成功");
        }
        else
        {
            Console.WriteLine("学生修改信息失败");
        }
    }

    public void DisplayAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("暂无学生信息");
        }
        else
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

    public void SearchStudents(string keyword)
    {
        var results = students.FindAll(s => s.Id == keyword || s.Name.Contains(keyword));
        if (results.Count == 0)
        {
            Console.WriteLine("未找到学生匹配信息");
        }
        else
        {
            foreach (var student in results)
            {
                Console.WriteLine(student);
            }
        }
    }

    public void LoadStudentsFormFile()
    {
        if (File.Exists(filepath))
        {
            using (StreamReader sr = new StreamReader(filepath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data.Length == 4)
                    {
                        students.Add(new Student(data[1], data[2],int.Parse(data[3]),data[0]));
                    }
                }
            }
        }
    }

    public StudentManager()
    {
        LoadStudentsFormFile();
    }




























    public void SaveStudents()
    {
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            foreach (var item in students)
            {
                writer.WriteLine($"{item.Id}\t{item.Name}\t{item.Age}\t{item.Gender}");
                
            }
        }
    }
}