using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CertificatesDeleteDeclarationsRequest
{
    [JsonPropertyName("system")]
    public required string System { get; set; }

    [JsonPropertyName("fieldKey")]
    public required CertificatesDeleteDeclarationsRequestFieldKey FieldKey { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
