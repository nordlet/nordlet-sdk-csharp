using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ExportsMonthSalesRequest
{
    [JsonPropertyName("month")]
    public required string Month { get; set; }

    [JsonPropertyName("format")]
    public required ExportsMonthSalesRequestFormat Format { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
