using PloomesClient.Dtos;
using PloomesClient.Models;

namespace PloomesClient.Services 
{
  public interface IAccountService 
  {
    public List<AccountModel> FindAll();
    public AccountModel FindOne(long Id);
    public AccountModel Create(AccountCreateDto input);
    public AccountModel Update(AccountUpdateDto input);
    public void Delete(long id);
  }
}