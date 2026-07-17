using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsEuIossComputeRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
