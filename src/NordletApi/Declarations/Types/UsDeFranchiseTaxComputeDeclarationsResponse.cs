using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsDeFranchiseTaxComputeDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("authorizedShares")]
    public required double AuthorizedShares { get; set; }

    [JsonPropertyName("authorizedSharesMethodTax")]
    public required string AuthorizedSharesMethodTax { get; set; }

    [JsonPropertyName("assumedPar")]
    public string? AssumedPar { get; set; }

    [JsonPropertyName("assumedParValueCapital")]
    public string? AssumedParValueCapital { get; set; }

    [JsonPropertyName("assumedNoParCapital")]
    public string? AssumedNoParCapital { get; set; }

    [JsonPropertyName("assumedParValueCapitalMethodTax")]
    public string? AssumedParValueCapitalMethodTax { get; set; }

    [JsonPropertyName("method")]
    public required UsDeFranchiseTaxComputeDeclarationsResponseMethod Method { get; set; }

    [JsonPropertyName("tax")]
    public required string Tax { get; set; }

    [JsonPropertyName("annualReportFee")]
    public required string AnnualReportFee { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
