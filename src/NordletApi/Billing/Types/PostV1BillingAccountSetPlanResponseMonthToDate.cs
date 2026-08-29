using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BillingAccountSetPlanResponseMonthToDate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("from")]
    public required string From { get; set; }

    [JsonPropertyName("to")]
    public required string To { get; set; }

    [JsonPropertyName("apiRequests")]
    public required long ApiRequests { get; set; }

    [JsonPropertyName("ocrPages")]
    public required long OcrPages { get; set; }

    [JsonPropertyName("fileBytes")]
    public required double FileBytes { get; set; }

    [JsonPropertyName("databaseBytes")]
    public required double DatabaseBytes { get; set; }

    [JsonPropertyName("archivedCompanies")]
    public required long ArchivedCompanies { get; set; }

    [JsonPropertyName("estimatedTodayCents")]
    public required long EstimatedTodayCents { get; set; }

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
