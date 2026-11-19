using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PaymentsExportBankResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("format")]
    public required PaymentsExportBankResponseFormat Format { get; set; }

    [JsonPropertyName("messageId")]
    public required string MessageId { get; set; }

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    [JsonPropertyName("contentType")]
    public required string ContentType { get; set; }

    [JsonPropertyName("transactionCount")]
    public required long TransactionCount { get; set; }

    [JsonPropertyName("controlSum")]
    public required string ControlSum { get; set; }

    [JsonPropertyName("content")]
    public required string Content { get; set; }

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
