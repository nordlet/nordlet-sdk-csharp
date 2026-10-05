using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AgreementsBillingRunAgreementsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("generated")]
    public IEnumerable<AgreementsBillingRunAgreementsResponseGeneratedItem> Generated { get; set; } =
        new List<AgreementsBillingRunAgreementsResponseGeneratedItem>();

    [JsonPropertyName("expired")]
    public IEnumerable<string> Expired { get; set; } = new List<string>();

    [JsonPropertyName("errors")]
    public IEnumerable<AgreementsBillingRunAgreementsResponseErrorsItem> Errors { get; set; } =
        new List<AgreementsBillingRunAgreementsResponseErrorsItem>();

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
