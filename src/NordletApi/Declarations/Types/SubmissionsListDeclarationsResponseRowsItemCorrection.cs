using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SubmissionsListDeclarationsResponseRowsItemCorrection : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("required")]
    public IEnumerable<SubmissionsListDeclarationsResponseRowsItemCorrectionRequiredItem> Required { get; set; } =
        new List<SubmissionsListDeclarationsResponseRowsItemCorrectionRequiredItem>();

    [JsonPropertyName("optional")]
    public IEnumerable<SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem> Optional { get; set; } =
        new List<SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem>();

    [JsonPropertyName("reasonCodes")]
    public IEnumerable<SubmissionsListDeclarationsResponseRowsItemCorrectionReasonCodesItem> ReasonCodes { get; set; } =
        new List<SubmissionsListDeclarationsResponseRowsItemCorrectionReasonCodesItem>();

    [JsonPropertyName("carry")]
    public required bool Carry { get; set; }

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
