using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BillingAccountGetResponsePlansValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("monthlyFeeEur")]
    public required string MonthlyFeeEur { get; set; }

    [JsonPropertyName("includedRequests")]
    public required long IncludedRequests { get; set; }

    [JsonPropertyName("requestOverageEur")]
    public required string RequestOverageEur { get; set; }

    [JsonPropertyName("includedDatabaseBytes")]
    public required double IncludedDatabaseBytes { get; set; }

    [JsonPropertyName("includedFileBytes")]
    public required double IncludedFileBytes { get; set; }

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
