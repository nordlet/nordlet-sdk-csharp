using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesCardPaymentsConnectSalesRequest
{
    [JsonPropertyName("returnUrl")]
    public required string ReturnUrl { get; set; }

    [JsonPropertyName("refreshUrl")]
    public required string RefreshUrl { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
