using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DebtRemindersUpcomingPartnersResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    [JsonPropertyName("kind")]
    public required DebtRemindersUpcomingPartnersResponseRowsItemKind Kind { get; set; }

    [JsonPropertyName("invoiceId")]
    public required string InvoiceId { get; set; }

    [JsonPropertyName("fullNumber")]
    public required string FullNumber { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("partnerName")]
    public required string PartnerName { get; set; }

    [JsonPropertyName("dueDate")]
    public required DateOnly DueDate { get; set; }

    [JsonPropertyName("remaining")]
    public required string Remaining { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

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
