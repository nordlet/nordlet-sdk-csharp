using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesRecognitionModifyRequest
{
    [JsonPropertyName("invoiceLineId")]
    public required string InvoiceLineId { get; set; }

    [JsonPropertyName("approach")]
    public required PostV1SalesRecognitionModifyRequestApproach Approach { get; set; }

    [JsonPropertyName("date")]
    public string? Date { get; set; }

    [JsonPropertyName("newEndDate")]
    public string? NewEndDate { get; set; }

    [JsonPropertyName("newMilestones")]
    public IEnumerable<PostV1SalesRecognitionModifyRequestNewMilestonesItem>? NewMilestones { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
