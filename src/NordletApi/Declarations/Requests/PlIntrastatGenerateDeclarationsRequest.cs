using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PlIntrastatGenerateDeclarationsRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("flow")]
    public required PlIntrastatGenerateDeclarationsRequestFlow Flow { get; set; }

    [JsonPropertyName("transactionNature")]
    public string? TransactionNature { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
