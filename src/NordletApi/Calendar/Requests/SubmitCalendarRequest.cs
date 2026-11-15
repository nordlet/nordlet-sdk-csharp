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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
