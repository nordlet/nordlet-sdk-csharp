using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsDebtAgingRequest
{
    [JsonPropertyName("side")]
    public PostV1ReportsDebtAgingRequestSide? Side { get; set; }

    [JsonPropertyName("asOf")]
    public string? AsOf { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
