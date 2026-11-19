using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SubmitCalendarRequest
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("amend")]
    public bool? Amend { get; set; }

    [JsonPropertyName("correction")]
    public SubmitCalendarRequestCorrection? Correction { get; set; }

    [JsonPropertyName("documentKeys")]
    public IEnumerable<string>? DocumentKeys { get; set; }

    /// <summary>
    /// Facts of the browser the user files from, which HMRC requires with every VAT (MTD) API call: `navigator.userAgent`, a UUID the browser keeps for the device, every screen (width, height, scaling factor, colour depth in bits), the window size in pixels and the time zone as `UTC±hh:mm`.
    /// </summary>
    [JsonPropertyName("device")]
    public SubmitCalendarRequestDevice? Device { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
