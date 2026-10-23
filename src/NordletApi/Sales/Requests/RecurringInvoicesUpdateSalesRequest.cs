using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RecurringInvoicesUpdateSalesRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("frequency")]
    public RecurringInvoicesUpdateSalesRequestFrequency? Frequency { get; set; }

    [JsonPropertyName("interval")]
    public long? Interval { get; set; }

    [JsonPropertyName("startDate")]
    public DateOnly? StartDate { get; set; }

    [JsonPropertyName("endDate")]
    public DateOnly? EndDate { get; set; }

    [JsonPropertyName("nextRunDate")]
    public DateOnly? NextRunDate { get; set; }

    [JsonPropertyName("status")]
    public RecurringInvoicesUpdateSalesRequestStatus? Status { get; set; }

    [JsonPropertyName("locale")]
    public RecurringInvoicesUpdateSalesRequestLocale? Locale { get; set; }

    [JsonPropertyName("autoIssue")]
    public bool? AutoIssue { get; set; }

    [JsonPropertyName("autoSend")]
    public bool? AutoSend { get; set; }

    [JsonPropertyName("sendTo")]
    public string? SendTo { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
