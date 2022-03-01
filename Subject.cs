using System;
using System.Collections.Generic;

namespace University_Management_System
{
  class Subject
  {
    private string subjectName;

    private string subjectCode;

    public Class ClassName { get; set; }

    public Teacher TeacherAssign { get; set; }
    public string SubjectName
    {
      get
      {
        return subjectName;
      }
      set
      {
        subjectName = value;
      }
    }

    public string SubjectCode
    {
      get
      {
        return subjectCode;
      }
      set
      {
        subjectCode = value;
      }
    }

    public Subject(string name, string code, Class classname, Teacher teacher)
    {
      SubjectName = name;
      SubjectCode = code;
      ClassName = classname;
      TeacherAssign = teacher;
    }
    public Subject()
    {

    }
    public void SubjectInfo(Subject subject)
    {
      Console.WriteLine("{Subject Name: " + subject.SubjectName + "} {Subject Code: " + subject.SubjectCode
        + "} " + subject.ClassName + " " + subject.TeacherAssign);
    }


    public void ShowSubjectList(List<Subject> subjectList)
    {
      int i = 1;
      foreach (Subject subj in subjectList)
      {
        Console.Write(i + ". ");
        SubjectInfo(subj);
        i++;
      }
      Console.ReadLine();
    }
    public void EnterMessage()
    {
      Console.WriteLine("Enter to go back to the Menu!");
      Console.ReadLine();
    }
    public Subject CreateNewSubject(Subject subject)
    {
      Console.WriteLine("Enter the Subject Name");
      subject.SubjectName = Console.ReadLine();
      Console.WriteLine("Enter the Subject Code");
      subject.SubjectCode = Console.ReadLine();
      subject.ClassName = ClassInput();
      subject.TeacherAssign = TeacherInput();

      EnterMessage();
      return subject;

    }

    public void BackUpSubjectData(Subject subject, Subject subjectData)
    {
      subjectData.SubjectName = subject.SubjectName;
      subjectData.SubjectCode = subject.SubjectCode;
      subjectData.ClassName = subject.ClassName;
      subjectData.TeacherAssign = subject.TeacherAssign;

    }

    public static Class ClassInput()
    {
      Class newClass = new Class();

      Console.WriteLine("Enter Class Name: ");
      newClass.ClassName = Console.ReadLine();


      return newClass;
    }

    public static Teacher TeacherInput()
    {
      Teacher newTeacher = new Teacher();

      Console.WriteLine("Enter Teacher Name: ");
      newTeacher.TeacherName = Console.ReadLine();


      return newTeacher;
    }

    public void StaffMenu()
    {
      Console.WriteLine("Welcome to the University Management System");
      Console.WriteLine("1. Add New Subject");
      Console.WriteLine("2. List of Subject Available");
      Console.WriteLine("3. Delete Subject");
      Console.WriteLine("4. Update Subject");
      Console.WriteLine("5. Exit The Program");
    }

    public void Delete(List<Subject> list)
    {
      Console.WriteLine("Type in the number of the item you want to Delete!");


      try
      {
        int number = int.Parse(Console.ReadLine());
        list.RemoveAt(number - 1);
        Console.WriteLine("Remove Successful!");
      }
      catch (ArgumentOutOfRangeException ex)
      {
        Console.WriteLine("The Number You Enter is Not Valid Please Try Again!");
      }

      EnterMessage();

    }

    public void Update(List<Subject> list)
    {
      Console.WriteLine("Enter Number of the Subject you want to Update");
      int number = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter New Name: ");
      list[number - 1].SubjectName = Console.ReadLine();
      list[number - 1].SubjectCode = Console.ReadLine();
      list[number - 1].ClassName = ClassInput();
      list[number - 1].TeacherAssign = TeacherInput();

      Console.ReadLine();
      EnterMessage();
    }
  }
}
