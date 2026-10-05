using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record StatementRowsListLedgerRequest
{
    [JsonPropertyName("scheme")]
    public required string Scheme { get; set; }

    [JsonPropertyName("fromDate")]
    public DateOnly? FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public DateOnly? ToDate { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
