using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RecognitionComputeSalesRequest
{
    [JsonPropertyName("asOfDate")]
    public DateOnly? AsOfDate { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
