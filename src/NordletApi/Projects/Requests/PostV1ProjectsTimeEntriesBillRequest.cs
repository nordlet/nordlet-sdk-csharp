using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProjectsTimeEntriesBillRequest
{
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("dateFrom")]
    public string? DateFrom { get; set; }

    [JsonPropertyName("dateTo")]
    public string? DateTo { get; set; }

    [JsonPropertyName("itemId")]
    public string? ItemId { get; set; }

    [JsonPropertyName("hourlyRate")]
    public string? HourlyRate { get; set; }

    [JsonPropertyName("vatRatePercent")]
    public string? VatRatePercent { get; set; }

    [JsonPropertyName("vatClassifierCode")]
    public string? VatClassifierCode { get; set; }

    [JsonPropertyName("issueDate")]
    public string? IssueDate { get; set; }

    [JsonPropertyName("dueDate")]
    public string? DueDate { get; set; }

    [JsonPropertyName("groupBy")]
    public PostV1ProjectsTimeEntriesBillRequestGroupBy? GroupBy { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
