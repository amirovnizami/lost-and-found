using System.ComponentModel.DataAnnotations;

namespace Lost_And_Found.Web.Contributors;
public class CreateContributorRequest
{
  public const string Route = "/Contributors";

  [Required]
  public string? Name { get; set; }
  public string? PhoneNumber { get; set; }
}
