using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RecurringInvoicesCreateSalesRequest
{
    [JsonPropertyName("templateId")]
    public required string TemplateId { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("frequency")]
    public RecurringInvoicesCreateSalesRequestFrequency? Frequency { get; set; }

    [JsonPropertyName("interval")]
    public long? Interval { get; set; }

    [JsonPropertyName("startDate")]
    public required DateOnly StartDate { get; set; }

    [JsonPropertyName("endDate")]
    public DateOnly? EndDate { get; set; }

    [JsonPropertyName("locale")]
    public RecurringInvoicesCreateSalesRequestLocale? Locale { get; set; }

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
