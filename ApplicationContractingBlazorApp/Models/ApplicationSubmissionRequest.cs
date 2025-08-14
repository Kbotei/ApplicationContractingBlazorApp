namespace ApplicationContractingBlazorApp.Models;

public class ApplicationSubmissionRequest
{
    public Guid SubmissionId { get; set; }

    public List<OrderedField> Fields { get; set; } = [];
}
