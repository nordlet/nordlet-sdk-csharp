using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EeTsdAnnexesGetDeclarationsResponseAnnexesAnnex6 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fields")]
    public IEnumerable<EeTsdAnnexesGetDeclarationsResponseAnnexesAnnex6FieldsItem> Fields { get; set; } =
        new List<EeTsdAnnexesGetDeclarationsResponseAnnexesAnnex6FieldsItem>();

    [JsonPropertyName("reductions")]
    public IEnumerable<EeTsdAnnexesGetDeclarationsResponseAnnexesAnnex6ReductionsItem> Reductions { get; set; } =
        new List<EeTsdAnnexesGetDeclarationsResponseAnnexesAnnex6ReductionsItem>();

    [JsonPropertyName("relatedParties")]
    public IEnumerable<EeTsdAnnexesGetDeclarationsResponseAnnexesAnnex6RelatedPartiesItem> RelatedParties { get; set; } =
        new List<EeTsdAnnexesGetDeclarationsResponseAnnexesAnnex6RelatedPartiesItem>();

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
