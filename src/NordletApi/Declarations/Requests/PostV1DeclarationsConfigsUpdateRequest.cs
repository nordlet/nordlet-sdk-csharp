using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsConfigsUpdateRequest
{
    [JsonPropertyName("system")]
    public required string System { get; set; }

    [JsonPropertyName("config")]
    public Dictionary<string, string> Config { get; set; } = new Dictionary<string, string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
