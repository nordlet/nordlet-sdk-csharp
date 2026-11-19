using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsDeFranchiseTaxComputeDeclarationsRequest
{
    [JsonPropertyName("authorizedShares")]
    public IEnumerable<UsDeFranchiseTaxComputeDeclarationsRequestAuthorizedSharesItem> AuthorizedShares { get; set; } =
        new List<UsDeFranchiseTaxComputeDeclarationsRequestAuthorizedSharesItem>();

    [JsonPropertyName("issuedShares")]
    public long? IssuedShares { get; set; }

    [JsonPropertyName("totalGrossAssets")]
    public string? TotalGrossAssets { get; set; }

    [JsonPropertyName("largeCorporateFiler")]
    public bool? LargeCorporateFiler { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
