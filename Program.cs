using Microsoft.Extensions.DependencyInjection;

class UserInterface()
{
    private string _username;
    private string _password;

    private void getData()
    {
        Console.WriteLine("Enter Username: ");
        _username = Console.ReadLine();
    
        
        Console.WriteLine("Enter Password: ");
        _password = Console.ReadLine();
    }

    public void SignUp()
    {
        var business = new BusinessLogic();
    }

}

class BusinessLogic()
{
    public void ProcessData(string userName, string password)
    {
        var dataAccess = new DataAccess();
        dataAccess.SaveData(userName, password);
    }
}

class DataAccess()
{
    public void SaveData(string userName, string password)
    {
        var dataAccess = new DataAccess();
        dataAccess.SaveData(userName, password);
    }
}
