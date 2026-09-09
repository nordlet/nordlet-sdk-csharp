using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesInvoicesPaymentSettingsUpdateRequest
{
    [JsonPropertyName("paymentLinkTemplate")]
    public string? PaymentLinkTemplate { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
