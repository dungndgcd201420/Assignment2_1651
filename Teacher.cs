namespace University_Management_System
{
  public class Teacher
  {
    private string teacherName;

    public string TeacherName { get { return teacherName; } set { teacherName = value; } }

    public Teacher(string name)
    {
      TeacherName = name;
    }

    public Teacher()
    {
    }

    public override string ToString()
    {
      return "{Teacher Name: " + TeacherName + "}";
    }
  }
}