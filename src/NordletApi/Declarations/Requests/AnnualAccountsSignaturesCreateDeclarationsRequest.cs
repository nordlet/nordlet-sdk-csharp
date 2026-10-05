using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AnnualAccountsSignaturesCreateDeclarationsRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("directorName")]
    public required string DirectorName { get; set; }

    [JsonPropertyName("directorType")]
    public required AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType DirectorType { get; set; }

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
