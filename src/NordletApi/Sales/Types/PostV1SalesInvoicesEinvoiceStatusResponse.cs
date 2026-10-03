using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesInvoicesEinvoiceStatusResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("system")]
    public required string System { get; set; }

    [JsonPropertyName("transport")]
    public required PostV1SalesInvoicesEinvoiceStatusResponseTransport Transport { get; set; }

    [JsonPropertyName("messageId")]
    public required string MessageId { get; set; }

    [JsonPropertyName("nationalNumber")]
    public string? NationalNumber { get; set; }

    [JsonPropertyName("status")]
    public required PostV1SalesInvoicesEinvoiceStatusResponseStatus Status { get; set; }

    [JsonPropertyName("detail")]
    public string? Detail { get; set; }

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
