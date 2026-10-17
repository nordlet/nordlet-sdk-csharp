using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ConfigsListDeclarationsRequest
{
    /// <summary>
    /// List the systems of this country instead of the company country
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
