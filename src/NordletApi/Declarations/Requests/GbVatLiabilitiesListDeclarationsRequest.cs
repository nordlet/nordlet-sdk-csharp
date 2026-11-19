using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbVatLiabilitiesListDeclarationsRequest
{
    /// <summary>
    /// Facts of the browser the user files from, which HMRC requires with every VAT (MTD) API call: `navigator.userAgent`, a UUID the browser keeps for the device, every screen (width, height, scaling factor, colour depth in bits), the window size in pixels and the time zone as `UTC±hh:mm`.
    /// </summary>
    [JsonPropertyName("device")]
    public required GbVatLiabilitiesListDeclarationsRequestDevice Device { get; set; }

    [JsonPropertyName("from")]
    public required DateOnly From { get; set; }

    [JsonPropertyName("to")]
    public required DateOnly To { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
