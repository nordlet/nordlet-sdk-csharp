using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

/// <summary>
/// Facts of the browser the user files from, which HMRC requires with every VAT (MTD) API call: `navigator.userAgent`, a UUID the browser keeps for the device, every screen (width, height, scaling factor, colour depth in bits), the window size in pixels and the time zone as `UTC±hh:mm`.
/// </summary>
[Serializable]
public record GbVatPenaltiesGetDeclarationsRequestDevice : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("userAgent")]
    public required string UserAgent { get; set; }

    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; set; }

    [JsonPropertyName("screens")]
    public IEnumerable<GbVatPenaltiesGetDeclarationsRequestDeviceScreensItem> Screens { get; set; } =
        new List<GbVatPenaltiesGetDeclarationsRequestDeviceScreensItem>();

    [JsonPropertyName("windowSize")]
    public required GbVatPenaltiesGetDeclarationsRequestDeviceWindowSize WindowSize { get; set; }

    [JsonPropertyName("timezone")]
    public required string Timezone { get; set; }

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
