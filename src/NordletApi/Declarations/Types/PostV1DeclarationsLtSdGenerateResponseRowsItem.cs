using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtSdGenerateResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("contractId")]
    public required string ContractId { get; set; }

    [JsonPropertyName("contractNo")]
    public required string ContractNo { get; set; }

    [JsonPropertyName("personalCode")]
    public string? PersonalCode { get; set; }

    [JsonPropertyName("socialInsuranceNo")]
    public string? SocialInsuranceNo { get; set; }

    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("professionCode")]
    public string? ProfessionCode { get; set; }

    [JsonPropertyName("endReason")]
    public string? EndReason { get; set; }

    [JsonPropertyName("finalInsuredIncome")]
    public string? FinalInsuredIncome { get; set; }

    [JsonPropertyName("finalContributions")]
    public string? FinalContributions { get; set; }

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
