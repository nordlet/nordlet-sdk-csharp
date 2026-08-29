using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PurchasesInvoicesMatchResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("invoiceId")]
    public required string InvoiceId { get; set; }

    [JsonPropertyName("orderId")]
    public required string OrderId { get; set; }

    [JsonPropertyName("status")]
    public required PostV1PurchasesInvoicesMatchResponseStatus Status { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1PurchasesInvoicesMatchResponseRowsItem> Rows { get; set; } =
        new List<PostV1PurchasesInvoicesMatchResponseRowsItem>();

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
