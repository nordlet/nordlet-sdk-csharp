using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankSettlementsPostResponseSummary : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("receivableApplied")]
    public required string ReceivableApplied { get; set; }

    [JsonPropertyName("commissionAmount")]
    public required string CommissionAmount { get; set; }

    [JsonPropertyName("sellerAmount")]
    public required string SellerAmount { get; set; }

    [JsonPropertyName("feeAmount")]
    public required string FeeAmount { get; set; }

    [JsonPropertyName("suspenseAmount")]
    public required string SuspenseAmount { get; set; }

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
