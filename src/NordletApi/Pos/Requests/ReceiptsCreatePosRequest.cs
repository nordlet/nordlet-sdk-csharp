using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ReceiptsCreatePosRequest
{
    [JsonPropertyName("shiftId")]
    public required string ShiftId { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<ReceiptsCreatePosRequestLinesItem> Lines { get; set; } =
        new List<ReceiptsCreatePosRequestLinesItem>();

    [JsonPropertyName("cashAmount")]
    public string? CashAmount { get; set; }

    [JsonPropertyName("cardAmount")]
    public string? CardAmount { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
