using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RecurringInvoicesUpdateSalesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("templateId")]
    public required string TemplateId { get; set; }

    [JsonPropertyName("templateName")]
    public string? TemplateName { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("partnerName")]
    public string? PartnerName { get; set; }

    [JsonPropertyName("frequency")]
    public required RecurringInvoicesUpdateSalesResponseFrequency Frequency { get; set; }

    [JsonPropertyName("interval")]
    public required long Interval { get; set; }

    [JsonPropertyName("startDate")]
    public required DateOnly StartDate { get; set; }

    [JsonPropertyName("endDate")]
    public DateOnly? EndDate { get; set; }

    [JsonPropertyName("nextRunDate")]
    public required DateOnly NextRunDate { get; set; }

    [JsonPropertyName("status")]
    public required RecurringInvoicesUpdateSalesResponseStatus Status { get; set; }

    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    [JsonPropertyName("autoIssue")]
    public required bool AutoIssue { get; set; }

    [JsonPropertyName("autoSend")]
    public required bool AutoSend { get; set; }

    [JsonPropertyName("sendTo")]
    public string? SendTo { get; set; }

    [JsonPropertyName("occurrences")]
    public required long Occurrences { get; set; }

    [JsonPropertyName("lastRunAt")]
    public DateTime? LastRunAt { get; set; }

    [JsonPropertyName("lastInvoiceId")]
    public string? LastInvoiceId { get; set; }

    [JsonPropertyName("lastError")]
    public string? LastError { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
