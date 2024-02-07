using System.ComponentModel.DataAnnotations;

namespace PloomesClient.Dtos
{
  public class AccountCreateDto {
    [Required]
    public string Name {get; set;}
    [Required]
    public string Email {get; set;}
  }
}