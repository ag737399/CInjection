public interface IClass
{
    void Serve();
}
public class Resource1: IClass
{
    public void Serve()
    {
        Console.WriteLine("Resource is Initialized");
    }
}
public class Resource2: IClass
{
    public void Serve()
    {
        Console.WriteLine("Resource2 is Initialized");
    }
}
public class Client
{
    private IClass _service;
    public Client(IClass service)
    {
        _service = service;
    }
    public void Serve()
    {
        _service.Serve();
    }
}
class Program
{
    static void Main(String[] args)
    {
        Resource1 r1=new Resource1();   
        Client cA=new Client(r1);
        cA.Serve();

        Resource2 r2=new Resource2();
        cA=new Client(r2);
        cA.Serve();
    }
}