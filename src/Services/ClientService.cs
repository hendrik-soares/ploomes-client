namespace PloomesClient.Services
{
  public class CiientService(IRepository repository) {
    public void  Create(ClientCreateDto input) {
      /** TODO: Se ele pode adicionar um novo cliente nessa conta */
      /** TODO: checar se o account id existe ou tratar erro de chave estrangeira */
      /** TODO: fazer a inserção do client  */
      return repository.Create(input);
    }
  }
}