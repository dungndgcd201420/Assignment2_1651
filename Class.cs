using System.Collections.Generic;

namespace University_Management_System
{
  class Class
  {
    List<Student> studentList = new List<Student>();

    List<Teacher> teacherList = new List<Teacher>();

    private string className;

    public string ClassName
    {
      get { return className; }
      set { className = value; }
    }

    public Class(string name)
    {
      className = name;
    }
    public Class(string name, List<Student> studentlist, List<Teacher> teacherlist)
    {
      ClassName = name;
      studentList = studentlist;
      teacherList = teacherlist;
    }

    public Class()
    {
    }

    public override string ToString()
    {
      return "{Class Name: " + ClassName + "}";
    }
  }
}
