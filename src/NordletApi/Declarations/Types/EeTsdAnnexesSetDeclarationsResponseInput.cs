using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EeTsdAnnexesSetDeclarationsResponseInput : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("annex4")]
    public EeTsdAnnexesSetDeclarationsResponseInputAnnex4? Annex4 { get; set; }

    [JsonPropertyName("annex5")]
    public EeTsdAnnexesSetDeclarationsResponseInputAnnex5? Annex5 { get; set; }

    [JsonPropertyName("annex6")]
    public EeTsdAnnexesSetDeclarationsResponseInputAnnex6? Annex6 { get; set; }

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
