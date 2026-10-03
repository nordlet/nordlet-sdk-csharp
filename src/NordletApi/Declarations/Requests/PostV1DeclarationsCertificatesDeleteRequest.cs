using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsCertificatesDeleteRequest
{
    [JsonPropertyName("system")]
    public required string System { get; set; }

    [JsonPropertyName("fieldKey")]
    public required PostV1DeclarationsCertificatesDeleteRequestFieldKey FieldKey { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
