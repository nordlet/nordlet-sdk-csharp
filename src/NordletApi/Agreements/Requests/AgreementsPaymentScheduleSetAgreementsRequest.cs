using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AgreementsPaymentScheduleSetAgreementsRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<AgreementsPaymentScheduleSetAgreementsRequestRowsItem> Rows { get; set; } =
        new List<AgreementsPaymentScheduleSetAgreementsRequestRowsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
