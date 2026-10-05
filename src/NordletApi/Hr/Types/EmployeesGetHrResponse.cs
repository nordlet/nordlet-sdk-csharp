using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EmployeesGetHrResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("personalCode")]
    public string? PersonalCode { get; set; }

    [JsonPropertyName("birthDate")]
    public DateOnly? BirthDate { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("address")]
    public EmployeesGetHrResponseAddress? Address { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("socialInsuranceNo")]
    public string? SocialInsuranceNo { get; set; }

    [JsonPropertyName("socialInsuranceStart")]
    public string? SocialInsuranceStart { get; set; }

    [JsonPropertyName("hireDate")]
    public DateOnly? HireDate { get; set; }

    [JsonPropertyName("terminationDate")]
    public DateOnly? TerminationDate { get; set; }

    [JsonPropertyName("applyAllowance")]
    public required bool ApplyAllowance { get; set; }

    [JsonPropertyName("allowanceOverride")]
    public string? AllowanceOverride { get; set; }

    [JsonPropertyName("pensionAccumulation")]
    public required bool PensionAccumulation { get; set; }

    [JsonPropertyName("payrollOptions")]
    public Dictionary<string, string> PayrollOptions { get; set; } =
        new Dictionary<string, string>();

    [JsonPropertyName("status")]
    public required EmployeesGetHrResponseStatus Status { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("attributes")]
    public IEnumerable<EmployeesGetHrResponseAttributesItem>? Attributes { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
