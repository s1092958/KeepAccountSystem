using KeepAccountManagementSystem_VV.Models;

namespace KeepAccountManagementSystem_VV.Interfaces;

public interface IHomeService
{
    void Create(KeepAccount data);

    List<KeepAccount> index();
}