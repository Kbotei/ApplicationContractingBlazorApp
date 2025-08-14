namespace ApplicationContractingBlazorApp.Models;

public record SimpleField
{
    public required string FieldNamespace { get; set; }

    public required string FieldName { get; set; }

    public string? FieldValue { get; set; }
}
