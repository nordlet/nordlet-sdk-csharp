using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerAccountsCreateResponseTranslations : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("lt")]
    public PostV1LedgerAccountsCreateResponseTranslationsLt? Lt { get; set; }

    [JsonPropertyName("en")]
    public PostV1LedgerAccountsCreateResponseTranslationsEn? En { get; set; }

    [JsonPropertyName("ru")]
    public PostV1LedgerAccountsCreateResponseTranslationsRu? Ru { get; set; }

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
