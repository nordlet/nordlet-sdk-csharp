using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AgreementsAgreementsUpdateRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("typeId")]
    public string? TypeId { get; set; }

    [JsonPropertyName("kind")]
    public PostV1AgreementsAgreementsUpdateRequestKind? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    [JsonPropertyName("autoRenew")]
    public bool? AutoRenew { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("billingPeriod")]
    public PostV1AgreementsAgreementsUpdateRequestBillingPeriod? BillingPeriod { get; set; }

    [JsonPropertyName("status")]
    public PostV1AgreementsAgreementsUpdateRequestStatus? Status { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
