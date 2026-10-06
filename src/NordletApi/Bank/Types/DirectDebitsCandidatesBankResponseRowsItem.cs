using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DirectDebitsCandidatesBankResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("fullNumber")]
    public string? FullNumber { get; set; }

    [JsonPropertyName("issueDate")]
    public DateOnly? IssueDate { get; set; }

    [JsonPropertyName("dueDate")]
    public DateOnly? DueDate { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("partnerName")]
    public string? PartnerName { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("paidAmount")]
    public required string PaidAmount { get; set; }

    [JsonPropertyName("remaining")]
    public required string Remaining { get; set; }

    [JsonPropertyName("mandateId")]
    public string? MandateId { get; set; }

    [JsonPropertyName("mandateReference")]
    public string? MandateReference { get; set; }

    [JsonPropertyName("mandateSignatureDate")]
    public DateOnly? MandateSignatureDate { get; set; }

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
