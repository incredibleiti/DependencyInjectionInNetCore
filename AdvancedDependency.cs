using Microsoft.Extensions.DependencyInjection;
IDataAccess data = new DataAccessMySQL();
IBusinessLogic biz = new BusinessLogic(data);
UserInterface ui = new UserInterface(biz);

ui.SignUp(); //now UI is called without very tight coupling
class UserInterface()
{
    private string _username;
    private string _password;
    private IBusinessLogic _businessLogic;

    public UserInterface(IBusinessLogic businessLogic)
    {
        _businessLogic = businessLogic;
    }

    private void getData()
    {
        Console.WriteLine("Enter Username: ");
        _username = Console.ReadLine();


        Console.WriteLine("Enter Password: ");
        _password = Console.ReadLine();
    }

    public void SignUp()
    {
        getData();
        _businessLogic.ProcessData(_username, _password);
    }

}

interface IBusinessLogic
{
    void ProcessData(string userName, string password);
}

interface IDataAccess
{
    void SaveData(string userName, string password);
}

class BusinessLogic() : IBusinessLogic
{
    private IDataAccess _dataAccess;
    public BusinessLogic(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public void ProcessData(string userName, string password)
    {
        _dataAccess.SaveData(userName, password);
    }
}

class DataAccessMySQL():IDataAccess
{
    public void SaveData(string userName, string password)
    {
        Console.WriteLine("Data Saved Successfully!");
    }
}
