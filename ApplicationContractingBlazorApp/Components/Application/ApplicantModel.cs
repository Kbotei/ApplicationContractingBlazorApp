using System.ComponentModel.DataAnnotations;

namespace ApplicationContractingBlazorApp.Components.Application;

public class ApplicantModel
{
    [Required(AllowEmptyStrings = false)]
    public string FirstName { get; set; } = "";

    [Required(AllowEmptyStrings = false)]
    public string LastName { get; set; } = "";

    [Required(AllowEmptyStrings = false)]
    public string Email { get; set; } = "";

    [Required(AllowEmptyStrings = false)]
    public string PhoneNumber { get; set; } = "";

    [Required(AllowEmptyStrings = false)]
    public string StreetAddress { get; set; } = "";

    [Required(AllowEmptyStrings = false)]
    public string City { get; set; } = "";

    [Required(AllowEmptyStrings = false)]
    public string? State { get; set; }

    [Required(AllowEmptyStrings = false)]
    [MaxLength(5)]
    public string ZipCode { get; set; } = "";
}
