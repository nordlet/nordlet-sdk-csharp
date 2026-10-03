using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsAnnualAccountsSignaturesCreateRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("directorName")]
    public required string DirectorName { get; set; }

    [JsonPropertyName("directorType")]
    public required PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType DirectorType { get; set; }

    [JsonPropertyName("signed")]
    public required bool Signed { get; set; }

    [JsonPropertyName("signedOn")]
    public string? SignedOn { get; set; }

    [JsonPropertyName("signedAt")]
    public string? SignedAt { get; set; }

    [JsonPropertyName("reasonNotSigned")]
    public string? ReasonNotSigned { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
