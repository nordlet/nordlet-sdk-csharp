using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EmployeesUpdateHrRequest
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }

    [JsonPropertyName("personalCode")]
    public string? PersonalCode { get; set; }

    [JsonPropertyName("birthDate")]
    public DateOnly? BirthDate { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("address")]
    public EmployeesUpdateHrRequestAddress? Address { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("socialInsuranceNo")]
    public string? SocialInsuranceNo { get; set; }

    [JsonPropertyName("socialInsuranceStart")]
    public DateOnly? SocialInsuranceStart { get; set; }

    [JsonPropertyName("hireDate")]
    public DateOnly? HireDate { get; set; }

    [JsonPropertyName("applyAllowance")]
    public bool? ApplyAllowance { get; set; }

    [JsonPropertyName("allowanceOverride")]
    public string? AllowanceOverride { get; set; }

    [JsonPropertyName("pensionAccumulation")]
    public bool? PensionAccumulation { get; set; }

    [JsonPropertyName("payrollOptions")]
    public Dictionary<string, string>? PayrollOptions { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("attributes")]
    public IEnumerable<EmployeesUpdateHrRequestAttributesItem>? Attributes { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("terminationDate")]
    public DateOnly? TerminationDate { get; set; }

    [JsonPropertyName("status")]
    public EmployeesUpdateHrRequestStatus? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
