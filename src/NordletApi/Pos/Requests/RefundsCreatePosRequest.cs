using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RefundsCreatePosRequest
{
    [JsonPropertyName("shiftId")]
    public required string ShiftId { get; set; }

    [JsonPropertyName("receiptId")]
    public required string ReceiptId { get; set; }

    [JsonPropertyName("date")]
    public DateOnly? Date { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<RefundsCreatePosRequestLinesItem> Lines { get; set; } =
        new List<RefundsCreatePosRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
