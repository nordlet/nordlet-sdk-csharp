using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesEinvoiceSendSalesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("sent")]
    public required bool Sent { get; set; }

    [JsonPropertyName("system")]
    public required string System { get; set; }

    [JsonPropertyName("format")]
    public required string Format { get; set; }

    [JsonPropertyName("transport")]
    public required InvoicesEinvoiceSendSalesResponseTransport Transport { get; set; }

    [JsonPropertyName("messageId")]
    public required string MessageId { get; set; }

    [JsonPropertyName("nationalNumber")]
    public string? NationalNumber { get; set; }

    [JsonPropertyName("status")]
    public required InvoicesEinvoiceSendSalesResponseStatus Status { get; set; }

    [JsonPropertyName("detail")]
    public string? Detail { get; set; }

    [JsonPropertyName("fileId")]
    public string? FileId { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

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
