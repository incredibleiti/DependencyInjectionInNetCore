using Microsoft.Extensions.DependencyInjection;

class UserInterface()
{
    private string _username;
    private string _password;
    private IBusinessLogic _businessLogic;

    public UserInterface()
    { 
        _businessLogic = new BusinessLogic();
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

class BusinessLogic() :IBusinessLogic
{
    private IDataAccess _dataAccess;
    public BusinessLogic()
    {
        _dataAccess = new DataAccessMySQL();
    }
    public void ProcessData(string userName, string password)
    {
        _dataAccess.SaveData(userName, password);
    }
}

interface IDataAccess
{
    void SaveData(string userName, string password);
}

class DataAccessMySQL():IDataAccess
{
    public void SaveData(string userName, string password)
    {
        Console.WriteLine("Data Saved Successfully!");
    }
}
