using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PaymentsListSalesRequest
{
    [JsonPropertyName("from")]
    public required DateOnly From { get; set; }

    [JsonPropertyName("to")]
    public required DateOnly To { get; set; }

    [JsonPropertyName("page")]
    public long? Page { get; set; }

    [JsonPropertyName("pageSize")]
    public long? PageSize { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
