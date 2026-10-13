using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AccountSetAccountTypeBillingRequest
{
    [JsonPropertyName("accountType")]
    public required AccountSetAccountTypeBillingRequestAccountType AccountType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
