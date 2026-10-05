using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PlJpkFaGenerateDeclarationsRequest
{
    [JsonPropertyName("dateFrom")]
    public required DateOnly DateFrom { get; set; }

    [JsonPropertyName("dateTo")]
    public required DateOnly DateTo { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
