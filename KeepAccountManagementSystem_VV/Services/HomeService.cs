using KeepAccountManagementSystem_VV.Interfaces;
using KeepAccountManagementSystem_VV.Models;

namespace KeepAccountManagementSystem_VV.Services;

public class HomeService : IHomeService
{
    private static List<KeepAccount> keepAccountGroup = new List<KeepAccount>();

    public List<KeepAccount> index()
    {
        return keepAccountGroup;
    }

    public void Create(KeepAccount data)
    {
        keepAccountGroup.Add(data);
    }
}