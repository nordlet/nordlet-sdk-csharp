using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsOnlineSalesResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("channel")]
    public required string Channel { get; set; }

    [JsonPropertyName("orders")]
    public required long Orders { get; set; }

    [JsonPropertyName("fulfilled")]
    public required long Fulfilled { get; set; }

    [JsonPropertyName("cancelled")]
    public required long Cancelled { get; set; }

    [JsonPropertyName("open")]
    public required long Open { get; set; }

    [JsonPropertyName("net")]
    public required string Net { get; set; }

    [JsonPropertyName("gross")]
    public required string Gross { get; set; }

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
