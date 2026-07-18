using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsEuUnionTurnoverGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capEur")]
    public required string CapEur { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("isVatPayer")]
    public required bool IsVatPayer { get; set; }

    [JsonPropertyName("currentYear")]
    public required PostV1DeclarationsEuUnionTurnoverGetResponseCurrentYear CurrentYear { get; set; }

    [JsonPropertyName("previousYear")]
    public required PostV1DeclarationsEuUnionTurnoverGetResponsePreviousYear PreviousYear { get; set; }

    [JsonPropertyName("status")]
    public required PostV1DeclarationsEuUnionTurnoverGetResponseStatus Status { get; set; }

    [JsonPropertyName("headroomAmount")]
    public string? HeadroomAmount { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

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
