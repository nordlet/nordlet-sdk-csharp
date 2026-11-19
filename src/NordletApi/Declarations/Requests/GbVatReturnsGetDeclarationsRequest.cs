using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbVatReturnsGetDeclarationsRequest
{
    /// <summary>
    /// Facts of the browser the user files from, which HMRC requires with every VAT (MTD) API call: `navigator.userAgent`, a UUID the browser keeps for the device, every screen (width, height, scaling factor, colour depth in bits), the window size in pixels and the time zone as `UTC±hh:mm`.
    /// </summary>
    [JsonPropertyName("device")]
    public required GbVatReturnsGetDeclarationsRequestDevice Device { get; set; }

    [JsonPropertyName("periodKey")]
    public required string PeriodKey { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
