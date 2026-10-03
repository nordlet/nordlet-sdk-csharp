using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsAnnualAccountsSignaturesUpdateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("directorName")]
    public required string DirectorName { get; set; }

    [JsonPropertyName("directorType")]
    public required PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType DirectorType { get; set; }

    [JsonPropertyName("signed")]
    public required bool Signed { get; set; }

    [JsonPropertyName("signedOn")]
    public string? SignedOn { get; set; }

    [JsonPropertyName("signedAt")]
    public string? SignedAt { get; set; }

    [JsonPropertyName("reasonNotSigned")]
    public string? ReasonNotSigned { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
