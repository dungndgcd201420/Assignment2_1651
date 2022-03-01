using System;

namespace University_Management_System
{
  class Student : SubjectEnroll
  {
    private string name;
    private int age;
    private string id;



    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int Age
    {
      get { return age; }
      set { age = value; }
    }

    public string Id
    {
      get { return id; }
      set { id = value; }
    }

    public Student(string name, int age, string id)
    {
      Name = name;
      Age = age;
      Id = id;

    }

    public override void Enroll()
    {
      Console.WriteLine("Welcome to the University Enrolling System");
      Console.WriteLine("1. Show Subject You Had Enrolled");
      Console.WriteLine("2. Enroll new Subject");
      Console.WriteLine("3. Show Your Info");
      Console.WriteLine("4. Exit The Program");

      int option = int.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:

          break;
        case 2:
          
          break;
        case 3:
          break;
        case 4:
          break;
      }
    }


  }
}
