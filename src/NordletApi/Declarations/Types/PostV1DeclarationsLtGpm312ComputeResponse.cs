using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtGpm312ComputeResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("payoutTiming")]
    public required PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming PayoutTiming { get; set; }

    [JsonPropertyName("payoutFrom")]
    public required PostV1DeclarationsLtGpm312ComputeResponsePayoutFrom PayoutFrom { get; set; }

    [JsonPropertyName("payoutTo")]
    public required PostV1DeclarationsLtGpm312ComputeResponsePayoutTo PayoutTo { get; set; }

    [JsonPropertyName("registrationNumber")]
    public required string RegistrationNumber { get; set; }

    [JsonPropertyName("companyName")]
    public required string CompanyName { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1DeclarationsLtGpm312ComputeResponseRowsItem> Rows { get; set; } =
        new List<PostV1DeclarationsLtGpm312ComputeResponseRowsItem>();

    [JsonPropertyName("totals")]
    public required PostV1DeclarationsLtGpm312ComputeResponseTotals Totals { get; set; }

    [JsonPropertyName("runsFound")]
    public required long RunsFound { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

    [JsonPropertyName("source")]
    public required string Source { get; set; }

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
