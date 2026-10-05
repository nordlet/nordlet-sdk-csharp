using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AnnualAccountsSignaturesUpdateDeclarationsRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("directorName")]
    public required string DirectorName { get; set; }

    [JsonPropertyName("directorType")]
    public required AnnualAccountsSignaturesUpdateDeclarationsRequestDirectorType DirectorType { get; set; }

    [JsonPropertyName("signed")]
    public required bool Signed { get; set; }

    [JsonPropertyName("signedOn")]
    public DateOnly? SignedOn { get; set; }

    [JsonPropertyName("signedAt")]
    public DateTime? SignedAt { get; set; }

    [JsonPropertyName("reasonNotSigned")]
    public string? ReasonNotSigned { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
