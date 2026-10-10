using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RunsApprovePayrollResponse : IJsonOnDeserialized
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

    [JsonPropertyName("payDate")]
    public DateOnly? PayDate { get; set; }

    [JsonPropertyName("status")]
    public required RunsApprovePayrollResponseStatus Status { get; set; }

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
    public IEnumerable<RunsApprovePayrollResponseComponentTotalsItem> ComponentTotals { get; set; } =
        new List<RunsApprovePayrollResponseComponentTotalsItem>();

    [JsonPropertyName("netTotal")]
    public required string NetTotal { get; set; }

    [JsonPropertyName("paidAmount")]
    public required string PaidAmount { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("approvedAt")]
    public DateTime? ApprovedAt { get; set; }

    [JsonPropertyName("reversedAt")]
    public DateTime? ReversedAt { get; set; }

    [JsonPropertyName("reversalJournalTransactionId")]
    public string? ReversalJournalTransactionId { get; set; }

    [JsonPropertyName("reversalReason")]
    public string? ReversalReason { get; set; }

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
