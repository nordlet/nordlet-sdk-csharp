using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbVatObligationsListDeclarationsRequest
{
    /// <summary>
    /// Facts of the browser the user files from, which HMRC requires with every VAT (MTD) API call: `navigator.userAgent`, a UUID the browser keeps for the device, every screen (width, height, scaling factor, colour depth in bits), the window size in pixels and the time zone as `UTC±hh:mm`.
    /// </summary>
    [JsonPropertyName("device")]
    public required GbVatObligationsListDeclarationsRequestDevice Device { get; set; }

    [JsonPropertyName("from")]
    public DateOnly? From { get; set; }

    [JsonPropertyName("to")]
    public DateOnly? To { get; set; }

    [JsonPropertyName("status")]
    public GbVatObligationsListDeclarationsRequestStatus? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
