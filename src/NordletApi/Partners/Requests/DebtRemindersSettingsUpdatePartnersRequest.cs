using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DebtRemindersSettingsUpdatePartnersRequest
{
    [JsonPropertyName("daysBefore")]
    public long? DaysBefore { get; set; }

    [JsonPropertyName("repeatDays")]
    public long? RepeatDays { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
