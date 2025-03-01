using System;
using System.Collections.Generic;
using ClassLibrary2;

namespace test
{
    class Program
    {
        
        
        
        
        
        
        
        static void Main(string[] strs)
        {
            StudentManager studentManager = new StudentManager();
            while (true)
            {
                Console.WriteLine("\n学生信息管理系统");
                Console.WriteLine("1. 添加学生信息");
                Console.WriteLine("2. 删除学生信息");
                Console.WriteLine("3. 修改学生信息");
                Console.WriteLine("4. 查询学生信息");
                Console.WriteLine("5. 显示所有学生信息");
                Console.WriteLine("6. 退出");
                Console.Write("请选择操作：");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("请输入学生姓名:");
                        string name = Console.ReadLine();
                        Console.Write("请输入学生性别:");
                        string gender = Console.ReadLine();
                        Console.Write("请输入学生年龄:");
                        string Age = Console.ReadLine();
                        Console.Write("请输入学生编号:");
                        string id = Console.ReadLine();
                        studentManager.addStudent(new Student(name, gender, int.Parse(Age), id));
                        break;
                    case "2":
                        Console.Write("输如学生的编号:");
                        string StudentID = Console.ReadLine();
                        studentManager.RemoveStudent(StudentID);
                        break;
                    case "3":
                        Console.Write("输入要修改的学生学号：");
                        string modifyID = Console.ReadLine();
                        Console.Write("输入新的学生姓名：");
                        string newName = Console.ReadLine();
                        Console.Write("输入新的学生性别：");
                        string newGender = Console.ReadLine();
                        Console.Write("输入新的学生年龄：");
                        int newAge = int.Parse(Console.ReadLine());
                        studentManager.ModifyStudent(modifyID, newName, newGender, newAge);
                        break;
                    case "4":
                        Console.WriteLine("输入查询关键字(学号或姓名):");
                        string keyword = Console.ReadLine();
                        studentManager.SearchStudents(keyword);
                        break;
                    case "5":
                        studentManager.DisplayAllStudents();
                        break;
                    case "6":
                        Console.WriteLine("退出系统");
                        return;
                    default:
                        Console.WriteLine("无效选项重新输入");
                        break;
                        
                }
            }
        }
    }
}