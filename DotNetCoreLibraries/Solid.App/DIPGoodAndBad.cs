namespace Solid.App.DIPGoodAndBad;

public class CarService
{
    private readonly IRepository _repository;

    public CarService(IRepository repository)
    {
        _repository = repository;
    }

    public List<string> GetAll()
    {
        return _repository.GetAll();
    }
}

public class CarRepositoryFromPostgreSqlServer : IRepository
{
    public List<string> GetAll()
    {
        return new List<string>() { "PostgreSqlServer - BMW", "PostgreSqlServer - Mercedes" };
    }
}

public class CarRepositoryFromMSSqlServer : IRepository
{
    public List<string> GetAll()
    {
        return new List<string>() { "MSSqlServer - BMW", "MSSqlServer - Mercedes" };
    }
}

public interface IRepository
{
    List<string> GetAll();
}

