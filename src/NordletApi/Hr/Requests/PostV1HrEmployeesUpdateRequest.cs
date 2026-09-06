using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1HrEmployeesUpdateRequest
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
    public string? BirthDate { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("address")]
    public PostV1HrEmployeesUpdateRequestAddress? Address { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("socialInsuranceNo")]
    public string? SocialInsuranceNo { get; set; }

    [JsonPropertyName("socialInsuranceStart")]
    public string? SocialInsuranceStart { get; set; }

    [JsonPropertyName("hireDate")]
    public string? HireDate { get; set; }

    [JsonPropertyName("applyNpd")]
    public bool? ApplyNpd { get; set; }

    [JsonPropertyName("npdOverride")]
    public string? NpdOverride { get; set; }

    [JsonPropertyName("pensionAccumulation")]
    public bool? PensionAccumulation { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("attributes")]
    public IEnumerable<PostV1HrEmployeesUpdateRequestAttributesItem>? Attributes { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("terminationDate")]
    public string? TerminationDate { get; set; }

    [JsonPropertyName("status")]
    public PostV1HrEmployeesUpdateRequestStatus? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
