using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsCertificatesUploadRequest
{
    [JsonPropertyName("system")]
    public required string System { get; set; }

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    /// <summary>
    /// Base64-encoded PEM or PKCS#12 file
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    [JsonPropertyName("passphrase")]
    public string? Passphrase { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
