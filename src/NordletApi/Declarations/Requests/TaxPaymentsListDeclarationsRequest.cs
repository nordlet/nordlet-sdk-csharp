using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TaxPaymentsListDeclarationsRequest
{
    [JsonPropertyName("tax")]
    public required TaxPaymentsListDeclarationsRequestTax Tax { get; set; }

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
