using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RecognitionModifySalesRequest
{
    [JsonPropertyName("invoiceLineId")]
    public required string InvoiceLineId { get; set; }

    [JsonPropertyName("approach")]
    public required RecognitionModifySalesRequestApproach Approach { get; set; }

    [JsonPropertyName("date")]
    public DateOnly? Date { get; set; }

    [JsonPropertyName("newEndDate")]
    public DateOnly? NewEndDate { get; set; }

    [JsonPropertyName("newMilestones")]
    public IEnumerable<RecognitionModifySalesRequestNewMilestonesItem>? NewMilestones { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
