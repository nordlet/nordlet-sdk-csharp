using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RecognitionRunSalesRequest
{
    [JsonPropertyName("asOfDate")]
    public DateOnly? AsOfDate { get; set; }

    [JsonPropertyName("postingDate")]
    public DateOnly? PostingDate { get; set; }

    [JsonPropertyName("scheduleIds")]
    public IEnumerable<string>? ScheduleIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
