using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ParticipantsLookupPeppolResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("participantId")]
    public required string ParticipantId { get; set; }

    [JsonPropertyName("registered")]
    public required bool Registered { get; set; }

    [JsonPropertyName("smpUrl")]
    public string? SmpUrl { get; set; }

    [JsonPropertyName("accessPointUrl")]
    public string? AccessPointUrl { get; set; }

    [JsonPropertyName("acceptsInvoice")]
    public required bool AcceptsInvoice { get; set; }

    [JsonPropertyName("acceptsCreditNote")]
    public required bool AcceptsCreditNote { get; set; }

    [JsonPropertyName("acceptsCii")]
    public required bool AcceptsCii { get; set; }

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
