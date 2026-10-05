using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtIvazCancelDeclarationsRequest
{
    [JsonPropertyName("entries")]
    public IEnumerable<LtIvazCancelDeclarationsRequestEntriesItem> Entries { get; set; } =
        new List<LtIvazCancelDeclarationsRequestEntriesItem>();

    [JsonPropertyName("persist")]
    public bool? Persist { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
