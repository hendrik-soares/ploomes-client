using System.ComponentModel.DataAnnotations;

namespace PloomesClient.Dtos
{
  public class AccountUpdateDto {
    public long Id {get; set;}
    public string? Name {get; set;}
    public string? Email {get; set;}
  }
}