using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PayrollRunsGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("status")]
    public required PostV1PayrollRunsGetResponseStatus Status { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("taxAllowanceTotal")]
    public required string TaxAllowanceTotal { get; set; }

    [JsonPropertyName("incomeTaxTotal")]
    public required string IncomeTaxTotal { get; set; }

    [JsonPropertyName("employeeContributionsTotal")]
    public required string EmployeeContributionsTotal { get; set; }

    [JsonPropertyName("employerContributionsTotal")]
    public required string EmployerContributionsTotal { get; set; }

    [JsonPropertyName("componentTotals")]
    public IEnumerable<PostV1PayrollRunsGetResponseComponentTotalsItem> ComponentTotals { get; set; } =
        new List<PostV1PayrollRunsGetResponseComponentTotalsItem>();

    [JsonPropertyName("netTotal")]
    public required string NetTotal { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("approvedAt")]
    public string? ApprovedAt { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1PayrollRunsGetResponseLinesItem> Lines { get; set; } =
        new List<PostV1PayrollRunsGetResponseLinesItem>();

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
