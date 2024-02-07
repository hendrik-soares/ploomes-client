
using PloomesClient.Dtos;
using PloomesClient.Models;
using PloomesClient.Repository;

namespace PloomesClient.Services
{
    public class AccountService(IAccountRepository repository) : IAccountService
    {
        public AccountModel Create(AccountCreateDto input)
        {
          /* TODO: verificar se existe um email com essa conta */
          return repository.Create(input);
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountModel> FindAll()
        {
            throw new NotImplementedException();
        }

        public AccountModel FindOne(long Id)
        {
            throw new NotImplementedException();
        }

        public AccountModel Update(AccountUpdateDto input)
        {
            throw new NotImplementedException();
        }
    }


}