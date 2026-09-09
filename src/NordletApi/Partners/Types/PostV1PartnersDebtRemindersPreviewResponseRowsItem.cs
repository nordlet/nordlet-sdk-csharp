using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersDebtRemindersPreviewResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("partnerName")]
    public required string PartnerName { get; set; }

    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("locale")]
    public required PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale Locale { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("invoices")]
    public IEnumerable<PostV1PartnersDebtRemindersPreviewResponseRowsItemInvoicesItem> Invoices { get; set; } =
        new List<PostV1PartnersDebtRemindersPreviewResponseRowsItemInvoicesItem>();

    [JsonPropertyName("totalDue")]
    public required string TotalDue { get; set; }

    [JsonPropertyName("interestDue")]
    public required string InterestDue { get; set; }

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
