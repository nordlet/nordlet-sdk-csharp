using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AgreementsAgreementsBillingRunResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("generated")]
    public IEnumerable<PostV1AgreementsAgreementsBillingRunResponseGeneratedItem> Generated { get; set; } =
        new List<PostV1AgreementsAgreementsBillingRunResponseGeneratedItem>();

    [JsonPropertyName("expired")]
    public IEnumerable<string> Expired { get; set; } = new List<string>();

    [JsonPropertyName("errors")]
    public IEnumerable<PostV1AgreementsAgreementsBillingRunResponseErrorsItem> Errors { get; set; } =
        new List<PostV1AgreementsAgreementsBillingRunResponseErrorsItem>();

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
