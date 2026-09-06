using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerAccountsListResponseRowsItemTranslations : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("lt")]
    public PostV1LedgerAccountsListResponseRowsItemTranslationsLt? Lt { get; set; }

    [JsonPropertyName("en")]
    public PostV1LedgerAccountsListResponseRowsItemTranslationsEn? En { get; set; }

    [JsonPropertyName("ru")]
    public PostV1LedgerAccountsListResponseRowsItemTranslationsRu? Ru { get; set; }

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
