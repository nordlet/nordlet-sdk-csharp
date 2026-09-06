using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AgreementsAgreementsGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("typeId")]
    public string? TypeId { get; set; }

    [JsonPropertyName("kind")]
    public required PostV1AgreementsAgreementsGetResponseKind Kind { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("employeeId")]
    public string? EmployeeId { get; set; }

    [JsonPropertyName("bankAccountId")]
    public string? BankAccountId { get; set; }

    [JsonPropertyName("number")]
    public required string Number { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("startDate")]
    public required string StartDate { get; set; }

    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    [JsonPropertyName("autoRenew")]
    public required bool AutoRenew { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("billingPeriod")]
    public PostV1AgreementsAgreementsGetResponseBillingPeriod? BillingPeriod { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("status")]
    public required PostV1AgreementsAgreementsGetResponseStatus Status { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<PostV1AgreementsAgreementsGetResponseItemsItem> Items { get; set; } =
        new List<PostV1AgreementsAgreementsGetResponseItemsItem>();

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
