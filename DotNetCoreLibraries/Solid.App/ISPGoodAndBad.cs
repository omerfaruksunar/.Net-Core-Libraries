namespace Solid.App.ISPGoodAndBad;

public class Student
{
    public int Id { get; set; }
    public String Name { get; set; }
}
//bad way
//public class ReadStudentRepository : IStudentRepository
//{
//    public Student Create(Student student)
//    {
//        throw new NotImplementedException();
//    }

//    public Student Delete(Student student)
//    {
//        throw new NotImplementedException();
//    }

//    public Student GetById(int id)
//    {
//        throw new NotImplementedException();
//    }

//    public List<Student> GetList()
//    {
//        throw new NotImplementedException();
//    }

//    public Student Update(Student student)
//    {
//        throw new NotImplementedException();
//    }
//}


//public interface IStudentRepository
//{
//    List<Student> GetList();
//    Student GetById(int id);
//    Student Create(Student student);
//    Student Update(Student student);    
//    Student Delete(Student student);
//}


public class ReadStudentRepository : IReadRepository
{
    public Student GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetList()
    {
        throw new NotImplementedException();
    }
}

public class WriteStudentRepository : IWriteRepository
{
    public Student Create(Student student)
    {
        throw new NotImplementedException();
    }

    public Student Delete(Student student)
    {
        throw new NotImplementedException();
    }

    public Student Update(Student student)
    {
        throw new NotImplementedException();
    }
}



public interface IReadRepository
{
    List<Student> GetList();
    Student GetById(int id);
}

public interface IWriteRepository
{
    Student Create(Student student);
    Student Update(Student student);
    Student Delete(Student student);
}

