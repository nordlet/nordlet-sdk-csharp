using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SalesTaxExemptionsCreatePartnersResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("state")]
    public required string State { get; set; }

    [JsonPropertyName("reasons")]
    public IEnumerable<string> Reasons { get; set; } = new List<string>();

    [JsonPropertyName("otherReason")]
    public string? OtherReason { get; set; }

    [JsonPropertyName("reasonDetail")]
    public string? ReasonDetail { get; set; }

    [JsonPropertyName("businessType")]
    public required string BusinessType { get; set; }

    [JsonPropertyName("otherBusinessType")]
    public string? OtherBusinessType { get; set; }

    [JsonPropertyName("idNumber")]
    public required string IdNumber { get; set; }

    [JsonPropertyName("idIssuedBy")]
    public required string IdIssuedBy { get; set; }

    [JsonPropertyName("singlePurchaseReference")]
    public string? SinglePurchaseReference { get; set; }

    [JsonPropertyName("signedBy")]
    public string? SignedBy { get; set; }

    [JsonPropertyName("signerTitle")]
    public string? SignerTitle { get; set; }

    [JsonPropertyName("signedOn")]
    public string? SignedOn { get; set; }

    [JsonPropertyName("receivedOn")]
    public required string ReceivedOn { get; set; }

    [JsonPropertyName("cancelledOn")]
    public string? CancelledOn { get; set; }

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
