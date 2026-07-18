using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesRecognitionComputeResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asOfDate")]
    public required string AsOfDate { get; set; }

    [JsonPropertyName("totalAmount")]
    public required string TotalAmount { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1SalesRecognitionComputeResponseRowsItem> Rows { get; set; } =
        new List<PostV1SalesRecognitionComputeResponseRowsItem>();

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
