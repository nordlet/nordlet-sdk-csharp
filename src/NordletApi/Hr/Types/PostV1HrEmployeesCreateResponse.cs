using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1HrEmployeesCreateResponse : IJsonOnDeserialized
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
    public string? BirthDate { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("address")]
    public PostV1HrEmployeesCreateResponseAddress? Address { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("socialInsuranceNo")]
    public string? SocialInsuranceNo { get; set; }

    [JsonPropertyName("socialInsuranceStart")]
    public string? SocialInsuranceStart { get; set; }

    [JsonPropertyName("hireDate")]
    public string? HireDate { get; set; }

    [JsonPropertyName("terminationDate")]
    public string? TerminationDate { get; set; }

    [JsonPropertyName("applyNpd")]
    public required bool ApplyNpd { get; set; }

    [JsonPropertyName("npdOverride")]
    public string? NpdOverride { get; set; }

    [JsonPropertyName("pensionAccumulation")]
    public required bool PensionAccumulation { get; set; }

    [JsonPropertyName("status")]
    public required PostV1HrEmployeesCreateResponseStatus Status { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("attributes")]
    public IEnumerable<PostV1HrEmployeesCreateResponseAttributesItem>? Attributes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

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
