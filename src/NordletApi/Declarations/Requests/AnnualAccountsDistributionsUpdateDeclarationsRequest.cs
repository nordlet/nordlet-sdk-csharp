using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AnnualAccountsDistributionsUpdateDeclarationsRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("decidedOn")]
    public required DateOnly DecidedOn { get; set; }

    [JsonPropertyName("kind")]
    public required AnnualAccountsDistributionsUpdateDeclarationsRequestKind Kind { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
