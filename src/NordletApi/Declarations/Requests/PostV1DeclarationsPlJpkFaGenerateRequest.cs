using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsPlJpkFaGenerateRequest
{
    [JsonPropertyName("dateFrom")]
    public required string DateFrom { get; set; }

    [JsonPropertyName("dateTo")]
    public required string DateTo { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
