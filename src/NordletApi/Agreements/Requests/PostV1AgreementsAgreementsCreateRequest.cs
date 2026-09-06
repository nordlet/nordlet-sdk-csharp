using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AgreementsAgreementsCreateRequest
{
    [JsonPropertyName("typeId")]
    public string? TypeId { get; set; }

    [JsonPropertyName("kind")]
    public PostV1AgreementsAgreementsCreateRequestKind? Kind { get; set; }

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
    public bool? AutoRenew { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("billingPeriod")]
    public PostV1AgreementsAgreementsCreateRequestBillingPeriod? BillingPeriod { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("status")]
    public PostV1AgreementsAgreementsCreateRequestStatus? Status { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<PostV1AgreementsAgreementsCreateRequestItemsItem>? Items { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
