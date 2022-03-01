using System;
using System.Collections.Generic;

namespace University_Management_System
{
  class Program
  {
    static void Main(string[] args)
    {
      Subject staff = new Staff();
      Class class1 = new Class("GCD0901");
      Teacher teacher1 = new Teacher("Nguyen Van Loi");
      Subject subject1 = new Subject("Advanced Programming", "1651", class1, teacher1);
      List<Subject> listSubject1 = new List<Subject>();

      listSubject1.Add(subject1);
      staff.StaffMenu();

      int option = int.Parse(Console.ReadLine());
      while (option > 0 || option < 6)
      {
        switch (option)
        {
          case 1:
            listSubject1.Add(staff.CreateNewSubject(new Subject()));
            staff.StaffMenu();
            option = int.Parse(Console.ReadLine());
            break;
          case 2:
            staff.ShowSubjectList(listSubject1);
            staff.StaffMenu();
            option = int.Parse(Console.ReadLine());
            break;
          case 3:
            staff.Delete(listSubject1);
            staff.StaffMenu();
            option = int.Parse(Console.ReadLine());
            break;
          case 4:
            staff.Update(listSubject1);
            staff.StaffMenu();
            option = int.Parse(Console.ReadLine());
            break;
          case 5:
            Console.WriteLine("The Program is over!");
            Console.ReadLine();
            Environment.Exit(0);
            break;
        }
      }
    }
  }
}

